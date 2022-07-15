namespace eRestoran.WinUI
{
    partial class frmAdminPanel
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdminPanel));
            this.pnlNav = new System.Windows.Forms.Panel();
            this.lbl_izvjestaji = new System.Windows.Forms.Label();
            this.btnSignOut = new System.Windows.Forms.PictureBox();
            this.lblProfil = new System.Windows.Forms.Label();
            this.lblKorisnici = new System.Windows.Forms.Label();
            this.lblJela = new System.Windows.Forms.Label();
            this.lblRezervacije = new System.Windows.Forms.Label();
            this.lblNarudzbe = new System.Windows.Forms.Label();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlNav.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnSignOut)).BeginInit();
            this.pnlMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlNav
            // 
            this.pnlNav.BackColor = System.Drawing.Color.Turquoise;
            this.pnlNav.Controls.Add(this.lbl_izvjestaji);
            this.pnlNav.Controls.Add(this.btnSignOut);
            this.pnlNav.Controls.Add(this.lblProfil);
            this.pnlNav.Controls.Add(this.lblKorisnici);
            this.pnlNav.Controls.Add(this.lblJela);
            this.pnlNav.Controls.Add(this.lblRezervacije);
            this.pnlNav.Controls.Add(this.lblNarudzbe);
            this.pnlNav.Location = new System.Drawing.Point(2, 0);
            this.pnlNav.Name = "pnlNav";
            this.pnlNav.Size = new System.Drawing.Size(258, 725);
            this.pnlNav.TabIndex = 0;
            // 
            // lbl_izvjestaji
            // 
            this.lbl_izvjestaji.AutoSize = true;
            this.lbl_izvjestaji.Font = new System.Drawing.Font("Matura MT Script Capitals", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_izvjestaji.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_izvjestaji.Location = new System.Drawing.Point(27, 368);
            this.lbl_izvjestaji.Name = "lbl_izvjestaji";
            this.lbl_izvjestaji.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbl_izvjestaji.Size = new System.Drawing.Size(136, 39);
            this.lbl_izvjestaji.TabIndex = 6;
            this.lbl_izvjestaji.Text = "Izvještaji";
            this.lbl_izvjestaji.Click += new System.EventHandler(this.lbl_izvjestaji_Click);
            this.lbl_izvjestaji.MouseLeave += new System.EventHandler(this.lbl_izvjestaji_MouseLeave);
            this.lbl_izvjestaji.MouseHover += new System.EventHandler(this.lbl_izvjestaji_MouseHover);
            // 
            // btnSignOut
            // 
            this.btnSignOut.Image = global::eRestoran.WinUI.Properties.Resources.logout1;
            this.btnSignOut.Location = new System.Drawing.Point(20, 555);
            this.btnSignOut.Name = "btnSignOut";
            this.btnSignOut.Size = new System.Drawing.Size(51, 49);
            this.btnSignOut.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnSignOut.TabIndex = 1;
            this.btnSignOut.TabStop = false;
            this.btnSignOut.Click += new System.EventHandler(this.btnSignOut_Click);
            // 
            // lblProfil
            // 
            this.lblProfil.AutoSize = true;
            this.lblProfil.Font = new System.Drawing.Font("Matura MT Script Capitals", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblProfil.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblProfil.Location = new System.Drawing.Point(27, 445);
            this.lblProfil.Name = "lblProfil";
            this.lblProfil.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblProfil.Size = new System.Drawing.Size(144, 39);
            this.lblProfil.TabIndex = 5;
            this.lblProfil.Text = "Moj profil";
            this.lblProfil.Click += new System.EventHandler(this.lblProfil_Click);
            this.lblProfil.MouseLeave += new System.EventHandler(this.lblProfil_MouseLeave);
            this.lblProfil.MouseHover += new System.EventHandler(this.lblProfil_MouseHover);
            // 
            // lblKorisnici
            // 
            this.lblKorisnici.AutoSize = true;
            this.lblKorisnici.Font = new System.Drawing.Font("Matura MT Script Capitals", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblKorisnici.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblKorisnici.Location = new System.Drawing.Point(27, 291);
            this.lblKorisnici.Name = "lblKorisnici";
            this.lblKorisnici.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblKorisnici.Size = new System.Drawing.Size(136, 39);
            this.lblKorisnici.TabIndex = 4;
            this.lblKorisnici.Text = "Korisnici";
            this.lblKorisnici.Click += new System.EventHandler(this.lblKorisnici_Click);
            this.lblKorisnici.MouseLeave += new System.EventHandler(this.lblKorisnici_MouseLeave);
            this.lblKorisnici.MouseHover += new System.EventHandler(this.lblKorisnici_MouseHover);
            // 
            // lblJela
            // 
            this.lblJela.AutoSize = true;
            this.lblJela.Font = new System.Drawing.Font("Matura MT Script Capitals", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblJela.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblJela.Location = new System.Drawing.Point(27, 214);
            this.lblJela.Name = "lblJela";
            this.lblJela.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblJela.Size = new System.Drawing.Size(77, 39);
            this.lblJela.TabIndex = 3;
            this.lblJela.Text = "Jela";
            this.lblJela.Click += new System.EventHandler(this.lblJela_Click);
            this.lblJela.MouseLeave += new System.EventHandler(this.lblJela_MouseLeave);
            this.lblJela.MouseHover += new System.EventHandler(this.lblJela_MouseHover);
            // 
            // lblRezervacije
            // 
            this.lblRezervacije.AutoSize = true;
            this.lblRezervacije.Font = new System.Drawing.Font("Matura MT Script Capitals", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblRezervacije.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblRezervacije.Location = new System.Drawing.Point(27, 137);
            this.lblRezervacije.Name = "lblRezervacije";
            this.lblRezervacije.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblRezervacije.Size = new System.Drawing.Size(180, 39);
            this.lblRezervacije.TabIndex = 2;
            this.lblRezervacije.Text = "Rezervacije";
            this.lblRezervacije.Click += new System.EventHandler(this.lblRezervacije_Click);
            this.lblRezervacije.MouseLeave += new System.EventHandler(this.lblRezervacije_MouseLeave);
            this.lblRezervacije.MouseHover += new System.EventHandler(this.lblRezervacija_MouseHover);
            // 
            // lblNarudzbe
            // 
            this.lblNarudzbe.AutoSize = true;
            this.lblNarudzbe.Font = new System.Drawing.Font("Matura MT Script Capitals", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblNarudzbe.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblNarudzbe.Location = new System.Drawing.Point(27, 60);
            this.lblNarudzbe.Name = "lblNarudzbe";
            this.lblNarudzbe.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblNarudzbe.Size = new System.Drawing.Size(153, 39);
            this.lblNarudzbe.TabIndex = 1;
            this.lblNarudzbe.Text = "Narudžbe";
            this.lblNarudzbe.Click += new System.EventHandler(this.lblNarudze_Click);
            this.lblNarudzbe.MouseLeave += new System.EventHandler(this.lblNarudzbe_MouseLeave);
            this.lblNarudzbe.MouseHover += new System.EventHandler(this.lblNarudzbe_MouseHover);
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.label1);
            this.pnlMain.Location = new System.Drawing.Point(266, 31);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(883, 596);
            this.pnlMain.TabIndex = 1;
            this.pnlMain.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlMain_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Calligraphy", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Turquoise;
            this.label1.Location = new System.Drawing.Point(126, 226);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(655, 62);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dobro došli u eRestoran!";
            // 
            // frmAdminPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1147, 639);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.pnlNav);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAdminPanel";
            this.Text = "eRestoran/Admin";
            this.Load += new System.EventHandler(this.frmAdminPanel_Load);
            this.pnlNav.ResumeLayout(false);
            this.pnlNav.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnSignOut)).EndInit();
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlNav;
        private System.Windows.Forms.Label lblNarudzbe;
        private System.Windows.Forms.Label lblProfil;
        private System.Windows.Forms.Label lblKorisnici;
        private System.Windows.Forms.Label lblJela;
        private System.Windows.Forms.Label lblRezervacije;
        private System.Windows.Forms.PictureBox btnSignOut;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_izvjestaji;
    }
}