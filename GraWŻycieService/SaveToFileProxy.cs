using GameOfLifeService.Model;
using GraWŻycieService.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace GraWŻycieService
{
    public class SaveToFileProxy : ISimulation
    {
        public SaveToFileProxy(int boardSide, string nick, string name, int maxrounds)
        {
            Name = name;
            Nick = nick;
            Simulation = new Simulation(boardSide, nick, name, maxrounds);
        }

        public SaveToFileProxy(ISimulation simulation)
        {
            Simulation = simulation;
            Name = simulation.Name;
            Nick = simulation.Nick;
        }
        public string Name { get; set; }

        public string Nick { get; set; }

        private ISimulation Simulation { get; set; }

        public virtual Cell[][][] Rounds { get; set; }

        public virtual Cell[][][] GetAllRounds(Cell[][] startingCells)
        {
            Rounds = Simulation.GetAllRounds(startingCells);
            if(Rounds != null)
            {
                Thread saveThread = new Thread(() => Save(Rounds));
                saveThread.Start();
            }
            return Rounds;
        }

        public virtual void Save(Cell[][][] rounds)
        {
            string filename = Nick + "_" + Name+".txt";
            string text = "";
            foreach (var round in rounds)
            {
                foreach (var column in round)
                {
                    foreach (var row in column)
                    {
                        if (row.Alive) text += "1";
                        else text += "0";
                    }
                    text += ",";
                }
                text += ";";
            }
            FileStream fs = new FileStream(filename, FileMode.Create, FileAccess.ReadWrite, FileShare.ReadWrite);
            byte[] bytes = Encoding.UTF8.GetBytes(text);

            fs.Write(bytes, 0, text.Length);

            fs.Close();

            Thread.CurrentThread.Abort();
        }
    }
}
