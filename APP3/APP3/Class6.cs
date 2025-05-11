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
        public void ReadData(TextBox txtObliqueSide, TextBox txtBase, TextBox txtHeight)
        {
            try
            {
                mObliqueSide = float.Parse(txtObliqueSide.Text);
                mBase = float.Parse(txtBase.Text);
                mHeight = float.Parse(txtHeight.Text);
            }
            catch
            {
                MessageBox.Show("Ingreso no valido...", "Mensaje de error");
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
