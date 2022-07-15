namespace eRestoran.WinUI.UserControls.Jela
{
    partial class ucJelaPrikaz
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
            this.btnUredi = new System.Windows.Forms.PictureBox();
            this.btnDeleteUser = new System.Windows.Forms.PictureBox();
            this.btnAddUser = new System.Windows.Forms.PictureBox();
            this.cmbKategorije = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPretraga = new System.Windows.Forms.TextBox();
            this.btnPrikazi = new System.Windows.Forms.Button();
            this.dgvJela = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Naziv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Opis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cijena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.btnUredi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDeleteUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAddUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvJela)).BeginInit();
            this.SuspendLayout();
            // 
            // btnUredi
            // 
            this.btnUredi.Image = global::eRestoran.WinUI.Properties.Resources.edit;
            this.btnUredi.Location = new System.Drawing.Point(745, 472);
            this.btnUredi.Name = "btnUredi";
            this.btnUredi.Size = new System.Drawing.Size(38, 35);
            this.btnUredi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnUredi.TabIndex = 20;
            this.btnUredi.TabStop = false;
            this.btnUredi.Click += new System.EventHandler(this.btnUredi_Click);
            // 
            // btnDeleteUser
            // 
            this.btnDeleteUser.Image = global::eRestoran.WinUI.Properties.Resources.delete;
            this.btnDeleteUser.Location = new System.Drawing.Point(789, 472);
            this.btnDeleteUser.Name = "btnDeleteUser";
            this.btnDeleteUser.Size = new System.Drawing.Size(38, 35);
            this.btnDeleteUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnDeleteUser.TabIndex = 19;
            this.btnDeleteUser.TabStop = false;
            this.btnDeleteUser.Click += new System.EventHandler(this.btnDeleteUser_Click);
            // 
            // btnAddUser
            // 
            this.btnAddUser.Image = global::eRestoran.WinUI.Properties.Resources.add;
            this.btnAddUser.Location = new System.Drawing.Point(704, 472);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(35, 35);
            this.btnAddUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnAddUser.TabIndex = 18;
            this.btnAddUser.TabStop = false;
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // cmbKategorije
            // 
            this.cmbKategorije.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cmbKategorije.FormattingEnabled = true;
            this.cmbKategorije.Location = new System.Drawing.Point(566, 56);
            this.cmbKategorije.Name = "cmbKategorije";
            this.cmbKategorije.Size = new System.Drawing.Size(261, 28);
            this.cmbKategorije.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(571, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 20);
            this.label2.TabIndex = 16;
            this.label2.Text = "Pretraga po kategoriji";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(47, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 20);
            this.label1.TabIndex = 15;
            this.label1.Text = "Pretraga po nazivu";
            // 
            // txtPretraga
            // 
            this.txtPretraga.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtPretraga.Location = new System.Drawing.Point(51, 56);
            this.txtPretraga.Name = "txtPretraga";
            this.txtPretraga.Size = new System.Drawing.Size(493, 27);
            this.txtPretraga.TabIndex = 14;
            // 
            // btnPrikazi
            // 
            this.btnPrikazi.BackColor = System.Drawing.Color.Turquoise;
            this.btnPrikazi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnPrikazi.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnPrikazi.Location = new System.Drawing.Point(725, 99);
            this.btnPrikazi.Name = "btnPrikazi";
            this.btnPrikazi.Size = new System.Drawing.Size(102, 32);
            this.btnPrikazi.TabIndex = 13;
            this.btnPrikazi.Text = "Prikaži";
            this.btnPrikazi.UseVisualStyleBackColor = false;
            this.btnPrikazi.Click += new System.EventHandler(this.btnPrikazi_Click);
            // 
            // dgvJela
            // 
            this.dgvJela.AllowUserToAddRows = false;
            this.dgvJela.AllowUserToDeleteRows = false;
            this.dgvJela.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvJela.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvJela.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Naziv,
            this.Opis,
            this.Cijena});
            this.dgvJela.Location = new System.Drawing.Point(51, 151);
            this.dgvJela.Name = "dgvJela";
            this.dgvJela.ReadOnly = true;
            this.dgvJela.RowHeadersWidth = 40;
            this.dgvJela.RowTemplate.Height = 24;
            this.dgvJela.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvJela.Size = new System.Drawing.Size(776, 305);
            this.dgvJela.TabIndex = 12;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "JeloID";
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            // 
            // Naziv
            // 
            this.Naziv.DataPropertyName = "Naziv";
            this.Naziv.HeaderText = "Naziv";
            this.Naziv.MinimumWidth = 6;
            this.Naziv.Name = "Naziv";
            this.Naziv.ReadOnly = true;
            // 
            // Opis
            // 
            this.Opis.DataPropertyName = "Opis";
            this.Opis.HeaderText = "Opis";
            this.Opis.MinimumWidth = 6;
            this.Opis.Name = "Opis";
            this.Opis.ReadOnly = true;
            // 
            // Cijena
            // 
            this.Cijena.DataPropertyName = "Cijena";
            this.Cijena.HeaderText = "Cijena (KM)";
            this.Cijena.MinimumWidth = 6;
            this.Cijena.Name = "Cijena";
            this.Cijena.ReadOnly = true;
            // 
            // ucJelaPrikaz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnUredi);
            this.Controls.Add(this.btnDeleteUser);
            this.Controls.Add(this.btnAddUser);
            this.Controls.Add(this.cmbKategorije);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPretraga);
            this.Controls.Add(this.btnPrikazi);
            this.Controls.Add(this.dgvJela);
            this.Name = "ucJelaPrikaz";
            this.Size = new System.Drawing.Size(898, 563);
            this.Load += new System.EventHandler(this.ucJelaPrikaz_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnUredi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDeleteUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAddUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvJela)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox btnUredi;
        private System.Windows.Forms.PictureBox btnDeleteUser;
        private System.Windows.Forms.PictureBox btnAddUser;
        private System.Windows.Forms.ComboBox cmbKategorije;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPretraga;
        private System.Windows.Forms.Button btnPrikazi;
        private System.Windows.Forms.DataGridView dgvJela;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Naziv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Opis;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cijena;
    }
}
