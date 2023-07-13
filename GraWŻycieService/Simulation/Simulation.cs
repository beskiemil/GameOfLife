using GameOfLifeService.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraWŻycieService.Model
{
    public class Simulation : ISimulation
    {
        public int BoardSide { get; private set; }

        public string Name { get; private set; }
        public string Nick { get; private set; }
        public int MaxRoundNumber { get; private set; }
        public Cell[][][] Rounds { get; private set; }


        public Simulation(int boardSide, string nick, string name, int maxrounds)
        {
            Nick = nick;
            BoardSide = boardSide;
            Name = name;
            MaxRoundNumber = maxrounds;
            Rounds = new Cell[MaxRoundNumber][][];

        }

        public virtual Cell[][][] GetAllRounds()
        {
            if (Rounds == null) return null;
            else return Rounds;

        }

        public virtual Cell[][][] GetAllRounds(Cell[][] startingCells)
        {
            Console.WriteLine("Symuluje sie");
            for (int i = 0; i < MaxRoundNumber; i++)
            {
                Rounds[i] = new Cell[BoardSide][];
                for (int j = 0; j < BoardSide; j++)
                {
                    Rounds[i][j] = new Cell[BoardSide];
                    for (int k = 0; k < BoardSide; k++)
                    {
                        Rounds[i][j][k] = new Cell();
                    }
                }
            }
            Rounds[0] = startingCells;
            StartSimulation();
            return Rounds;
        }

        protected virtual void StartSimulation()
        {
            for (int i = 0; i < MaxRoundNumber - 1; i++)
            {

                Simulate(i, i + 1);
            }
        }

        protected virtual void Simulate(int actualRound, int nextRound)
        {

            for (int i = 0; i < BoardSide; i++)
            {
                for (int j = 0; j < BoardSide; j++)
                {
                    int aliveNeighbours = GetAliveNeighbours(actualRound, i, j);

                    if (Rounds[actualRound][i][j].Alive)
                    {
                        if (aliveNeighbours < 2) Rounds[nextRound][i][j].Alive = false;
                        else if (aliveNeighbours > 3) Rounds[nextRound][i][j].Alive = false;
                        else Rounds[nextRound][i][j].Alive = true;
                    }
                    else
                    {
                        if (aliveNeighbours == 3) Rounds[nextRound][i][j].Alive = true;

                    }
                }
            }

        }

        protected virtual int GetAliveNeighbours(int actualRound, int i, int j)
        {
            int alive = 0;
            if (i > 0 && j > 0) if (Rounds[actualRound][i - 1][j - 1].Alive) alive++;
            if (i > 0) if (Rounds[actualRound][i - 1][j].Alive) alive++;
            if (i > 0 && j < BoardSide - 1) if (Rounds[actualRound][i - 1][j + 1].Alive) alive++;
            if (j > 0) if (Rounds[actualRound][i][j - 1].Alive) alive++;
            if (j < BoardSide - 1) if (Rounds[actualRound][i][j + 1].Alive) alive++;
            if (i < BoardSide - 1 && j > 0) if (Rounds[actualRound][i + 1][j - 1].Alive) alive++;
            if (i < BoardSide - 1) if (Rounds[actualRound][i + 1][j].Alive) alive++;
            if (i < BoardSide - 1 && j < BoardSide - 1) if (Rounds[actualRound][i + 1][j + 1].Alive) alive++;

            return alive;
        }
    }
}
