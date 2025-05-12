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
    public partial class Frm11 : Form
    {
        CTriangle ObjTriangulo = new CTriangle();
        public Frm11()
        {
            InitializeComponent();
            ObjTriangulo.initializeData(txtBase, txtHeight, txtPerimeter, txtArea);
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (ObjTriangulo.ReadData(txtBase, txtHeight))
            {
                ObjTriangulo.PerimeterTriangle();
                ObjTriangulo.AreaTriangle();
                ObjTriangulo.PrintData(txtPerimeter, txtArea);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ObjTriangulo.initializeData(txtBase, txtHeight, txtPerimeter, txtArea);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
