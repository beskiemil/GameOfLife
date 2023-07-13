using GameOfLifeService.Model;

namespace GraWŻycieService.Model
{
    public interface ISimulation
    {

        string Name { get; }
        string Nick { get; }
        Cell[][][] Rounds { get; }

        Cell[][][] GetAllRounds(Cell[][] startingCells);
    }
}