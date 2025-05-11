namespace APP3
{
    partial class Frm6
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm6));
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
            txtHeight = new TextBox();
            label1 = new Label();
            txtBase = new TextBox();
            txtObliqueSide = new TextBox();
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
            grbCanvas.Location = new Point(349, 31);
            grbCanvas.Name = "grbCanvas";
            grbCanvas.Size = new Size(494, 331);
            grbCanvas.TabIndex = 8;
            grbCanvas.TabStop = false;
            grbCanvas.Text = "Romboide";
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
            grbOutputs.Location = new Point(12, 265);
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
            grbProcess.Location = new Point(12, 165);
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
            grbInputs.Controls.Add(txtHeight);
            grbInputs.Controls.Add(label1);
            grbInputs.Controls.Add(txtBase);
            grbInputs.Controls.Add(txtObliqueSide);
            grbInputs.Controls.Add(lblHeight);
            grbInputs.Controls.Add(lblWidth);
            grbInputs.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            grbInputs.Location = new Point(12, 22);
            grbInputs.Name = "grbInputs";
            grbInputs.Size = new Size(331, 137);
            grbInputs.TabIndex = 7;
            grbInputs.TabStop = false;
            grbInputs.Text = "Entradas";
            // 
            // txtHeight
            // 
            txtHeight.Location = new Point(180, 99);
            txtHeight.Name = "txtHeight";
            txtHeight.Size = new Size(143, 26);
            txtHeight.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 99);
            label1.Name = "label1";
            label1.Size = new Size(89, 20);
            label1.TabIndex = 4;
            label1.Text = "Altura (h):";
            // 
            // txtBase
            // 
            txtBase.Location = new Point(180, 61);
            txtBase.Name = "txtBase";
            txtBase.Size = new Size(143, 26);
            txtBase.TabIndex = 3;
            // 
            // txtObliqueSide
            // 
            txtObliqueSide.Location = new Point(180, 29);
            txtObliqueSide.Name = "txtObliqueSide";
            txtObliqueSide.Size = new Size(143, 26);
            txtObliqueSide.TabIndex = 2;
            // 
            // lblHeight
            // 
            lblHeight.AutoSize = true;
            lblHeight.Location = new Point(6, 61);
            lblHeight.Name = "lblHeight";
            lblHeight.Size = new Size(82, 20);
            lblHeight.TabIndex = 1;
            lblHeight.Text = "Base (b):";
            // 
            // lblWidth
            // 
            lblWidth.AutoSize = true;
            lblWidth.Location = new Point(6, 29);
            lblWidth.Name = "lblWidth";
            lblWidth.Size = new Size(143, 20);
            lblWidth.TabIndex = 0;
            lblWidth.Text = "Lado oblícuo (a):";
            // 
            // Frm6
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(873, 450);
            Controls.Add(grbCanvas);
            Controls.Add(grbOutputs);
            Controls.Add(grbProcess);
            Controls.Add(grbInputs);
            Name = "Frm6";
            Text = "Romboide";
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
        private TextBox txtHeight;
        private Label label1;
        private TextBox txtBase;
        private TextBox txtObliqueSide;
        private Label lblHeight;
        private Label lblWidth;
    }
}