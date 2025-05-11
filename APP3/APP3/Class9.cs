using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APP3
{
    class Cfigure
    {
        private float mWidth;
        private int numLados;
        private float mPerimeter;
        private float mArea;

        public Cfigure()
        {
            mWidth = 0.0f; numLados = 0;
            mPerimeter = 0.0f; mArea = 0.0f;
        }

        public void ReadData(TextBox txtWidth,int num)
        {
            try
            {
                mWidth = float.Parse(txtWidth.Text);
                numLados = num;
            }
            catch
            {
                MessageBox.Show("Ingreso no valido...", "Mensaje de error");
            }

        }

        public void PerimeterFigure()
        {
            mPerimeter = numLados * mWidth;
        }


        public void AreaFigure()
        {
            float apot = (float)(mWidth / (2 * Math.Tan(Math.PI / numLados)));
            MessageBox.Show(apot.ToString());
            mArea = (mPerimeter * apot) / 2;
        }

        public void initializeData(TextBox txtWidth,TextBox txtPerimeter, TextBox txtArea)
        {
            mWidth = 0.0f; numLados = 0;
            mPerimeter = 0.0f; mArea = 0.0f;

            txtWidth.Text = "";
            txtPerimeter.Text = ""; txtArea.Text = "";
        }

        public void PrintData(TextBox txtPerimeter, TextBox txtArea)
        {
            txtPerimeter.Text = mPerimeter.ToString();
            txtArea.Text = mArea.ToString();
        }

    }
}
