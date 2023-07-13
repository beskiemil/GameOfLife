using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace GameOfLifeService.Model
{
    
    public interface ICell
    {
        bool Alive { get; set; }
        void DieOrRevive();
    }
}
