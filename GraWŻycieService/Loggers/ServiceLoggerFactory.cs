using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraWŻycieService.Loggers
{
    public class ServiceLoggerFactory : ILoggerFactory
    {
        public ServiceLoggerFactory() { }
        public IConsoleLogger CreateConsoleLogger(string fileName)
        {
            return new ConsoleLogger(CreateFileLogger(fileName));
        }

        public IFileLogger CreateFileLogger(string fileName)
        {
            return new FileLogger(fileName);
        }
    }
}
