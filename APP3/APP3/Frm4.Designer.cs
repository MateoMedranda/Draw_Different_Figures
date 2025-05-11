namespace APP3
{
    partial class Frm4
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
            btnExit = new Button();
            btnReset = new Button();
            grbProcess = new GroupBox();
            grbCanvas = new GroupBox();
            picCanvas = new PictureBox();
            grbProcess.SuspendLayout();
            grbCanvas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picCanvas).BeginInit();
            SuspendLayout();
            // 
            // btnExit
            // 
            btnExit.Location = new Point(111, 20);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(75, 30);
            btnExit.TabIndex = 2;
            btnExit.Text = "Salir";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btnReset
            // 
            btnReset.Location = new Point(6, 20);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(99, 30);
            btnReset.TabIndex = 1;
            btnReset.Text = "Resetear";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // grbProcess
            // 
            grbProcess.Controls.Add(btnExit);
            grbProcess.Controls.Add(btnReset);
            grbProcess.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold);
            grbProcess.Location = new Point(12, 12);
            grbProcess.Name = "grbProcess";
            grbProcess.Size = new Size(776, 57);
            grbProcess.TabIndex = 6;
            grbProcess.TabStop = false;
            grbProcess.Text = "Proceso";
            // 
            // grbCanvas
            // 
            grbCanvas.Controls.Add(picCanvas);
            grbCanvas.Font = new Font("Microsoft Sans Serif", 12F);
            grbCanvas.Location = new Point(12, 75);
            grbCanvas.Name = "grbCanvas";
            grbCanvas.Size = new Size(776, 371);
            grbCanvas.TabIndex = 7;
            grbCanvas.TabStop = false;
            grbCanvas.Text = "Figura";
            // 
            // picCanvas
            // 
            picCanvas.Location = new Point(17, 31);
            picCanvas.Name = "picCanvas";
            picCanvas.Size = new Size(753, 332);
            picCanvas.TabIndex = 0;
            picCanvas.TabStop = false;
            picCanvas.Click += picCanvas_Click;
            // 
            // Frm4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(grbCanvas);
            Controls.Add(grbProcess);
            Name = "Frm4";
            Text = "Frm4";
            Load += Frm4_Load;
            grbProcess.ResumeLayout(false);
            grbCanvas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picCanvas).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button btnExit;
        private Button btnReset;
        private GroupBox grbProcess;
        private GroupBox grbCanvas;
        private PictureBox picCanvas;
    }
}