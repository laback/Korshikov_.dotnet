using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiguresLib
{
    public abstract class FilmFigure : Figure
    {
        public FilmFigure(double radius) : base(radius)
        {
            color = Color.no;
        }
        public FilmFigure(double lenght, double width) : base(lenght, width)
        {
            color = Color.no;
        }
        public override void ChangeColor(Color color)
        {
            throw new Exception("Плёнку окрашивать нельзя");
        }

    }
}
