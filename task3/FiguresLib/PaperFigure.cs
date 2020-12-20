using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiguresLib
{
    public abstract class PaperFigure : Figure
    {
        public PaperFigure(double radius) : base(radius)
        {
            color = Color.white;
        }
        public PaperFigure(double lenght, double width) : base(lenght, width)
        {
            color = Color.white;
        }
        public override void ChangeColor(Color color)
        {
            if (IsPainted == false)
            {
                this.color = color;
                IsPainted = true;
            }
            else
                throw new Exception("Нельзя окрасить");
        }
    }
}
