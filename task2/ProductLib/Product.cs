using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductLib
{
    public enum TypeName
    {
        Бытовая,
        Продовольственная
    }
    public abstract class Product
    {
        public TypeName NameOfType { get; protected set; }
        public string Name { get; protected set; }
        private decimal Cost { get; set; }
        public double MarkUp { get; protected set; }
        public int Count { get; protected set; }
        public Product(TypeName typeName, string name, decimal cost, double markUp, int count)
        {
            NameOfType = typeName;
            Name = name;
            Cost = cost;
            MarkUp = markUp;
            Count = count;
        }
        public decimal GetAllCost(List<Product> products)
        {
            decimal cost = 0;
            foreach(Product p in products)
            {
                cost += p.GetCost();
            }
            return cost;
        }
        public decimal GetCost()
        {
            return Cost * Convert.ToDecimal(MarkUp) / 100;
        }
        public static implicit operator int(Product p) => (int)p.GetCost() * 100;
        public static implicit operator double(Product p) => (double)p.GetCost();

    }
}
