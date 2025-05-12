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

        public bool ReadData(TextBox txtWidth, int num)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtWidth.Text))
                {
                    MessageBox.Show("No deje el campo vacío.", "Mensaje de error");
                    return false;
                }

                if (!float.TryParse(txtWidth.Text, out mWidth))
                {
                    MessageBox.Show("Ingrese solo un número válido (sin letras ni símbolos).", "Mensaje de error");
                    return false;
                }

                if (mWidth <= 0)
                {
                    MessageBox.Show("El valor de ancho debe ser mayor que cero.", "Mensaje de error");
                    return false;
                }

                numLados = num;
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error: " + ex.Message, "Mensaje de error");
                return false;
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
