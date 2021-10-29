using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.Core
{
    class NesterenkoLog : LogAbstract, LogInterface
    {
        private readonly string path = "../../../Log";
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
            CreateDirectoryAndFile(arrayStringLog);

            WriteConsole(arrayStringLog.ToArray());
            return this;
        }

        public void CreateDirectoryAndFile(List<string> stringLog)
        {
            DirectoryInfo directory = new DirectoryInfo(path);
            
            if (!directory.Exists) 
                directory.Create();
            
            string filename = DateTime.Now.ToString("dd.MM.yyyy_hh.mm.ss.fff");
            File.WriteAllLines($@"..\..\..\Log\{filename}.log", stringLog.ToArray());
        }
    }
}
