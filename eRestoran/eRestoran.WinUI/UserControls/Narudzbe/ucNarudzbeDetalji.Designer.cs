namespace eRestoran.WinUI.UserControls.Narudzbe
{
    partial class ucNarudzbeDetalji
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
            this.txtKorisnik = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDatum = new System.Windows.Forms.TextBox();
            this.txtAdresa = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTelefon = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvNarudzbaDetalji = new System.Windows.Forms.DataGridView();
            this.Jelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kolicina = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cijena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnOdobri = new System.Windows.Forms.Button();
            this.btnOdbij = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNarudzbaDetalji)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(59, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Korisnik";
            // 
            // txtKorisnik
            // 
            this.txtKorisnik.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtKorisnik.Location = new System.Drawing.Point(64, 50);
            this.txtKorisnik.Name = "txtKorisnik";
            this.txtKorisnik.ReadOnly = true;
            this.txtKorisnik.Size = new System.Drawing.Size(319, 27);
            this.txtKorisnik.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(456, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Datum narudžbe";
            // 
            // txtDatum
            // 
            this.txtDatum.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtDatum.Location = new System.Drawing.Point(461, 50);
            this.txtDatum.Name = "txtDatum";
            this.txtDatum.ReadOnly = true;
            this.txtDatum.Size = new System.Drawing.Size(338, 27);
            this.txtDatum.TabIndex = 4;
            // 
            // txtAdresa
            // 
            this.txtAdresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtAdresa.Location = new System.Drawing.Point(63, 110);
            this.txtAdresa.Name = "txtAdresa";
            this.txtAdresa.ReadOnly = true;
            this.txtAdresa.Size = new System.Drawing.Size(319, 27);
            this.txtAdresa.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(59, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Adresa";
            // 
            // txtTelefon
            // 
            this.txtTelefon.AcceptsReturn = true;
            this.txtTelefon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtTelefon.Location = new System.Drawing.Point(460, 110);
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.ReadOnly = true;
            this.txtTelefon.Size = new System.Drawing.Size(338, 27);
            this.txtTelefon.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(456, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Telefon";
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
            this.dgvNarudzbaDetalji.Location = new System.Drawing.Point(64, 180);
            this.dgvNarudzbaDetalji.Name = "dgvNarudzbaDetalji";
            this.dgvNarudzbaDetalji.ReadOnly = true;
            this.dgvNarudzbaDetalji.RowHeadersWidth = 40;
            this.dgvNarudzbaDetalji.RowTemplate.Height = 24;
            this.dgvNarudzbaDetalji.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvNarudzbaDetalji.Size = new System.Drawing.Size(735, 280);
            this.dgvNarudzbaDetalji.TabIndex = 11;
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
            // btnOdobri
            // 
            this.btnOdobri.BackColor = System.Drawing.Color.LimeGreen;
            this.btnOdobri.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnOdobri.Location = new System.Drawing.Point(61, 482);
            this.btnOdobri.Name = "btnOdobri";
            this.btnOdobri.Size = new System.Drawing.Size(125, 37);
            this.btnOdobri.TabIndex = 12;
            this.btnOdobri.Text = "Odobri";
            this.btnOdobri.UseVisualStyleBackColor = false;
            this.btnOdobri.Click += new System.EventHandler(this.btnOdobri_Click);
            // 
            // btnOdbij
            // 
            this.btnOdbij.BackColor = System.Drawing.Color.Red;
            this.btnOdbij.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnOdbij.Location = new System.Drawing.Point(204, 482);
            this.btnOdbij.Name = "btnOdbij";
            this.btnOdbij.Size = new System.Drawing.Size(125, 37);
            this.btnOdbij.TabIndex = 13;
            this.btnOdbij.Text = "Odbij";
            this.btnOdbij.UseVisualStyleBackColor = false;
            this.btnOdbij.Click += new System.EventHandler(this.btnOdbij_ClickAsync);
            // 
            // ucNarudzbeDetalji
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnOdbij);
            this.Controls.Add(this.btnOdobri);
            this.Controls.Add(this.dgvNarudzbaDetalji);
            this.Controls.Add(this.txtTelefon);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtAdresa);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDatum);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtKorisnik);
            this.Controls.Add(this.label1);
            this.Name = "ucNarudzbeDetalji";
            this.Size = new System.Drawing.Size(866, 567);
            this.Load += new System.EventHandler(this.ucNarudzbeDetalji_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNarudzbaDetalji)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtKorisnik;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDatum;
        private System.Windows.Forms.TextBox txtAdresa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTelefon;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvNarudzbaDetalji;
        private System.Windows.Forms.DataGridViewTextBoxColumn Jelo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kolicina;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cijena;
        private System.Windows.Forms.Button btnOdobri;
        private System.Windows.Forms.Button btnOdbij;
    }
}
