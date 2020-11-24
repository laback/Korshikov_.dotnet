using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureLib
{
    public class Circle: AnyFigure
    {
        public double r;
        public double square;
        public double perimeter;
        public Circle(double r)
        {
            this.r = r;
            perimeter = Perimeter();
            square = Square();
        }
        public override double Perimeter()
        {
            return r * 2 * Math.PI;
        }
        public override double Square()
        {
            return Math.PI * r * r;
        }
    }
}
