using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductLib
{
    class CustomException : ArgumentException
    {
        public CustomException(string message) : base(message) { }
    }
}
