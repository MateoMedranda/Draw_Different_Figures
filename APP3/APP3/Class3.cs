using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APP3
{
    class CLine
    {
        private float mX1;

        private float mY1;

        private float mX2;

        private float mY2;

        private Graphics mGraph;

        private const float SF = 20;

        private Pen mPen1;
        private Pen mPen2;

        public CLine()
        {
            mX1 = 0.0f;
            mY1 = 0.0f;
            mX2 = 0.0f;
            mY2 = 0.0f;
        }

        public void ReadData(float mouseX, float mouseY)
        {
            try
            {
                mX2 = mouseX;
                mY2 = mouseY;

            }
            catch
            {
                MessageBox.Show("Ingreso no valido...", "Mensaje de error");
            }

        }

        public void initializeData(PictureBox picCanvas)
        {
            mX1 = 0.0f;
            mY1 = 0.0f;
            mX2 = 0.0f;
            mY2 = 0.0f;
            picCanvas.Refresh();
        }

        public void PlotShape(PictureBox picCanvas)
        {
            mGraph = picCanvas.CreateGraphics();
            mPen1 = new Pen(Color.Blue, 2);
            mPen2 = new Pen(Color.Red, 2);
            mGraph.DrawEllipse(mPen2, mX2, mY2, 5, 5);
            mGraph.DrawLine(mPen1, mX1, mY1, mX2, mY2);
            mX1 = mX2;
            mY1 = mY2;
        }

        public void CloseForm(Form frmLine)
        {
            frmLine.Close();
        }
    }
}
