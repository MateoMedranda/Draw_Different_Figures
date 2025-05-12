using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APP3
{
    class Cdiamond
    {
        private float mMajorD;
        private float mMinorD;
        private float mPerimeter;
        private float mArea;

        //Constructor sin parámetros
        public Cdiamond()
        {
            mMajorD = 0.0f; mMinorD = 0.0f;
            mPerimeter = 0.0f; mArea = 0.0f;
        }

        //Función que lee los datos de entrada del rombo
        public bool ReadData(TextBox txtMajorD, TextBox txtMinorD)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtMajorD.Text) || string.IsNullOrWhiteSpace(txtMinorD.Text))
                {
                    MessageBox.Show("No deje los campos vacíos.", "Mensaje de error");
                    return false;
                }

                if (!float.TryParse(txtMajorD.Text, out mMajorD) || !float.TryParse(txtMinorD.Text, out mMinorD))
                {
                    MessageBox.Show("Ingrese solo números válidos (sin letras ni símbolos).", "Mensaje de error");
                    return false;
                }

                if (mMajorD < 0 || mMinorD < 0)
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


        public void PerimeterDiamond()
        {
            double L =Math.Sqrt(Math.Pow(mMajorD / 2, 2) + Math.Pow(mMinorD / 2, 2));
            mPerimeter = 4f * (float)L;
            MessageBox.Show(L.ToString());
        }


        public void AreaDiamond()
        {
            mArea = (mMinorD * mMajorD) / 2;
        }

        public void initializeData(TextBox txtMajorD, TextBox txtMinorD, TextBox txtPerimeter, TextBox txtArea)
        {
            mMajorD = 0.0f; mMinorD = 0.0f;
            mPerimeter = 0.0f; mArea = 0.0f;

            txtMajorD.Text = ""; txtMinorD.Text = "";
            txtPerimeter.Text = ""; txtArea.Text = "";
        }

        public void PrintData(TextBox txtPerimeter, TextBox txtArea)
        {
            txtPerimeter.Text = mPerimeter.ToString();
            
            txtArea.Text = mArea.ToString();
        }

    }
}
