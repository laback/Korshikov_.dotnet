using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiguresLib
{
    public enum Color
    {
        no,
        red,
        blue,
        brown,
        yellow,
        pink,
        black,
        white
    }
    public abstract class Figure
    {
        public Color color { get; set; }
        protected double radius { get; set; }
        protected double side { get; set; }
        public bool IsPainted { get; set; }
        public abstract void ChangeColor(Color color);
        public abstract double GetSquare();
        public abstract double GetPerimeter();
        public Figure(double variable) 
        { 
            IsPainted = false;
            radius = variable;
            side = variable;
        }
        public abstract void ChangeFigure(double variable);
    }
}
