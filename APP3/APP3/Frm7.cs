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
    public partial class Frm7 : Form
    {
        Ctrapezoid objTrapecio = new Ctrapezoid();
        public Frm7()
        {
            InitializeComponent();
            objTrapecio.initializeData(txtLateralSide, txtBase, txtTop, txtPerimeter, txtArea);
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (objTrapecio.ReadData(txtLateralSide, txtBase, txtTop))
            {
                objTrapecio.PerimeterTrapezoid();
                objTrapecio.AreaTrapezoid();
                objTrapecio.PrintData(txtPerimeter, txtArea);
            }
        }


        private void btnReset_Click(object sender, EventArgs e)
        {
            objTrapecio.initializeData(txtLateralSide, txtBase, txtTop, txtPerimeter, txtArea);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
