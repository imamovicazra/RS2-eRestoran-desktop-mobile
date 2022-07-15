using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using eRestoran.WinUI.Helpers;

namespace eRestoran.WinUI.UserControls.Rezervacije
{
    public partial class ucRezervacijeDetalji : UserControl
    {
        private readonly APIService _service = new APIService("rezervacija");
        private readonly int _ID;

        public ucRezervacijeDetalji(int Id)
        {
            InitializeComponent();
            _ID = Id;
        }

        private async void ucRezervacijeDetalji_Load(object sender, EventArgs e)
        {
            var rezervacija = await _service.GetById<Model.Rezervacije>(_ID);
            txtKorisnik.Text = rezervacija.ImePrezime;
            txtBrojOsoba.Text = rezervacija.BrojMjesta.ToString();
            txtTelefon.Text = rezervacija.Telefon;
            txtDatum.Text = rezervacija.DatumRezervacije.ToString("dd.MM.yyyy hh:mm:ss");
                      
        }

        private async void btnOdobri_Click(object sender, EventArgs e)
        {
            await _service.UpdateStatusDostave<Model.Rezervacije>(_ID, 1);
            PanelHelper.SwapPanels(this.Parent, this, new ucRezervacijePrikaz());
        }

        private async void btnOdbij_Click(object sender, EventArgs e)
        {
            await _service.UpdateStatusDostave<Model.Rezervacije>(_ID, 2);
            PanelHelper.SwapPanels(this.Parent, this, new ucRezervacijePrikaz());
        }
    }
}
