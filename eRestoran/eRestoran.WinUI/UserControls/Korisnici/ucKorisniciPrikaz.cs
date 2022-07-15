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
using System.Reflection;
using eRestoran.WinUI.Helpers;

namespace eRestoran.WinUI.UserControls.Korisnici
{
    public partial class ucKorisniciPrikaz : UserControl
    {
        private readonly APIService _service = new APIService("korisnici");
        private readonly APIService _ulogeService = new APIService("uloge");
        public ucKorisniciPrikaz()
        {
            InitializeComponent();
        }
        async Task LoadUloge()
        {
            var uloge = await _ulogeService.Get<List<Model.Uloge>>(null);
            uloge.Insert(0, new Model.Uloge() { Naziv = "---" });
            cmbUloge.DataSource = uloge;
            cmbUloge.ValueMember = "UlogaID";
            cmbUloge.DisplayMember = "Naziv";
            cmbUloge.SelectedIndex = 0;
        }


        private void txtPretraga_TextChanged(object sender, EventArgs e)
        {

        }

       

        private async void btnPrikazi_Click(object sender, EventArgs e)
        {


            var request = new KorisniciSearchRequest
            {
                Ime = txtPretraga.Text, 
                Prezime=txtPretraga.Text,
                UlogaId = int.Parse(cmbUloge.SelectedValue.ToString())
            };     
               


            dgvKorisnici.AutoGenerateColumns = false;
            dgvKorisnici.DataSource = await _service.Get<List<Model.Korisnici>>(request);
            
        }

        private async void ucKorisniciPrikaz_Load(object sender, EventArgs e)
        {
            await LoadUloge();

        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            PanelHelper.SwapPanels(this.Parent, this, new ucKorisniciDodaj());
        }

        

        private void btnUredi_Click(object sender, EventArgs e)
        {

            if (dgvKorisnici.CurrentRow != null)
            {
                int ID = Convert.ToInt32(dgvKorisnici.CurrentRow.Cells["ID"].Value);
                PanelHelper.SwapPanels(this.Parent, this, new ucKorisniciUredi(ID));
            }
        }

        private async void btnDeleteUser_Click(object sender, EventArgs e)
        {
            if (dgvKorisnici.CurrentRow != null)
            {
                int ID = Convert.ToInt32(dgvKorisnici.CurrentRow.Cells["ID"].Value);
                await _service.Delete<dynamic>(ID);
                PanelHelper.SwapPanels(this.Parent, this, new ucKorisniciPrikaz());
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dgvKorisnici_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cmbUloge_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
