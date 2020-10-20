using System;

namespace MathLib
{
    public class MyLib
    {
        public static int CheckToDouble(string a)
        {
            try
            {
                double b = Convert.ToDouble(a);
            }
            catch
            {
                return 1;
            }
            return 0;
        }
       public static int Fun(double a, double b, double c, out double d, out double x1, out double x2)
        {
            d = ((b * b) - (4 * a * c));

            if (a == 0)
            {
                x1 = -(c / b);
                x2 = -1;
                return 1;   
            }
            if (d == 0)
            {
                x1 = (-1 * b) / (2 * a);
                x2 = -1;
                return 1;
            }
            if (d < 0)
            {
                x1 = x2 = -1;
                return 0;
            }
             else
            {
                x1 = (-1 * b + Math.Sqrt(d)) / (2 * a);
                x2 = (-1 * b - Math.Sqrt(d)) / (2 * a);
                return 2;
            }


        }
        public static double Res(double a, double b, double x)
        {
            double res = 2.4 * (Math.Abs(Math.Pow(x, 2) + b) / a) + ((a - b) * Math.Pow(Math.Sin(a - b), 2)) + (0.01 * (x - b));
            return res;
        }
    }
}
