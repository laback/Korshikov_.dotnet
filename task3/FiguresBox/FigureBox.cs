using FiguresLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiguresBoxLib
{
    public class FigureBox
    {
        public List<Figure> figures = new List<Figure>();
        public void AddFigure(Figure figure)
        {
            bool flag = true;
            foreach(Figure f in figures)
            {
                if (f.Equals(figure))
                {
                    flag = false;
                    throw new Exception("Такая фигура уже существует");
                }
            }
            if (flag)
                figures.Add(figure);
        }
        public Figure ShowFigure(int index)
        {
            try
            {
                return figures[index];
            }
            catch
            {
                throw new Exception("Фигуры с таким номер не существует");
            }
        }
        public List<Figure> GetEquals(Figure figure)
        {
            List<Figure> result = new List<Figure>();
            foreach(Figure f in figures)
            {
                if (f.Equals(figure))
                    result.Add(f);
            }
            return result;
        }
        public Figure GetByNumber(Figure figure)
        {
            Figure figure1;
            foreach (Figure f in figures)
            {
                if (f.Equals(figure))
                {
                    figure1 = f;
                    figures.Remove(f);
                    return figure1;
                }
            }
            throw new Exception("Такой фигуры нет");
        }
        public void SetByNumber(int index, Figure figure)
        {
            figures[index] = figure;
        }
        public List<Figure> GetAllFilmFigures()
        {
            List<Figure> figures = new List<Figure>();
            foreach(Figure f in figures)
            {
                if (f.figureMaterial == FigureMaterial.Film)
                    figures.Add(f);
            }
            return figures;
        }
        public List<Figure> GetPlasticColorless()
        {
            List<Figure> figures = new List<Figure>();
            foreach (Figure f in figures)
            {
                if (f.figureMaterial == FigureMaterial.Plastic && f.color == Color.no)
                    figures.Add(f);
            }
            return figures;
        }
        public int GetCount()
        {
            return figures.Count();
        }
        public double GetSquares()
        {
            double squares = 0;
            foreach (Figure f in figures)
                squares += f.GetSquare();
            return squares;
        }
        public double GetPerimeter()
        {
            double perimeters = 0;
            foreach (Figure f in figures)
                perimeters += f.GetPerimeter();
            return perimeters;
        }
        public List<Figure> GetAllCirles()
        {
            List<Figure> cirles = new List<Figure>();
            foreach(Figure f in figures)
            {
                if (f.typeOfFigure == TypeOfFigure.Circle)
                    cirles.Add(f);
            }
            return cirles;
        }

    }
}
