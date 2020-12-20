using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiguresLib
{
    public class PlasticFoursquare : PlasticFigure
    {
        public PlasticFoursquare(double variable) : base(variable, TypeOfFigure.Foursquare) { }
        public override double GetSquare()
        {
            double square = side * side;
            return square;
        }

        public override double GetPerimeter()
        {
            double perimeter = side * 4;
            return perimeter;
        }

        public override void ChangeFigure(double variable)
        {
            double newSquare = variable * variable;
            double newPerimeter = variable * 4;
            if (GetPerimeter() > newPerimeter && GetSquare() > newSquare)
                side = variable;
            else
                throw new Exception("Размеры новой фигуры меньше");
        }
    }
}
