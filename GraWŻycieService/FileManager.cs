using GameOfLifeService;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraWŻycieService
{
    public class FileManager
    {
        private FileManager() { }

        public static FileManager _instance;

        public static FileManager GetInstance() {
            if (_instance == null) _instance = new FileManager();
            return _instance;
        }


        public void AppendToFile(string fileName, string message) 
        {
            StreamWriter file = new StreamWriter(fileName, true, Encoding.UTF8);
            file.WriteLine(message);
            file.Close();
        }
        public string ReadFromFile(string fileName)
        {
            StreamReader file = new StreamReader(fileName, Encoding.UTF8);
            string tmp = file.ReadToEnd();
            file.Close();
            return tmp;
        }
        public void ReplaceFile(string fileName, string message)
        {
            StreamWriter file = new StreamWriter(fileName, false, Encoding.UTF8);
            file.Write(message);
            file.Close();

        }
    }
}
