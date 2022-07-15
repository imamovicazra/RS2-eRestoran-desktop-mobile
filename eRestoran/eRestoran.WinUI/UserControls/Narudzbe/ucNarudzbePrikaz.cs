using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using eRestoran.Model.Requests;
using eRestoran.WinUI.Helpers;
using eRestoran.Model;
using ClosedXML.Excel;

namespace eRestoran.WinUI.UserControls.Narudzbe
{
    public partial class ucNarudzbePrikaz : UserControl
    {
        private readonly APIService _service = new APIService("narudzba");
        private readonly APIService _korisniciService = new APIService("korisnici");
        private readonly APIService _narudzbaDetaljiService = new APIService("NarudzbaDetalji");


        public ucNarudzbePrikaz()
        {
            InitializeComponent();
        }

        private async void btnPrikazi_Click(object sender, EventArgs e)
        {
            var request = new NarudzbaSearchRequest
            {
                Ime = txtPretraga.Text,
                Prezime = txtPretraga.Text
            };



            dgvNarudzbe.AutoGenerateColumns = false;
            dgvNarudzbe.DataSource = await _service.Get<List<Model.Narudzbe>>(request);
        }



        private async void dgvNarudzbe_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var narudzbaID = int.Parse(dgvNarudzbe.SelectedRows[0].Cells[0].Value.ToString());
            var narudzba = await _service.GetById<Model.Narudzbe>(narudzbaID);
            if (narudzba.Status.StatusID == 3)
            {
                PanelHelper.SwapPanels(this.Parent, this, new ucNarudzbeDetalji(narudzbaID));
            }
            else
            {
                PanelHelper.SwapPanels(this.Parent, this, new ucNarudzbeDetaljiPregled(narudzbaID));
            }

        }

        
        
        private async void btnIzvjestaj_Click(object sender, EventArgs e)
        {
            var mjesec = DateTime.Now.Month;
            var narudzbe = await _service.Get<List<Model.Narudzbe>>(null);
            var narudzbeZaTrenutniMjesec = narudzbe.Where(s => s.DatumNarudzbe.Month == mjesec);
            List<NarudzbeReportModel> narudzbeReportList = new List<NarudzbeReportModel>();
            decimal? suma = 0;

            foreach (var x in narudzbeZaTrenutniMjesec)
            {
                var korisnik = await _korisniciService.GetById<Model.Korisnici>(x.KorisnikID);
                NarudzbeReportModel model = new NarudzbeReportModel
                {
                    Ime = korisnik.Ime,
                    Prezime = korisnik.Prezime,
                    Datum = x.DatumNarudzbe,
                    KorisnickoIme = korisnik.KorisnickoIme, 
                    NarudzbaUkupno=0
                    
                };
                var request = new NarudzbaDetaljiSearchRequest
                {
                    NarudzbaID = x.NarudzbaID
                };
                var detalji= await _narudzbaDetaljiService.Get<List<Model.NarudzbaDetalji>>(request);
                foreach (var y in detalji)
                {
                    model.NarudzbaUkupno+= (decimal)(y.Kolicina * y.Jelo.Cijena);
                    suma += (y.Kolicina * y.Jelo.Cijena);
                }
                narudzbeReportList.Add(model);
            }

            var workBook = new XLWorkbook();
            workBook.AddWorksheet("MjesecniIzvjestajOZaradi");
            var ws = workBook.Worksheet("MjesecniIzvjestajOZaradi");

            int redPrvi = 1;
            ws.Columns("A", "E").AdjustToContents();
            ws.Cell("A" + redPrvi.ToString()).Value = "Ime";
            ws.Cell("B" + redPrvi.ToString()).Value = "Prezime";
            ws.Cell("C" + redPrvi.ToString()).Value = "Korisničko ime";
            ws.Cell("D" + redPrvi.ToString()).Value = "Datum narudžbe";
            ws.Cell("E" + redPrvi.ToString()).Value = "Iznos narudžbe";

            int row = 2;
            foreach (var item in narudzbeReportList)
            {
                ws.Cell("A" + row.ToString()).Value = item.Ime.ToString();
                ws.Cell("B" + row.ToString()).Value = item.Prezime.ToString();
                ws.Cell("C" + row.ToString()).Value = item.KorisnickoIme.ToString();
                ws.Cell("D" + row.ToString()).Value = item.Datum.ToString();
                ws.Cell("E" + row.ToString()).Value = item.NarudzbaUkupno.ToString();
                row++;
            }
            ws.Cell("E" + row.ToString()).Value = "Ukupna zarada";
            row++;
            ws.Cell("E" + row.ToString()).Value = suma.ToString() + " KM";
            workBook.SaveAs("NarudzbeReport.xlsx");

            var saveFileDialog = new SaveFileDialog()
            {
                Filter = "Excel files|*.xlsx",
                Title = "Save an Excel File"
            };

            saveFileDialog.ShowDialog();
            if (!string.IsNullOrWhiteSpace(saveFileDialog.FileName))
                workBook.SaveAs(saveFileDialog.FileName);
        }
    }
}
