using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using GameOfLifeService;

namespace GoLServer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Serwer Game of Life");
            
            GoLService gol = new GoLService();

            ServiceHost host = new ServiceHost(gol);

            host.Open();

            while (true)
            {
                if (Console.KeyAvailable)
                {

                    var k = Console.ReadKey().Key;
                    if (k == ConsoleKey.Escape) break;
                }
            }

            host.Close();
        }

        
        
    }
}
