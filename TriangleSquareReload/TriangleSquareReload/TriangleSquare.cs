using System;
using System.Collections.Generic;
using System.Text;

namespace TriangleSquareReload
{
    class TriangleSquare
    {
        public static double CalculateSquare(double ab, double bc, double ca)
        {
            double halfPer = (ab + bc + ca) / 2;
            return Math.Sqrt(halfPer * (halfPer - ab) * (halfPer - bc) * (halfPer - ca));
        }
        public static double CalculateSquare(double h, double b)
        {
            return  (h * b)/2;
        }
        public static double CalculateSquare(double ab, double bc, int alpha)
        {
            double rads = alpha * Math.PI / 180;
            return (ab * bc * Math.Sin(rads)) / 2;
        }
    }
}
