using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompuGrafica.Clases
{
    internal class Segmento : Vector
    {
        public double xf;
        public double yf;

        public Segmento() { }

        public void Encender(Bitmap canva)
        {
            double t = 0;
            double dt = 0.0001;
            Vector v = new Vector(0, 0, color0);
            do
            {
                v.x0 = (x0 + (xf - x0) * t);
                v.y0 = (y0 + (yf - y0) * t);
                v.Encender(canva);
                t += dt;
            } while (t <= 1);
        }

        public void Apagar(Bitmap canva)
        {
            double t = 0;
            double dt = 0.0001;
            Vector v = new Vector(0, 0, color0);
            do
            {
                v.x0 = (x0 + (xf - x0) * t);
                v.y0 = (y0 + (yf - y0) * t);
                v.color0 = Color.White;
                v.Apagar(canva);
                t += dt;
            } while (t <= 1);
        }
    }
}
