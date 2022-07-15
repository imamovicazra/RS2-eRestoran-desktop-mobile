namespace eRestoran.WinUI.UserControls.Narudzbe
{
    partial class ucNarudzbePrikaz
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtPretraga = new System.Windows.Forms.TextBox();
            this.btnPrikazi = new System.Windows.Forms.Button();
            this.dgvNarudzbe = new System.Windows.Forms.DataGridView();
            this.NarudzbaID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Korisnik = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Adresa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DatumNarudzbe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnIzvjestaj = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNarudzbe)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(44, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(246, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "Pretraga po imenu ili prezimenu";
            // 
            // txtPretraga
            // 
            this.txtPretraga.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtPretraga.Location = new System.Drawing.Point(48, 76);
            this.txtPretraga.Name = "txtPretraga";
            this.txtPretraga.Size = new System.Drawing.Size(598, 27);
            this.txtPretraga.TabIndex = 11;
            // 
            // btnPrikazi
            // 
            this.btnPrikazi.BackColor = System.Drawing.Color.Turquoise;
            this.btnPrikazi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnPrikazi.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnPrikazi.Location = new System.Drawing.Point(673, 73);
            this.btnPrikazi.Name = "btnPrikazi";
            this.btnPrikazi.Size = new System.Drawing.Size(151, 32);
            this.btnPrikazi.TabIndex = 10;
            this.btnPrikazi.Text = "Prikaži";
            this.btnPrikazi.UseVisualStyleBackColor = false;
            this.btnPrikazi.Click += new System.EventHandler(this.btnPrikazi_Click);
            // 
            // dgvNarudzbe
            // 
            this.dgvNarudzbe.AllowUserToAddRows = false;
            this.dgvNarudzbe.AllowUserToDeleteRows = false;
            this.dgvNarudzbe.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNarudzbe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNarudzbe.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NarudzbaID,
            this.Korisnik,
            this.Adresa,
            this.Telefon,
            this.DatumNarudzbe,
            this.Status});
            this.dgvNarudzbe.Location = new System.Drawing.Point(48, 131);
            this.dgvNarudzbe.Name = "dgvNarudzbe";
            this.dgvNarudzbe.ReadOnly = true;
            this.dgvNarudzbe.RowHeadersWidth = 40;
            this.dgvNarudzbe.RowTemplate.Height = 24;
            this.dgvNarudzbe.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvNarudzbe.Size = new System.Drawing.Size(776, 306);
            this.dgvNarudzbe.TabIndex = 9;
            this.dgvNarudzbe.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNarudzbe_CellDoubleClick);
            // 
            // NarudzbaID
            // 
            this.NarudzbaID.DataPropertyName = "NarudzbaID";
            this.NarudzbaID.HeaderText = "NarudzbaID";
            this.NarudzbaID.MinimumWidth = 6;
            this.NarudzbaID.Name = "NarudzbaID";
            this.NarudzbaID.ReadOnly = true;
            this.NarudzbaID.Visible = false;
            // 
            // Korisnik
            // 
            this.Korisnik.DataPropertyName = "ImePrezime";
            this.Korisnik.HeaderText = "Korisnik";
            this.Korisnik.MinimumWidth = 6;
            this.Korisnik.Name = "Korisnik";
            this.Korisnik.ReadOnly = true;
            // 
            // Adresa
            // 
            this.Adresa.DataPropertyName = "Adresa";
            this.Adresa.HeaderText = "Adresa";
            this.Adresa.MinimumWidth = 6;
            this.Adresa.Name = "Adresa";
            this.Adresa.ReadOnly = true;
            // 
            // Telefon
            // 
            this.Telefon.DataPropertyName = "Telefon";
            this.Telefon.HeaderText = "Telefon";
            this.Telefon.MinimumWidth = 6;
            this.Telefon.Name = "Telefon";
            this.Telefon.ReadOnly = true;
            // 
            // DatumNarudzbe
            // 
            this.DatumNarudzbe.DataPropertyName = "DatumNarudzbe";
            this.DatumNarudzbe.HeaderText = "Datum narudžbe";
            this.DatumNarudzbe.MinimumWidth = 6;
            this.DatumNarudzbe.Name = "DatumNarudzbe";
            this.DatumNarudzbe.ReadOnly = true;
            // 
            // Status
            // 
            this.Status.DataPropertyName = "StatusNaziv";
            this.Status.HeaderText = "Status";
            this.Status.MinimumWidth = 6;
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            // 
            // btnIzvjestaj
            // 
            this.btnIzvjestaj.BackColor = System.Drawing.Color.Turquoise;
            this.btnIzvjestaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnIzvjestaj.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnIzvjestaj.Location = new System.Drawing.Point(582, 457);
            this.btnIzvjestaj.Name = "btnIzvjestaj";
            this.btnIzvjestaj.Size = new System.Drawing.Size(242, 32);
            this.btnIzvjestaj.TabIndex = 13;
            this.btnIzvjestaj.Text = "Generiši izvještaj";
            this.btnIzvjestaj.UseVisualStyleBackColor = false;
            this.btnIzvjestaj.Click += new System.EventHandler(this.btnIzvjestaj_Click);
            // 
            // ucNarudzbePrikaz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnIzvjestaj);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPretraga);
            this.Controls.Add(this.btnPrikazi);
            this.Controls.Add(this.dgvNarudzbe);
            this.Name = "ucNarudzbePrikaz";
            this.Size = new System.Drawing.Size(912, 513);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNarudzbe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPretraga;
        private System.Windows.Forms.Button btnPrikazi;
        private System.Windows.Forms.DataGridView dgvNarudzbe;
        private System.Windows.Forms.DataGridViewTextBoxColumn NarudzbaID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Korisnik;
        private System.Windows.Forms.DataGridViewTextBoxColumn Adresa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefon;
        private System.Windows.Forms.DataGridViewTextBoxColumn DatumNarudzbe;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.Button btnIzvjestaj;
    }
}
