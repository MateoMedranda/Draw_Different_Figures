namespace APP3
{
    public partial class frmRectangle : Form
    {
        private Crectangle ObjRectangle = new Crectangle();

        public frmRectangle()
        {
            InitializeComponent();
        }

        private void frmRectangle_Load(object sender, EventArgs e)
        {
            ObjRectangle.initializeData(txtWidth, txtHeight, txtPerimeter, txtArea, picCanvas);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ObjRectangle.initializeData(txtWidth, txtHeight, txtPerimeter, txtArea, picCanvas);
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (ObjRectangle.ReadData(txtWidth, txtHeight))
            {
                ObjRectangle.PerimeterRectangle();
                ObjRectangle.AreaRectangle();
                ObjRectangle.PrintData(txtPerimeter, txtArea);
                ObjRectangle.PlotShape(picCanvas);
            }
        }


        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
