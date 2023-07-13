using SymulacjaGameOfLifePLPRO;

namespace SymulacjaGameOfLifePLPRO
{
    public interface IGraWZycieSymulacjaPro
    {
        int MaxLiczbaTur { get; }
        string Nazwa { get; }
        string Nick { get; }
        int RozmiarPlanszy { get; }
        Komorka[][][] Rundy { get; }
        Komorka[][][] PobierzRundy(Komorka[][] startingCells);
    }
}