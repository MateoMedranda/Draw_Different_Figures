using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APP3
{
    class Crhomboid
    {
        private float mObliqueSide;
        private float mBase;
        private float mHeight;
        private float mPerimeter;
        private float mArea;

        //Constructor sin parámetros
        public Crhomboid()
        {
            mObliqueSide = 0.0f; mBase = 0.0f; mHeight = 0.0f;
            mPerimeter = 0.0f; mArea = 0.0f;
        }

        //Función que lee los datos de entrada del rombo
        public bool ReadData(TextBox txtObliqueSide, TextBox txtBase, TextBox txtHeight)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtObliqueSide.Text) ||
                    string.IsNullOrWhiteSpace(txtBase.Text) ||
                    string.IsNullOrWhiteSpace(txtHeight.Text))
                {
                    MessageBox.Show("No deje campos vacíos.", "Mensaje de error");
                    return false;
                }

                if (!float.TryParse(txtObliqueSide.Text, out mObliqueSide) ||
                    !float.TryParse(txtBase.Text, out mBase) ||
                    !float.TryParse(txtHeight.Text, out mHeight))
                {
                    MessageBox.Show("Ingrese solo números válidos (sin letras ni símbolos).", "Mensaje de error");
                    return false;
                }

                if (mObliqueSide < 0 || mBase < 0 || mHeight < 0)
                {
                    MessageBox.Show("No se permiten valores menores a cero.", "Mensaje de error");
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


        public void PerimeterRhomboid()
        {
            mPerimeter = 2*(mBase + mObliqueSide);
        }


        public void AreaRhomboid()
        {
            mArea = mBase * mHeight;
        }

        public void initializeData(TextBox txtObliqueSide, TextBox txtBase, TextBox txtHeight, TextBox txtPerimeter, TextBox txtArea)
        {
            mBase = 0.0f; mObliqueSide = 0.0f; mHeight= 0.0f;
            mPerimeter = 0.0f; mArea = 0.0f;

            txtObliqueSide.Text = ""; txtBase.Text = ""; txtHeight.Text = "";
            txtPerimeter.Text = ""; txtArea.Text = "";
        }

        public void PrintData(TextBox txtPerimeter, TextBox txtArea)
        {
            txtPerimeter.Text = mPerimeter.ToString();

            txtArea.Text = mArea.ToString();
        }

    }
}
