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

namespace eRestoran.WinUI.UserControls.Jela
{
    public partial class ucJelaPrikaz : UserControl
    {
        private readonly APIService _service = new APIService("jelo");
        private readonly APIService _kategorijeService = new APIService("kategorija");
        public ucJelaPrikaz()
        {
            InitializeComponent();
        }

        private async void ucJelaPrikaz_Load(object sender, EventArgs e)
        {
            var kategorije = await _kategorijeService.Get<List<Model.Kategorije>>(null);
            kategorije.Insert(0, new Model.Kategorije() { Naziv = "---" });
            cmbKategorije.DataSource = kategorije;
            cmbKategorije.ValueMember = "KategorijaID";
            cmbKategorije.DisplayMember = "Naziv";
            cmbKategorije.SelectedIndex = 0;
        }

        private async void btnPrikazi_Click(object sender, EventArgs e)
        {

            var search = Convert.ToString(txtPretraga.Text);

            var request = new JelaSearchRequest
            {
                Naziv=txtPretraga.Text,
                KategorijaID = int.Parse(cmbKategorije.SelectedValue.ToString())
            };



            dgvJela.AutoGenerateColumns = false;
            dgvJela.DataSource = await _service.Get<List<Model.Jela>>(request);

        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            PanelHelper.SwapPanels(this.Parent, this, new ucJelaDodaj());
        }

        private async void btnDeleteUser_Click(object sender, EventArgs e)
        {
            if (dgvJela.CurrentRow != null)
            {
                int ID = Convert.ToInt32(dgvJela.CurrentRow.Cells["ID"].Value);
                await _service.Delete<dynamic>(ID);
                PanelHelper.SwapPanels(this.Parent, this, new ucJelaPrikaz());
            }
        }

        private void btnUredi_Click(object sender, EventArgs e)
        {
            if (dgvJela.CurrentRow != null)
            {
                int ID = Convert.ToInt32(dgvJela.CurrentRow.Cells["ID"].Value);
                PanelHelper.SwapPanels(this.Parent, this, new ucJelaUredi(ID));
            }
        }
    }
}
