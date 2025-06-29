using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    internal class FileLogger
    {
        private readonly string _className;
        private readonly string _filePath;

        public FileLogger(string className, string filePath)
        {
            _className = className;
            _filePath = filePath;

            // Создать файл, если он не существует
            if (!File.Exists(_filePath))
            {
                using (File.Create(_filePath)) { }
            }
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

            File.AppendAllText(_filePath, logEntry + Environment.NewLine);
        }
    }
}
