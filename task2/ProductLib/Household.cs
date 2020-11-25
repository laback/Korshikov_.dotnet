using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductLib
{
    public class Household : Product
    {
        public Household(string name, decimal cost, double markUp, int count) : base(TypeName.Бытовая, name, cost, markUp, count) 
        {
        }
        public static Household operator +(Household h1, Household h2)
        {
            if (h1.NameOfType == h2.NameOfType && h1.Name == h2.Name)
            {
                decimal newCost = (h1.GetCost() * h1.Count + h2.GetCost() * h2.Count) / (h1.Count + h2.Count);
                double newMarkUp = (h1.MarkUp * h1.Count + h2.MarkUp * h2.Count) / (h1.Count + h2.Count);
                return new Household(h1.Name, newCost, newMarkUp, h1.Count + h2.Count);
            }
            else
                throw new CustomException("Типы или наименования не совпадают");
        }
        public static Household operator -(Household h, int count)
        {
            if (count > 0)
                return new Household(h.Name, h.GetCost(), h.MarkUp, h.Count - count);
            else
                throw new CustomException("Некорректное количество товара");
        }
        public static implicit operator Household(Food food) => new Household(food.Name, food.GetCost(), food.MarkUp, food.Count);
    }
}
