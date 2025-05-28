using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;

namespace ClassLibrary
{
    internal class ConsoleLogger : ILogger
    {
        public void Trace(string trace) { }
        public void Info(string info) { }
        public void Debug(string debug) { }
        public void Warning(string warning) { }
        public void Error(string error) { }
        public void Fatal(string fatal) { }
        public void Log(string log, LogLevel loglevel) { }
    }
}
