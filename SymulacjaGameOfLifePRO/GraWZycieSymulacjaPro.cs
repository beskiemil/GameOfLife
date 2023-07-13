using SymulacjaGameOfLifePLPRO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SymulacjaGameOfLifePLPRO
{
    public class GraWZycieSymulacjaPro : IGraWZycieSymulacjaPro

    {
        public int RozmiarPlanszy { get; private set; }

        public string Nazwa { get; private set; }
        public string Nick { get; private set; }
        public int MaxLiczbaTur { get; private set; }
        public Komorka[][][] Rundy { get; private set; }


        public GraWZycieSymulacjaPro(int rozmiarPlanszy, string nick, string nazwa, int maxliczbatur)
        {
            Nick = nick;
            RozmiarPlanszy = rozmiarPlanszy;
            Nazwa = nazwa;
            MaxLiczbaTur = maxliczbatur;
            Rundy = new Komorka[MaxLiczbaTur][][];

        }

        public virtual Komorka[][][] PobierzRundy(Komorka[][] startingCells)
        {
            for (int i = 0; i < MaxLiczbaTur; i++)
            {
                Rundy[i] = new Komorka[RozmiarPlanszy][];
                for (int j = 0; j < RozmiarPlanszy; j++)
                {
                    Rundy[i][j] = new Komorka[RozmiarPlanszy];
                    for (int k = 0; k < RozmiarPlanszy; k++)
                    {
                        Rundy[i][j][k] = new Komorka();
                    }
                }
            }
            Rundy[0] = startingCells;
            RozpocznijSymulacje();
            return Rundy;
        }

        protected virtual void RozpocznijSymulacje()
        {
            for (int i = 0; i < MaxLiczbaTur - 1; i++)
            {

                Symuluj(i, i + 1);
            }
        }

        protected virtual void Symuluj(int aktualnarunda, int nastepnaRunda)
        {

            for (int i = 0; i < RozmiarPlanszy; i++)
            {
                for (int j = 0; j < RozmiarPlanszy; j++)
                {
                    int zywiSasiedzi = PoliczZywych(aktualnarunda, i, j);

                    if (Rundy[aktualnarunda][i][j].Zyje)
                    {
                        if (zywiSasiedzi < 2) Rundy[nastepnaRunda][i][j].Zyje = false;
                        else if (zywiSasiedzi > 3) Rundy[nastepnaRunda][i][j].Zyje = false;
                        else Rundy[nastepnaRunda][i][j].Zyje = true;
                    }
                    else
                    {
                        if (zywiSasiedzi == 3) Rundy[nastepnaRunda][i][j].Zyje = true;

                    }
                }
            }

        }

        protected virtual int PoliczZywych(int aktualnaRunda, int i, int j)
        {
            int żywi = 0;
            if (i > 0 && j > 0) if (Rundy[aktualnaRunda][i - 1][j - 1].Zyje) żywi++;
            if (i > 0) if (Rundy[aktualnaRunda][i - 1][j].Zyje) żywi++;
            if (i > 0 && j < RozmiarPlanszy - 1) if (Rundy[aktualnaRunda][i - 1][j + 1].Zyje) żywi++;
            if (j > 0) if (Rundy[aktualnaRunda][i][j - 1].Zyje) żywi++;
            if (j < RozmiarPlanszy - 1) if (Rundy[aktualnaRunda][i][j + 1].Zyje) żywi++;
            if (i < RozmiarPlanszy - 1 && j > 0) if (Rundy[aktualnaRunda][i + 1][j - 1].Zyje) żywi++;
            if (i < RozmiarPlanszy - 1) if (Rundy[aktualnaRunda][i + 1][j].Zyje) żywi++;
            if (i < RozmiarPlanszy - 1 && j < RozmiarPlanszy - 1) if (Rundy[aktualnaRunda][i + 1][j + 1].Zyje) żywi++;

            return żywi;
        }
    }
}
