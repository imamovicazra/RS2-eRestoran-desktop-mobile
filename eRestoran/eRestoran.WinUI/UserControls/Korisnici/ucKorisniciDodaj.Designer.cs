namespace eRestoran.WinUI.UserControls.Korisnici
{
    partial class ucKorisniciDodaj
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbGrad = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtLozinkaPotvrda = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtLozinka = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtKorisnickoIme = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTelefon = new System.Windows.Forms.TextBox();
            this.Email = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPrezime = new System.Windows.Forms.TextBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.txtIme = new System.Windows.Forms.TextBox();
            this.clbUloge = new System.Windows.Forms.CheckedListBox();
            this.btnSacuvaj = new System.Windows.Forms.Button();
            this.epIme = new System.Windows.Forms.ErrorProvider(this.components);
            this.epPrezime = new System.Windows.Forms.ErrorProvider(this.components);
            this.epBrojTelefona = new System.Windows.Forms.ErrorProvider(this.components);
            this.epEmail = new System.Windows.Forms.ErrorProvider(this.components);
            this.epKorisnickoIme = new System.Windows.Forms.ErrorProvider(this.components);
            this.epLozinka = new System.Windows.Forms.ErrorProvider(this.components);
            this.epLozinkaPotvrda = new System.Windows.Forms.ErrorProvider(this.components);
            this.epGradovi = new System.Windows.Forms.ErrorProvider(this.components);
            this.epUloge = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epIme)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epPrezime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epBrojTelefona)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epEmail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epKorisnickoIme)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epLozinka)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epLozinkaPotvrda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epGradovi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epUloge)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbGrad);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtLozinkaPotvrda);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtLozinka);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtKorisnickoIme);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtTelefon);
            this.groupBox1.Controls.Add(this.Email);
            this.groupBox1.Controls.Add(this.txtEmail);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtPrezime);
            this.groupBox1.Controls.Add(this.lblFirstName);
            this.groupBox1.Controls.Add(this.txtIme);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox1.Location = new System.Drawing.Point(76, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(663, 346);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lične informacije";
            // 
            // cmbGrad
            // 
            this.cmbGrad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cmbGrad.FormattingEnabled = true;
            this.cmbGrad.Location = new System.Drawing.Point(374, 221);
            this.cmbGrad.Name = "cmbGrad";
            this.cmbGrad.Size = new System.Drawing.Size(249, 28);
            this.cmbGrad.TabIndex = 56;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(369, 273);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(150, 25);
            this.label5.TabIndex = 50;
            this.label5.Text = "Lozinka potvrda";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(369, 190);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 25);
            this.label7.TabIndex = 53;
            this.label7.Text = "Grad";
            // 
            // txtLozinkaPotvrda
            // 
            this.txtLozinkaPotvrda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLozinkaPotvrda.Location = new System.Drawing.Point(374, 306);
            this.txtLozinkaPotvrda.Margin = new System.Windows.Forms.Padding(4);
            this.txtLozinkaPotvrda.Name = "txtLozinkaPotvrda";
            this.txtLozinkaPotvrda.PasswordChar = '*';
            this.txtLozinkaPotvrda.Size = new System.Drawing.Size(249, 26);
            this.txtLozinkaPotvrda.TabIndex = 49;
            this.txtLozinkaPotvrda.Validating += new System.ComponentModel.CancelEventHandler(this.LozinkaPotvrda_Validating);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 273);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 25);
            this.label4.TabIndex = 48;
            this.label4.Text = "Lozinka";
            // 
            // txtLozinka
            // 
            this.txtLozinka.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLozinka.Location = new System.Drawing.Point(33, 306);
            this.txtLozinka.Margin = new System.Windows.Forms.Padding(4);
            this.txtLozinka.Name = "txtLozinka";
            this.txtLozinka.PasswordChar = '*';
            this.txtLozinka.Size = new System.Drawing.Size(249, 26);
            this.txtLozinka.TabIndex = 47;
            this.txtLozinka.Validating += new System.ComponentModel.CancelEventHandler(this.Lozinka_Validating);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 190);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 25);
            this.label3.TabIndex = 46;
            this.label3.Text = "Korisničko ime";
            // 
            // txtKorisnickoIme
            // 
            this.txtKorisnickoIme.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKorisnickoIme.Location = new System.Drawing.Point(33, 223);
            this.txtKorisnickoIme.Margin = new System.Windows.Forms.Padding(4);
            this.txtKorisnickoIme.Name = "txtKorisnickoIme";
            this.txtKorisnickoIme.Size = new System.Drawing.Size(249, 26);
            this.txtKorisnickoIme.TabIndex = 45;
            this.txtKorisnickoIme.Validating += new System.ComponentModel.CancelEventHandler(this.KorisnickoIme_Validating);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 114);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 25);
            this.label2.TabIndex = 44;
            this.label2.Text = "Broj telefona";
            // 
            // txtTelefon
            // 
            this.txtTelefon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefon.Location = new System.Drawing.Point(33, 147);
            this.txtTelefon.Margin = new System.Windows.Forms.Padding(4);
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(249, 26);
            this.txtTelefon.TabIndex = 43;
            this.txtTelefon.Validating += new System.ComponentModel.CancelEventHandler(this.Telefon_Validating);
            // 
            // Email
            // 
            this.Email.AutoSize = true;
            this.Email.Location = new System.Drawing.Point(369, 114);
            this.Email.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(67, 25);
            this.Email.TabIndex = 42;
            this.Email.Text = "E-mail";
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(374, 147);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(249, 26);
            this.txtEmail.TabIndex = 41;
            this.txtEmail.Validating += new System.ComponentModel.CancelEventHandler(this.Email_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(369, 38);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 25);
            this.label1.TabIndex = 40;
            this.label1.Text = "Prezime";
            // 
            // txtPrezime
            // 
            this.txtPrezime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrezime.Location = new System.Drawing.Point(374, 71);
            this.txtPrezime.Margin = new System.Windows.Forms.Padding(4);
            this.txtPrezime.Name = "txtPrezime";
            this.txtPrezime.Size = new System.Drawing.Size(249, 26);
            this.txtPrezime.TabIndex = 39;
            this.txtPrezime.Validating += new System.ComponentModel.CancelEventHandler(this.Prezime_Validating);
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(28, 38);
            this.lblFirstName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(44, 25);
            this.lblFirstName.TabIndex = 38;
            this.lblFirstName.Text = "Ime";
            // 
            // txtIme
            // 
            this.txtIme.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIme.Location = new System.Drawing.Point(33, 71);
            this.txtIme.Margin = new System.Windows.Forms.Padding(4);
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(249, 26);
            this.txtIme.TabIndex = 37;
            this.txtIme.Validating += new System.ComponentModel.CancelEventHandler(this.Ime_Validating);
            // 
            // clbUloge
            // 
            this.clbUloge.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.clbUloge.FormattingEnabled = true;
            this.clbUloge.Location = new System.Drawing.Point(33, 40);
            this.clbUloge.Name = "clbUloge";
            this.clbUloge.Size = new System.Drawing.Size(263, 79);
            this.clbUloge.TabIndex = 6;
            this.clbUloge.Validating += new System.ComponentModel.CancelEventHandler(this.Uloge_Validating);
            // 
            // btnSacuvaj
            // 
            this.btnSacuvaj.BackColor = System.Drawing.Color.Turquoise;
            this.btnSacuvaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSacuvaj.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSacuvaj.Location = new System.Drawing.Point(616, 541);
            this.btnSacuvaj.Name = "btnSacuvaj";
            this.btnSacuvaj.Size = new System.Drawing.Size(123, 42);
            this.btnSacuvaj.TabIndex = 5;
            this.btnSacuvaj.Text = "Sačuvaj";
            this.btnSacuvaj.UseVisualStyleBackColor = false;
            this.btnSacuvaj.Click += new System.EventHandler(this.btnSacuvaj_Click);
            // 
            // epIme
            // 
            this.epIme.ContainerControl = this;
            // 
            // epPrezime
            // 
            this.epPrezime.ContainerControl = this;
            // 
            // epBrojTelefona
            // 
            this.epBrojTelefona.ContainerControl = this;
            // 
            // epEmail
            // 
            this.epEmail.ContainerControl = this;
            // 
            // epKorisnickoIme
            // 
            this.epKorisnickoIme.ContainerControl = this;
            // 
            // epLozinka
            // 
            this.epLozinka.ContainerControl = this;
            // 
            // epLozinkaPotvrda
            // 
            this.epLozinkaPotvrda.ContainerControl = this;
            // 
            // epGradovi
            // 
            this.epGradovi.ContainerControl = this;
            // 
            // epUloge
            // 
            this.epUloge.ContainerControl = this;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.clbUloge);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox2.Location = new System.Drawing.Point(76, 374);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(663, 149);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Uloge";
            // 
            // ucKorisniciDodaj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnSacuvaj);
            this.Controls.Add(this.groupBox1);
            this.Name = "ucKorisniciDodaj";
            this.Size = new System.Drawing.Size(789, 618);
            this.Load += new System.EventHandler(this.ucKorisniciDodaj_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epIme)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epPrezime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epBrojTelefona)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epEmail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epKorisnickoIme)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epLozinka)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epLozinkaPotvrda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epGradovi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epUloge)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtLozinkaPotvrda;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtLozinka;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtKorisnickoIme;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTelefon;
        private System.Windows.Forms.Label Email;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPrezime;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.TextBox txtIme;
        private System.Windows.Forms.Button btnSacuvaj;
        private System.Windows.Forms.ErrorProvider epIme;
        private System.Windows.Forms.ErrorProvider epPrezime;
        private System.Windows.Forms.ErrorProvider epBrojTelefona;
        private System.Windows.Forms.ErrorProvider epEmail;
        private System.Windows.Forms.ErrorProvider epKorisnickoIme;
        private System.Windows.Forms.ErrorProvider epLozinka;
        private System.Windows.Forms.ErrorProvider epLozinkaPotvrda;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckedListBox clbUloge;
        private System.Windows.Forms.ErrorProvider epGradovi;
        private System.Windows.Forms.ErrorProvider epUloge;
        private System.Windows.Forms.ComboBox cmbGrad;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}
