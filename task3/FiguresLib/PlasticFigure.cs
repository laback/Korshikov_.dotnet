using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiguresLib
{
    public abstract class PlasticFigure : Figure
    {
        public PlasticFigure(double radius) : base(radius)
        {
            color = Color.white;
        }
        public PlasticFigure(double lenght, double width) : base(lenght, width)
        {
            color = Color.white;
        }
        public override void ChangeColor(Color color)
        {
            IsPainted = true;
            this.color = color;
        }
    }
}
