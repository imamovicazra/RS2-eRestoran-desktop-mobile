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

namespace eRestoran.WinUI.UserControls.Narudzbe
{
    public partial class ucNarudzbeDetaljiPregled : UserControl
    {
        private readonly APIService _service = new APIService("narudzba");
        private readonly APIService _narudzbaDetaljiService = new APIService("NarudzbaDetalji");

        private readonly int _ID;
        public ucNarudzbeDetaljiPregled(int ID)
        {
            InitializeComponent();
            _ID = ID;
        }

        private async void ucNarudzbeDetaljiPregled_Load(object sender, EventArgs e)
        {
            var narudzba = await _service.GetById<Model.Narudzbe>(_ID);
            txtKorisnik.Text = narudzba.ImePrezime;
            txtAdresa.Text = narudzba.Adresa;
            txtTelefon.Text = narudzba.Telefon;
            txtDatum.Text = narudzba.DatumNarudzbe.ToString("dd.MM.yyyy");
            txtUposlenik.Text = narudzba.Uposlenik.Ime + " " + narudzba.Uposlenik.Prezime;
            txtStatus.Text = narudzba.Status.Naziv;

            var request = new NarudzbaDetaljiSearchRequest
            {
                NarudzbaID = _ID
            };
            dgvNarudzbaDetalji.AutoGenerateColumns = false;
            dgvNarudzbaDetalji.DataSource = await _narudzbaDetaljiService.Get<List<Model.NarudzbaDetalji>>(request);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            PanelHelper.SwapPanels(this.Parent, this, new ucNarudzbePrikaz());
        }
    }
}
