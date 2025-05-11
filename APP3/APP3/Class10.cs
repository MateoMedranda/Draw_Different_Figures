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
        public void ReadData(TextBox txtA, TextBox txtB, TextBox txtC, TextBox txtD, TextBox txtDiagonal)
        {
            try
            {
                mA = float.Parse(txtA.Text);
                mB = float.Parse(txtB.Text);
                mC = float.Parse(txtC.Text);
                mD = float.Parse(txtD.Text);
                mDiagonal = float.Parse(txtDiagonal.Text);

            }
            catch
            {
                MessageBox.Show("Ingreso no valido...", "Mensaje de error");
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
