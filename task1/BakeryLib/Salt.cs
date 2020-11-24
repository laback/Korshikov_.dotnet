using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BakeryLib
{
    public class Salt : Ingredient
    {
        public Salt(double volume) : base(volume)
        {
            Cost = 25 * Volume / 100;
            Calorific = 10 * Volume / 100;
        }
    }
}
