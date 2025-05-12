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
    public partial class Frm8 : Form
    {
        Celipse ObjElipse = new Celipse();
        public Frm8()
        {
            InitializeComponent();
            ObjElipse.initializeData(txtMajorRadius, txtMinorRadius, txtPerimeter, txtArea);
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (ObjElipse.ReadData(txtMajorRadius, txtMinorRadius))
            {
                ObjElipse.PerimeterElipse();
                ObjElipse.AreaElipse();
                ObjElipse.PrintData(txtPerimeter, txtArea);
            }
        }


        private void btnReset_Click(object sender, EventArgs e)
        {
            ObjElipse.initializeData(txtMajorRadius, txtMinorRadius, txtPerimeter, txtArea);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
