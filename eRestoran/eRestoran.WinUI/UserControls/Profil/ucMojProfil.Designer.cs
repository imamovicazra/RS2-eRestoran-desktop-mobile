namespace eRestoran.WinUI.UserControls.Profil
{
    partial class ucMojProfil
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.clbUloge = new System.Windows.Forms.CheckedListBox();
            this.btnSacuvaj = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbGrad = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnPassword = new System.Windows.Forms.Button();
            this.btnInfo = new System.Windows.Forms.Button();
            this.epIme = new System.Windows.Forms.ErrorProvider(this.components);
            this.epPrezime = new System.Windows.Forms.ErrorProvider(this.components);
            this.epKorisnickoIme = new System.Windows.Forms.ErrorProvider(this.components);
            this.epBrojTelefona = new System.Windows.Forms.ErrorProvider(this.components);
            this.epEmail = new System.Windows.Forms.ErrorProvider(this.components);
            this.epGradovi = new System.Windows.Forms.ErrorProvider(this.components);
            this.epUloge = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epIme)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epPrezime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epKorisnickoIme)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epBrojTelefona)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epEmail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epGradovi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epUloge)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.clbUloge);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox2.Location = new System.Drawing.Point(94, 370);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(663, 139);
            this.groupBox2.TabIndex = 72;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Uloge";
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
            this.btnSacuvaj.Location = new System.Drawing.Point(634, 531);
            this.btnSacuvaj.Name = "btnSacuvaj";
            this.btnSacuvaj.Size = new System.Drawing.Size(123, 42);
            this.btnSacuvaj.TabIndex = 71;
            this.btnSacuvaj.Text = "Sačuvaj";
            this.btnSacuvaj.UseVisualStyleBackColor = false;
            this.btnSacuvaj.Click += new System.EventHandler(this.btnSacuvaj_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbGrad);
            this.groupBox1.Controls.Add(this.label4);
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
            this.groupBox1.Location = new System.Drawing.Point(94, 76);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(663, 278);
            this.groupBox1.TabIndex = 70;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lične informacije";
            // 
            // cmbGrad
            // 
            this.cmbGrad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cmbGrad.FormattingEnabled = true;
            this.cmbGrad.Location = new System.Drawing.Point(374, 223);
            this.cmbGrad.Name = "cmbGrad";
            this.cmbGrad.Size = new System.Drawing.Size(249, 28);
            this.cmbGrad.TabIndex = 58;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(369, 192);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 25);
            this.label4.TabIndex = 57;
            this.label4.Text = "Grad";
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
            // panel1
            // 
            this.panel1.Controls.Add(this.btnInfo);
            this.panel1.Controls.Add(this.btnPassword);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(861, 70);
            this.panel1.TabIndex = 73;
            // 
            // btnPassword
            // 
            this.btnPassword.BackColor = System.Drawing.Color.Turquoise;
            this.btnPassword.FlatAppearance.BorderSize = 0;
            this.btnPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnPassword.Location = new System.Drawing.Point(252, 4);
            this.btnPassword.Margin = new System.Windows.Forms.Padding(4);
            this.btnPassword.Name = "btnPassword";
            this.btnPassword.Size = new System.Drawing.Size(184, 38);
            this.btnPassword.TabIndex = 70;
            this.btnPassword.Text = "Promjena lozinke";
            this.btnPassword.UseVisualStyleBackColor = false;
            this.btnPassword.Click += new System.EventHandler(this.btnPassword_Click);
            // 
            // btnInfo
            // 
            this.btnInfo.BackColor = System.Drawing.Color.Turquoise;
            this.btnInfo.FlatAppearance.BorderSize = 0;
            this.btnInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnInfo.Location = new System.Drawing.Point(25, 4);
            this.btnInfo.Margin = new System.Windows.Forms.Padding(4);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(184, 38);
            this.btnInfo.TabIndex = 71;
            this.btnInfo.Text = "Promjena podataka";
            this.btnInfo.UseVisualStyleBackColor = false;
            // 
            // epIme
            // 
            this.epIme.ContainerControl = this;
            // 
            // epPrezime
            // 
            this.epPrezime.ContainerControl = this;
            // 
            // epKorisnickoIme
            // 
            this.epKorisnickoIme.ContainerControl = this;
            // 
            // epBrojTelefona
            // 
            this.epBrojTelefona.ContainerControl = this;
            // 
            // epEmail
            // 
            this.epEmail.ContainerControl = this;
            // 
            // epGradovi
            // 
            this.epGradovi.ContainerControl = this;
            // 
            // epUloge
            // 
            this.epUloge.ContainerControl = this;
            // 
            // ucMojProfil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnSacuvaj);
            this.Controls.Add(this.groupBox1);
            this.Name = "ucMojProfil";
            this.Size = new System.Drawing.Size(861, 632);
            this.Load += new System.EventHandler(this.ucMojProfil_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.epIme)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epPrezime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epKorisnickoIme)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epBrojTelefona)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epEmail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epGradovi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epUloge)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckedListBox clbUloge;
        private System.Windows.Forms.Button btnSacuvaj;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbGrad;
        private System.Windows.Forms.Label label4;
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
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnInfo;
        private System.Windows.Forms.Button btnPassword;
        private System.Windows.Forms.ErrorProvider epIme;
        private System.Windows.Forms.ErrorProvider epPrezime;
        private System.Windows.Forms.ErrorProvider epKorisnickoIme;
        private System.Windows.Forms.ErrorProvider epBrojTelefona;
        private System.Windows.Forms.ErrorProvider epEmail;
        private System.Windows.Forms.ErrorProvider epGradovi;
        private System.Windows.Forms.ErrorProvider epUloge;
    }
}
