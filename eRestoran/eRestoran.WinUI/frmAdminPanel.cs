using eRestoran.WinUI.Helpers;
using eRestoran.WinUI.UserControls.Izvjestaji;
using eRestoran.WinUI.UserControls.Jela;
using eRestoran.WinUI.UserControls.Korisnici;
using eRestoran.WinUI.UserControls.Narudzbe;
using eRestoran.WinUI.UserControls.Profil;
using eRestoran.WinUI.UserControls.Rezervacije;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eRestoran.WinUI
{
    public partial class frmAdminPanel : Form
    {
        private static Model.Korisnici _user;
        public frmAdminPanel(Model.Korisnici user)
        {
            _user = user;
            PrijavljeniKorisnikHelper.User = _user;
            InitializeComponent();
            AutoValidate = AutoValidate.Disable;
        }

        private void frmAdminPanel_Load(object sender, EventArgs e)
        {

        }

        private void lblKorisnici_Click(object sender, EventArgs e)
        {
            PanelHelper.RemovePanels(pnlMain);
            PanelHelper.AddPanel(pnlMain, new ucKorisniciPrikaz());
        }

        private void lblJela_Click(object sender, EventArgs e)
        {
            PanelHelper.RemovePanels(pnlMain);
            PanelHelper.AddPanel(pnlMain, new ucJelaPrikaz());
        }

        private void pnlMain_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblNarudze_Click(object sender, EventArgs e)
        {
            PanelHelper.RemovePanels(pnlMain);
            PanelHelper.AddPanel(pnlMain, new ucNarudzbePrikaz());
        }

        private void lblRezervacije_Click(object sender, EventArgs e)
        {
            PanelHelper.RemovePanels(pnlMain);
            PanelHelper.AddPanel(pnlMain, new ucRezervacijePrikaz());
        }

      
        private void lblNarudzbe_MouseHover(object sender, EventArgs e)
        {

            lblNarudzbe.BackColor = Color.MediumTurquoise;

        }

        private void lblNarudzbe_MouseLeave(object sender, EventArgs e)
        {

            lblNarudzbe.BackColor = Color.Turquoise;

        }

        private void lblRezervacija_MouseHover(object sender, EventArgs e)
        {

            lblRezervacije.BackColor = Color.MediumTurquoise;

        }

        private void lblRezervacije_MouseLeave(object sender, EventArgs e)
        {

            lblRezervacije.BackColor = Color.Turquoise;

        }
        private void lblJela_MouseHover(object sender, EventArgs e)
        {

            lblJela.BackColor = Color.MediumTurquoise;

        }

        private void lblJela_MouseLeave(object sender, EventArgs e)
        {

            lblJela.BackColor = Color.Turquoise;

        }
        private void lblProfil_MouseHover(object sender, EventArgs e)
        {
            lblProfil.BackColor = Color.MediumTurquoise;

        }

        private void lblProfil_MouseLeave(object sender, EventArgs e)
        {

            lblProfil.BackColor = Color.Turquoise;

        }
        private void lblKorisnici_MouseHover(object sender, EventArgs e)
        {

            lblKorisnici.BackColor = Color.MediumTurquoise;

        }

        private void lblKorisnici_MouseLeave(object sender, EventArgs e)
        {

            lblKorisnici.BackColor = Color.Turquoise;

        }
        private void lbl_izvjestaji_MouseHover(object sender, EventArgs e)
        {

            lbl_izvjestaji.BackColor = Color.MediumTurquoise;

        }

        private void lbl_izvjestaji_MouseLeave(object sender, EventArgs e)
        {

            lbl_izvjestaji.BackColor = Color.Turquoise;

        }

        private void btnSignOut_Click(object sender, EventArgs e)
        {
           
            var form = new frmMain();
            form.Show();

            Hide();
            
        }

        private void lblProfil_Click(object sender, EventArgs e)
        {
            PanelHelper.RemovePanels(pnlMain);
            PanelHelper.AddPanel(pnlMain, new ucMojProfil(_user.KorisnikID));
        }

        
        private void lbl_izvjestaji_Click(object sender, EventArgs e)
        {
            PanelHelper.RemovePanels(pnlMain);
            PanelHelper.AddPanel(pnlMain, new ucIzvjestaji());
        }
    }
}
