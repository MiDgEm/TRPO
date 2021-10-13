using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nesterenko
{
    class NesterenkoException : Exception
    {
        public NesterenkoException(string message) 
            : base(message)
        { }
    }
}
