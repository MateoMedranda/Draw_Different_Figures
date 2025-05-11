namespace APP3
{
    partial class FrmHome
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
            menuStrip1 = new MenuStrip();
            cuadrangulosToolStripMenuItem = new ToolStripMenuItem();
            cuadradoToolStripMenuItem = new ToolStripMenuItem();
            rectanguloToolStripMenuItem = new ToolStripMenuItem();
            romboToolStripMenuItem = new ToolStripMenuItem();
            romboideToolStripMenuItem = new ToolStripMenuItem();
            trapecioToolStripMenuItem = new ToolStripMenuItem();
            trapezoideToolStripMenuItem = new ToolStripMenuItem();
            circuloToolStripMenuItem = new ToolStripMenuItem();
            circuloToolStripMenuItem1 = new ToolStripMenuItem();
            elipseToolStripMenuItem = new ToolStripMenuItem();
            triangulosToolStripMenuItem = new ToolStripMenuItem();
            trianguloToolStripMenuItem = new ToolStripMenuItem();
            poligonosRegularesToolStripMenuItem = new ToolStripMenuItem();
            poligonosToolStripMenuItem = new ToolStripMenuItem();
            dibujoToolStripMenuItem = new ToolStripMenuItem();
            lineasToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { cuadrangulosToolStripMenuItem, circuloToolStripMenuItem, triangulosToolStripMenuItem, poligonosRegularesToolStripMenuItem, dibujoToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // cuadrangulosToolStripMenuItem
            // 
            cuadrangulosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { cuadradoToolStripMenuItem, rectanguloToolStripMenuItem, romboToolStripMenuItem, romboideToolStripMenuItem, trapecioToolStripMenuItem, trapezoideToolStripMenuItem });
            cuadrangulosToolStripMenuItem.Name = "cuadrangulosToolStripMenuItem";
            cuadrangulosToolStripMenuItem.Size = new Size(93, 20);
            cuadrangulosToolStripMenuItem.Text = "Cuadrangulos";
            // 
            // cuadradoToolStripMenuItem
            // 
            cuadradoToolStripMenuItem.Name = "cuadradoToolStripMenuItem";
            cuadradoToolStripMenuItem.Size = new Size(170, 22);
            cuadradoToolStripMenuItem.Text = "Cuadrado";
            cuadradoToolStripMenuItem.Click += cuadradoToolStripMenuItem_Click;
            // 
            // rectanguloToolStripMenuItem
            // 
            rectanguloToolStripMenuItem.Name = "rectanguloToolStripMenuItem";
            rectanguloToolStripMenuItem.Size = new Size(170, 22);
            rectanguloToolStripMenuItem.Text = "Rectángulo";
            rectanguloToolStripMenuItem.Click += rectanguloToolStripMenuItem_Click;
            // 
            // romboToolStripMenuItem
            // 
            romboToolStripMenuItem.Name = "romboToolStripMenuItem";
            romboToolStripMenuItem.Size = new Size(170, 22);
            romboToolStripMenuItem.Text = "Rombo";
            romboToolStripMenuItem.Click += romboToolStripMenuItem_Click;
            // 
            // romboideToolStripMenuItem
            // 
            romboideToolStripMenuItem.Name = "romboideToolStripMenuItem";
            romboideToolStripMenuItem.Size = new Size(170, 22);
            romboideToolStripMenuItem.Text = "Romboide";
            romboideToolStripMenuItem.Click += romboideToolStripMenuItem_Click;
            // 
            // trapecioToolStripMenuItem
            // 
            trapecioToolStripMenuItem.Name = "trapecioToolStripMenuItem";
            trapecioToolStripMenuItem.Size = new Size(170, 22);
            trapecioToolStripMenuItem.Text = "Trapecio (Isóceles)";
            trapecioToolStripMenuItem.Click += trapecioToolStripMenuItem_Click;
            // 
            // trapezoideToolStripMenuItem
            // 
            trapezoideToolStripMenuItem.Name = "trapezoideToolStripMenuItem";
            trapezoideToolStripMenuItem.Size = new Size(170, 22);
            trapezoideToolStripMenuItem.Text = "Trapezoide";
            trapezoideToolStripMenuItem.Click += trapezoideToolStripMenuItem_Click;
            // 
            // circuloToolStripMenuItem
            // 
            circuloToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { circuloToolStripMenuItem1, elipseToolStripMenuItem });
            circuloToolStripMenuItem.Name = "circuloToolStripMenuItem";
            circuloToolStripMenuItem.Size = new Size(96, 20);
            circuloToolStripMenuItem.Text = "Figuras Curvas";
            // 
            // circuloToolStripMenuItem1
            // 
            circuloToolStripMenuItem1.Name = "circuloToolStripMenuItem1";
            circuloToolStripMenuItem1.Size = new Size(112, 22);
            circuloToolStripMenuItem1.Text = "Círculo";
            circuloToolStripMenuItem1.Click += circuloToolStripMenuItem1_Click;
            // 
            // elipseToolStripMenuItem
            // 
            elipseToolStripMenuItem.Name = "elipseToolStripMenuItem";
            elipseToolStripMenuItem.Size = new Size(112, 22);
            elipseToolStripMenuItem.Text = "Elipse";
            elipseToolStripMenuItem.Click += elipseToolStripMenuItem_Click;
            // 
            // triangulosToolStripMenuItem
            // 
            triangulosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { trianguloToolStripMenuItem });
            triangulosToolStripMenuItem.Name = "triangulosToolStripMenuItem";
            triangulosToolStripMenuItem.Size = new Size(73, 20);
            triangulosToolStripMenuItem.Text = "Triángulos";
            // 
            // trianguloToolStripMenuItem
            // 
            trianguloToolStripMenuItem.Name = "trianguloToolStripMenuItem";
            trianguloToolStripMenuItem.Size = new Size(180, 22);
            trianguloToolStripMenuItem.Text = "Triángulo (isóceles)";
            trianguloToolStripMenuItem.Click += trianguloToolStripMenuItem_Click;
            // 
            // poligonosRegularesToolStripMenuItem
            // 
            poligonosRegularesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { poligonosToolStripMenuItem });
            poligonosRegularesToolStripMenuItem.Name = "poligonosRegularesToolStripMenuItem";
            poligonosRegularesToolStripMenuItem.Size = new Size(126, 20);
            poligonosRegularesToolStripMenuItem.Text = "Polígonos Regulares";
            // 
            // poligonosToolStripMenuItem
            // 
            poligonosToolStripMenuItem.Name = "poligonosToolStripMenuItem";
            poligonosToolStripMenuItem.Size = new Size(127, 22);
            poligonosToolStripMenuItem.Text = "Polígonos";
            poligonosToolStripMenuItem.Click += poligonosToolStripMenuItem_Click;
            // 
            // dibujoToolStripMenuItem
            // 
            dibujoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { lineasToolStripMenuItem });
            dibujoToolStripMenuItem.Name = "dibujoToolStripMenuItem";
            dibujoToolStripMenuItem.Size = new Size(54, 20);
            dibujoToolStripMenuItem.Text = "Dibujo";
            // 
            // lineasToolStripMenuItem
            // 
            lineasToolStripMenuItem.Name = "lineasToolStripMenuItem";
            lineasToolStripMenuItem.Size = new Size(107, 22);
            lineasToolStripMenuItem.Text = "Líneas";
            lineasToolStripMenuItem.Click += lineasToolStripMenuItem_Click;
            // 
            // FrmHome
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "FrmHome";
            Text = "FormHome";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem cuadrangulosToolStripMenuItem;
        private ToolStripMenuItem cuadradoToolStripMenuItem;
        private ToolStripMenuItem rectanguloToolStripMenuItem;
        private ToolStripMenuItem circuloToolStripMenuItem;
        private ToolStripMenuItem circuloToolStripMenuItem1;
        private ToolStripMenuItem dibujoToolStripMenuItem;
        private ToolStripMenuItem lineasToolStripMenuItem;
        private ToolStripMenuItem romboToolStripMenuItem;
        private ToolStripMenuItem romboideToolStripMenuItem;
        private ToolStripMenuItem trapecioToolStripMenuItem;
        private ToolStripMenuItem trapezoideToolStripMenuItem;
        private ToolStripMenuItem elipseToolStripMenuItem;
        private ToolStripMenuItem triangulosToolStripMenuItem;
        private ToolStripMenuItem poligonosRegularesToolStripMenuItem;
        private ToolStripMenuItem poligonosToolStripMenuItem;
        private ToolStripMenuItem trianguloToolStripMenuItem;
    }
}