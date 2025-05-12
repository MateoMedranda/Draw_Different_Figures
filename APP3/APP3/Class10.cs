using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APP3
{
    class Ctrapezium
    {
        private float mA;
        private float mB;
        private float mC;
        private float mD;
        private float mDiagonal;
        private float mPerimeter;
        private float mArea;

        //Constructor sin parámetros
        public Ctrapezium()
        {
            mA = 0.0f; mB = 0.0f; mC = 0.0f; mD = 0.0f; mDiagonal = 0.0f;
            mPerimeter = 0.0f; mArea = 0.0f;
        }

        //Función que lee los datos de entrada del Trapezoide
        public bool ReadData(TextBox txtA, TextBox txtB, TextBox txtC, TextBox txtD, TextBox txtDiagonal)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtA.Text) ||
                    string.IsNullOrWhiteSpace(txtB.Text) ||
                    string.IsNullOrWhiteSpace(txtC.Text) ||
                    string.IsNullOrWhiteSpace(txtD.Text) ||
                    string.IsNullOrWhiteSpace(txtDiagonal.Text))
                {
                    MessageBox.Show("No deje campos vacíos.", "Mensaje de error");
                    return false;
                }

                if (!float.TryParse(txtA.Text, out mA) ||
                    !float.TryParse(txtB.Text, out mB) ||
                    !float.TryParse(txtC.Text, out mC) ||
                    !float.TryParse(txtD.Text, out mD) ||
                    !float.TryParse(txtDiagonal.Text, out mDiagonal))
                {
                    MessageBox.Show("Ingrese solo números válidos (sin letras ni símbolos).", "Mensaje de error");
                    return false;
                }

                if (mA <= 0 || mB <= 0 || mC <= 0 || mD <= 0 || mDiagonal <= 0)
                {
                    MessageBox.Show("Los valores deben ser mayores a cero.", "Mensaje de error");
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


        public void PerimeterTrapezium()
        {
            mPerimeter = mA +mB +mC + mD;
        }


        public void AreaTrapezium()
        {
            float spABD = (mA + mB + mDiagonal) / 2;
            float areaTriangleABD = (float)Math.Sqrt(spABD * (spABD - mA) * (spABD - mB) * (spABD - mDiagonal));
            float spBCD = (mB + mC + mDiagonal) / 2;
            float areaTriangleBCD = (float)Math.Sqrt(spBCD * (spBCD - mC) * (spBCD - mD) * (spBCD - mDiagonal));

            mArea = areaTriangleABD + areaTriangleBCD;
        }

        public void initializeData(TextBox txtA, TextBox txtB, TextBox txtC, TextBox txtD, TextBox txtDiagonal, TextBox txtPerimeter, TextBox txtArea)
        {
            mA = 0.0f; mB = 0.0f; mC = 0.0f; mD = 0.0f; mDiagonal = 0.0f;
            mPerimeter = 0.0f; mArea = 0.0f;

            txtA.Text = ""; txtB.Text = ""; txtC.Text = ""; txtD.Text = ""; txtDiagonal.Text = "";
            txtPerimeter.Text = ""; txtArea.Text = "";
        }

        public void PrintData(TextBox txtPerimeter, TextBox txtArea)
        {
            txtPerimeter.Text = mPerimeter.ToString();

            txtArea.Text = mArea.ToString();
        }

    }
}
