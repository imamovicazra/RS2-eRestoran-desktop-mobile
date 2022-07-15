namespace eRestoran.WinUI.UserControls
{
    partial class ucPrijava
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
            this.btnSignIn = new System.Windows.Forms.Button();
            this.txtLozinka = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtKorisnickoIme = new System.Windows.Forms.TextBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.errKorisnickoIme = new System.Windows.Forms.ErrorProvider(this.components);
            this.errLozinka = new System.Windows.Forms.ErrorProvider(this.components);
            this.errAdmin = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errKorisnickoIme)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errLozinka)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errAdmin)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSignIn
            // 
            this.btnSignIn.BackColor = System.Drawing.SystemColors.Control;
            this.btnSignIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignIn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSignIn.Location = new System.Drawing.Point(126, 366);
            this.btnSignIn.Margin = new System.Windows.Forms.Padding(4);
            this.btnSignIn.Name = "btnSignIn";
            this.btnSignIn.Size = new System.Drawing.Size(381, 54);
            this.btnSignIn.TabIndex = 14;
            this.btnSignIn.Text = "Prijavi se";
            this.btnSignIn.UseVisualStyleBackColor = false;
            this.btnSignIn.Click += new System.EventHandler(this.btnSignIn_ClickAsync);
            // 
            // txtLozinka
            // 
            this.txtLozinka.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLozinka.Location = new System.Drawing.Point(126, 290);
            this.txtLozinka.Margin = new System.Windows.Forms.Padding(4);
            this.txtLozinka.Name = "txtLozinka";
            this.txtLozinka.PasswordChar = '*';
            this.txtLozinka.Size = new System.Drawing.Size(380, 30);
            this.txtLozinka.TabIndex = 13;
            this.txtLozinka.Validating += new System.ComponentModel.CancelEventHandler(this.txtPassword_Validating);
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(121, 261);
            this.lblPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(80, 25);
            this.lblPassword.TabIndex = 12;
            this.lblPassword.Text = "Lozinka";
            // 
            // txtKorisnickoIme
            // 
            this.txtKorisnickoIme.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKorisnickoIme.Location = new System.Drawing.Point(126, 208);
            this.txtKorisnickoIme.Margin = new System.Windows.Forms.Padding(4);
            this.txtKorisnickoIme.Name = "txtKorisnickoIme";
            this.txtKorisnickoIme.Size = new System.Drawing.Size(380, 30);
            this.txtKorisnickoIme.TabIndex = 11;
            this.txtKorisnickoIme.Validating += new System.ComponentModel.CancelEventHandler(this.txtUsername_Validating);
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.Location = new System.Drawing.Point(121, 180);
            this.lblUsername.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(139, 25);
            this.lblUsername.TabIndex = 10;
            this.lblUsername.Text = "Korisničko ime";
            // 
            // errKorisnickoIme
            // 
            this.errKorisnickoIme.ContainerControl = this;
            // 
            // errLozinka
            // 
            this.errLozinka.ContainerControl = this;
            // 
            // errAdmin
            // 
            this.errAdmin.ContainerControl = this;
            // 
            // ucPrijava
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnSignIn);
            this.Controls.Add(this.txtLozinka);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.txtKorisnickoIme);
            this.Controls.Add(this.lblUsername);
            this.Name = "ucPrijava";
            this.Size = new System.Drawing.Size(544, 536);
            ((System.ComponentModel.ISupportInitialize)(this.errKorisnickoIme)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errLozinka)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errAdmin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSignIn;
        private System.Windows.Forms.TextBox txtLozinka;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtKorisnickoIme;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.ErrorProvider errKorisnickoIme;
        private System.Windows.Forms.ErrorProvider errLozinka;
        private System.Windows.Forms.ErrorProvider errAdmin;
    }
}
