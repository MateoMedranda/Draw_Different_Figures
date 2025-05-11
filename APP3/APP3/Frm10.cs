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
    public partial class Frm10 : Form
    {
        Ctrapezium ObjTrapezoide = new Ctrapezium();
        public Frm10()
        {
            InitializeComponent();
            ObjTrapezoide.initializeData(txtA, txtB, txtC, txtD, txtDiagonal, txtPerimeter, txtArea);
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            ObjTrapezoide.ReadData(txtA, txtB, txtC, txtD, txtDiagonal);
            ObjTrapezoide.PerimeterTrapezium();
            ObjTrapezoide.AreaTrapezium();
            ObjTrapezoide.PrintData(txtPerimeter, txtArea);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ObjTrapezoide.initializeData(txtA, txtB, txtC, txtD, txtDiagonal, txtPerimeter, txtArea);

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
