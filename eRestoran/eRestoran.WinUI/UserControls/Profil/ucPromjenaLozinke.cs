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

namespace eRestoran.WinUI.UserControls.Profil
{
    public partial class ucPromjenaLozinke : UserControl
    {
        private readonly APIService _service = new APIService("korisnici");

        private readonly int _ID;
        public ucPromjenaLozinke(int Id)
        {
            _ID = Id;
            InitializeComponent();
        }

        private async void btnSacuvaj_Click(object sender, EventArgs e)
        {
            if (ValidateChildren())
            {

                try
                {
                    var user = await _service.GetById<Model.Korisnici>(_ID);
                    var roleList = user.KorisniciUloge.Select(i => i.UlogaID).ToList();

                    var request = new KorisniciUpdateRequest
                    {
                        Ime = user.Ime,
                        Prezime = user.Prezime,
                        KorisnickoIme = user.KorisnickoIme,
                        Email = user.Email,
                        Telefon = user.Telefon,
                        Lozinka = txtNewPassword.Text,
                        LozinkaPotvrda = txtNewPasswordConfirm.Text,
                        GradID = user.GradID,
                        Uloge = roleList,
                        UlogeZaObrisati = new List<int>()
                        
                    };

                    await _service.Update<Model.Korisnici>(_ID, request);
                    MessageBox.Show("Uspješno ste promijenili lozinku");
                    var uc = new ucMojProfil(_ID);
                    if (!this.Controls.Contains(uc))
                    {
                        this.Controls.Add(uc);
                        uc.Dock = DockStyle.Fill;
                    }

                    uc.BringToFront();
                }
                catch
                {
                    MessageBox.Show("Greška");

                }
            }
        }

        private void NewPasswordValidating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtNewPassword.Text))
            {
                epNovaLozinka.SetError(txtNewPassword, "Obavezno polje");
                e.Cancel = true;
            }
            else
            {
                epNovaLozinka.Clear();
                e.Cancel = false;
            }
        }

        private void NewPasswordConfirmValidating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtNewPasswordConfirm.Text))
            {
                epPotvrdaNoveLozinke.SetError(txtNewPasswordConfirm, "Obavezno polje");
                e.Cancel = true;
            }
            if(txtNewPasswordConfirm.Text!=txtNewPassword.Text)
            {
                epPotvrdaNoveLozinke.SetError(txtNewPasswordConfirm, "Lozinke se ne podudaraju");
                e.Cancel = true;
            }
            else
            {
                epPotvrdaNoveLozinke.Clear();
                e.Cancel = false;
            }
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            var uc = new ucMojProfil(_ID);
            if (!this.Controls.Contains(uc))
            {
                this.Controls.Add(uc);
                uc.Dock = DockStyle.Fill;
            }

            uc.BringToFront();
        }
    }
}
