using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labs
{
    class ExtremelyHighValueExeption : ArgumentException
    {
        public ExtremelyHighValueExeption(string message) : base(message)
        { }
    }
}
