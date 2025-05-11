using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APP3
{
    class Ctrapezoid
    {
        private float mLateralSide;
        private float mBase;
        private float mTop;
        private float mPerimeter;
        private float mArea;

        //Constructor sin parámetros
        public Ctrapezoid()
        {
            mLateralSide = 0.0f; mBase = 0.0f; mTop = 0.0f;
            mPerimeter = 0.0f; mArea = 0.0f;
        }

        //Función que lee los datos de entrada del Trapecio
        public void ReadData(TextBox txtLateralSide, TextBox txtBase, TextBox txtTop)
        {
            try
            {
                mLateralSide = float.Parse(txtLateralSide.Text);
                mBase = float.Parse(txtBase.Text);
                mTop = float.Parse(txtTop.Text);
            }
            catch
            {
                MessageBox.Show("Ingreso no valido...", "Mensaje de error");
            }

        }

        public void PerimeterTrapezoid()
        {
            mPerimeter = (2*mLateralSide) + mBase + mTop;
        }


        public void AreaTrapezoid()
        {
            double x = (mBase - mTop) / 2;
            double mHeight = Math.Sqrt(Math.Pow(mLateralSide, 2) - Math.Pow(x, 2));
            mArea = ((mBase+mTop)/2)*(float)mHeight;
        }

        public void initializeData(TextBox txtLateralSide, TextBox txtBase, TextBox txtTop, TextBox txtPerimeter, TextBox txtArea)
        {
            mBase = 0.0f; mLateralSide = 0.0f; mTop = 0.0f;
            mPerimeter = 0.0f; mArea = 0.0f;

            txtLateralSide.Text = ""; txtBase.Text = ""; txtTop.Text = "";
            txtPerimeter.Text = ""; txtArea.Text = "";
        }

        public void PrintData(TextBox txtPerimeter, TextBox txtArea)
        {
            txtPerimeter.Text = mPerimeter.ToString();

            txtArea.Text = mArea.ToString();
        }

    }
}
