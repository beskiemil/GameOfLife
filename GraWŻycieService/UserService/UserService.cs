using GameOfLifeService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraWŻycieService.UserService
{
    public class UserService: IUserService
    {
        private static UserService _instance;
        public static UserService GetInstance()
        {
            if (_instance == null) _instance = new UserService();
            return _instance;
        }

        public string UsersFile { get; set; }

        public List<User> Users { get; set; }

        public bool AddUser(string nick, string password)
        {
            if (FindUser(nick) == null)
            {
                User newUser = new User(nick, password);
                Users.Add(newUser);
                SaveUsers();
                return true;
            }
            else return false;
            
        }

        public bool CheckUsersPassword(string nick, string password)
        {
            var thisuser = FindUser(nick);
            if( thisuser != null)
            {
                if (thisuser.Password == password) return true;
                else return false;
            }
            return false;
        }

        public User FindUser(string nick)
        {
            if (Users.Count > 0)
            {
                var thisuser = Users.Find(user => user.Nickname == nick);
                if (thisuser == null) return null;
                else return thisuser;
            }
            else return null;

        }

        public void LoadUsers()
        {
            Users= new List<User>();
            var stream = FileManager.GetInstance().ReadFromFile(UsersFile);
            var userslist = stream.Split('\n');
            foreach (var user in userslist)
            {
                //var trimmed = user.TrimEnd();
                var credensials = user.Split(',');
                if (credensials.Length > 1)
                {
                    var newUser = new User(credensials[0], credensials[1]);
                    Users.Add(newUser);
                }
                
            }
        }

        public void SaveUsers()
        {
            List<string> users = new List<string>();
            foreach (var user in Users)
            {
                List<string> newUser= new List<string>();
                newUser.Add(user.Nickname); newUser.Add(user.Password);
                var stringUser = string.Join(",", newUser);
                users.Add(stringUser);
            }
            var stringUsers = string.Join("\n", users);

            FileManager.GetInstance().ReplaceFile(UsersFile, stringUsers);
        }
    }
}
