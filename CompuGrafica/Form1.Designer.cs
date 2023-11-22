namespace CompuGrafica
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            parcialIToolStripMenuItem = new ToolStripMenuItem();
            pixelToolStripMenuItem = new ToolStripMenuItem();
            encender_pixel = new ToolStripMenuItem();
            generar_letra = new ToolStripMenuItem();
            colorToolStripMenuItem = new ToolStripMenuItem();
            bandera = new ToolStripMenuItem();
            degradado_bandera = new ToolStripMenuItem();
            practica_degradado = new ToolStripMenuItem();
            segmentoToolStripMenuItem = new ToolStripMenuItem();
            circuferencias = new ToolStripMenuItem();
            practica_seg_cir = new ToolStripMenuItem();
            leccion1PToolStripMenuItem = new ToolStripMenuItem();
            color_1 = new ToolStripMenuItem();
            color_2 = new ToolStripMenuItem();
            color_3 = new ToolStripMenuItem();
            curvasToolStripMenuItem = new ToolStripMenuItem();
            tipo_1 = new ToolStripMenuItem();
            tipo_2 = new ToolStripMenuItem();
            tipo_3 = new ToolStripMenuItem();
            tipo_4 = new ToolStripMenuItem();
            curvas_todas = new ToolStripMenuItem();
            parabola = new ToolStripMenuItem();
            parcialIIToolStripMenuItem = new ToolStripMenuItem();
            parcialIIIToolStripMenuItem = new ToolStripMenuItem();
            limpiar_pantalla = new ToolStripMenuItem();
            ejes_xy = new ToolStripMenuItem();
            canvas = new PictureBox();
            aproximacionToolStripMenuItem = new ToolStripMenuItem();
            taylor = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)canvas).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { parcialIToolStripMenuItem, parcialIIToolStripMenuItem, parcialIIIToolStripMenuItem, limpiar_pantalla, ejes_xy });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(732, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // parcialIToolStripMenuItem
            // 
            parcialIToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { pixelToolStripMenuItem, colorToolStripMenuItem, segmentoToolStripMenuItem, leccion1PToolStripMenuItem, curvasToolStripMenuItem, aproximacionToolStripMenuItem });
            parcialIToolStripMenuItem.Name = "parcialIToolStripMenuItem";
            parcialIToolStripMenuItem.Size = new Size(60, 20);
            parcialIToolStripMenuItem.Text = "Parcial I";
            // 
            // pixelToolStripMenuItem
            // 
            pixelToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { encender_pixel, generar_letra });
            pixelToolStripMenuItem.Name = "pixelToolStripMenuItem";
            pixelToolStripMenuItem.Size = new Size(180, 22);
            pixelToolStripMenuItem.Text = "Pixel";
            // 
            // encender_pixel
            // 
            encender_pixel.Name = "encender_pixel";
            encender_pixel.Size = new Size(151, 22);
            encender_pixel.Text = "Encender Pixel";
            encender_pixel.Click += encender_pixel_Click;
            // 
            // generar_letra
            // 
            generar_letra.Name = "generar_letra";
            generar_letra.Size = new Size(151, 22);
            generar_letra.Text = "Generar Letra";
            generar_letra.Click += generar_letra_Click;
            // 
            // colorToolStripMenuItem
            // 
            colorToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { bandera, degradado_bandera, practica_degradado });
            colorToolStripMenuItem.Name = "colorToolStripMenuItem";
            colorToolStripMenuItem.Size = new Size(180, 22);
            colorToolStripMenuItem.Text = "Color";
            // 
            // bandera
            // 
            bandera.Name = "bandera";
            bandera.Size = new Size(177, 22);
            bandera.Text = "Bandera";
            bandera.Click += bandera_Click;
            // 
            // degradado_bandera
            // 
            degradado_bandera.Name = "degradado_bandera";
            degradado_bandera.Size = new Size(177, 22);
            degradado_bandera.Text = "Degradado";
            degradado_bandera.Click += degradado_bandera_Click;
            // 
            // practica_degradado
            // 
            practica_degradado.Name = "practica_degradado";
            practica_degradado.Size = new Size(177, 22);
            practica_degradado.Text = "Practica Degragado";
            practica_degradado.Click += practica_degradado_Click;
            // 
            // segmentoToolStripMenuItem
            // 
            segmentoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { circuferencias, practica_seg_cir });
            segmentoToolStripMenuItem.Name = "segmentoToolStripMenuItem";
            segmentoToolStripMenuItem.Size = new Size(180, 22);
            segmentoToolStripMenuItem.Text = "Segmento";
            // 
            // circuferencias
            // 
            circuferencias.Name = "circuferencias";
            circuferencias.Size = new Size(149, 22);
            circuferencias.Text = "Circuferencias";
            circuferencias.Click += circuferencias_Click;
            // 
            // practica_seg_cir
            // 
            practica_seg_cir.Name = "practica_seg_cir";
            practica_seg_cir.Size = new Size(149, 22);
            practica_seg_cir.Text = "Practica";
            practica_seg_cir.Click += practica_seg_cir_Click;
            // 
            // leccion1PToolStripMenuItem
            // 
            leccion1PToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { color_1, color_2, color_3 });
            leccion1PToolStripMenuItem.Name = "leccion1PToolStripMenuItem";
            leccion1PToolStripMenuItem.Size = new Size(180, 22);
            leccion1PToolStripMenuItem.Text = "Leccion1P";
            // 
            // color_1
            // 
            color_1.Name = "color_1";
            color_1.Size = new Size(112, 22);
            color_1.Text = "Color 1";
            color_1.Click += color_1_Click;
            // 
            // color_2
            // 
            color_2.Name = "color_2";
            color_2.Size = new Size(112, 22);
            color_2.Text = "Color 2";
            color_2.Click += color_2_Click;
            // 
            // color_3
            // 
            color_3.Name = "color_3";
            color_3.Size = new Size(112, 22);
            color_3.Text = "Color 3";
            color_3.Click += color_3_Click;
            // 
            // curvasToolStripMenuItem
            // 
            curvasToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { tipo_1, tipo_2, tipo_3, tipo_4, curvas_todas, parabola });
            curvasToolStripMenuItem.Name = "curvasToolStripMenuItem";
            curvasToolStripMenuItem.Size = new Size(180, 22);
            curvasToolStripMenuItem.Text = "Curvas";
            // 
            // tipo_1
            // 
            tipo_1.Name = "tipo_1";
            tipo_1.Size = new Size(180, 22);
            tipo_1.Text = "Tipo 1";
            tipo_1.Click += tipo_1_Click;
            // 
            // tipo_2
            // 
            tipo_2.Name = "tipo_2";
            tipo_2.Size = new Size(180, 22);
            tipo_2.Text = "Tipo 2";
            tipo_2.Click += tipo_2_Click;
            // 
            // tipo_3
            // 
            tipo_3.Name = "tipo_3";
            tipo_3.Size = new Size(180, 22);
            tipo_3.Text = "Tipo 3";
            tipo_3.Click += tipo_3_Click;
            // 
            // tipo_4
            // 
            tipo_4.Name = "tipo_4";
            tipo_4.Size = new Size(180, 22);
            tipo_4.Text = "Tipo 4";
            tipo_4.Click += tipo_4_Click;
            // 
            // curvas_todas
            // 
            curvas_todas.Name = "curvas_todas";
            curvas_todas.Size = new Size(180, 22);
            curvas_todas.Text = "Todas";
            curvas_todas.Click += curvas_todas_Click;
            // 
            // parabola
            // 
            parabola.Name = "parabola";
            parabola.Size = new Size(180, 22);
            parabola.Text = "Parabola";
            parabola.Click += parabola_Click;
            // 
            // parcialIIToolStripMenuItem
            // 
            parcialIIToolStripMenuItem.Name = "parcialIIToolStripMenuItem";
            parcialIIToolStripMenuItem.Size = new Size(63, 20);
            parcialIIToolStripMenuItem.Text = "Parcial II";
            // 
            // parcialIIIToolStripMenuItem
            // 
            parcialIIIToolStripMenuItem.Name = "parcialIIIToolStripMenuItem";
            parcialIIIToolStripMenuItem.Size = new Size(66, 20);
            parcialIIIToolStripMenuItem.Text = "Parcial III";
            // 
            // limpiar_pantalla
            // 
            limpiar_pantalla.Name = "limpiar_pantalla";
            limpiar_pantalla.Size = new Size(104, 20);
            limpiar_pantalla.Text = "Limpiar Pantalla";
            limpiar_pantalla.Click += limpiar_pantalla_Click;
            // 
            // ejes_xy
            // 
            ejes_xy.Name = "ejes_xy";
            ejes_xy.Size = new Size(56, 20);
            ejes_xy.Text = "Ejes XY";
            ejes_xy.Click += ejes_xy_Click;
            // 
            // canvas
            // 
            canvas.Location = new Point(72, 37);
            canvas.Name = "canvas";
            canvas.Size = new Size(620, 520);
            canvas.TabIndex = 1;
            canvas.TabStop = false;
            // 
            // aproximacionToolStripMenuItem
            // 
            aproximacionToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { taylor });
            aproximacionToolStripMenuItem.Name = "aproximacionToolStripMenuItem";
            aproximacionToolStripMenuItem.Size = new Size(180, 22);
            aproximacionToolStripMenuItem.Text = "Aproximacion";
            // 
            // taylor
            // 
            taylor.Name = "taylor";
            taylor.Size = new Size(180, 22);
            taylor.Text = "Taylor";
            taylor.Click += taylor_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(732, 563);
            Controls.Add(canvas);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Michael Figueroa - 6441";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)canvas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem parcialIToolStripMenuItem;
        private ToolStripMenuItem pixelToolStripMenuItem;
        private ToolStripMenuItem encender_pixel;
        private ToolStripMenuItem parcialIIToolStripMenuItem;
        private ToolStripMenuItem parcialIIIToolStripMenuItem;
        private ToolStripMenuItem limpiar_pantalla;
        private ToolStripMenuItem generar_letra;
        private ToolStripMenuItem colorToolStripMenuItem;
        private ToolStripMenuItem bandera;
        private ToolStripMenuItem degradado_bandera;
        private ToolStripMenuItem practica_degradado;
        private ToolStripMenuItem segmentoToolStripMenuItem;
        private ToolStripMenuItem circuferencias;
        private ToolStripMenuItem practica_seg_cir;
        private PictureBox canvas;
        private ToolStripMenuItem leccion1PToolStripMenuItem;
        private ToolStripMenuItem color_1;
        private ToolStripMenuItem color_2;
        private ToolStripMenuItem color_3;
        private ToolStripMenuItem curvasToolStripMenuItem;
        private ToolStripMenuItem tipo_1;
        private ToolStripMenuItem tipo_2;
        private ToolStripMenuItem tipo_3;
        private ToolStripMenuItem curvas_todas;
        private ToolStripMenuItem tipo_4;
        private ToolStripMenuItem ejes_xy;
        private ToolStripMenuItem parabola;
        private ToolStripMenuItem aproximacionToolStripMenuItem;
        private ToolStripMenuItem taylor;
    }
}