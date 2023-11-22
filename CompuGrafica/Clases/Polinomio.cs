using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompuGrafica.Clases
{
    internal class Polinomio : Vector
    {
        public Polinomio() { }

        public void Encender(Bitmap canva)
        {
            Vector v = new Vector();
            double t = -8;
            double dt = 0.001;
            do
            {
                v.x0 = t;
                v.y0 = Math.Pow(3, t);
                v.color0 = Color.Green;
                v.Encender(canva);

                v.y0 = 1 + (1.098 * (t)) + (((1.206) / 2) * Math.Pow(t, 2)) + (((1.325) / 6) * Math.Pow(t, 3) + (((1.456) / 24) * Math.Pow(t, 4))); 
                v.color0 = Color.Red;
                v.Encender(canva);

                t += dt;
            } while (t <= 8);

        }
    }
}
