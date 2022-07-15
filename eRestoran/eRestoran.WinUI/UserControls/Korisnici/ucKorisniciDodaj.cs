using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using eRestoran.WinUI.Validators;
using eRestoran.WinUI.Helpers;
using System.Text.RegularExpressions;
using eRestoran.Model.Requests;

namespace eRestoran.WinUI.UserControls.Korisnici
{
    public partial class ucKorisniciDodaj : UserControl
    {
        private readonly APIService _service = new APIService("korisnici");
        private readonly APIService _ulogeService = new APIService("uloge");
        private readonly APIService _gradoviService = new APIService("grad");

        public ucKorisniciDodaj()
        {
            InitializeComponent();
        }

        private async void ucKorisniciDodaj_Load(object sender, EventArgs e)
        {
            var uloge = await _ulogeService.Get<List<Model.Uloge>>(null);
            clbUloge.DataSource = uloge;
            clbUloge.ValueMember = "UlogaID";
            clbUloge.DisplayMember = "Naziv";

            var gradovi = await _gradoviService.Get<List<Model.Gradovi>>(null);
            cmbGrad.DataSource = gradovi;
            cmbGrad.ValueMember = "GradID";
            cmbGrad.DisplayMember = "Naziv";
            cmbGrad.SelectedIndex = 0;
        }

        private async void btnSacuvaj_Click(object sender, EventArgs e)
        {

            if (ValidateChildren())
            {
                try
                {
                    var roleList = clbUloge.CheckedItems.Cast<Model.Uloge>().Select(i => i.UlogaID).ToList();

                    var request =new KorisniciInsertRequest
                    {
                        Ime = Convert.ToString(txtIme.Text),
                        Prezime = Convert.ToString(txtPrezime.Text),
                        KorisnickoIme = Convert.ToString(txtKorisnickoIme.Text),
                        Email = Convert.ToString(txtEmail.Text),
                        Telefon = Convert.ToString(txtTelefon.Text),
                        Lozinka = Convert.ToString(txtLozinka.Text),
                        LozinkaPotvrda = Convert.ToString(txtLozinkaPotvrda.Text),
                        Uloge = roleList,
                        GradID = int.Parse(cmbGrad.SelectedValue.ToString()),
                    };

                    await _service.Insert<Model.Korisnici>(request);
                    MessageBox.Show("Uspješno ste dodali novog korisnika");
                    PanelHelper.SwapPanels(this.Parent, this, new ucKorisniciPrikaz());
                }
                catch
                {
                    MessageBox.Show("Greška");
                }
            }
        }

        private void Ime_Validating(object sender, CancelEventArgs e)
        {
            var validator = new KorisnikValidator();
            var result = validator.FirstNameCheck(txtIme.Text);
            epIme.SetError(txtIme, result.Message);
            e.Cancel = !result.IsValid;
        }

        private void Prezime_Validating(object sender, CancelEventArgs e)
        {
            var validator = new KorisnikValidator();
            var result = validator.FirstNameCheck(txtPrezime.Text);
            epPrezime.SetError(txtPrezime, result.Message);
            e.Cancel = !result.IsValid;
        }

        private void KorisnickoIme_Validating(object sender, CancelEventArgs e)
        {
            var validator = new KorisnikValidator();
            var result = validator.UsernameCheck(txtKorisnickoIme.Text);
            epEmail.SetError(txtKorisnickoIme, result.Message);
            e.Cancel = !result.IsValid;
        }

        private void Email_Validating(object sender, CancelEventArgs e)
        {
            var validator = new KorisnikValidator();
            var result = validator.EmailCheck(txtEmail.Text);
            epEmail.SetError(txtEmail, result.Message);
            e.Cancel = !result.IsValid;
        }

        protected bool PhoneValidating(string value)
        {
            Regex regex = new Regex(@"^(\+)?([0-9]){9,16}$");
            Match match = regex.Match(value);

            return match.Success;
        }
        private void Telefon_Validating(object sender, CancelEventArgs e)
        {
            if(!PhoneValidating(txtTelefon.Text))
            {
                epBrojTelefona.SetError(txtTelefon, "Pogresan format");
                e.Cancel = !(PhoneValidating(txtTelefon.Text));
            }
            else if(string.IsNullOrEmpty(txtTelefon.Text))
            {
                epBrojTelefona.SetError(txtTelefon, "Obavezan unos");
                e.Cancel = (string.IsNullOrEmpty(txtTelefon.Text));
            }
            else
            {
                epBrojTelefona.Clear();
            }
        }

        private void Lozinka_Validating(object sender, CancelEventArgs e)
        {
            var validator = new KorisnikValidator();
            var result = validator.PasswordCheck(txtLozinka.Text);
            epLozinka.SetError(txtLozinka, result.Message);
            e.Cancel = !result.IsValid;
        }

        private void LozinkaPotvrda_Validating(object sender, CancelEventArgs e)
        {
            var validator = new KorisnikValidator();
            var result = validator.PasswordConfirmCheck(txtLozinka.Text, txtLozinkaPotvrda.Text);
            epLozinkaPotvrda.SetError(txtLozinkaPotvrda, result.Message);
            e.Cancel = !result.IsValid;
        }

        

        private void Uloge_Validating(object sender, CancelEventArgs e)
        {
            if (clbUloge.CheckedItems.Count < 1)
            {
                epUloge.SetError(clbUloge, "Obavezan unos");
                e.Cancel = (clbUloge.CheckedItems.Count < 1);

            }
            else
            {
                epUloge.Clear();
            }
           
        }



        
    }
}
