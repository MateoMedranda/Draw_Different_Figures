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
    public partial class Frm3 : Form
    {
        private Ccircle ObjCircle = new Ccircle();
        public Frm3()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (ObjCircle.ReadData(txtRadius))
            {
                ObjCircle.PerimeterCircle();
                ObjCircle.AreaCircle();
                ObjCircle.PrintData(txtPerimeter, txtArea);
                ObjCircle.PlotShape(picCanvas);
            }
        }


        private void btnReset_Click(object sender, EventArgs e)
        {
            ObjCircle.initializeData(txtRadius, txtPerimeter, txtArea, picCanvas);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Frm3_Load(object sender, EventArgs e)
        {
            ObjCircle.initializeData(txtRadius, txtPerimeter, txtArea, picCanvas);
        }
    }
}
