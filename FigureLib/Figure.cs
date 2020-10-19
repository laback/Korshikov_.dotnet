using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureLib
{
    public class Figure
    {
        public List<string> FileRead()
        {
            string path = Directory.GetCurrentDirectory() + @"\figure.txt";
            using (StreamReader reader = new StreamReader(path))
            {
                List<string> result = new List<string>();
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    result.Add(line);
                }
                return result;
            }
        }
        public double AveragePerimeter(List<string> lines)
        {
            int temp;
            string[] sides;
            double averagePer = 0;
            foreach(string line in lines)
            {
                temp = line.Split(' ').Length;
                switch (temp)
                {
                    case 1:
                        Circle circle = new Circle(int.Parse(line));
                        averagePer += circle.perimeter;
                        break;
                    case 3:
                        sides = line.Split(' ');
                        Triangle triangle = new Triangle(int.Parse(sides[0]), int.Parse(sides[1]), int.Parse(sides[2]));
                        averagePer += triangle.perimeter;
                        break;
                    case 2:
                        sides = line.Split(' ');
                        Rectangle rectangle = new Rectangle(int.Parse(sides[0]), int.Parse(sides[1]));
                        averagePer += rectangle.perimeter;
                        break;
                }
            }
            averagePer /= lines.Count;
            return averagePer;
        }
        public Dictionary<Type, double> Squares(List<string> lines)
        {
            int temp;
            string[] sides;
            Dictionary<Type, double> squares = new Dictionary<Type, double>();
            foreach (string line in lines)
            {
                temp = line.Split(' ').Length;
                switch (temp)
                {
                    case 1:
                        Circle circle = new Circle(int.Parse(line));
                        if (squares.ContainsKey(typeof(Circle)))
                            squares[typeof(Circle)] += circle.square;
                        else
                            squares.Add(typeof(Circle), circle.square);
                        break;
                    case 3:
                        sides = line.Split(' ');
                        Triangle triangle = new Triangle(int.Parse(sides[0]), int.Parse(sides[1]), int.Parse(sides[2]));
                        if (squares.ContainsKey(typeof(Triangle)))
                            squares[typeof(Triangle)] += triangle.square;
                        else
                            squares.Add(typeof(Triangle), triangle.square);
                        break;
                    case 2:
                        sides = line.Split(' ');
                        Rectangle rectangle = new Rectangle(int.Parse(sides[0]), int.Parse(sides[1]));
                        if (squares.ContainsKey(typeof(Rectangle)))
                            squares[typeof(Rectangle)] += rectangle.square;
                        else
                            squares.Add(typeof(Rectangle), rectangle.square);
                        break;
                }
            }
            return squares;
        }
        public double MaxSquare()
        {
            List<string> lines = FileRead();
            Dictionary<Type, double> squares = Squares(lines);
            
            return squares.Aggregate((k, v) => k.Value > v.Value ? k : v).Value;
        }
        public Type MaxPerByType()
        {
            List<string> lines = FileRead();
            int temp;
            string[] sides;
            Dictionary<Type, double> per = new Dictionary<Type, double>();
            Dictionary<Type, int> count = new Dictionary<Type, int>();
            foreach (string line in lines)
            {
                temp = line.Split(' ').Length;
                switch (temp)
                {
                    case 1:
                        Circle circle = new Circle(int.Parse(line));
                        if (per.ContainsKey(typeof(Circle)))
                        {
                            per[typeof(Circle)] += circle.perimeter;
                            count[typeof(Circle)] += 1;
                        }
                        else
                        {
                            per.Add(typeof(Circle), circle.perimeter);
                            count.Add(typeof(Circle), 1);
                        }
                        break;
                    case 3:
                        sides = line.Split(' ');
                        Triangle triangle = new Triangle(int.Parse(sides[0]), int.Parse(sides[1]), int.Parse(sides[2]));
                        if (per.ContainsKey(typeof(Triangle)))
                        {
                            per[typeof(Triangle)] += triangle.perimeter;
                            count[typeof(Triangle)] += 1;
                        }
                        else
                        {
                            per.Add(typeof(Triangle), triangle.perimeter);
                            count.Add(typeof(Triangle), 1);
                        }
                        break;
                    case 2:
                        sides = line.Split(' ');
                        Rectangle rectangle = new Rectangle(int.Parse(sides[0]), int.Parse(sides[1]));
                        if (per.ContainsKey(typeof(Rectangle)))
                        {
                            per[typeof(Rectangle)] += rectangle.perimeter;
                            count[typeof(Rectangle)] += 1;
                        }
                        else
                        {
                            per.Add(typeof(Rectangle), rectangle.perimeter);
                            count.Add(typeof(Rectangle), 1);
                        }
                        break;
                }
            }
            Dictionary<Type, double> result = new Dictionary<Type, double>();
            foreach(KeyValuePair<Type, double> pair in per)
            {
                result.Add(pair.Key, pair.Value / count[pair.Key]);
            }
            return result.Aggregate((k, v) => k.Value > v.Value ? k : v).Key;
        }
    }
}
