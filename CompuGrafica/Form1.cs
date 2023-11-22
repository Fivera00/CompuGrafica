using CompuGrafica.Clases;
using System.Windows.Forms;

namespace CompuGrafica
{
    public partial class Form1 : Form
    {

        Bitmap mapa = new Bitmap(600, 500);
        int screenSizeX = 600, screenSizeY = 500;
        Color primario = Color.FromArgb(0, 0, 0);

        public Form1()
        {
            InitializeComponent();
            ejes();
        }

        private float lagrange(float x, float xo, float xf, float yo, float yf)
        {
            if (yo == 0 && yf == 0) return 0;
            float result = (yo * ((float)(x - xf) / (xo - xf))) + (yf * ((x - xo) / (xf - xo)));
            return result;
        }

        private void ejes()
        {
            Segmento s1 = new Segmento();
            s1.x0 = -10;
            s1.y0 = 8.33;
            s1.xf = 10;
            s1.yf = 8.33;
            s1.color0 = primario;
            s1.Encender(mapa);

            Segmento s2 = new Segmento();
            s2.x0 = -10;
            s2.y0 = -8.33;
            s2.xf = -10;
            s2.yf = 8.33;
            s2.color0 = primario;
            s2.Encender(mapa);

            Segmento s3 = new Segmento();
            s3.x0 = -10;
            s3.y0 = -8.33;
            s3.xf = 10;
            s3.yf = -8.33;
            s3.color0 = primario;
            s3.Encender(mapa);

            Segmento s4 = new Segmento();
            s4.x0 = 9.99;
            s4.y0 = 8.33;
            s4.xf = 9.99;
            s4.yf = -8.33;
            s4.color0 = primario;
            s4.Encender(mapa);

            Segmento s5 = new Segmento();
            s5.x0 = 0;
            s5.y0 = 8.33;
            s5.xf = 0;
            s5.yf = -8.33;
            s5.color0 = primario;
            s5.Encender(mapa);

            Segmento s6 = new Segmento();
            s6.x0 = -10;
            s6.y0 = 0;
            s6.xf = 10;
            s6.yf = 0;
            s6.color0 = primario;
            s6.Encender(mapa);
            canvas.Image = mapa;
        }

        private void encender_pixel_Click(object sender, EventArgs e)
        {
            mapa.SetPixel(screenSizeX / 2, screenSizeY / 2, Color.White);
            canvas.Image = mapa;
        }

        private void generar_letra_Click(object sender, EventArgs e)
        {
            int centerX = screenSizeX / 2;
            int centerY = screenSizeY / 2;

            // Dibuja la parte vertical de la "F"
            for (int y = centerY - 100; y <= centerY + 100; y++)
            {
                mapa.SetPixel(centerX, y, primario);
            }

            // Dibuja la parte horizontal superior de la "F"
            for (int x = centerX; x <= centerX + 150; x++)
            {
                mapa.SetPixel(x, centerY - 100, primario);
            }

            // Dibuja la parte horizontal de la mitad de la "F"
            for (int x = centerX; x <= centerX + 100; x++)
            {
                mapa.SetPixel(x, centerY, primario);
            }

            canvas.Image = mapa;
        }

        private void limpiar_pantalla_Click(object sender, EventArgs e)
        {
            mapa = new Bitmap(600, 500);
            canvas.Image = null;
            ejes();
        }

        private void bandera_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 600; i++)
                for (int j = 0; j < 500; j++)
                    if (i <= 300)
                        mapa.SetPixel(i, j, Color.Blue);
                    else
                        mapa.SetPixel(i, j, Color.Green);


            canvas.Image = mapa;
        }

        private void degradado_bandera_Click(object sender, EventArgs e)
        {
            int r, g, b;
            int red1 = 0, green1 = 0, blue1 = 255;
            int red2 = 0, green2 = 255, blue2 = 0;

            for (int i = 0; i < 600; i++)
            {
                r = (int)lagrange(i, 0, 600, red1, red2);
                g = (int)lagrange(i, 0, 600, green1, green2);
                b = (int)lagrange(i, 0, 600, blue1, blue2);
                for (int j = 0; j < 500; j++)
                {
                    mapa.SetPixel(i, j, Color.FromArgb(r, g, b));
                }
            }

            canvas.Image = mapa;
        }

        private void practica_degradado_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 600; i++)
            {
                int r = (-(13 * i) / 100) + 182;
                int g = (-(43 * i) / 200) + 255;
                int b = (i / 120) + 250;
                for (int j = 0; j < 500; j++)
                {
                    mapa.SetPixel(i, j, Color.FromArgb(r, g, b));
                }
            }

            canvas.Image = mapa;
        }

        private void circuferencias_Click(object sender, EventArgs e)
        {
            Circunferencia c = new Circunferencia();
            c.rd = 3;
            c.x0 = -2;
            c.y0 = -1;
            c.color0 = Color.Red;
            c.Encender(mapa);

            Circunferencia c1 = new Circunferencia();
            c1.rd = 2;
            c1.x0 = 6;
            c1.y0 = 4;
            c1.color0 = Color.Blue;
            c1.Encender(mapa);


            canvas.Image = mapa;
        }

        private void practica_seg_cir_Click(object sender, EventArgs e)
        {
            Segmento s = new Segmento();
            s.x0 = -10;
            s.y0 = -2;
            s.xf = 6;
            s.yf = 4;
            s.color0 = primario;
            s.Encender(mapa);

            Segmento s2 = new Segmento();
            s2.x0 = 6;
            s2.y0 = 4;
            s2.xf = 6;
            s2.yf = -4;
            s2.color0 = primario;
            s2.Encender(mapa);

            Segmento s3 = new Segmento();
            s3.x0 = 6;
            s3.y0 = -4;
            s3.xf = 10;
            s3.yf = 5;
            s3.color0 = primario;
            s3.Encender(mapa);

            Circunferencia c = new Circunferencia();
            c.rd = 3;
            c.x0 = -2;
            c.y0 = -1;
            c.color0 = Color.Red;
            c.Encender(mapa);

            Circunferencia c1 = new Circunferencia();
            c1.rd = 2;
            c1.x0 = 6;
            c1.y0 = 4;
            c1.color0 = Color.Blue;
            c1.Encender(mapa);

            Circunferencia c2 = new Circunferencia();
            c2.rd = 2;
            c2.x0 = -2;
            c2.y0 = -1;
            c2.color0 = Color.Green;
            c2.Encender(mapa);

            canvas.Image = mapa;
        }

        private void color_1_Click(object sender, EventArgs e)
        {
            int r, g, b;
            int red1 = 182, green1 = 255, blue1 = 250;
            int red2 = 104, green2 = 126, blue2 = 255;

            for (int i = 0; i < 600; i++)
            {
                r = (int)lagrange(i, 0, 600, red1, red2);
                g = (int)lagrange(i, 0, 600, green1, green2);
                b = (int)lagrange(i, 0, 600, blue1, blue2);
                for (int j = 0; j < 500; j++)
                {
                    mapa.SetPixel(i, j, Color.FromArgb(r, g, b));
                }
            }

            canvas.Image = mapa;
        }

        private void color_2_Click(object sender, EventArgs e)
        {
            int r, g, b;
            int red1 = 252, green1 = 233, blue1 = 30;
            int red2 = 104, green2 = 126, blue2 = 255;

            for (int i = 0; i < 600; i++)
            {
                r = (int)lagrange(i, 0, 600, red1, red2);
                g = (int)lagrange(i, 0, 600, green1, green2);
                b = (int)lagrange(i, 0, 600, blue1, blue2);
                for (int j = 0; j < 500; j++)
                {
                    mapa.SetPixel(i, j, Color.FromArgb(r, g, b));
                }
            }

            canvas.Image = mapa;
        }

        private void color_3_Click(object sender, EventArgs e)
        {

            int red1 = 252, green1 = 233, blue1 = 30;
            int red2 = 104, green2 = 126, blue2 = 255;
            int red3 = 182, green3 = 255, blue3 = 250;


            for (int i = 0; i < 600; i++)
            {
                for (int j = 0; j < 500; j++)
                {
                    int diagonal = (int)lagrange(i, 0, 600, 0, 500);
                    if (j > diagonal) mapa.SetPixel(i, j, Color.FromArgb((int)lagrange(i, 0, 600, red1, red2), (int)lagrange(i, 0, 600, green1, green2), (int)lagrange(i, 0, 600, blue1, blue2)));
                    else mapa.SetPixel(i, j, Color.FromArgb((int)lagrange(i, 0, 600, red3, red2), (int)lagrange(i, 0, 600, green3, green2), (int)lagrange(i, 0, 600, blue3, blue2)));

                }
            }

            canvas.Image = mapa;
        }

        private void tipo_1_Click(object sender, EventArgs e)
        {
            CurvaV curva1 = new CurvaV();
            curva1.tipo = 0;
            curva1.rd = 2;
            curva1.x0 = 3;
            curva1.y0 = -1;
            curva1.color0 = Color.Green;
            curva1.Encender(mapa);

            canvas.Image = mapa;

        }

        private void tipo_2_Click(object sender, EventArgs e)
        {
            CurvaV curva2 = new CurvaV();
            curva2.tipo = 1;
            curva2.rd = 2;
            curva2.x0 = 3;
            curva2.y0 = -1;
            curva2.color0 = Color.Blue;
            curva2.Encender(mapa);

            canvas.Image = mapa;
        }

        private void tipo_3_Click(object sender, EventArgs e)
        {
            CurvaV curva3 = new CurvaV();
            curva3.tipo = 2;
            curva3.rd = 2;
            curva3.x0 = 3;
            curva3.y0 = -1;
            curva3.color0 = Color.Red;
            curva3.Encender(mapa);

            canvas.Image = mapa;
        }

        private void tipo_4_Click(object sender, EventArgs e)
        {
            CurvaV curva1 = new CurvaV();
            curva1.tipo = 3;
            curva1.rd = 4;
            curva1.x0 = 0;
            curva1.y0 = 0;
            curva1.color0 = Color.Green;
            curva1.Encender(mapa);

            CurvaV curva2 = new CurvaV();
            curva2.tipo = 3;
            curva2.rd = 2;
            curva2.x0 = -7;
            curva2.y0 = 5;
            curva2.color0 = Color.Red;
            curva2.Encender(mapa);

            CurvaV curva3 = new CurvaV();
            curva3.tipo = 3;
            curva3.rd = 1;
            curva3.x0 = 6;
            curva3.y0 = -2;
            curva3.color0 = Color.Blue;
            curva3.Encender(mapa);

            canvas.Image = mapa;
        }

        private void curvas_todas_Click(object sender, EventArgs e)
        {
            CurvaV curva1 = new CurvaV();
            curva1.tipo = 0;
            curva1.rd = 2;
            curva1.x0 = -5;
            curva1.y0 = 5;
            curva1.color0 = Color.Green;
            curva1.Encender(mapa);

            CurvaV curva2 = new CurvaV();
            curva2.tipo = 1;
            curva2.rd = 3;
            curva2.x0 = 3;
            curva2.y0 = -5;
            curva2.color0 = Color.Blue;
            curva2.Encender(mapa);

            CurvaV curva3 = new CurvaV();
            curva3.tipo = 2;
            curva3.rd = 2;
            curva3.x0 = 0;
            curva3.y0 = 0;
            curva3.color0 = Color.Red;
            curva3.Encender(mapa);

            CurvaV curva4 = new CurvaV();
            curva4.tipo = 3;
            curva4.rd = 1;
            curva4.x0 = 6;
            curva4.y0 = -2;
            curva4.color0 = Color.Blue;
            curva4.Encender(mapa);
            canvas.Image = mapa;
        }

        private void ejes_xy_Click(object sender, EventArgs e)
        {
            ejes();
        }

        private void parabola_Click(object sender, EventArgs e)
        {
            CurvaV curva4 = new CurvaV();
            curva4.tipo = 6;
            curva4.color0 = Color.Blue;
            curva4.Encender(mapa);
            canvas.Image = mapa;
        }

        private void taylor_Click(object sender, EventArgs e)
        {
            Polinomio pl = new Polinomio();
            pl.color0 = Color.Blue;
            pl.Encender(mapa);
            canvas.Image = mapa;
        }
    }
}
