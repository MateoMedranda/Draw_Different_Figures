using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APP3
{
    class Csquare
    {
        private float mWidth;

        private float mPerimeter;
        private float mArea;
        private Graphics mGraph;
        private const float SF = 20;
        private Pen mPen;


        //Constructor sin parámetros
        public Csquare()
        {
            mWidth = 0.0f;
            mPerimeter = 0.0f; mArea = 0.0f;
        }

        //Función que lee los datos de entrada del Cuadrado
        public bool ReadData(TextBox txtWidth)
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

                if (mWidth < 0)
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


        public void PerimeterSquare()
        {
            mPerimeter = 4 * mWidth;
        }

        public void AreaSquare()
        {
            mArea = (float)Math.Pow(mWidth, 2);
        }

        public void initializeData(TextBox txtWidth, TextBox txtPerimeter, TextBox txtArea, PictureBox picCanvas)
        {
            mWidth = 0.0f;
            mPerimeter = 0.0f; mArea = 0.0f;

            txtWidth.Text = "";
            txtPerimeter.Text = ""; txtArea.Text = "";

            txtWidth.Focus();
            picCanvas.Refresh();
        }

        public void PlotShape(PictureBox picCanvas)
        {
            mGraph = picCanvas.CreateGraphics();
            mPen = new Pen(Color.Blue, 3);
            mGraph.DrawRectangle(mPen, 0, 0, mWidth * SF, mWidth*SF);
        }

        public void PrintData(TextBox txtPerimeter, TextBox txtArea)
        {
            txtPerimeter.Text = mPerimeter.ToString();
            txtArea.Text = mArea.ToString();
        }

    }
}
