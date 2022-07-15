namespace eRestoran.WinUI.UserControls.Rezervacije
{
    partial class ucRezervacijePrikaz
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
            this.dgvRezervacije = new System.Windows.Forms.DataGridView();
            this.RezervacijaID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Korisnik = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BrojMjesta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DatumRezervacije = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRezervacije)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(39, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(246, 20);
            this.label1.TabIndex = 16;
            this.label1.Text = "Pretraga po imenu ili prezimenu";
            // 
            // txtPretraga
            // 
            this.txtPretraga.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtPretraga.Location = new System.Drawing.Point(43, 59);
            this.txtPretraga.Name = "txtPretraga";
            this.txtPretraga.Size = new System.Drawing.Size(598, 27);
            this.txtPretraga.TabIndex = 15;
            // 
            // btnPrikazi
            // 
            this.btnPrikazi.BackColor = System.Drawing.Color.Turquoise;
            this.btnPrikazi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnPrikazi.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnPrikazi.Location = new System.Drawing.Point(668, 56);
            this.btnPrikazi.Name = "btnPrikazi";
            this.btnPrikazi.Size = new System.Drawing.Size(151, 32);
            this.btnPrikazi.TabIndex = 14;
            this.btnPrikazi.Text = "Prikaži";
            this.btnPrikazi.UseVisualStyleBackColor = false;
            this.btnPrikazi.Click += new System.EventHandler(this.btnPrikazi_Click);
            // 
            // dgvRezervacije
            // 
            this.dgvRezervacije.AllowUserToAddRows = false;
            this.dgvRezervacije.AllowUserToDeleteRows = false;
            this.dgvRezervacije.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRezervacije.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRezervacije.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RezervacijaID,
            this.Korisnik,
            this.Telefon,
            this.BrojMjesta,
            this.DatumRezervacije,
            this.Status});
            this.dgvRezervacije.Location = new System.Drawing.Point(43, 114);
            this.dgvRezervacije.Name = "dgvRezervacije";
            this.dgvRezervacije.ReadOnly = true;
            this.dgvRezervacije.RowHeadersWidth = 40;
            this.dgvRezervacije.RowTemplate.Height = 24;
            this.dgvRezervacije.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRezervacije.Size = new System.Drawing.Size(776, 306);
            this.dgvRezervacije.TabIndex = 13;
            this.dgvRezervacije.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRezervacije_CellDoubleClick);
            // 
            // RezervacijaID
            // 
            this.RezervacijaID.DataPropertyName = "RezervacijaID";
            this.RezervacijaID.HeaderText = "RezervacijaID";
            this.RezervacijaID.MinimumWidth = 6;
            this.RezervacijaID.Name = "RezervacijaID";
            this.RezervacijaID.ReadOnly = true;
            this.RezervacijaID.Visible = false;
            // 
            // Korisnik
            // 
            this.Korisnik.DataPropertyName = "ImePrezime";
            this.Korisnik.HeaderText = "Korisnik";
            this.Korisnik.MinimumWidth = 6;
            this.Korisnik.Name = "Korisnik";
            this.Korisnik.ReadOnly = true;
            // 
            // Telefon
            // 
            this.Telefon.DataPropertyName = "Telefon";
            this.Telefon.HeaderText = "Telefon";
            this.Telefon.MinimumWidth = 6;
            this.Telefon.Name = "Telefon";
            this.Telefon.ReadOnly = true;
            // 
            // BrojMjesta
            // 
            this.BrojMjesta.DataPropertyName = "BrojMjesta";
            this.BrojMjesta.HeaderText = "Broj mjesta";
            this.BrojMjesta.MinimumWidth = 6;
            this.BrojMjesta.Name = "BrojMjesta";
            this.BrojMjesta.ReadOnly = true;
            // 
            // DatumRezervacije
            // 
            this.DatumRezervacije.DataPropertyName = "DatumRezervacije";
            this.DatumRezervacije.HeaderText = "Datum rezervacije";
            this.DatumRezervacije.MinimumWidth = 6;
            this.DatumRezervacije.Name = "DatumRezervacije";
            this.DatumRezervacije.ReadOnly = true;
            // 
            // Status
            // 
            this.Status.DataPropertyName = "StatusNaziv";
            this.Status.HeaderText = "Status";
            this.Status.MinimumWidth = 6;
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            // 
            // ucRezervacijePrikaz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPretraga);
            this.Controls.Add(this.btnPrikazi);
            this.Controls.Add(this.dgvRezervacije);
            this.Name = "ucRezervacijePrikaz";
            this.Size = new System.Drawing.Size(880, 491);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRezervacije)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPretraga;
        private System.Windows.Forms.Button btnPrikazi;
        private System.Windows.Forms.DataGridView dgvRezervacije;
        private System.Windows.Forms.DataGridViewTextBoxColumn RezervacijaID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Korisnik;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefon;
        private System.Windows.Forms.DataGridViewTextBoxColumn BrojMjesta;
        private System.Windows.Forms.DataGridViewTextBoxColumn DatumRezervacije;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
    }
}
