using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APP3
{
    class CTriangle
    {

        private float mBase;
        private float mHeight;
        private float mPerimeter;
        private float mArea;

        //Constructor sin parámetros
        public CTriangle()
        {
            mBase = 0.0f; mHeight = 0.0f;
            mPerimeter = 0.0f; mArea = 0.0f;
        }

        //Función que lee los datos de entrada del Triángulo
        public void ReadData(TextBox txtBase, TextBox txtSide)
        {
            try
            {
                mBase = float.Parse(txtBase.Text);
                mHeight = float.Parse(txtSide.Text);
            }
            catch
            {
                MessageBox.Show("Ingreso no valido...", "Mensaje de error");
            }

        }

        public void PerimeterTriangle()
        {
            mPerimeter = mBase + 2 * (float)Math.Sqrt(Math.Pow(mBase / 2, 2) + Math.Pow(mHeight, 2));
        }

        public void AreaTriangle()
        {
            mArea = (mHeight * mBase) / 2;
        }

        public void initializeData(TextBox txtBase, TextBox txtSide, TextBox txtPerimeter, TextBox txtArea)
        {
            mBase = 0.0f; mHeight = 0.0f;
            mPerimeter = 0.0f; mArea = 0.0f;

            txtBase.Text = ""; txtSide.Text = "";
            txtPerimeter.Text = ""; txtArea.Text = "";

        }

        public void PrintData(TextBox txtPerimeter, TextBox txtArea)
        {
            txtPerimeter.Text = mPerimeter.ToString();
            txtArea.Text = mArea.ToString();
        }
    }
}
