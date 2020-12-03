using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductLib
{
    public class Food : Product
    {
        public Food(string name, decimal cost, double markUp, int count) : base(TypeName.Продовольственная, name, cost, markUp, count) 
        {
        }
        public static Food operator +(Food f1, Food f2)
        {
            if (f1.NameOfType == f2.NameOfType && f1.Name == f2.Name)
            {
                decimal newCost = (f1.GetCost() * f1.Count + f2.GetCost() * f2.Count) / (f1.Count + f2.Count);
                double newMarkUp = (f1.MarkUp * f1.Count + f2.MarkUp * f2.Count) / (f1.Count + f2.Count);
                return new Food(f1.Name, newCost, newMarkUp, f1.Count + f2.Count);
            }
            else
                throw new CustomException("Типы или наименования не совпадают");
        }
        public static Food operator -(Food f, int count)
        {
            if (count > 0)
                return new Food(f.Name, f.GetCost(), f.MarkUp, f.Count - count);
            else
                throw new CustomException("Некорректное количество товара");
        }

        public static explicit operator Food(Household household) => new Food(household.Name, household.GetCost(), household.MarkUp, household.Count);
    }
}
