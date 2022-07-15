namespace eRestoran.WinUI.UserControls.Rezervacije
{
    partial class ucRezervacijeDetalji
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
            this.btnOdbij = new System.Windows.Forms.Button();
            this.btnOdobri = new System.Windows.Forms.Button();
            this.txtTelefon = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBrojOsoba = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDatum = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtKorisnik = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnOdbij
            // 
            this.btnOdbij.BackColor = System.Drawing.Color.Red;
            this.btnOdbij.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnOdbij.Location = new System.Drawing.Point(416, 449);
            this.btnOdbij.Name = "btnOdbij";
            this.btnOdbij.Size = new System.Drawing.Size(125, 37);
            this.btnOdbij.TabIndex = 24;
            this.btnOdbij.Text = "Odbij";
            this.btnOdbij.UseVisualStyleBackColor = false;
            this.btnOdbij.Click += new System.EventHandler(this.btnOdbij_Click);
            // 
            // btnOdobri
            // 
            this.btnOdobri.BackColor = System.Drawing.Color.LimeGreen;
            this.btnOdobri.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnOdobri.Location = new System.Drawing.Point(262, 449);
            this.btnOdobri.Name = "btnOdobri";
            this.btnOdobri.Size = new System.Drawing.Size(125, 37);
            this.btnOdobri.TabIndex = 23;
            this.btnOdobri.Text = "Odobri";
            this.btnOdobri.UseVisualStyleBackColor = false;
            this.btnOdobri.Click += new System.EventHandler(this.btnOdobri_Click);
            // 
            // txtTelefon
            // 
            this.txtTelefon.AcceptsReturn = true;
            this.txtTelefon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtTelefon.Location = new System.Drawing.Point(235, 353);
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.ReadOnly = true;
            this.txtTelefon.Size = new System.Drawing.Size(338, 30);
            this.txtTelefon.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(230, 313);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 25);
            this.label4.TabIndex = 20;
            this.label4.Text = "Telefon";
            // 
            // txtBrojOsoba
            // 
            this.txtBrojOsoba.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtBrojOsoba.Location = new System.Drawing.Point(235, 183);
            this.txtBrojOsoba.Name = "txtBrojOsoba";
            this.txtBrojOsoba.ReadOnly = true;
            this.txtBrojOsoba.Size = new System.Drawing.Size(338, 30);
            this.txtBrojOsoba.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(233, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 25);
            this.label3.TabIndex = 18;
            this.label3.Text = "Broj osoba";
            // 
            // txtDatum
            // 
            this.txtDatum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtDatum.Location = new System.Drawing.Point(235, 268);
            this.txtDatum.Name = "txtDatum";
            this.txtDatum.ReadOnly = true;
            this.txtDatum.Size = new System.Drawing.Size(338, 30);
            this.txtDatum.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(233, 228);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(244, 25);
            this.label2.TabIndex = 16;
            this.label2.Text = "Datum i vrijeme rezervacije";
            // 
            // txtKorisnik
            // 
            this.txtKorisnik.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtKorisnik.Location = new System.Drawing.Point(235, 98);
            this.txtKorisnik.Name = "txtKorisnik";
            this.txtKorisnik.ReadOnly = true;
            this.txtKorisnik.Size = new System.Drawing.Size(338, 30);
            this.txtKorisnik.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(230, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 25);
            this.label1.TabIndex = 14;
            this.label1.Text = "Korisnik";
            // 
            // ucRezervacijeDetalji
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnOdbij);
            this.Controls.Add(this.btnOdobri);
            this.Controls.Add(this.txtTelefon);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtBrojOsoba);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDatum);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtKorisnik);
            this.Controls.Add(this.label1);
            this.Name = "ucRezervacijeDetalji";
            this.Size = new System.Drawing.Size(722, 537);
            this.Load += new System.EventHandler(this.ucRezervacijeDetalji_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOdbij;
        private System.Windows.Forms.Button btnOdobri;
        private System.Windows.Forms.TextBox txtTelefon;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBrojOsoba;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDatum;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtKorisnik;
        private System.Windows.Forms.Label label1;
    }
}
