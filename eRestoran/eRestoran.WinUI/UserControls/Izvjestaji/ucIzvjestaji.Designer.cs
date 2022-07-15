
namespace eRestoran.WinUI.UserControls.Izvjestaji
{
    partial class ucIzvjestaji
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
            this.btnKupci = new System.Windows.Forms.Button();
            this.btnLikes = new System.Windows.Forms.Button();
            this.btnJela = new System.Windows.Forms.Button();
            this.dgvPrikaz = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrikaz)).BeginInit();
            this.SuspendLayout();
            // 
            // btnKupci
            // 
            this.btnKupci.BackColor = System.Drawing.Color.Turquoise;
            this.btnKupci.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnKupci.Location = new System.Drawing.Point(301, 19);
            this.btnKupci.Margin = new System.Windows.Forms.Padding(4);
            this.btnKupci.Name = "btnKupci";
            this.btnKupci.Size = new System.Drawing.Size(203, 63);
            this.btnKupci.TabIndex = 15;
            this.btnKupci.Text = "Najbolji kupci";
            this.btnKupci.UseVisualStyleBackColor = false;
            this.btnKupci.Click += new System.EventHandler(this.btnKupci_Click);
            // 
            // btnLikes
            // 
            this.btnLikes.BackColor = System.Drawing.Color.Turquoise;
            this.btnLikes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnLikes.Location = new System.Drawing.Point(546, 19);
            this.btnLikes.Margin = new System.Windows.Forms.Padding(4);
            this.btnLikes.Name = "btnLikes";
            this.btnLikes.Size = new System.Drawing.Size(251, 63);
            this.btnLikes.TabIndex = 13;
            this.btnLikes.Text = "Jela sa najviše oznaka \"Sviđa mi se\"";
            this.btnLikes.UseVisualStyleBackColor = false;
            this.btnLikes.Click += new System.EventHandler(this.btnLikes_Click);
            // 
            // btnJela
            // 
            this.btnJela.BackColor = System.Drawing.Color.Turquoise;
            this.btnJela.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnJela.Location = new System.Drawing.Point(61, 19);
            this.btnJela.Margin = new System.Windows.Forms.Padding(4);
            this.btnJela.Name = "btnJela";
            this.btnJela.Size = new System.Drawing.Size(203, 63);
            this.btnJela.TabIndex = 12;
            this.btnJela.Text = "Najprodavanija jela";
            this.btnJela.UseVisualStyleBackColor = false;
            this.btnJela.Click += new System.EventHandler(this.btnJela_Click);
            // 
            // dgvPrikaz
            // 
            this.dgvPrikaz.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPrikaz.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPrikaz.Location = new System.Drawing.Point(61, 108);
            this.dgvPrikaz.Name = "dgvPrikaz";
            this.dgvPrikaz.RowHeadersWidth = 51;
            this.dgvPrikaz.RowTemplate.Height = 24;
            this.dgvPrikaz.Size = new System.Drawing.Size(736, 375);
            this.dgvPrikaz.TabIndex = 16;
            // 
            // ucIzvjestaji
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvPrikaz);
            this.Controls.Add(this.btnKupci);
            this.Controls.Add(this.btnLikes);
            this.Controls.Add(this.btnJela);
            this.Name = "ucIzvjestaji";
            this.Size = new System.Drawing.Size(846, 501);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrikaz)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnKupci;
        private System.Windows.Forms.Button btnLikes;
        private System.Windows.Forms.Button btnJela;
        private System.Windows.Forms.DataGridView dgvPrikaz;
    }
}
