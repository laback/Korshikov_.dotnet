using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BakeryLib
{
    public class Yeast : Ingredient
    {
        public Yeast(double volume) : base(volume)
        {
            Cost = 15 * Volume / 100;
            Calorific = 49.5 * Volume / 100;
        }
    }
}
