namespace GameOfLifeService
{
    // UWAGA: możesz użyć polecenia „Zmień nazwę” w menu „Refaktoryzuj”, aby zmienić nazwę interfejsu „IService1” w kodzie i pliku konfiguracji.

    public class User
    {
        public string Nickname {get; set; }
        public string Password { get; set; }
        public string Id { get; set; }
        public User(string nickname, string password)
        {
            this.Nickname = nickname;
            this.Password = password;
            
        }

        
    }

}
