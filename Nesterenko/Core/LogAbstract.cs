using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nesterenko
{
    abstract public class LogAbstract
    {
        protected string FormaLog(string[] strings)
        {
            return string.Join(";\n\r", strings);
        }

        protected void WriteConsole(string s)
        {
            Console.WriteLine(s);
        }

        protected void WriteConsole(string[] s)
        {
            Console.WriteLine(FormaLog(s));
        }
    }
}
