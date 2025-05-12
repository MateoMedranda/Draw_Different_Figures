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
    public partial class Frm5 : Form
    {
        Cdiamond ObjRombo = new Cdiamond();
        public Frm5()
        {
            InitializeComponent();
            ObjRombo.initializeData(txtMajorDiagonal, txtMinorDiagonal, txtPerimeter, txtArea);
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (ObjRombo.ReadData(txtMajorDiagonal, txtMinorDiagonal))
            {
                ObjRombo.PerimeterDiamond();
                ObjRombo.AreaDiamond();
                ObjRombo.PrintData(txtPerimeter, txtArea);
            }
        }


        private void btnReset_Click(object sender, EventArgs e)
        {
            ObjRombo.initializeData(txtMajorDiagonal, txtMinorDiagonal, txtPerimeter, txtArea);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
