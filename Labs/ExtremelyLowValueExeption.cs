using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labs
{
    class ExtremelyLowValueExeption : ArgumentException
    {
        public ExtremelyLowValueExeption(string message) : base(message)
        { }
    }
}
