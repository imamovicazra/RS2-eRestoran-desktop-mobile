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
    public partial class ucNarudzbeDetalji : UserControl
    {
        private readonly APIService _service = new APIService("narudzba");
        private readonly APIService _narudzbaDetaljiService = new APIService("NarudzbaDetalji");

        private readonly int _ID;
        public ucNarudzbeDetalji(int id)
        {
            InitializeComponent();
            _ID = id;
        }

        private async void ucNarudzbeDetalji_Load(object sender, EventArgs e)
        {
            var narudzba = await _service.GetById<Model.Narudzbe>(_ID);
            txtKorisnik.Text = narudzba.ImePrezime;
            txtAdresa.Text = narudzba.Adresa;
            txtTelefon.Text = narudzba.Telefon;
            txtDatum.Text= narudzba.DatumNarudzbe.ToString("dd.MM.yyyy");
           
            var request = new NarudzbaDetaljiSearchRequest
            {
                NarudzbaID = _ID
            };
            dgvNarudzbaDetalji.AutoGenerateColumns = false;
            dgvNarudzbaDetalji.DataSource = await _narudzbaDetaljiService.Get<List<Model.NarudzbaDetalji>>(request);
        }

        private async void btnOdobri_Click(object sender, EventArgs e)
        {
            await _service.UpdateStatusDostave<Model.Narudzbe>(_ID, 1);
            PanelHelper.SwapPanels(this.Parent, this, new ucNarudzbePrikaz());
        }

        private async void btnOdbij_ClickAsync(object sender, EventArgs e)
        {
            await _service.UpdateStatusDostave<Model.Narudzbe>(_ID, 2);
            PanelHelper.SwapPanels(this.Parent, this, new ucNarudzbePrikaz());
        }
    }
}
