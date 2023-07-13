using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraWŻycieService.Loggers
{
    public class ConsoleLogger : IConsoleLogger
    {
        public IFileLogger FileLogger { get; protected set; }

        public ConsoleLogger(IFileLogger fileLogger)
        {
            FileLogger = fileLogger;
        }

        public virtual void LogMessage(string message)
        {
            Console.WriteLine(DateTime.Now.ToString() + " " + message);
            FileLogger.LogMessage(message);
        }
    }
}
