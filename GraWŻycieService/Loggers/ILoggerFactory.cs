using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraWŻycieService.Loggers
{
    public interface ILoggerFactory
    {
        IConsoleLogger CreateConsoleLogger(string fileName);
        IFileLogger CreateFileLogger(string fileName);
    }
}
