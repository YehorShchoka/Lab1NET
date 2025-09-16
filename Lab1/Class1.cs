using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    internal class Tabul
    {
        public double[,] xy = new double[1000, 2];
        public int n = 0;

        private double f1(double x)
        {
            return Math.Pow(x, 3) - Math.Log(Math.Abs(x) + 1);
        }

        private double f2(double x)
        {
            double t = Math.Tan(2 * x);
            if(t == 0) {
                t = 1;
            }

            return ((2 * x) + 2) / ((t - 1) + 1);
        }

        private double f3(double x)
        {
            return Math.Pow(x, 4) - Math.Pow(x, x);
        }

        public void tab(double xn = -1.25, double xk = 9.39, double h = 0.4, double a = 0.8)
        {
            double x = xn, y;
            int i = 0;
            while (x <= xk)
            {
                if (x < 0)
                {
                    y = f1(x);
                }
                else
                {
                    if ((x >= 0) && (x < a))
                    {
                        y = f2(x);
                    }
                    else
                    { y = f3(x); }
                }
                xy[i, 0] = x;
                xy[i, 1] = y;
                x = x + h;
                i++;
            }
            n = i;
        }
    }
}
