using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nesterenko
{
    class NesterenkoLog : LogAbstract, LogInterface
    {
        private NesterenkoLog() { }

        private static NesterenkoLog instance;

        public static NesterenkoLog I()
        {
            if (instance == null)
                instance = new NesterenkoLog();

            return instance;
        }

        private List<string> arrayStringLog = new List<string>();

        public LogInterface Log(string str)
        {
           arrayStringLog.Add(str);
           return this;
        }

        public LogInterface Write()
        {
            WriteConsole(arrayStringLog.ToArray());
            return this;
        }
    }
}
