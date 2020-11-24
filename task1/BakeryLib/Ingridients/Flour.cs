using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BakeryLib
{
    public class Flour : Ingredient
    {
        public Flour(double volume) : base(volume)
        {
            Cost = 50.1 * Volume / 100;
            Calorific = 90 * Volume / 100;
        }
    }
}
