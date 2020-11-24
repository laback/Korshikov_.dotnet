using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BakeryLib
{
    public abstract class AnyProduct
    {
        public virtual List<Ingredient> ingredients { get; protected set; }
        public double markUp { get; protected set; }
        public double GetCost()
        {
            double price = 0;
            foreach(Ingredient i in ingredients)
            {
                price += i.Cost;
            }
            return price + markUp;
        }
        public double GetCalorific()
        {
            double calorific = 0;
            foreach (Ingredient i in ingredients)
            {
                calorific += i.Calorific;
            }
            return calorific;
        }
        public List<Ingredient> GetIngridients()
        {
            return ingredients;
        }
        public AnyProduct(List<Ingredient> ingredients, double markUp)
        {
            this.ingredients = ingredients;
            this.markUp = markUp;
        }
    }
}
