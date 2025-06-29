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
        //public void Trace(string trace) { }
        //public void Info(string info) { }
        //public void Debug(string debug) { }
        //public void Warning(string warning) { }
        //public void Error(string error) { }
        //public void Fatal(string fatal) { }
        //public void Log(string log, LogLevel loglevel) { }

        private readonly string _className;

        public ConsoleLogger(string className)
        {
            _className = className;
        }

        public void Trace(string message) => Log(message, LogLevel.Trace);
        public void Debug(string message) => Log(message, LogLevel.Debug);
        public void Info(string message) => Log(message, LogLevel.Info);
        public void Warning(string message) => Log(message, LogLevel.Warning);
        public void Error(string message) => Log(message, LogLevel.Error);
        public void Fatal(string message) => Log(message, LogLevel.Fatal);

        public void Log(string message, LogLevel level)
        {
            string logEntry = $"{DateTime.Now:yyyy-MM-dd HH:mm:ss} | {_className} | {level} | {message}";
            Console.WriteLine(logEntry);
        }
    }
}
