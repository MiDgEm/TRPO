using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class C : B
    {
        public object PropertyB { get; set; }

        public C(object a, object b) 
            : base(a)
        {
            PropertyB = b; 
        }
    }
}
