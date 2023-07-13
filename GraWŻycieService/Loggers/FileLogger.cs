using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraWŻycieService.Loggers
{
    public class FileLogger : IFileLogger
    {
        public string FileName { get; protected set; }
        public FileLogger(string fileName)
        {
            FileName = fileName;
        }

        public virtual void LogMessage(string message)
        {
            StreamWriter file = new StreamWriter(FileName, true, Encoding.UTF8);
            file.WriteLine( DateTime.Now.ToString()+" "+message);
            file.Close();
        }
    }
}
