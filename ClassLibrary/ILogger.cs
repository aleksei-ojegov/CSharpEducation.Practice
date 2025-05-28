using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Abstractions;

namespace ClassLibrary
{
    internal interface ILogger
    {
        void Trace(string trace);
        void Info(string info);
        void Debug(string debug);
        void Warning(string warning);
        void Error(string error);
        void Fatal(string fatal);
        void Log(string log, LogLevel loglevel);
    }
}
