using GameOfLifeService.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace GameOfLifeService
{


    [ServiceContract]
    public interface IGoLService
    {
        [OperationContract] bool Login(string nick, string password);
        [OperationContract] bool Logout(string nick);

        [OperationContract] Cell[][][] GetAllRounds(int boardSide, int maxrounds, string nick, string name, Cell[][] startingCells);

    }

}
