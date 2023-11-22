using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompuGrafica.Clases
{
    internal class Vector
    {
        public double x0;
        public double y0;
        public Color color0;

        public static int sx1 = 0;
        public static int sy1 = 0;
        public static int sx2 = 600;
        public static int sy2 = 500;

        private double x1 = -10, x2 = 10;
        // private double y1 = -5, y2 = 5; 
        private double y1 = -8.333, y2 = 8.333; //dimesion proporcional  

        public Vector()
        {
        }

        public Vector(double x0, double y0, Color color0)
        {
            this.x0 = x0;
            this.y0 = y0;
            this.color0 = color0;
        }

        public void Pantalla(double x, double y, out int sx, out int sy)
        {
            sx = (int)(((x - x1) / (x1 - x2)) * (sx1 - sx2)) + sx1;
            sy = (int)(((y - y2) / (y2 - y1)) * (sy1 - sy2)) + sy1;
        }

        public void Encender(Bitmap canva)
        {
            Pantalla(x0, y0, out int sX, out int sY);

            if (sX >= 0 && sX < 600 && sY >= 0 && sY < 500)
            {
                canva.SetPixel(sX, sY, color0);
            }
        }

        public void Apagar(Bitmap canva)
        {
            Pantalla(x0, y0, out int sX, out int sY);
            if (sX >= 0 && sX < 600 && sY >= 0 && sY < 500)
            {
                canva.SetPixel(sX, sY, Color.White);
            }
        }
          
        public void Tranformar(double sx, double sy, out double x, out double y)
        {
            x = ((x1 - x2) * (sx - sx1) / (sx1 - sx2)) + x1;
            y = ((y2 - y1) * (sy - sy1) / (sy1 - sy2)) + y2;
        }

    }
}
