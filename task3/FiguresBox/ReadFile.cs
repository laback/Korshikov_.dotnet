using FiguresLib;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace FiguresBox
{
    public enum FileType
    {
        Stream,
        Xml
    }
    public class ReadFile
    {
        public List<Figure> ReadXmlWithStreamReader(string filePath)
        {
            using (StreamReader reader = new StreamReader(filePath))
            {
                string xmlString = reader.ReadToEnd();

                XmlDocument document = new XmlDocument();
                document.LoadXml(xmlString);

                XmlNodeList list = document.GetElementsByTagName("figure");

                List<Figure> figures = new List<Figure>();
                foreach (XmlNode node in list)
                {
                    figures.Add(GetFigure(node));
                }

                return figures;
            }
        }
        private void GetFigureValues(XmlNode node, out double variable)
        {
            variable = 0;
            XmlNodeList variables = node.ChildNodes;
            foreach (XmlNode var in variables)
            {
                variable = Convert.ToDouble(var.InnerText);
            }
        }
        private void GetFigureMaterialAndForm(XmlNode node, out string material, out string form)
        {
            material = "";
            form = "";

            foreach (XmlAttribute attribute in node.Attributes)
            {
                switch (attribute.Name)
                {
                    case "material":
                        material = attribute.InnerText;
                        break;
                    case "form":
                        form = attribute.InnerText;
                        break;
                }
            }
        }
        private Figure GetConcreteFigure(string material, string form, double variable)
        {
            Figure figure = null;

            if (material == "Paper")
            {
                if (form == "Foursquare")
                    figure = new PaperFoursquare(variable);
                if (form == "Circle")
                    figure = new PaperCircle(variable);
            }

            if (material == "Film")
            {
                if (form == "Rectangle")
                    figure = new FilmFoursquare(variable);
                if (form == "Circle")
                    figure = new FilmCircle(variable);
            }
            if (material == "Plastic")
            {
                if (form == "Rectangle")
                    figure = new PlasticFoursquare(variable);
                if (form == "Circle")
                    figure = new PlasticCircle(variable);
            }
            if (figure == null)
                throw new Exception("Вы ввели неккоректные данные фигур(ы).");
            else
                return figure;
        }
        private Figure GetFigure(XmlNode node)
        {
            GetFigureValues(node, out double variable);
            GetFigureMaterialAndForm(node, out string material, out string form);
            return GetConcreteFigure(material, form, variable);
        }
        public List<Figure> ReadXmlWithXmlReader(string filePath)
        {
            using (XmlReader reader = XmlReader.Create(filePath))
            {
                List<Figure> figures = new List<Figure>();

                string element = "";

                string material = "";
                string form = "";

                double variable = 0;

                while (reader.Read())
                {
                    if (reader.NodeType == XmlNodeType.Element)
                    {
                        element = reader.Name;
                        if (element == "figure")
                        {
                            material = reader.GetAttribute("material");
                            form = reader.GetAttribute("form");
                        }
                    }
                    else if (reader.NodeType == XmlNodeType.Text)
                    {
                        variable = Convert.ToDouble(variable);
                    }
                    else if ((reader.NodeType == XmlNodeType.EndElement) && (reader.Name == "figure"))
                    {
                        figures.Add(GetConcreteFigure(material, form, variable));
                    }
                }
                return figures;
            }
        }
    }
}
