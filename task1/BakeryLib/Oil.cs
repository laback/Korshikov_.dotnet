using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BakeryLib
{
    public class Oil : Ingredient
    {
        public Oil(double volume) : base(volume)
        {
            Cost = 67 * Volume / 100;
            Calorific = 150 * Volume / 100;
        }
    }
}
