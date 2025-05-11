namespace APP3
{
    partial class Frm9
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm9));
            grbCanvas = new GroupBox();
            picCanvas = new PictureBox();
            grbOutputs = new GroupBox();
            txtArea = new TextBox();
            txtPerimeter = new TextBox();
            lblPerimeter = new Label();
            lblArea = new Label();
            grbProcess = new GroupBox();
            btnExit = new Button();
            btnReset = new Button();
            btnCalculate = new Button();
            grbInputs = new GroupBox();
            cbxTypeFigure = new ComboBox();
            txtWidth = new TextBox();
            lblHeight = new Label();
            lblWidth = new Label();
            grbCanvas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picCanvas).BeginInit();
            grbOutputs.SuspendLayout();
            grbProcess.SuspendLayout();
            grbInputs.SuspendLayout();
            SuspendLayout();
            // 
            // grbCanvas
            // 
            grbCanvas.Controls.Add(picCanvas);
            grbCanvas.Font = new Font("Microsoft Sans Serif", 12F);
            grbCanvas.Location = new Point(349, 36);
            grbCanvas.Name = "grbCanvas";
            grbCanvas.Size = new Size(494, 331);
            grbCanvas.TabIndex = 8;
            grbCanvas.TabStop = false;
            grbCanvas.Text = "Polígonos";
            // 
            // picCanvas
            // 
            picCanvas.Image = (Image)resources.GetObject("picCanvas.Image");
            picCanvas.Location = new Point(17, 31);
            picCanvas.Name = "picCanvas";
            picCanvas.Size = new Size(460, 287);
            picCanvas.SizeMode = PictureBoxSizeMode.StretchImage;
            picCanvas.TabIndex = 0;
            picCanvas.TabStop = false;
            // 
            // grbOutputs
            // 
            grbOutputs.Controls.Add(txtArea);
            grbOutputs.Controls.Add(txtPerimeter);
            grbOutputs.Controls.Add(lblPerimeter);
            grbOutputs.Controls.Add(lblArea);
            grbOutputs.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            grbOutputs.Location = new Point(12, 245);
            grbOutputs.Name = "grbOutputs";
            grbOutputs.Size = new Size(331, 113);
            grbOutputs.TabIndex = 10;
            grbOutputs.TabStop = false;
            grbOutputs.Text = "Salidas";
            // 
            // txtArea
            // 
            txtArea.Enabled = false;
            txtArea.Location = new Point(137, 61);
            txtArea.Name = "txtArea";
            txtArea.Size = new Size(143, 26);
            txtArea.TabIndex = 7;
            // 
            // txtPerimeter
            // 
            txtPerimeter.Enabled = false;
            txtPerimeter.Location = new Point(137, 32);
            txtPerimeter.Name = "txtPerimeter";
            txtPerimeter.Size = new Size(143, 26);
            txtPerimeter.TabIndex = 6;
            // 
            // lblPerimeter
            // 
            lblPerimeter.AutoSize = true;
            lblPerimeter.Location = new Point(16, 32);
            lblPerimeter.Name = "lblPerimeter";
            lblPerimeter.Size = new Size(91, 20);
            lblPerimeter.TabIndex = 4;
            lblPerimeter.Text = "Perímetro:";
            // 
            // lblArea
            // 
            lblArea.AutoSize = true;
            lblArea.Location = new Point(16, 57);
            lblArea.Name = "lblArea";
            lblArea.Size = new Size(52, 20);
            lblArea.TabIndex = 5;
            lblArea.Text = "Área:";
            // 
            // grbProcess
            // 
            grbProcess.Controls.Add(btnExit);
            grbProcess.Controls.Add(btnReset);
            grbProcess.Controls.Add(btnCalculate);
            grbProcess.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            grbProcess.Location = new Point(12, 145);
            grbProcess.Name = "grbProcess";
            grbProcess.Size = new Size(331, 81);
            grbProcess.TabIndex = 9;
            grbProcess.TabStop = false;
            grbProcess.Text = "Proceso";
            // 
            // btnExit
            // 
            btnExit.Location = new Point(205, 34);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(75, 30);
            btnExit.TabIndex = 2;
            btnExit.Text = "Salir";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btnReset
            // 
            btnReset.Location = new Point(99, 34);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(99, 30);
            btnReset.TabIndex = 1;
            btnReset.Text = "Resetear";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // btnCalculate
            // 
            btnCalculate.Location = new Point(6, 34);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(87, 30);
            btnCalculate.TabIndex = 0;
            btnCalculate.Text = "Calcular";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // grbInputs
            // 
            grbInputs.Controls.Add(cbxTypeFigure);
            grbInputs.Controls.Add(txtWidth);
            grbInputs.Controls.Add(lblHeight);
            grbInputs.Controls.Add(lblWidth);
            grbInputs.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            grbInputs.Location = new Point(12, 27);
            grbInputs.Name = "grbInputs";
            grbInputs.Size = new Size(331, 100);
            grbInputs.TabIndex = 7;
            grbInputs.TabStop = false;
            grbInputs.Text = "Entradas";
            // 
            // cbxTypeFigure
            // 
            cbxTypeFigure.FormattingEnabled = true;
            cbxTypeFigure.Items.AddRange(new object[] { "Pentágono", "Hexágono", "Heptágono", "Octágono", "Eneágono", "Decágono" });
            cbxTypeFigure.Location = new Point(137, 66);
            cbxTypeFigure.Name = "cbxTypeFigure";
            cbxTypeFigure.Size = new Size(168, 28);
            cbxTypeFigure.TabIndex = 3;
            // 
            // txtWidth
            // 
            txtWidth.Location = new Point(137, 29);
            txtWidth.Name = "txtWidth";
            txtWidth.Size = new Size(168, 26);
            txtWidth.TabIndex = 2;
            // 
            // lblHeight
            // 
            lblHeight.AutoSize = true;
            lblHeight.Location = new Point(6, 61);
            lblHeight.Name = "lblHeight";
            lblHeight.Size = new Size(104, 20);
            lblHeight.TabIndex = 1;
            lblHeight.Text = "Tipo Figura:";
            // 
            // lblWidth
            // 
            lblWidth.AutoSize = true;
            lblWidth.Location = new Point(6, 29);
            lblWidth.Name = "lblWidth";
            lblWidth.Size = new Size(75, 20);
            lblWidth.TabIndex = 0;
            lblWidth.Text = "Lado (l):";
            // 
            // Frm9
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(875, 407);
            Controls.Add(grbCanvas);
            Controls.Add(grbOutputs);
            Controls.Add(grbProcess);
            Controls.Add(grbInputs);
            Name = "Frm9";
            Text = "Frm9";
            grbCanvas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picCanvas).EndInit();
            grbOutputs.ResumeLayout(false);
            grbOutputs.PerformLayout();
            grbProcess.ResumeLayout(false);
            grbInputs.ResumeLayout(false);
            grbInputs.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grbCanvas;
        private PictureBox picCanvas;
        private GroupBox grbOutputs;
        private TextBox txtArea;
        private TextBox txtPerimeter;
        private Label lblPerimeter;
        private Label lblArea;
        private GroupBox grbProcess;
        private Button btnExit;
        private Button btnReset;
        private Button btnCalculate;
        private GroupBox grbInputs;
        private TextBox txtWidth;
        private Label lblHeight;
        private Label lblWidth;
        private ComboBox cbxTypeFigure;
    }
}