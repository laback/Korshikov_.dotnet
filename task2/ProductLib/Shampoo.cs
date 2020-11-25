using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductLib
{
    public class Shampoo : Household
    {
        public Shampoo(string name, decimal cost, double markUp, int count) : base(name, cost, markUp, count) { }
    }
}
