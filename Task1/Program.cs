using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            A a1 = new A();
            A a2 = new A();
            B b3 = new B(a2);
            B b4 = new B(b3);
            C c5 = new C(a1, b4);
        }
    }
}
