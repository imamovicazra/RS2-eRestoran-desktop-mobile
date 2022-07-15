namespace eRestoran.WinUI.UserControls.Narudzbe
{
    partial class ucNarudzbeDetaljiPregled
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
            this.dgvNarudzbaDetalji = new System.Windows.Forms.DataGridView();
            this.txtUposlenik = new System.Windows.Forms.TextBox();
            this.Uposlenik = new System.Windows.Forms.Label();
            this.txtTelefon = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAdresa = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDatum = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtKorisnik = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Jelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kolicina = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cijena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNarudzbaDetalji)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBack)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvNarudzbaDetalji
            // 
            this.dgvNarudzbaDetalji.AllowUserToAddRows = false;
            this.dgvNarudzbaDetalji.AllowUserToDeleteRows = false;
            this.dgvNarudzbaDetalji.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNarudzbaDetalji.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNarudzbaDetalji.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Jelo,
            this.Kolicina,
            this.Cijena});
            this.dgvNarudzbaDetalji.Location = new System.Drawing.Point(66, 230);
            this.dgvNarudzbaDetalji.Name = "dgvNarudzbaDetalji";
            this.dgvNarudzbaDetalji.ReadOnly = true;
            this.dgvNarudzbaDetalji.RowHeadersWidth = 40;
            this.dgvNarudzbaDetalji.RowTemplate.Height = 24;
            this.dgvNarudzbaDetalji.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvNarudzbaDetalji.Size = new System.Drawing.Size(727, 289);
            this.dgvNarudzbaDetalji.TabIndex = 24;
            // 
            // txtUposlenik
            // 
            this.txtUposlenik.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtUposlenik.Location = new System.Drawing.Point(66, 172);
            this.txtUposlenik.Name = "txtUposlenik";
            this.txtUposlenik.ReadOnly = true;
            this.txtUposlenik.Size = new System.Drawing.Size(319, 27);
            this.txtUposlenik.TabIndex = 23;
            // 
            // Uposlenik
            // 
            this.Uposlenik.AutoSize = true;
            this.Uposlenik.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Uposlenik.Location = new System.Drawing.Point(62, 149);
            this.Uposlenik.Name = "Uposlenik";
            this.Uposlenik.Size = new System.Drawing.Size(82, 20);
            this.Uposlenik.TabIndex = 22;
            this.Uposlenik.Text = "Uposlenik";
            // 
            // txtTelefon
            // 
            this.txtTelefon.AcceptsReturn = true;
            this.txtTelefon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtTelefon.Location = new System.Drawing.Point(463, 106);
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.ReadOnly = true;
            this.txtTelefon.Size = new System.Drawing.Size(329, 27);
            this.txtTelefon.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(459, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 20);
            this.label4.TabIndex = 20;
            this.label4.Text = "Telefon";
            // 
            // txtAdresa
            // 
            this.txtAdresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtAdresa.Location = new System.Drawing.Point(66, 106);
            this.txtAdresa.Name = "txtAdresa";
            this.txtAdresa.ReadOnly = true;
            this.txtAdresa.Size = new System.Drawing.Size(319, 27);
            this.txtAdresa.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(62, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 20);
            this.label3.TabIndex = 18;
            this.label3.Text = "Adresa";
            // 
            // txtDatum
            // 
            this.txtDatum.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtDatum.Location = new System.Drawing.Point(464, 46);
            this.txtDatum.Name = "txtDatum";
            this.txtDatum.ReadOnly = true;
            this.txtDatum.Size = new System.Drawing.Size(329, 27);
            this.txtDatum.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(459, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 20);
            this.label2.TabIndex = 16;
            this.label2.Text = "Datum narudžbe";
            // 
            // txtKorisnik
            // 
            this.txtKorisnik.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtKorisnik.Location = new System.Drawing.Point(67, 46);
            this.txtKorisnik.Name = "txtKorisnik";
            this.txtKorisnik.ReadOnly = true;
            this.txtKorisnik.Size = new System.Drawing.Size(319, 27);
            this.txtKorisnik.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(62, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "Korisnik";
            // 
            // Jelo
            // 
            this.Jelo.DataPropertyName = "NazivJela";
            this.Jelo.HeaderText = "Jelo";
            this.Jelo.MinimumWidth = 6;
            this.Jelo.Name = "Jelo";
            this.Jelo.ReadOnly = true;
            // 
            // Kolicina
            // 
            this.Kolicina.DataPropertyName = "Kolicina";
            this.Kolicina.HeaderText = "Kolicina";
            this.Kolicina.MinimumWidth = 6;
            this.Kolicina.Name = "Kolicina";
            this.Kolicina.ReadOnly = true;
            // 
            // Cijena
            // 
            this.Cijena.DataPropertyName = "Cijena";
            this.Cijena.HeaderText = "Cijena";
            this.Cijena.MinimumWidth = 6;
            this.Cijena.Name = "Cijena";
            this.Cijena.ReadOnly = true;
            // 
            // txtStatus
            // 
            this.txtStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtStatus.Location = new System.Drawing.Point(463, 172);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.ReadOnly = true;
            this.txtStatus.Size = new System.Drawing.Size(329, 27);
            this.txtStatus.TabIndex = 26;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(459, 149);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 20);
            this.label5.TabIndex = 25;
            this.label5.Text = "Status narudžbe";
            // 
            // btnBack
            // 
            this.btnBack.Image = global::eRestoran.WinUI.Properties.Resources.back;
            this.btnBack.Location = new System.Drawing.Point(748, 552);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(44, 31);
            this.btnBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnBack.TabIndex = 27;
            this.btnBack.TabStop = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // ucNarudzbeDetaljiPregled
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dgvNarudzbaDetalji);
            this.Controls.Add(this.txtUposlenik);
            this.Controls.Add(this.Uposlenik);
            this.Controls.Add(this.txtTelefon);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtAdresa);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDatum);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtKorisnik);
            this.Controls.Add(this.label1);
            this.Name = "ucNarudzbeDetaljiPregled";
            this.Size = new System.Drawing.Size(866, 606);
            this.Load += new System.EventHandler(this.ucNarudzbeDetaljiPregled_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNarudzbaDetalji)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBack)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvNarudzbaDetalji;
        private System.Windows.Forms.TextBox txtUposlenik;
        private System.Windows.Forms.Label Uposlenik;
        private System.Windows.Forms.TextBox txtTelefon;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAdresa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDatum;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtKorisnik;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Jelo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kolicina;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cijena;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox btnBack;
    }
}
