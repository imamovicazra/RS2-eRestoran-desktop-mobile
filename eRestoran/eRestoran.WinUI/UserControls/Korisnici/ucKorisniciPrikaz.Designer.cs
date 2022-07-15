namespace eRestoran.WinUI.UserControls.Korisnici
{
    partial class ucKorisniciPrikaz
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
            this.txtPretraga = new System.Windows.Forms.TextBox();
            this.btnPrikazi = new System.Windows.Forms.Button();
            this.dgvKorisnici = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prezime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KorisnickoIme = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbUloge = new System.Windows.Forms.ComboBox();
            this.btnUredi = new System.Windows.Forms.PictureBox();
            this.btnDeleteUser = new System.Windows.Forms.PictureBox();
            this.btnAddUser = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKorisnici)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnUredi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDeleteUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAddUser)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPretraga
            // 
            this.txtPretraga.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtPretraga.Location = new System.Drawing.Point(45, 63);
            this.txtPretraga.Name = "txtPretraga";
            this.txtPretraga.Size = new System.Drawing.Size(493, 27);
            this.txtPretraga.TabIndex = 5;
            this.txtPretraga.TextChanged += new System.EventHandler(this.txtPretraga_TextChanged);
            // 
            // btnPrikazi
            // 
            this.btnPrikazi.BackColor = System.Drawing.Color.Turquoise;
            this.btnPrikazi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnPrikazi.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnPrikazi.Location = new System.Drawing.Point(719, 106);
            this.btnPrikazi.Name = "btnPrikazi";
            this.btnPrikazi.Size = new System.Drawing.Size(102, 32);
            this.btnPrikazi.TabIndex = 4;
            this.btnPrikazi.Text = "Prikaži";
            this.btnPrikazi.UseVisualStyleBackColor = false;
            this.btnPrikazi.Click += new System.EventHandler(this.btnPrikazi_Click);
            // 
            // dgvKorisnici
            // 
            this.dgvKorisnici.AllowUserToAddRows = false;
            this.dgvKorisnici.AllowUserToDeleteRows = false;
            this.dgvKorisnici.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvKorisnici.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKorisnici.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Ime,
            this.Prezime,
            this.KorisnickoIme,
            this.Email});
            this.dgvKorisnici.Location = new System.Drawing.Point(45, 158);
            this.dgvKorisnici.Name = "dgvKorisnici";
            this.dgvKorisnici.ReadOnly = true;
            this.dgvKorisnici.RowHeadersWidth = 40;
            this.dgvKorisnici.RowTemplate.Height = 24;
            this.dgvKorisnici.Size = new System.Drawing.Size(776, 305);
            this.dgvKorisnici.TabIndex = 3;
            this.dgvKorisnici.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKorisnici_CellContentClick);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "KorisnikID";
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // Ime
            // 
            this.Ime.DataPropertyName = "Ime";
            this.Ime.HeaderText = "Ime";
            this.Ime.MinimumWidth = 6;
            this.Ime.Name = "Ime";
            this.Ime.ReadOnly = true;
            // 
            // Prezime
            // 
            this.Prezime.DataPropertyName = "Prezime";
            this.Prezime.HeaderText = "Prezime";
            this.Prezime.MinimumWidth = 6;
            this.Prezime.Name = "Prezime";
            this.Prezime.ReadOnly = true;
            // 
            // KorisnickoIme
            // 
            this.KorisnickoIme.DataPropertyName = "KorisnickoIme";
            this.KorisnickoIme.HeaderText = "Korisničko ime";
            this.KorisnickoIme.MinimumWidth = 6;
            this.KorisnickoIme.Name = "KorisnickoIme";
            this.KorisnickoIme.ReadOnly = true;
            // 
            // Email
            // 
            this.Email.DataPropertyName = "Email";
            this.Email.HeaderText = "Email";
            this.Email.MinimumWidth = 6;
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(41, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(246, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Pretraga po imenu ili prezimenu";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(565, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Pretraga po ulozi";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // cmbUloge
            // 
            this.cmbUloge.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cmbUloge.FormattingEnabled = true;
            this.cmbUloge.Location = new System.Drawing.Point(560, 63);
            this.cmbUloge.Name = "cmbUloge";
            this.cmbUloge.Size = new System.Drawing.Size(261, 28);
            this.cmbUloge.TabIndex = 8;
            this.cmbUloge.SelectedIndexChanged += new System.EventHandler(this.cmbUloge_SelectedIndexChanged);
            // 
            // btnUredi
            // 
            this.btnUredi.Image = global::eRestoran.WinUI.Properties.Resources.edit;
            this.btnUredi.Location = new System.Drawing.Point(739, 479);
            this.btnUredi.Name = "btnUredi";
            this.btnUredi.Size = new System.Drawing.Size(38, 35);
            this.btnUredi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnUredi.TabIndex = 11;
            this.btnUredi.TabStop = false;
            this.btnUredi.Click += new System.EventHandler(this.btnUredi_Click);
            // 
            // btnDeleteUser
            // 
            this.btnDeleteUser.Image = global::eRestoran.WinUI.Properties.Resources.delete;
            this.btnDeleteUser.Location = new System.Drawing.Point(783, 479);
            this.btnDeleteUser.Name = "btnDeleteUser";
            this.btnDeleteUser.Size = new System.Drawing.Size(38, 35);
            this.btnDeleteUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnDeleteUser.TabIndex = 10;
            this.btnDeleteUser.TabStop = false;
            this.btnDeleteUser.Click += new System.EventHandler(this.btnDeleteUser_Click);
            // 
            // btnAddUser
            // 
            this.btnAddUser.Image = global::eRestoran.WinUI.Properties.Resources.add;
            this.btnAddUser.Location = new System.Drawing.Point(698, 479);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(35, 35);
            this.btnAddUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnAddUser.TabIndex = 9;
            this.btnAddUser.TabStop = false;
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // ucKorisniciPrikaz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnUredi);
            this.Controls.Add(this.btnDeleteUser);
            this.Controls.Add(this.btnAddUser);
            this.Controls.Add(this.cmbUloge);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPretraga);
            this.Controls.Add(this.btnPrikazi);
            this.Controls.Add(this.dgvKorisnici);
            this.Name = "ucKorisniciPrikaz";
            this.Size = new System.Drawing.Size(861, 549);
            this.Load += new System.EventHandler(this.ucKorisniciPrikaz_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKorisnici)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnUredi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDeleteUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAddUser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPretraga;
        private System.Windows.Forms.Button btnPrikazi;
        private System.Windows.Forms.DataGridView dgvKorisnici;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbUloge;
        private System.Windows.Forms.PictureBox btnAddUser;
        private System.Windows.Forms.PictureBox btnDeleteUser;
        private System.Windows.Forms.PictureBox btnUredi;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prezime;
        private System.Windows.Forms.DataGridViewTextBoxColumn KorisnickoIme;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
    }
}
