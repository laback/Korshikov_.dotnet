using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiguresLib
{
    public abstract class FilmFigure : Figure
    {
        public FilmFigure(double varialbe, TypeOfFigure typeOfFigure) : base(varialbe, typeOfFigure, FigureMaterial.Film)
        {
            color = Color.white;
        }
        public override void ChangeColor(Color color)
        {
            throw new Exception("Плёнку окрашивать нельзя");
        }

    }
}
