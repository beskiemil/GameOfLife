using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace SymulacjaGameOfLifePLPRO
{
    public class Komorka : IKomorka
    {
        public bool Zyje { get; set; }
        public Komorka()
        {
            Zyje = false;
        }
        public void ZabijLubWskrzes()
        {
            Zyje = !Zyje;
        }
    }
}
