using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BakeryLib
{
    public class Cheese : Ingredient
    {
        public Cheese(double volume) : base(volume)
        {
            Cost = 135.2 * Volume / 100;
            Calorific = 150.8 * Volume / 100;
        }
    }
}
