using GameOfLifeService;
using Gra_w_życie.API;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gra_w_życie.Forms
{
    public partial class LoginForm : Form
    {

        public string nick;
        public string password;

        public LoginForm()
        {
            InitializeComponent();
            DialogResult = DialogResult.No;
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            if (nickTextBox.Text != "")
            {
                if (passwordTextBox.Text != "")
                {

                    GoLServiceClient client = new GoLServiceClient();
                    if (client.Login(nickTextBox.Text, passwordTextBox.Text))
                    {
                        LoginCredensials.Nick = nickTextBox.Text;
                        DialogResult = DialogResult.OK;
                        Close();
                    }
                    else MessageBox.Show("Złe hasło!");

                }
                else
                {
                    MessageBox.Show("Wpisz haslo!");
                }

            }
            else
            {
                MessageBox.Show("Wpisz nick!");
            }


            

        }
    }
}
