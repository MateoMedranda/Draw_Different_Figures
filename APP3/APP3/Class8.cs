using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APP3
{
    class Celipse
    {
        private float mMajorR;
        private float mMinorR;
        private float mPerimeter;
        private float mArea;

        //Constructor sin parámetros
        public Celipse()
        {
            mMajorR = 0.0f; mMinorR = 0.0f;
            mPerimeter = 0.0f; mArea = 0.0f;
        }

        //Función que lee los datos de entrada del rombo
        public void ReadData(TextBox txtMajorR, TextBox txtMinorR)
        {
            try
            {
                mMajorR = float.Parse(txtMajorR.Text);
                mMinorR = float.Parse(txtMinorR.Text);
            }
            catch
            {
                MessageBox.Show("Ingreso no valido...", "Mensaje de error");
            }

        }

        public void PerimeterElipse()
        {
            mPerimeter =(float)(2 * Math.PI * Math.Sqrt((Math.Pow(mMajorR, 2) + Math.Pow(mMinorR, 2)) / 2));
        }


        public void AreaElipse()
        {
            mArea = (float) Math.PI*mMajorR * mMinorR;
        }

        public void initializeData(TextBox txtMajorR, TextBox txtMinorR, TextBox txtPerimeter, TextBox txtArea)
        {
            mMajorR = 0.0f; mMinorR = 0.0f;
            mPerimeter = 0.0f; mArea = 0.0f;

            txtMajorR.Text = ""; txtMinorR.Text = "";
            txtPerimeter.Text = ""; txtArea.Text = "";
        }

        public void PrintData(TextBox txtPerimeter, TextBox txtArea)
        {
            txtPerimeter.Text = mPerimeter.ToString();

            txtArea.Text = mArea.ToString();
        }

    }
}
