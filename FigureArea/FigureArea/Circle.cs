using System;

namespace FigureArea
{
    public class Circle: IAreable
    {
        double r;
        public Circle(double r)
        {
            this.r = r;
        }

        public double CalculateArea()
        {
            return (Math.PI * r * r);
        }
    }
}
