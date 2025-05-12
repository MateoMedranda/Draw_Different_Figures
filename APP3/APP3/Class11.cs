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
        public bool ReadData(TextBox txtBase, TextBox txtSide)
        {
            try
            {
                // Verificar si los campos están vacíos
                if (string.IsNullOrWhiteSpace(txtBase.Text) || string.IsNullOrWhiteSpace(txtSide.Text))
                {
                    MessageBox.Show("No deje campos vacíos.", "Mensaje de error");
                    return false;
                }

                // Intentar convertir los valores a float
                if (!float.TryParse(txtBase.Text, out mBase) || !float.TryParse(txtSide.Text, out mHeight))
                {
                    MessageBox.Show("Ingrese solo números válidos (sin letras ni símbolos).", "Mensaje de error");
                    return false;
                }

                // Verificar que los valores sean mayores que cero
                if (mBase <= 0 || mHeight <= 0)
                {
                    MessageBox.Show("Los valores deben ser mayores que cero.", "Mensaje de error");
                    return false;
                }

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error: " + ex.Message, "Mensaje de error");
                return false;
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
