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
    public partial class StartMenuForm : Form
    {
        
        public StartMenuForm()
        {
            InitializeComponent();
        }

        private void symulacjaButton_Click(object sender, EventArgs e)
        {

            SimulationParametersForm par = new SimulationParametersForm();
            par.ShowDialog();

            if(par.DialogResult== DialogResult.OK)
            {
                SimulationForm simulation = new SimulationForm();
                simulation.MaxRounds = par.maxrounds;
                simulation.GameName = par.name;
                simulation.BoardSide = par.boardsize;
                simulation.Show();
            }

            
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            GoLServiceClient client = new GoLServiceClient();
            client.Logout(LoginCredensials.Nick);
            Close();
        }
    }
}
