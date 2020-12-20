using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiguresLib
{
    public abstract class PlasticFigure : Figure
    {
        public PlasticFigure(double varialbe, TypeOfFigure typeOfFigure) : base(varialbe, typeOfFigure, FigureMaterial.Plastic)
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
