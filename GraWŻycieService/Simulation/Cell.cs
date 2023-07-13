using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace GameOfLifeService.Model
{

    [Serializable]
    [DataContract]
    public class Cell : ICell
    {
        [DataMember] 
        public bool Alive { get; set; }
        public Cell()
        {
            Alive = false;
        }
        public void DieOrRevive()
        {
            Alive = !Alive;
        }
    }
}
