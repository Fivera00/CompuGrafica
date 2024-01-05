using CompuGrafica.Clases;
using System.Drawing;
using System.Security.Cryptography.Xml;
using System.Windows.Forms;

namespace CompuGrafica
{
    public partial class Form1 : Form
    {

        Bitmap mapa = new Bitmap(600, 500);
        int screenSizeX = 600, screenSizeY = 500;
        Color primario = Color.FromArgb(0, 0, 0);
        Color[] paleta0 = new Color[16];

        Color[] paletaFuego = new Color[16];

        Color[] paleta1 = new Color[16];

        public Form1()
        {
            InitializeComponent();
            marco();
            ejes3D();

            paleta0[0] = Color.Black;
            paleta0[1] = Color.Navy;
            paleta0[2] = Color.Green;
            paleta0[3] = Color.Aqua;
            paleta0[4] = Color.Red;
            paleta0[5] = Color.Purple;
            paleta0[6] = Color.Maroon;
            paleta0[7] = Color.LightGray;
            paleta0[8] = Color.DarkGray;
            paleta0[9] = Color.Blue;
            paleta0[10] = Color.Lime;
            paleta0[11] = Color.Silver;
            paleta0[12] = Color.Teal;
            paleta0[13] = Color.Fuchsia;
            paleta0[14] = Color.Yellow;
            paleta0[15] = Color.White;

            paleta1[0] = Color.Beige;
            paleta1[1] = Color.BlueViolet;
            paleta1[2] = Color.CadetBlue;
            paleta1[3] = Color.Cyan;
            paleta1[4] = Color.Red;
            paleta1[5] = Color.DarkOrange;
            paleta1[6] = Color.Magenta;
            paleta1[7] = Color.Indigo;
            paleta1[8] = Color.Pink;
            paleta1[9] = Color.Turquoise;
            paleta1[10] = Color.Teal;
            paleta1[11] = Color.Olive;
            paleta1[12] = Color.Purple;
            paleta1[13] = Color.Fuchsia;
            paleta1[14] = Color.Silver;
            paleta1[15] = Color.White;


        }

        private float lagrange(float x, float xo, float xf, float yo, float yf)
        {
            if (yo == 0 && yf == 0) return 0;
            float result = (yo * ((float)(x - xf) / (xo - xf))) + (yf * ((x - xo) / (xf - xo)));
            return result;
        }

        private void marco()
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

            canvas.Image = mapa;
        }

        private void ejes3D()
        {
            /*Segmento3D seg3D1 = new()
            {
                x0 = 0,
                y0 = 0,
                z0 = 0,
                xf = 0,
                yf = 0,
                zf = 5,
                color0 = Color.Red
            };

            //EJE Y 
            Segmento3D seg3D2 = new()
            {
                x0 = 0,
                y0 = 0,
                z0 = 0,
                xf = 0,
                yf = 5,
                zf = 0,
                color0 = Color.Blue
            };

            //EJE X 
            Segmento3D seg3D3 = new()
            {
                x0 = 0,
                y0 = 0,
                z0 = 0,
                xf = 8,
                yf = 0,
                zf = 0,
                color0 = Color.Black
            };

            //EJE 4
            Segmento3D seg3D4 = new()
            {
                x0 = 8,
                y0 = 0,
                z0 = 0,
                xf = 8,
                yf = 5,
                zf = 0,
                color0 = Color.Blue
            };

            //EJE 5
            Segmento3D seg3D5 = new()
            {
                x0 = 0,
                y0 = 5,
                z0 = 0,
                xf = 8,
                yf = 5,
                zf = 0,
                color0 = Color.Red
            };

            //EJE 6 
            Segmento3D seg3D6 = new()
            {
                x0 = 0,
                y0 = 5,
                z0 = 5,
                xf = 0,
                yf = 5,
                zf = 0,
                color0 = Color.Red
            };

            //EJE 7 
            Segmento3D seg3D7 = new()
            {
                x0 = 0,
                y0 = 0,
                z0 = 5,
                xf = 0,
                yf = 5,
                zf = 5,
                color0 = Color.Red
            };

            //EJE 8 
            Segmento3D seg3D8 = new()
            {
                x0 = 0,
                y0 = 0,
                z0 = 5,
                xf = 8,
                yf = 0,
                zf = 5,
                color0 = Color.Red
            };

            //EJE 9
            Segmento3D seg3D9 = new()
            {
                x0 = 8,
                y0 = 0,
                z0 = 0,
                xf = 8,
                yf = 0,
                zf = 5,
                color0 = Color.Red
            };


            seg3D1.Encender(mapa);
            seg3D2.Encender(mapa);
            seg3D3.Encender(mapa);
            seg3D4.Encender(mapa);
            seg3D5.Encender(mapa);
            seg3D6.Encender(mapa);
            seg3D7.Encender(mapa);
            seg3D8.Encender(mapa);
            seg3D9.Encender(mapa);
            */

            
            Segmento3D xyz = new Segmento3D();

            //EJE Z1 -> Vertical
            xyz.color0 = Color.Black;
            xyz.x0 = -9; xyz.xf = -9;
            xyz.y0 = 0; xyz.yf = 0;
            xyz.z0 = -7; xyz.zf = 3;
            xyz.Encender(mapa);

            //EJE Z2 -> Vertical
            xyz.color0 = Color.Black;
            xyz.x0 = 1; xyz.xf = 1;
            xyz.y0 = 0; xyz.yf = 0;
            xyz.z0 = -7; xyz.zf = 3;
            xyz.Encender(mapa);

            //EJE Z3 -> Vertical
            xyz.color0 = Color.Black;
            xyz.x0 = 4.12; xyz.xf = 4.12;
            xyz.y0 = 5; xyz.yf = 5;
            xyz.z0 = -3.8; xyz.zf = 6.2;
            xyz.Encender(mapa);
            //EJE Z4 -> Vertical
            xyz.color0 = Color.Black;
            xyz.x0 = -5.9; xyz.xf = -5.9;
            xyz.y0 = 5; xyz.yf = 5;
            xyz.z0 = -3.8; xyz.zf = 6.2;
            xyz.Encender(mapa);

            //EJE Y1 -> Diagonal
            xyz.color0 = Color.Blue;
            xyz.x0 = -9; xyz.xf = -9;
            xyz.y0 = 0; xyz.yf = 14;
            xyz.z0 = -7; xyz.zf = -7;
            xyz.Encender(mapa);
            //EJE Y2 -> Diagonal
            xyz.color0 = Color.Blue;
            xyz.x0 = 1; xyz.xf = 1;
            xyz.y0 = 0; xyz.yf = 14;
            xyz.z0 = -7; xyz.zf = -7;
            xyz.Encender(mapa);
            //EJE Y3 -> Diagonal
            xyz.color0 = Color.Blue;
            xyz.x0 = -9; xyz.xf = -9;
            xyz.y0 = 0; xyz.yf = 14;
            xyz.z0 = 3; xyz.zf = 3;
            xyz.Encender(mapa);
            //EJE Y4 -> Diagonal
            xyz.color0 = Color.Blue;
            xyz.x0 = 1; xyz.xf = 1;
            xyz.y0 = 0; xyz.yf = 14;
            xyz.z0 = 3; xyz.zf = 3;
            xyz.Encender(mapa);

            //EJE X1 -> Horizontal
            xyz.color0 = Color.Red;
            xyz.x0 = -9; xyz.xf = 1;
            xyz.y0 = 0; xyz.yf = 0;
            xyz.z0 = -7; xyz.zf = -7;
            xyz.Encender(mapa);
            //EJE X2 -> Horizontal
            xyz.color0 = Color.Red;
            xyz.x0 = -9; xyz.xf = 1;
            xyz.y0 = 0; xyz.yf = 0;
            xyz.z0 = 3; xyz.zf = 3;
            xyz.Encender(mapa);
            //EJE X3 -> Horizontal
            xyz.color0 = Color.Red;
            xyz.x0 = -9; xyz.xf = 1;
            xyz.y0 = 14; xyz.yf = 14;
            xyz.z0 = 3; xyz.zf = 3;
            xyz.Encender(mapa);
            //EJE X4 -> Horizontal
            xyz.color0 = Color.Red;
            xyz.x0 = -9; xyz.xf = 1;
            xyz.y0 = 14; xyz.yf = 14;
            xyz.z0 = -7; xyz.zf = -7;
            xyz.Encender(mapa);

            canvas.Image = mapa;
        }

        private void ejes()
        {
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
            marco();
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

        private void practica_curvas_Click(object sender, EventArgs e)
        {
            CurvaV c = new CurvaV();
            c.tipo = 6;
            c.color0 = Color.Blue;
            c.Encender(mapa);
            canvas.Image = mapa;
        }

        private void taylor_Click(object sender, EventArgs e)
        {
            Polinomio pl = new Polinomio();
            pl.Encender(mapa);
            canvas.Image = mapa;
        }

        private void practica_parabola_Click(object sender, EventArgs e)
        {
            Vector vec = new Vector();
            double x = -10, dx = 0.001;
            do
            {
                vec.x0 = x;
                vec.y0 = ((-0.03) * Math.Pow(x, 2)) + 3;
                vec.color0 = paleta0[2];
                vec.Encender(mapa);
                x += dx;
            } while (x < 10);

            trazarTangente(3, paleta0[4]);
            trazarTangente(-5, paleta0[4]);
            trazarTangente(8, paleta0[4]);

            canvas.Image = mapa;
        }

        private void trazarTangente(double a, Color color)
        {
            double xa = a;
            double ya = ((-0.03) * Math.Pow(xa, 2)) + 3;
            double m = -0.06 * xa;

            Segmento s = new Segmento();
            s.x0 = -10;
            s.y0 = m * (s.x0 - xa) + ya;
            s.xf = 10;
            s.yf = m * (s.xf - xa) + ya;
            s.color0 = color;
            s.Encender(mapa);

        }

        private void practica1_tapete_Click(object sender, EventArgs e)
        {
            int colorT;
            Color c;
            for (int i = 0; i < 600; i++)
            {
                for (int j = 0; j < 500; j++)
                {
                    colorT = ((i * i) + (j * j)) % 15;

                    //c = paleta0[colorT];
                    c = paleta1[colorT];
                    mapa.SetPixel(i, j, c);
                }

            }
            canvas.Image = mapa;
        }

        private void practica2_tapete_Click(object sender, EventArgs e)
        {
            int colorT;
            Color c;
            for (int i = 0; i < 600; i++)
            {
                for (int j = 0; j < 500; j++)
                {
                    colorT = (((i + j) / 2) * (j * i)) % 15;

                    //c = paleta0[colorT];
                    c = paleta1[colorT];
                    mapa.SetPixel(i, j, c);
                }

            }
            canvas.Image = mapa;
        }

        private void tapete0_Click(object sender, EventArgs e)
        {
            int colorT;
            Color c;
            for (int i = 0; i < 600; i++)
            {
                for (int j = 0; j < 500; j++)
                {
                    colorT = Math.Abs((int)(Math.Cos(i) + (j * j)) % 15);

                    c = paleta0[colorT];
                    mapa.SetPixel(i, j, c);
                }

            }
            canvas.Image = mapa;
        }

        private void tapete1_Click(object sender, EventArgs e)
        {
            int colorT;
            Color c;
            for (int i = 0; i < 600; i++)
            {
                for (int j = 0; j < 500; j++)
                {
                    colorT = Math.Abs((int)(Math.Sqrt(j * j + i * i)) % 15);

                    c = paleta0[colorT];
                    mapa.SetPixel(i, j, c);
                }

            }
            canvas.Image = mapa;
        }

        private void tapete2_Click(object sender, EventArgs e)
        {
            int colorT;
            Color c;
            Color[] paleta = new Color[16];

            for (int i = 0; i < 15; i++)
            {
                int r = (int)(4.666666 * i) + 130;
                int g = (2 * i) + 70;
                int b = (int)(1.33333 * i) + 30;

                paleta[i] = Color.FromArgb(r, g, b);
            }

            for (int i = 0; i < 600; i++)
            {
                for (int j = 0; j < 500; j++)
                {
                    colorT = (int)((Math.Sqrt(i + 50.5) + Math.Cos(i) + 10 * j) / 2.3) % 15;

                    c = paleta[colorT];
                    //c = paleta1[colorT];
                    mapa.SetPixel(i, j, c);
                }

            }
            canvas.Image = mapa;
        }

        private void tapete3_Click(object sender, EventArgs e)
        {
            int colorT;
            Color c;
            for (int i = 0; i < 600; i++)
            {
                for (int j = 0; j < 500; j++)
                {
                    colorT = Math.Abs((int)(Math.Sin(i / 10) + 4 * Math.Sin(j * 3.375)) % 15);

                    c = paleta0[colorT];
                    mapa.SetPixel(i, j, c);
                }

            }
            canvas.Image = mapa;
        }

        private void tapete4_Click(object sender, EventArgs e)
        {
            int colorT;
            Color c;
            for (int i = 0; i < 600; i++)
            {
                for (int j = 0; j < 500; j++)
                {
                    colorT = Math.Abs((int)(i * Math.Pow(j, 2) + Math.Pow(i, 2) - j) % 15);

                    c = paleta0[colorT];
                    mapa.SetPixel(i, j, c);
                }

            }
            canvas.Image = mapa;
        }

        private void tapete5_Click(object sender, EventArgs e)
        {
            int colorT;
            Color c;
            for (int i = 0; i < 600; i++)
            {
                for (int j = 0; j < 500; j++)
                {
                    colorT = Math.Abs((int)(Math.Sin(i * j) + 3 * Math.Sin(j * 3.1111 + Math.Sqrt(i))) % 15);

                    c = paleta0[colorT];
                    mapa.SetPixel(i, j, c);
                }

            }
            canvas.Image = mapa;
        }

        private void tapete6_Click(object sender, EventArgs e)
        {
            int colorT;
            Color c;
            for (int i = 0; i < 600; i++)
            {
                for (int j = 0; j < 500; j++)
                {
                    colorT = Math.Abs((int)(Math.Sin(i * j) + 3 * Math.Sin(j * 3.3333 + Math.Sqrt(i))) % 15);

                    c = paleta0[colorT];
                    mapa.SetPixel(i, j, c);
                }

            }
            canvas.Image = mapa;
        }

        private void tapete7_Click(object sender, EventArgs e)
        {
            int colorT;
            Color c;
            for (int i = 0; i < 600; i++)
            {
                for (int j = 0; j < 500; j++)
                {
                    colorT = Math.Abs((int)(Math.Sin(i * j) + 3 * Math.Sin(j * 3.14165 + Math.Sqrt(i))));

                    c = paleta0[colorT];
                    mapa.SetPixel(i, j, c);
                }

            }
            canvas.Image = mapa;
        }

        private void tapete8_Click(object sender, EventArgs e)
        {
            int colorT;
            Color c;
            for (int i = 0; i < 600; i++)
            {
                for (int j = 0; j < 500; j++)
                {
                    colorT = Math.Abs((int)(Math.Sin(i) + 3 * Math.Sin(j * i * 3.14165 + Math.Sqrt(i + j))));

                    c = paleta0[colorT];
                    mapa.SetPixel(i, j, c);
                }

            }
            canvas.Image = mapa;
        }

        private void fuego_Click(object sender, EventArgs e)
        {
            paletaFuego[0] = Color.FromArgb(236, 13, 13);
            paletaFuego[1] = Color.FromArgb(236, 107, 0);
            paletaFuego[2] = Color.FromArgb(240, 127, 32);
            paletaFuego[3] = Color.FromArgb(214, 161, 61);
            paletaFuego[4] = Color.FromArgb(244, 192, 28);
            paletaFuego[5] = Color.FromArgb(212, 193, 193);

            int colorT;
            Color c;

            for (int i = 0; i < 600; i++)
            {
                for (int j = 0; j < 500; j++)
                {
                    double flameIntensity = Math.Sin((i * 0.02) + Math.Cos(j * 0.02));
                    colorT = (int)((flameIntensity + 1) * 16 / 2) % 6;

                    c = paletaFuego[colorT];
                    mapa.SetPixel(i, j, c);
                }
            }
            canvas.Image = mapa;
        }

        private void jean_Click(object sender, EventArgs e)
        {
            Color[] paletaJean = new Color[16];

            for (int a = 0; a <= 15; a++)
            {
                paletaJean[a] = Color.FromArgb((int)(30 - (1.5 * a)), (int)(50 - (2.0 * a)), (int)(70 - (2.0 * a)));

            }

            int colorT;
            Color c;
            for (int i = 0; i < 600; i++)
            {
                for (int j = 0; j < 500; j++)
                {

                    colorT = (int)(((Math.Sin(i + Math.PI) % 16 - Math.Cos(j % 16)) + Math.Pow(i, 5)) % 16);
                    c = paletaJean[colorT];
                    mapa.SetPixel(i, j, c);
                }

            }

            canvas.Image = mapa;
        }

        private void cesped_Click(object sender, EventArgs e)
        {
            Color[] paletaCesped = new Color[16];
            int colorT;
            Color c;

            //Cargar paleta de colores
            for (int k = 0; k < 15; k++)
            {
                paletaCesped[k] = Color.FromArgb((int)(126 - (4.87 * k)), (int)(217 - (7.53 * k)), (int)(87 - (2.8 * k)));
            }

            //Dibujar textura
            for (int i = 0; i < 600; i++)
            {
                for (int j = 0; j < 500; j++)
                {
                    colorT = (int)((Math.Pow(i / 4, 3) + Math.Pow(j / 2.5, 2)) % 15 + 1) * (int)((Math.Sqrt(Math.Pow(i * 3.7, 2) + Math.Pow(j * 3.7, 2))) + (i * i * 4 + j + j * 2.7)) % 15;
                    c = paletaCesped[colorT];
                    mapa.SetPixel(i, j, c);
                }
            }

            canvas.Image = mapa;
        }

        private void madera_Click(object sender, EventArgs e)
        {
            Color[] paletaMadera = new Color[16];
            int colorT;
            Color c;

            for (int x = 0; x < 16; x++)
            {
                int r = (int)(4.66 * x + 130);
                int g = (int)(2 * x + 70);
                int b = (int)(1.33 * x + 30);
                paletaMadera[x] = Color.FromArgb(r, g, b);
            }

            int cs = 0;
            for (int j = 0; j < 600; j++)
            { //vertical
                for (int i = 0; i < 500; i++)
                { //horizontal
                    cs = cs + 3;
                    colorT = (int)(((j + cs)) / Math.Log(cs) % 15);
                    c = paletaMadera[colorT];
                    mapa.SetPixel(j, i, c);

                }
            }
            canvas.Image = mapa;

        }

        private async void ejercicio1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CurvaV curva2 = new CurvaV();
            curva2.tipo = 1;
            curva2.rd = 2;
            curva2.x0 = 3;
            curva2.y0 = -1;
            curva2.color0 = Color.Blue;
            curva2.Encender(mapa);

            CurvaV curva3 = new CurvaV();
            curva3.tipo = 2;
            curva3.rd = 2;
            curva3.x0 = -5;
            curva3.y0 = -1;
            curva3.color0 = Color.Red;
            curva3.Encender(mapa);

            canvas.Image = mapa;
            await Task.Delay(1000);
            curva3.Apagar(mapa);
            canvas.Image = mapa;
            await Task.Delay(1000);
            curva2.Apagar(mapa);
            canvas.Image = mapa;
        }

        private async void pruebaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Circunferencia vec = new Circunferencia();
            double t = -8, dt = 0.1;
            vec.rd = 0.25;
            do
            {
                vec.x0 = t;
                vec.y0 = -(Math.Pow(t, 2) + (10 * t) + 16) / 2.25;
                vec.color0 = Color.Green;
                vec.Encender(mapa);
                t += dt;
            } while (t <= -2);
            do
            {
                vec.x0 = t;
                vec.y0 = (4 - Math.Pow(t, 2)) / 1.333;
                vec.color0 = Color.Red;
                vec.Encender(mapa);
                t += dt;
            } while (t <= 2);
            do
            {
                vec.x0 = t;
                vec.y0 = -(t * t - 6 * t + 8) / 0.5;
                vec.color0 = Color.Black;
                vec.Encender(mapa);
                t = t + dt;
            } while (t <= 4);
            canvas.Image = mapa;

        }

        private async void parabola_Click(object sender, EventArgs e)
        {
            Circunferencia vec = new Circunferencia();
            double t = -8, dt = 0.1;
            vec.rd = 0.25;
            do
            {
                vec.x0 = t;
                vec.y0 = -(Math.Pow(t, 2) + (10 * t) + 16) / 2.25;
                vec.color0 = Color.Green;
                vec.Encender(mapa);
                canvas.Image = mapa;
                await Task.Delay(20);
                vec.Apagar(mapa);
                t += dt;

            } while (t <= -2);
            do
            {
                vec.x0 = t;
                vec.y0 = (4 - Math.Pow(t, 2)) / 1.333;
                vec.color0 = Color.Red;
                vec.Encender(mapa);
                canvas.Image = mapa;
                await Task.Delay(20);
                vec.Apagar(mapa);
                t += dt;

            } while (t <= 2);
            do
            {
                vec.x0 = t;
                vec.y0 = -(t * t - 6 * t + 8) / 0.5;
                vec.color0 = Color.Black;
                vec.Encender(mapa);
                canvas.Image = mapa;
                await Task.Delay(20);
                vec.Apagar(mapa);

                t = t + dt;

            } while (t <= 4);
            canvas.Image = mapa;
        }

        private void reflexion_Click(object sender, EventArgs e)
        {
            Segmento seg = new Segmento();
            seg.color0 = Color.Black;
            seg.x0 = 1;
            seg.xf = -5;
            seg.y0 = 1;
            seg.yf = -6;
            seg.Encender(mapa);

            seg.color0 = Color.Red;
            seg.x0 = -10;
            seg.y0 = -0.23;
            seg.Encender(mapa);

            canvas.Image = mapa;
        }

        private async void movReflexionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Circunferencia vec = new Circunferencia();
            double t = 0, dt = 0.01;
            vec.rd = 0.25;
            do
            {
                vec.x0 = (1 * (1 - t)) + (8 * t);
                vec.y0 = (1 * (1 - t)) + (25 / 3 * t);
                vec.color0 = Color.Green;
                vec.Encender(mapa);
                await Task.Delay(20);
                vec.Apagar(mapa);

                t += dt;

            } while (t <= 1);

            canvas.Image = mapa;
        }

        private void ejemplo1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Vector vec = new Vector();
            double x = -8, dx = 0.002;

            do
            {
                vec.x0 = x;
                vec.y0 = 3 * Math.Pow(Math.E, (-4 * x));
                vec.color0 = Color.Green;
                vec.Encender(mapa);
                canvas.Image = mapa;
                x += dx;

            } while (x <= 8);
            x = -8;
            do
            {
                vec.x0 = x;
                vec.y0 = 6 * Math.Pow(Math.E, (-4 * x));
                vec.color0 = Color.Red;
                vec.Encender(mapa);
                canvas.Image = mapa;
                x += dx;

            } while (x <= 8);
            x = -8;
            do
            {
                vec.x0 = x;
                vec.y0 = 8 * Math.Pow(Math.E, (-4 * x));
                vec.color0 = Color.Black;
                vec.Encender(mapa);
                canvas.Image = mapa;
                x += dx;

            } while (x <= 8);
            x = -8;
            do
            {
                vec.x0 = x;
                vec.y0 = (-4) * Math.Pow(Math.E, (-4 * x));
                vec.color0 = Color.Fuchsia;
                vec.Encender(mapa);
                canvas.Image = mapa;
                x += dx;

            } while (x <= 8);
            x = -8;
            do
            {
                vec.x0 = x;
                vec.y0 = (-7) * Math.Pow(Math.E, (-4 * x));
                vec.color0 = Color.Orange;
                vec.Encender(mapa);
                canvas.Image = mapa;
                x += dx;

            } while (x <= 8);
            x = -8;
            do
            {
                vec.x0 = x;
                vec.y0 = (5.53) * Math.Pow(Math.E, (-4 * x));
                vec.color0 = Color.DarkTurquoise;
                vec.Encender(mapa);
                canvas.Image = mapa;
                x += dx;

            } while (x <= 8);
            x = -8;
            do
            {
                vec.x0 = x;
                vec.y0 = (-8.66) * Math.Pow(Math.E, (-4 * x));
                vec.color0 = Color.DarkRed;
                vec.Encender(mapa);
                canvas.Image = mapa;
                x += dx;

            } while (x <= 8);

            canvas.Image = mapa;
        }

        private async void p2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Segmento seg = new Segmento();
            seg.color0 = Color.Black;
            seg.x0 = -1;
            seg.xf = 5;
            seg.y0 = 0;
            seg.yf = 8.333;
            seg.Encender(mapa);

            seg.color0 = Color.Red;
            seg.x0 = 10;
            seg.y0 = 1.39;
            seg.Encender(mapa);

            Circunferencia c = new Circunferencia();
            c.rd = 0.2;
            double t = 0;
            do
            {
                c.x0 = (-1 * (1 - t)) + (5 * t);
                c.y0 = (0 * (1 - t)) + (8.33 * t);
                c.color0 = Color.Black;
                c.Encender(mapa);
                canvas.Image = mapa;
                canvas.Refresh();
                await Task.Delay(100);
                c.Apagar(mapa);
                canvas.Image = mapa;
                t += 0.2;
            } while (t <= 1);

            t = 0;
            do
            {
                c.x0 = (5 * (1 - t)) + (10 * t);
                c.y0 = (8.33 * (1 - t)) + (1.39 * t);
                c.color0 = Color.Red;
                c.Encender(mapa);
                canvas.Image = mapa;
                canvas.Refresh();
                await Task.Delay(100);
                c.Apagar(mapa);
                canvas.Image = mapa;
                t += 0.2;
            } while (t <= 1);


            canvas.Image = mapa;
        }

        private void practicaToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Vector3D vector3D = new Vector3D();
            double t = 0, dt = 0.001;
            do
            {
                vector3D.x0 = 2 + (3 * Math.Cos(t));
                vector3D.y0 = 1 + (3 * Math.Sin(t));
                vector3D.z0 = (t / 3) - 2;
                vector3D.color0 = primario;
                vector3D.Encender(mapa);
                t += dt;
            } while (t <= 15);
            canvas.Image = mapa;

        }

        private void ejesXY_Click(object sender, EventArgs e)
        {
            ejes();
        }

        private void ejesXYZ_Click(object sender, EventArgs e)
        {
            ejes3D();
        }
    }
}
