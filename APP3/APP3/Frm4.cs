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
    public partial class Frm4 : Form
    {
        private CLine ObjLine = new CLine();
        public Frm4()
        {
            InitializeComponent();
        }

        private void picCanvas_Click(object sender, EventArgs e)
        {
            MouseEventArgs me = (MouseEventArgs)e;
            Point coordinates = me.Location;
            ObjLine.ReadData(coordinates.X, coordinates.Y);
            ObjLine.PlotShape(picCanvas);
        }

        private void Frm4_Load(object sender, EventArgs e)
        {
            ObjLine.initializeData(picCanvas);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ObjLine.initializeData(picCanvas);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
