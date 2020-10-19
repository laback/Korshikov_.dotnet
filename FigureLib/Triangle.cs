using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureLib
{
    public class Triangle : AnyFigure
    {
        public double sideA;
        public double sideB;
        public double sideC;
        public double square;
        public double perimeter;
        public Triangle(double sideA, double sideB, double sideC)
        {
            this.sideA = sideA;
            this.sideB = sideB;
            this.sideC = sideC;
            perimeter = Perimeter();
            square = Square();
        }
        public override double Perimeter()
        {
            return sideA + sideB + sideC;
        }
        public override double Square()
        {
            double halfPer = Perimeter() / 2;
            return Math.Sqrt(halfPer * (halfPer - sideA) * (halfPer - sideB) * (halfPer - sideC));
        }
    }
}
