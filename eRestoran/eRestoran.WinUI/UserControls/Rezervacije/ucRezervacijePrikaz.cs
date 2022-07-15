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

namespace eRestoran.WinUI.UserControls.Rezervacije
{
    public partial class ucRezervacijePrikaz : UserControl
    {
        private readonly APIService _service = new APIService("rezervacija");
        public ucRezervacijePrikaz()
        {
            InitializeComponent();
        }

        private async void btnPrikazi_Click(object sender, EventArgs e)
        {
            var request = new RezervacijaSearchRequest
            {
                Ime = txtPretraga.Text,
                Prezime = txtPretraga.Text
            };
            dgvRezervacije.AutoGenerateColumns = false;
            dgvRezervacije.DataSource = await _service.Get<List<Model.Rezervacije>>(request);
        }

        private async void dgvRezervacije_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var rezervacijaID = int.Parse(dgvRezervacije.SelectedRows[0].Cells[0].Value.ToString());
            var rezervacija = await _service.GetById<Model.Rezervacije>(rezervacijaID);
            if (rezervacija.Status.StatusID == 3)
            {
                PanelHelper.SwapPanels(this.Parent, this, new ucRezervacijeDetalji(rezervacijaID));
            }
            else
            {
                PanelHelper.SwapPanels(this.Parent, this, new ucRezervacijeDetaljiPregled(rezervacijaID));
            }

        }
    }
}
