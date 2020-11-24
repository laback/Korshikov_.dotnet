using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BakeryLib
{
    public abstract class Ingredient
    {
        public double Cost { get; protected set; }
        public double Calorific { get; protected set; }
        public double Volume { get; set; }
        public Ingredient(double volume)
        {
            Volume = volume;
        }

        public override bool Equals(object obj)
        {
            return obj is Ingredient ingridient &&
                   Cost == ingridient.Cost &&
                   Calorific == ingridient.Calorific &&
                   Volume == ingridient.Volume;
        }

        public override int GetHashCode()
        {
            int hashCode = -1358118544;
            hashCode = hashCode * -1521134295 + Cost.GetHashCode();
            hashCode = hashCode * -1521134295 + Calorific.GetHashCode();
            hashCode = hashCode * -1521134295 + Volume.GetHashCode();
            return hashCode;
        }
    }
}
