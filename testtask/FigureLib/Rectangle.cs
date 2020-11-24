using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureLib
{
    public class Rectangle: AnyFigure
    {
        public double sideA;
        public double sideB;
        public double square;
        public double perimeter;
        public Rectangle(double sideA, double sideB)
        {
            this.sideA = sideA;
            this.sideB = sideB;
            perimeter = Perimeter();
            square = Square();
        }
        public override double Perimeter()
        {
            return (sideA + sideB) * 2;
        }
        public override double Square()
        {
            return sideA * sideB;
        }
    }
}
