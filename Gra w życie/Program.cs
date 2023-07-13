using Gra_w_życie.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gra_w_życie
{
    internal static class Program
    {
        /// <summary>
        /// Główny punkt wejścia dla aplikacji.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            LoginForm loginform = new LoginForm();
            Application.Run(loginform);
            if(loginform.DialogResult== DialogResult.OK)
            {
                loginform.Close();
                Application.Run(new StartMenuForm());
            }
        }
    }
}
