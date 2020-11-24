using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BakeryLib
{
    public class Loaf : AnyProduct
    {
        private static new List<Ingredient> ingredients = new List<Ingredient>() { new Sugar(150), new Oil(30), new Flour(60), new Yeast(30), new Cheese(20) };
        private static new double markUp = 100;
        public Loaf() : base(ingredients, markUp) { }
    }
}
