namespace eRestoran.WinUI.UserControls.Profil
{
    partial class ucPromjenaLozinke
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
            this.gbPassword = new System.Windows.Forms.GroupBox();
            this.lblNewPasswordConfirm = new System.Windows.Forms.Label();
            this.txtNewPasswordConfirm = new System.Windows.Forms.TextBox();
            this.lblNewPassword = new System.Windows.Forms.Label();
            this.txtNewPassword = new System.Windows.Forms.TextBox();
            this.btnSacuvaj = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnInfo = new System.Windows.Forms.Button();
            this.btnPassword = new System.Windows.Forms.Button();
            this.epNovaLozinka = new System.Windows.Forms.ErrorProvider(this.components);
            this.epPotvrdaNoveLozinke = new System.Windows.Forms.ErrorProvider(this.components);
            this.gbPassword.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epNovaLozinka)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epPotvrdaNoveLozinke)).BeginInit();
            this.SuspendLayout();
            // 
            // gbPassword
            // 
            this.gbPassword.Controls.Add(this.lblNewPasswordConfirm);
            this.gbPassword.Controls.Add(this.txtNewPasswordConfirm);
            this.gbPassword.Controls.Add(this.lblNewPassword);
            this.gbPassword.Controls.Add(this.txtNewPassword);
            this.gbPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbPassword.Location = new System.Drawing.Point(183, 116);
            this.gbPassword.Margin = new System.Windows.Forms.Padding(4);
            this.gbPassword.Name = "gbPassword";
            this.gbPassword.Padding = new System.Windows.Forms.Padding(4);
            this.gbPassword.Size = new System.Drawing.Size(507, 283);
            this.gbPassword.TabIndex = 83;
            this.gbPassword.TabStop = false;
            this.gbPassword.Text = "Promjena lozinke";
            // 
            // lblNewPasswordConfirm
            // 
            this.lblNewPasswordConfirm.AutoSize = true;
            this.lblNewPasswordConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblNewPasswordConfirm.Location = new System.Drawing.Point(56, 158);
            this.lblNewPasswordConfirm.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNewPasswordConfirm.Name = "lblNewPasswordConfirm";
            this.lblNewPasswordConfirm.Size = new System.Drawing.Size(137, 24);
            this.lblNewPasswordConfirm.TabIndex = 84;
            this.lblNewPasswordConfirm.Text = "Potvrda lozinke";
            // 
            // txtNewPasswordConfirm
            // 
            this.txtNewPasswordConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtNewPasswordConfirm.Location = new System.Drawing.Point(60, 186);
            this.txtNewPasswordConfirm.Margin = new System.Windows.Forms.Padding(4);
            this.txtNewPasswordConfirm.Name = "txtNewPasswordConfirm";
            this.txtNewPasswordConfirm.PasswordChar = '*';
            this.txtNewPasswordConfirm.Size = new System.Drawing.Size(375, 28);
            this.txtNewPasswordConfirm.TabIndex = 83;
            this.txtNewPasswordConfirm.Validating += new System.ComponentModel.CancelEventHandler(this.NewPasswordConfirmValidating);
            // 
            // lblNewPassword
            // 
            this.lblNewPassword.AutoSize = true;
            this.lblNewPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblNewPassword.Location = new System.Drawing.Point(56, 59);
            this.lblNewPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNewPassword.Name = "lblNewPassword";
            this.lblNewPassword.Size = new System.Drawing.Size(117, 24);
            this.lblNewPassword.TabIndex = 82;
            this.lblNewPassword.Text = "Nova lozinka";
            // 
            // txtNewPassword
            // 
            this.txtNewPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtNewPassword.Location = new System.Drawing.Point(60, 87);
            this.txtNewPassword.Margin = new System.Windows.Forms.Padding(4);
            this.txtNewPassword.Name = "txtNewPassword";
            this.txtNewPassword.PasswordChar = '*';
            this.txtNewPassword.Size = new System.Drawing.Size(375, 28);
            this.txtNewPassword.TabIndex = 81;
            this.txtNewPassword.Validating += new System.ComponentModel.CancelEventHandler(this.NewPasswordValidating);
            // 
            // btnSacuvaj
            // 
            this.btnSacuvaj.BackColor = System.Drawing.Color.Turquoise;
            this.btnSacuvaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSacuvaj.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSacuvaj.Location = new System.Drawing.Point(567, 439);
            this.btnSacuvaj.Name = "btnSacuvaj";
            this.btnSacuvaj.Size = new System.Drawing.Size(123, 42);
            this.btnSacuvaj.TabIndex = 85;
            this.btnSacuvaj.Text = "Sačuvaj";
            this.btnSacuvaj.UseVisualStyleBackColor = false;
            this.btnSacuvaj.Click += new System.EventHandler(this.btnSacuvaj_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnInfo);
            this.panel1.Controls.Add(this.btnPassword);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(861, 70);
            this.panel1.TabIndex = 86;
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
            this.btnInfo.Click += new System.EventHandler(this.btnInfo_Click);
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
            // 
            // epNovaLozinka
            // 
            this.epNovaLozinka.ContainerControl = this;
            // 
            // epPotvrdaNoveLozinke
            // 
            this.epPotvrdaNoveLozinke.ContainerControl = this;
            // 
            // ucPromjenaLozinke
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnSacuvaj);
            this.Controls.Add(this.gbPassword);
            this.Name = "ucPromjenaLozinke";
            this.Size = new System.Drawing.Size(867, 602);
            this.gbPassword.ResumeLayout(false);
            this.gbPassword.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.epNovaLozinka)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epPotvrdaNoveLozinke)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbPassword;
        private System.Windows.Forms.Label lblNewPasswordConfirm;
        private System.Windows.Forms.TextBox txtNewPasswordConfirm;
        private System.Windows.Forms.Label lblNewPassword;
        private System.Windows.Forms.TextBox txtNewPassword;
        private System.Windows.Forms.Button btnSacuvaj;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnInfo;
        private System.Windows.Forms.Button btnPassword;
        private System.Windows.Forms.ErrorProvider epNovaLozinka;
        private System.Windows.Forms.ErrorProvider epPotvrdaNoveLozinke;
    }
}
