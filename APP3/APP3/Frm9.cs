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
    public partial class Frm9 : Form
    {
        Cfigure ObjFigura = new Cfigure();
        public Frm9()
        {
            InitializeComponent();
            ObjFigura.initializeData(txtWidth, txtPerimeter, txtArea);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indexSeleccionado = cbxTypeFigure.SelectedIndex;
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            int numLados = cbxTypeFigure.SelectedIndex + 5;

            if (ObjFigura.ReadData(txtWidth, numLados))
            {
                ObjFigura.PerimeterFigure();
                ObjFigura.AreaFigure();
                ObjFigura.PrintData(txtPerimeter, txtArea);
            }
        }


        private void btnReset_Click(object sender, EventArgs e)
        {
            ObjFigura.initializeData(txtWidth, txtPerimeter, txtArea);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
