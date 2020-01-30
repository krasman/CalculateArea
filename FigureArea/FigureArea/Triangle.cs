using System;

namespace FigureArea
{
    public class Triangle: IAreable
    {
        double a, b, c;
        public Triangle(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public bool IsRectangular()
        {
            if (a > b && a > c)
                return (a * a == (b * b + c * c));
            else if (b > a && b > c)
                return (b * b == (a * a + c * c));
            else
                return (c * c == (a * a + b * b));
        }
        public double CalculateArea()
        {
            double p = (a + b + c) / 2;
            return (Math.Sqrt(p * (p - a) * (p - b) * (p - c)));
        }
    }
}
