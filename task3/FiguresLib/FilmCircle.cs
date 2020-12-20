using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiguresLib
{
    public class FilmCircle : FilmFigure
    {
        public FilmCircle(double variable) : base(variable) {}
        public override double GetSquare()
        {
            double square = Math.PI * Math.Pow(this.radius, 2);
            return square;
        }
        public override double GetPerimeter()
        {
            double perimeter = 2 * Math.PI * this.radius;
            return perimeter;
        }
        public override void ChangeFigure(double variable)
        {
            double newSquare = Math.PI * Math.Pow(variable, 2);
            double newPerimeter = 2 * Math.PI * variable;
            if (GetSquare() > newSquare && GetPerimeter() > newPerimeter)
            {
                radius = variable;
            }
            else
                throw new Exception("Размеры новой фигуры меньше");
        }
    }
}
