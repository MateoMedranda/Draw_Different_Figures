namespace APP3
{
    partial class Frm10
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm10));
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
            txtDiagonal = new TextBox();
            txtD = new TextBox();
            txtC = new TextBox();
            txtB = new TextBox();
            label4 = new Label();
            label2 = new Label();
            label1 = new Label();
            label3 = new Label();
            txtA = new TextBox();
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
            grbCanvas.Location = new Point(349, 30);
            grbCanvas.Name = "grbCanvas";
            grbCanvas.Size = new Size(494, 331);
            grbCanvas.TabIndex = 12;
            grbCanvas.TabStop = false;
            grbCanvas.Text = "Trapezoide";
            // 
            // picCanvas
            // 
            picCanvas.Image = (Image)resources.GetObject("picCanvas.Image");
            picCanvas.Location = new Point(17, 62);
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
            grbOutputs.Location = new Point(12, 327);
            grbOutputs.Name = "grbOutputs";
            grbOutputs.Size = new Size(331, 113);
            grbOutputs.TabIndex = 14;
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
            grbProcess.Location = new Point(12, 227);
            grbProcess.Name = "grbProcess";
            grbProcess.Size = new Size(331, 81);
            grbProcess.TabIndex = 13;
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
            grbInputs.Controls.Add(txtDiagonal);
            grbInputs.Controls.Add(txtD);
            grbInputs.Controls.Add(txtC);
            grbInputs.Controls.Add(txtB);
            grbInputs.Controls.Add(label4);
            grbInputs.Controls.Add(label2);
            grbInputs.Controls.Add(label1);
            grbInputs.Controls.Add(label3);
            grbInputs.Controls.Add(txtA);
            grbInputs.Controls.Add(lblWidth);
            grbInputs.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            grbInputs.Location = new Point(12, 21);
            grbInputs.Name = "grbInputs";
            grbInputs.Size = new Size(331, 200);
            grbInputs.TabIndex = 11;
            grbInputs.TabStop = false;
            grbInputs.Text = "Entradas";
            // 
            // txtDiagonal
            // 
            txtDiagonal.Location = new Point(180, 157);
            txtDiagonal.Name = "txtDiagonal";
            txtDiagonal.Size = new Size(143, 26);
            txtDiagonal.TabIndex = 16;
            // 
            // txtD
            // 
            txtD.Location = new Point(180, 125);
            txtD.Name = "txtD";
            txtD.Size = new Size(143, 26);
            txtD.TabIndex = 15;
            // 
            // txtC
            // 
            txtC.Location = new Point(180, 93);
            txtC.Name = "txtC";
            txtC.Size = new Size(143, 26);
            txtC.TabIndex = 14;
            // 
            // txtB
            // 
            txtB.Location = new Point(180, 61);
            txtB.Name = "txtB";
            txtB.Size = new Size(143, 26);
            txtB.TabIndex = 13;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 125);
            label4.Name = "label4";
            label4.Size = new Size(81, 20);
            label4.TabIndex = 12;
            label4.Text = "Lado (d):";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 90);
            label2.Name = "label2";
            label2.Size = new Size(80, 20);
            label2.TabIndex = 11;
            label2.Text = "Lado (c):";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 61);
            label1.Name = "label1";
            label1.Size = new Size(81, 20);
            label1.TabIndex = 10;
            label1.Text = "Lado (b):";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 163);
            label3.Name = "label3";
            label3.Size = new Size(145, 20);
            label3.TabIndex = 8;
            label3.Text = "Diagonal a-c (D):";
            // 
            // txtA
            // 
            txtA.Location = new Point(180, 29);
            txtA.Name = "txtA";
            txtA.Size = new Size(143, 26);
            txtA.TabIndex = 2;
            // 
            // lblWidth
            // 
            lblWidth.AutoSize = true;
            lblWidth.Location = new Point(6, 29);
            lblWidth.Name = "lblWidth";
            lblWidth.Size = new Size(81, 20);
            lblWidth.TabIndex = 0;
            lblWidth.Text = "Lado (a):";
            // 
            // Frm10
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(869, 464);
            Controls.Add(grbCanvas);
            Controls.Add(grbOutputs);
            Controls.Add(grbProcess);
            Controls.Add(grbInputs);
            Name = "Frm10";
            Text = "Frm10";
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
        private TextBox textBox2;
        private Label label3;
        private TextBox textBox1;
        private TextBox txtHeight;
        private TextBox txtBase;
        private TextBox txtA;
        private Label lblHeight;
        private Label lblWidth;
        private Label label4;
        private Label label2;
        private Label label1;
        private TextBox txtDiagonal;
        private TextBox txtD;
        private TextBox txtC;
        private TextBox txtB;
    }
}