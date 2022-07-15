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

namespace eRestoran.WinUI.UserControls
{
    public partial class ucPrijava : UserControl
    {
        private readonly APIService _service = new APIService("korisnici");
        private static ucPrijava _instance;
        bool flag = false;
        public static ucPrijava Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ucPrijava();
                return _instance;
            }
        }
        public ucPrijava()
        {
            InitializeComponent();
        }
        private void txtUsername_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtKorisnickoIme.Text))
            {
                errKorisnickoIme.SetError(txtKorisnickoIme, "Obavezan unos");
                e.Cancel = true;
            }
            else
            {
                errKorisnickoIme.Clear();
                e.Cancel = false;
            }
        }
        private void txtPassword_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtLozinka.Text))
            {
                errLozinka.SetError(txtLozinka, "Obavezan unos");
                e.Cancel = true;
            }
            else
            {
                errLozinka.Clear();
                e.Cancel = false;
            }
        }
        private async void btnSignIn_ClickAsync(object sender, EventArgs e)
        {
            if (ValidateChildren())
            {
                APIService.KorisnickoIme = txtKorisnickoIme.Text;
                APIService.Lozinka = txtLozinka.Text;
                var request = new KorisnikAuthenticationRequest()
                {
                    KorisnickoIme = APIService.KorisnickoIme,
                    Lozinka = APIService.Lozinka
                };

                var user = await _service.Authenticate(request);
                if (user != null)
                {
                    foreach (var x in user.KorisniciUloge)
                    {
                        if (x.KorisnikUlogaID == 1)
                            flag = true;
                    }                   
                }
                else
                {
                    errLozinka.SetError(txtLozinka, "Pogrešna lozinka");
                }

                if (flag == true)
                {
                    LoadPanel(user);
                    errKorisnickoIme.Clear();
                }
                else
                {
                    errKorisnickoIme.SetError(txtKorisnickoIme, "Korisnik sa tim korisničkim imenom ne postoji ili nemate privilegije za pristup administratorskom dijelu");
                }
            }
        }

        private void LoadPanel(Model.Korisnici user)
        {
            var adminRole = user.KorisniciUloge.FirstOrDefault(i => i.Uloga.Naziv == "Administrator");
            if (adminRole != null)
            {
                var form = new frmAdminPanel(user);
                form.Show();

                ParentForm.Hide();
            }
        }

        
    }
}
