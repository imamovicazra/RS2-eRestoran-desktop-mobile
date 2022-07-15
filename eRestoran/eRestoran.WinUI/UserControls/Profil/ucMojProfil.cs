using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using eRestoran.WinUI.Validators;
using eRestoran.Model.Requests;
using eRestoran.WinUI.Helpers;

namespace eRestoran.WinUI.UserControls.Profil
{
    public partial class ucMojProfil : UserControl
    {
        private readonly APIService _service = new APIService("korisnici");
        private readonly APIService _ulogeService = new APIService("uloge");
        private readonly APIService _gradoviService = new APIService("grad");

        private readonly int _ID;
        public ucMojProfil(int Id)
        {
            _ID = Id;
            InitializeComponent();
        }

        private void btnPassword_Click(object sender, EventArgs e)
        {
            var uc = new ucPromjenaLozinke(_ID);
            if (!this.Controls.Contains(uc))
            {
                this.Controls.Add(uc);
                uc.Dock = DockStyle.Fill;
            }

            uc.BringToFront();
        }

        private async void ucMojProfil_Load(object sender, EventArgs e)
        {
            var user = await _service.GetById<Model.Korisnici>(_ID);
            txtIme.Text = user.Ime;
            txtPrezime.Text = user.Prezime;
            txtEmail.Text = user.Email;
            txtKorisnickoIme.Text = user.KorisnickoIme;
            txtTelefon.Text = user.Telefon;

            var roles = await _ulogeService.Get<List<Model.Uloge>>(null);
            clbUloge.DataSource = roles;
            clbUloge.ValueMember = "UlogaID";
            clbUloge.DisplayMember = "Naziv";

            var gradovi = await _gradoviService.Get<List<Model.Gradovi>>(null);
            cmbGrad.DataSource = gradovi;
            cmbGrad.ValueMember = "GradID";
            cmbGrad.DisplayMember = "Naziv";
            cmbGrad.SelectedItem = gradovi.Where(i => i.GradID == user.GradID).SingleOrDefault();


            var rolesList = clbUloge.Items.Cast<Model.Uloge>().Select(i => i.UlogaID).ToList();
            foreach (var userRole in user.KorisniciUloge)
            {
                for (int i = 0; i < clbUloge.Items.Count; i++)
                {
                    if (rolesList[i] == userRole.UlogaID)
                    {
                        clbUloge.SetItemChecked(i, true);
                    }
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
            if (!PhoneValidating(txtTelefon.Text))
            {
                epBrojTelefona.SetError(txtTelefon, "Pogresan format");
                e.Cancel = !(PhoneValidating(txtTelefon.Text));
            }
            else if (string.IsNullOrEmpty(txtTelefon.Text))
            {
                epBrojTelefona.SetError(txtTelefon, "Obavezan unos");
                e.Cancel = (string.IsNullOrEmpty(txtTelefon.Text));
            }
            else
            {
                epBrojTelefona.Clear();
            }
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

        private async void btnSacuvaj_Click(object sender, EventArgs e)
        {
            if (ValidateChildren())
            {
                try
                {

                    var roleList = clbUloge.CheckedItems.Cast<Model.Uloge>().Select(i => i.UlogaID).ToList();
                    List<int> uncheckedRoles = new List<int>();
                    for (int i = 0; i < clbUloge.Items.Count; i++)
                    {
                        if (!clbUloge.GetItemChecked(i))
                        {
                            int RoleID = clbUloge.Items.Cast<Model.Uloge>().ToList()[i].UlogaID;
                            uncheckedRoles.Add(RoleID);
                        }
                    }
                    var request = new KorisniciUpdateRequest
                    {
                        Ime = Convert.ToString(txtIme.Text),
                        Prezime = Convert.ToString(txtPrezime.Text),
                        KorisnickoIme = Convert.ToString(txtKorisnickoIme.Text),
                        Email = Convert.ToString(txtEmail.Text),
                        Telefon = Convert.ToString(txtTelefon.Text),
                        Uloge = roleList,
                        UlogeZaObrisati = uncheckedRoles,
                        GradID = int.Parse(cmbGrad.SelectedValue.ToString()),
                    };

                    await _service.Update<Model.Korisnici>(_ID, request);

                    MessageBox.Show("Uspješno ste izmijenili lične podatke");
                    
                }
                catch
                {
                    MessageBox.Show("Error");
                }
            }
        }
    }
}
