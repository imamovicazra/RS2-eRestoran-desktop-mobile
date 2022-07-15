namespace eRestoran.WinUI.UserControls.Jela
{
    partial class ucJelaUredi
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
            this.btnSacuvaj = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtSlikaValidate = new System.Windows.Forms.TextBox();
            this.cmbKategorije = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDodajSliku = new System.Windows.Forms.Button();
            this.txtOpis = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCijena = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblNaziv = new System.Windows.Forms.Label();
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.epSlika = new System.Windows.Forms.ErrorProvider(this.components);
            this.pbJelo = new System.Windows.Forms.PictureBox();
            this.epNaziv = new System.Windows.Forms.ErrorProvider(this.components);
            this.epCijena = new System.Windows.Forms.ErrorProvider(this.components);
            this.epOpis = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epSlika)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbJelo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epNaziv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epCijena)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epOpis)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSacuvaj
            // 
            this.btnSacuvaj.BackColor = System.Drawing.Color.Turquoise;
            this.btnSacuvaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSacuvaj.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSacuvaj.Location = new System.Drawing.Point(711, 509);
            this.btnSacuvaj.Name = "btnSacuvaj";
            this.btnSacuvaj.Size = new System.Drawing.Size(123, 42);
            this.btnSacuvaj.TabIndex = 8;
            this.btnSacuvaj.Text = "Sačuvaj";
            this.btnSacuvaj.UseVisualStyleBackColor = false;
            this.btnSacuvaj.Click += new System.EventHandler(this.btnSacuvaj_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtSlikaValidate);
            this.groupBox1.Controls.Add(this.cmbKategorije);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnDodajSliku);
            this.groupBox1.Controls.Add(this.txtOpis);
            this.groupBox1.Controls.Add(this.pbJelo);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtCijena);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lblNaziv);
            this.groupBox1.Controls.Add(this.txtNaziv);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox1.Location = new System.Drawing.Point(39, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(819, 460);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informacije o jelu";
            // 
            // txtSlikaValidate
            // 
            this.txtSlikaValidate.BackColor = System.Drawing.SystemColors.Control;
            this.txtSlikaValidate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSlikaValidate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSlikaValidate.Location = new System.Drawing.Point(372, 380);
            this.txtSlikaValidate.Margin = new System.Windows.Forms.Padding(4);
            this.txtSlikaValidate.Name = "txtSlikaValidate";
            this.txtSlikaValidate.Size = new System.Drawing.Size(10, 19);
            this.txtSlikaValidate.TabIndex = 56;
            this.txtSlikaValidate.Validating += new System.ComponentModel.CancelEventHandler(this.Slika_Validating);
            // 
            // cmbKategorije
            // 
            this.cmbKategorije.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cmbKategorije.FormattingEnabled = true;
            this.cmbKategorije.Location = new System.Drawing.Point(428, 380);
            this.cmbKategorije.Name = "cmbKategorije";
            this.cmbKategorije.Size = new System.Drawing.Size(324, 33);
            this.cmbKategorije.TabIndex = 55;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(423, 340);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 25);
            this.label1.TabIndex = 54;
            this.label1.Text = "Kategorija\r\n";
            // 
            // btnDodajSliku
            // 
            this.btnDodajSliku.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDodajSliku.Location = new System.Drawing.Point(72, 379);
            this.btnDodajSliku.Name = "btnDodajSliku";
            this.btnDodajSliku.Size = new System.Drawing.Size(293, 36);
            this.btnDodajSliku.TabIndex = 53;
            this.btnDodajSliku.Text = "Učitaj sliku";
            this.btnDodajSliku.UseVisualStyleBackColor = true;
            this.btnDodajSliku.Click += new System.EventHandler(this.btnDodajSliku_Click);
            // 
            // txtOpis
            // 
            this.txtOpis.Location = new System.Drawing.Point(427, 216);
            this.txtOpis.Name = "txtOpis";
            this.txtOpis.Size = new System.Drawing.Size(325, 106);
            this.txtOpis.TabIndex = 52;
            this.txtOpis.Text = "";
            this.txtOpis.Validating += new System.ComponentModel.CancelEventHandler(this.Opis_Validating);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(422, 120);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 25);
            this.label3.TabIndex = 46;
            this.label3.Text = "Cijena";
            // 
            // txtCijena
            // 
            this.txtCijena.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCijena.Location = new System.Drawing.Point(427, 153);
            this.txtCijena.Margin = new System.Windows.Forms.Padding(4);
            this.txtCijena.Name = "txtCijena";
            this.txtCijena.Size = new System.Drawing.Size(325, 26);
            this.txtCijena.TabIndex = 45;
            this.txtCijena.Validating += new System.ComponentModel.CancelEventHandler(this.Cijena_Validating);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(422, 188);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 25);
            this.label2.TabIndex = 44;
            this.label2.Text = "Opis";
            // 
            // lblNaziv
            // 
            this.lblNaziv.AutoSize = true;
            this.lblNaziv.Location = new System.Drawing.Point(422, 47);
            this.lblNaziv.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNaziv.Name = "lblNaziv";
            this.lblNaziv.Size = new System.Drawing.Size(61, 25);
            this.lblNaziv.TabIndex = 38;
            this.lblNaziv.Text = "Naziv";
            // 
            // txtNaziv
            // 
            this.txtNaziv.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNaziv.Location = new System.Drawing.Point(427, 80);
            this.txtNaziv.Margin = new System.Windows.Forms.Padding(4);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(325, 26);
            this.txtNaziv.TabIndex = 37;
            this.txtNaziv.Validating += new System.ComponentModel.CancelEventHandler(this.Naziv_Validating);
            // 
            // epSlika
            // 
            this.epSlika.ContainerControl = this;
            // 
            // pbJelo
            // 
            this.pbJelo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbJelo.Location = new System.Drawing.Point(72, 56);
            this.pbJelo.Name = "pbJelo";
            this.pbJelo.Size = new System.Drawing.Size(293, 292);
            this.pbJelo.TabIndex = 51;
            this.pbJelo.TabStop = false;
            // 
            // epNaziv
            // 
            this.epNaziv.ContainerControl = this;
            // 
            // epCijena
            // 
            this.epCijena.ContainerControl = this;
            // 
            // epOpis
            // 
            this.epOpis.ContainerControl = this;
            // 
            // ucJelaUredi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnSacuvaj);
            this.Controls.Add(this.groupBox1);
            this.Name = "ucJelaUredi";
            this.Size = new System.Drawing.Size(916, 581);
            this.Load += new System.EventHandler(this.ucJelaUredi_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epSlika)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbJelo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epNaziv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epCijena)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epOpis)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSacuvaj;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtSlikaValidate;
        private System.Windows.Forms.ComboBox cmbKategorije;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDodajSliku;
        private System.Windows.Forms.RichTextBox txtOpis;
        private System.Windows.Forms.PictureBox pbJelo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCijena;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblNaziv;
        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.ErrorProvider epSlika;
        private System.Windows.Forms.ErrorProvider epNaziv;
        private System.Windows.Forms.ErrorProvider epCijena;
        private System.Windows.Forms.ErrorProvider epOpis;
    }
}
