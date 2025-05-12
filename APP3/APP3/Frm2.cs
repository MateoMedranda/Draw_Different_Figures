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
    public partial class Frm2 : Form
    {
        Csquare ObjSquare = new Csquare();
        public Frm2()
        {
            InitializeComponent();
            ObjSquare.initializeData(txtWidth, txtPerimeter, txtArea, picCanvas);
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (ObjSquare.ReadData(txtWidth))
            {
                ObjSquare.PerimeterSquare();
                ObjSquare.AreaSquare();
                ObjSquare.PrintData(txtPerimeter, txtArea);
                ObjSquare.PlotShape(picCanvas);
            }
        }


        private void btnReset_Click(object sender, EventArgs e)
        {
            ObjSquare.initializeData(txtWidth, txtPerimeter, txtArea, picCanvas);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
