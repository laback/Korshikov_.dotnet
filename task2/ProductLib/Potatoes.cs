using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductLib
{
    public class Potatoes : Food
    {
        public Potatoes(string name, decimal cost, double markUp, int count) : base(name, cost, markUp, count) { }
    }
}
