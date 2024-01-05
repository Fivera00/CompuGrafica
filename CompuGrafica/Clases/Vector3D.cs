using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompuGrafica.Clases
{
    internal class Vector3D : Vector
    {
        public Vector3D()
        {
        }
        public double z0;
        public void Encender(Bitmap canva)
        {
            double ax, ay;
            int sX, sY;
            Vector v = new Vector(0, 0, color0);
            v.Axonometria(x0, y0, z0, out ax, out ay);
            v.Pantalla(ax, ay, out sX, out sY);
            if (sX >= 0 && sX < 600 && sY >= 0 && sY < 500)
            {
                canva.SetPixel(sX, sY, color0);
            }
        }
    }
}
