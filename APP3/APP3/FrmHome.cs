using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APP3
{
    public partial class FrmHome : Form
    {
        private Frm2 frm2 = null;
        private frmRectangle frm1 = null;
        private Frm3 frm3 = null;
        private Frm4 frm4 = null;
        private Frm5 frm5 = null;
        private Frm6 frm6 = null;
        private Frm7 frm7 = null;
        private Frm8 frm8 = null;
        private Frm9 frm9 = null;
        private Frm10 frm10 = null;
        private Frm11 frm11 = null;

        public FrmHome()
        {
            InitializeComponent();
        }

        private void cuadradoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frm2 == null || frm2.IsDisposed)
            {
                frm2 = new Frm2();
                frm2.MdiParent = this;
                frm2.Show();
            }

        }

        private void rectanguloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frm1 == null || frm1.IsDisposed)
            {
                frm1 = new frmRectangle();
                frm1.MdiParent = this;
                frm1.Show();
            }

        }

        private void circuloToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (frm3 == null || frm3.IsDisposed)
            {
                frm3 = new Frm3();
                frm3.MdiParent = this;
                frm3.Show();
            }
        }

        private void lineasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frm4 == null || frm4.IsDisposed)
            {
                frm4 = new Frm4();
                frm4.MdiParent = this;
                frm4.Show();
            }
        }

        private void romboToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frm5 == null || frm5.IsDisposed)
            {
                frm5 = new Frm5();
                frm5.MdiParent = this;
                frm5.Show();
            }
        }

        private void romboideToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frm6 == null || frm6.IsDisposed)
            {
                frm6 = new Frm6();
                frm6.MdiParent = this;
                frm6.Show();
            }
        }

        private void trapecioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frm7 == null || frm7.IsDisposed)
            {
                frm7 = new Frm7();
                frm7.MdiParent = this;
                frm7.Show();
            }
        }

        private void elipseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frm8 == null || frm8.IsDisposed)
            {
                frm8 = new Frm8();
                frm8.MdiParent = this;
                frm8.Show();
            }
        }

        private void poligonosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frm9 == null || frm9.IsDisposed)
            {
                frm9 = new Frm9();
                frm9.MdiParent = this;
                frm9.Show();
            }
        }

        private void trapezoideToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frm10 == null || frm10.IsDisposed)
            {
                frm10 = new Frm10();
                frm10.MdiParent = this;
                frm10.Show();
            }
        }

        private void trianguloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frm11 == null || frm11.IsDisposed)
            {
                frm11 = new Frm11();
                frm11.MdiParent = this;
                frm11.Show();
            }
        }
    }
}
