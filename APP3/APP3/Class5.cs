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
        public void ReadData(TextBox txtMajorD, TextBox txtMinorD)
        {
            try
            {
                mMajorD = float.Parse(txtMajorD.Text);
                mMinorD = float.Parse(txtMinorD.Text);
            }
            catch
            {
                MessageBox.Show("Ingreso no valido...", "Mensaje de error");
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
