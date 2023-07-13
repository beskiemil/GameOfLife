using GameOfLifeService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraWŻycieService.UserService
{
    public interface IUserService
    {
        string UsersFile { get; set; }
        List<User> Users { get; set; }
        bool AddUser(string nick, string password);
        bool CheckUsersPassword(string nick, string password);
        User FindUser(string username);
        void LoadUsers();
        void SaveUsers();
    }
}
