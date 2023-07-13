using GameOfLifeService.Model;
using GraWŻycieService;
using GraWŻycieService.Loggers;
using GraWŻycieService.Model;
using GraWŻycieService.UserService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Xml.Linq;


namespace GameOfLifeService
{
    // UWAGA: możesz użyć polecenia „Zmień nazwę” w menu „Refaktoryzuj”, aby zmienić nazwę klasy „Service1” w kodzie i pliku konfiguracji.
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single)]
    public class GoLService : IGoLService
    {
        private IUserService userService;

        private static string logFile = "logs.txt";
        public static string LogFile
        {
            get { return logFile; }
        }

        public IConsoleLogger ConsoleLogger { get; private set; }
        public IFileLogger FileLogger { get; private set; }

        public GoLService() 
        {
            ServiceLoggerFactory loggerFactory = new ServiceLoggerFactory();
            ConsoleLogger = loggerFactory.CreateConsoleLogger(LogFile);

            userService = UserService.GetInstance();
            userService.UsersFile = "users.txt";
            userService.LoadUsers();
        }


        public bool Login(string nick, string password)
        {
            if (userService.FindUser(nick) != null)
            {
                if(userService.CheckUsersPassword(nick, password))
                {
                    ConsoleLogger.LogMessage($"Użytkownik zalogowany: {nick}");
                    
                    return true;
                }
                else
                {
                    ConsoleLogger.LogMessage($"Nieudana próba zalogowania: {nick}. Złe hasło.");
                    return false;
                }
            }
            else
            {
                userService.AddUser(nick, password);
                ConsoleLogger.LogMessage($"Użytkownik utworzony i zalogowany: {nick}");
                return true;
            }
        }

        public bool Logout(string nick)
        {
            ConsoleLogger.LogMessage($"Wylogowano: {nick}");
            return true;
        }

        public Cell[][][] GetAllRounds(int boardSide, int maxrounds, string nick, string name, Cell[][] cellsState)
        {
            //ISimulation simulation = new SaveToFileProxy(boardSide, nick, name, maxrounds);
            ISimulation simulation = new SaveToFileProxy(new Simulation(boardSide, nick, name, maxrounds));
            var rounds = simulation.GetAllRounds(cellsState);
            ConsoleLogger.LogMessage($"Użytkownik: {nick} pobrał symulacje {name}");
            return rounds;
        }
    }
}
