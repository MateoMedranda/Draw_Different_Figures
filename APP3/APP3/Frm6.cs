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
    public partial class Frm6 : Form
    {
        Crhomboid ObjRomboide = new Crhomboid();
        public Frm6()
        {
            InitializeComponent();
            ObjRomboide.initializeData(txtObliqueSide, txtBase, txtHeight, txtPerimeter, txtArea);
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (ObjRomboide.ReadData(txtObliqueSide, txtBase, txtHeight))
            {
                ObjRomboide.PerimeterRhomboid();
                ObjRomboide.AreaRhomboid();
                ObjRomboide.PrintData(txtPerimeter, txtArea);
            }
        }


        private void btnReset_Click(object sender, EventArgs e)
        {
            ObjRomboide.initializeData(txtObliqueSide, txtBase, txtHeight, txtPerimeter, txtArea);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
