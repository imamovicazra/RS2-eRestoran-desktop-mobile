using eRestoran.WinUI.Helpers;
using eRestoran.WinUI.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eRestoran.WinUI
{
    public partial class frmMain : Form
    {
        private Point lastPoint;

        public frmMain()
        {
            InitializeComponent();
        }


     
       
        private void frmMain_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void frmMain_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }



        private void frmMain_Load(object sender, EventArgs e)
        {
            PanelHelper.AddPanel(pnlMain, new ucPrijava());
        }
    }
}
