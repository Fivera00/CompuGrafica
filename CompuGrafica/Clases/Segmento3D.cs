using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompuGrafica.Clases
{
    internal class Segmento3D: Vector3D
    {
        public Segmento3D() { }

        public double xf;
        public double yf;
        public double zf;

        public void Encender(Bitmap canva)
        {
            double t = 0;
            double dt = 0.00001;
            Vector3D vector3D = new Vector3D();
            vector3D.color0 = color0;
            do
            {
                vector3D.x0 = (x0 + (xf - x0) * t); // x0 * (1 - t) + xf * t;
                vector3D.y0 = (y0 + (yf - y0) * t); // y0 * (1 - t) + yf * t;
                vector3D.z0 = z0 + (zf - z0) * t; // z0 * (1 - t) + zf * t;
                vector3D.Encender(canva);
                t += dt;
            }
            while (t <= 1);
        }

    }
}
