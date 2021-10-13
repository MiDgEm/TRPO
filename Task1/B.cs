using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class B : A
    {
        public object PropertyA { get; set; }

        public B(object a)
        {
            PropertyA = a;
        }
    }
}
