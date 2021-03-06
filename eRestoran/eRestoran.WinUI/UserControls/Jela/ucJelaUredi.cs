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
using eRestoran.Model.Requests;
using eRestoran.WinUI.Validators;

namespace eRestoran.WinUI.UserControls.Jela
{
    public partial class ucJelaUredi : UserControl
    {
        private readonly APIService _service = new APIService("jelo");
        private readonly APIService _kategorijeService = new APIService("kategorija");
        private readonly int _ID;
        private bool flag = false;


        public ucJelaUredi(int ID)
        {
            InitializeComponent();
            _ID = ID;
        }

        private async void ucJelaUredi_Load(object sender, EventArgs e)
        {
            var jelo = await _service.GetById<Model.Jela>(_ID);
            txtNaziv.Text = jelo.Naziv;
            txtCijena.Text = jelo.Cijena.ToString();
            txtOpis.Text = jelo.Opis;
           

            if (jelo.Slika.Length != 0)
            {
                pbJelo.Image = ImageHelper.ByteArrayToSystemDrawing(jelo.Slika);
                pbJelo.SizeMode = PictureBoxSizeMode.StretchImage;
                flag = true;
            }

            var kategorije = await _kategorijeService.Get<List<Model.Kategorije>>(null);

            cmbKategorije.DataSource = kategorije;
            cmbKategorije.ValueMember = "KategorijaID";
            cmbKategorije.DisplayMember = "Naziv";
            cmbKategorije.SelectedItem = kategorije.Where(i => i.KategorijaID == jelo.KategorijaID).SingleOrDefault();


        }

        private async void btnSacuvaj_Click(object sender, EventArgs e)
        {
            if (ValidateChildren())
            {
                try
                {
                    var request = new JelaUpsertRequest
                    {
                        Naziv = Convert.ToString(txtNaziv.Text),
                        Cijena = double.Parse(txtCijena.Text),
                        Opis = txtOpis.Text,
                        KategorijaID = int.Parse(cmbKategorije.SelectedValue.ToString()),
                        Favorit = false,
                        Slika = pbJelo.Image != null ? ImageHelper.SystemDrawingToByteArray(pbJelo.Image) : null,
                    };

                    await _service.Update<Model.Jela>(_ID, request);
                    MessageBox.Show("Uspješno ste izmijenili podatke o jelu");

                    PanelHelper.SwapPanels(this.Parent, this, new ucJelaPrikaz());
                }
                catch
                {
                    MessageBox.Show("Error");
                }
            }
        }

        private void btnDodajSliku_Click(object sender, EventArgs e)
        {

            OpenFileDialog opnfd = new OpenFileDialog
            {
                Filter = "Image Files (*.jpg;*.jpeg;.*.gif;)|*.jpg;*.jpeg;.*.gif"
            };
            if (opnfd.ShowDialog() == DialogResult.OK)
            {
                pbJelo.SizeMode = PictureBoxSizeMode.StretchImage;
                pbJelo.Image = new Bitmap(opnfd.FileName);
                flag = true;
            }
            else
            {
                flag = false;
            }

        }
        private void Naziv_Validating(object sender, CancelEventArgs e)
        {
            var validator = new JeloValidator();
            var result = validator.NameCheck(txtNaziv.Text);
            epNaziv.SetError(txtNaziv, result.Message);
            e.Cancel = !result.IsValid;
        }
        private void Cijena_Validating(object sender, CancelEventArgs e)
        {
            var validator = new JeloValidator();
            var result = validator.PriceCheck(txtCijena.Text);
            epNaziv.SetError(txtCijena, result.Message);
            e.Cancel = !result.IsValid;
        }

        private void Opis_Validating(object sender, CancelEventArgs e)
        {
            var validator = new JeloValidator();
            var result = validator.DescriptionCheck(txtOpis.Text);
            epNaziv.SetError(txtOpis, result.Message);
            e.Cancel = !result.IsValid;
        }

        private void Slika_Validating(object sender, CancelEventArgs e)
        {
            if (!flag)
            {
                epSlika.SetError(txtSlikaValidate, "Obavezno polje");
                e.Cancel = !flag;
            }
            else
            {
                epSlika.Clear();
            }

        }
    }
}
