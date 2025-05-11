using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APP3
{
    class Ccircle
    {
        private float mRadius;

        private float mPerimeter;
       
        private float mArea;

        private Graphics mGraph;

        private const float SF = 20;

        private Pen mPen;

        public Ccircle()
        {
            mRadius = 0.0f;
            mPerimeter = 0.0f; mArea = 0.0f;
        }

        public void ReadData(TextBox txtRadius)
        {
            try
            {
                mRadius = float.Parse(txtRadius.Text);
            }
            catch
            {
                MessageBox.Show("Ingreso no valido...", "Mensaje de error");
            }

        }

        public void PerimeterCircle()
        {
            mPerimeter = 2* (float)Math.PI *mRadius;
        }

        public void AreaCircle()
        {
            mArea = (float)(Math.PI*Math.Pow(mRadius,2));
        }

        public void initializeData(TextBox txtRadius,TextBox txtPerimeter, TextBox txtArea, PictureBox picCanvas)
        {
            mRadius = 0.0f;
            mPerimeter = 0.0f; mArea = 0.0f;

            txtRadius.Text = "";
            txtPerimeter.Text = ""; txtArea.Text = "";

            txtRadius.Focus();
            picCanvas.Refresh();
        }

        public void PlotShape(PictureBox picCanvas)
        {
            mGraph = picCanvas.CreateGraphics();
            mPen = new Pen(Color.Blue, 3);
            mGraph.DrawEllipse(mPen,0,0,2*mRadius*SF,2*mRadius*SF);
        }

        public void CloseForm(Form frmCircle)
        {
            frmCircle.Close();
        }

        public void PrintData(TextBox txtPerimeter, TextBox txtArea)
        {
            txtPerimeter.Text = mPerimeter.ToString();
            txtArea.Text = mArea.ToString();
        }
    }
}
