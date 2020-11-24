using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BakeryLib
{
    public class Jam : Ingredient
    {
        public Jam(double volume) : base(volume)
        {
            Cost = 79 * Volume / 100;
            Calorific = 18.6 * Volume / 100;
        }
    }
}
