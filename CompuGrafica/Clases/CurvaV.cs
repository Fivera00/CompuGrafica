using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CompuGrafica.Clases
{
    internal class CurvaV : Circunferencia
    {
        public int tipo;

        public CurvaV() { }

        public void Encender(Bitmap canva)
        {
            Vector v = new Vector();
            double t = -8;
            double dt = 0.001;

            switch (tipo)
            {
                case 0:
                    do
                    {
                        v.x0 = x0 + (rd * (Math.Sin(2 * t)));
                        v.y0 = y0 + (rd * (Math.Cos(3 * t)));
                        v.color0 = color0;
                        v.Encender(canva);
                        t += dt;
                    } while (t <= 2 * Math.PI);

                    break;

                case 1:
                    do
                    {
                        v.x0 = x0 + (rd * Math.Cos(4 * t) * Math.Cos(t));
                        v.y0 = y0 + (rd * Math.Cos(4 * t) * Math.Sin(t));
                        v.color0 = color0;
                        v.Encender(canva);
                        t += dt;
                    } while (t <= 2 * Math.PI);

                    break;
                case 2:
                    do
                    {
                        v.x0 = x0 + (rd * Math.Pow( Math.Sin(t), 3));
                        v.y0 = y0 + (rd * Math.Pow(Math.Cos(t), 3));
                        v.color0 = color0;
                        v.Encender(canva);
                        t += dt;
                    } while (t <= 2 * Math.PI);

                    break;
                case 3:
                    do
                    {
                        double xt = (8 * t) / 5;
                        v.x0 = x0 + (rd * Math.Sin(xt) * Math.Cos(t));
                        v.y0 = y0 + (rd * Math.Sin(xt) * Math.Sin(t));
                        v.color0 = color0;
                        v.Encender(canva);
                        t += dt;
                    } while (t <= 10 * Math.PI);

                    break;
                case 4:
                    do
                    {
                        v.x0 = t;
                        v.y0 = Math.Pow(2, t);
                        v.color0 = color0;
                        v.Encender(canva);
                        v.y0 = (Math.Pow(t, 2)/5) - 3;
                        v.color0 = Color.Green;
                        v.Encender(canva);
                        t += dt;
                    } while (t <= 8);

                    break;
                case 5:
                    do
                    {
                        v.x0 = t;
                        v.y0 = Math.Pow(2, t);
                        v.color0 = color0;
                        v.Encender(canva);
                        v.y0 = (Math.Pow(t, 2) / 5) - 3;
                        v.color0 = Color.Green;
                        v.Encender(canva);
                        v.y0 = Math.Log(t);
                        v.color0 = Color.Red;
                        v.Encender(canva);
                        t += dt;
                    } while (t <= 8);

                    break;
                case 6:
                    do
                    {
                        v.x0 = t;
                        v.y0 = Math.Pow(2, t);
                        v.color0 = color0;
                        v.Encender(canva);

                        v.y0 = (Math.Pow(t, 2) / 5) - 3;
                        v.color0 = Color.Green;
                        v.Encender(canva);

                        v.y0 = Math.Log(t);
                        v.color0 = Color.Red;
                        v.Encender(canva);

                        v.y0 = 2 * (Math.Sin(t) + 2);  
                        v.color0 = Color.Brown;
                        v.Encender(canva);

                        v.y0 = ( Math.Pow(t, 3) / 10) + 1; 
                        v.color0 = Color.Orange;  
                        v.Encender(canva);
                        t += dt;
                    } while (t <= 8);

                    break;
            }


        }
    }
}

