using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BakeryLib
{
    public class Bread : AnyProduct
    {
        private static new List<Ingredient> ingredients = new List<Ingredient>() { new Salt(100), new Sugar(50), new Oil(20), new Flour(150) };
        private static new double markUp = 59;
        public Bread() : base(ingredients, markUp) { }
    }
}
