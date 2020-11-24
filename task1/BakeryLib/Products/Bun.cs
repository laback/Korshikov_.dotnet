using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BakeryLib
{
    public class Bun : AnyProduct
    {
        private static new List<Ingredient> ingredients = new List<Ingredient>() {new Sugar(100), new Oil(50), new Flour(60), new Yeast(30), new Jam(50) };
        private static new double markUp = 20;
        public Bun() : base(ingredients, markUp) { }
    }
}
