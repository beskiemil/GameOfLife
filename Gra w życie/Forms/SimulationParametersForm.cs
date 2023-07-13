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
    
    public delegate void LoginHandler(string nick, string password, int boardSize);
    public partial class SimulationParametersForm : Form
    {
        

        public int boardsize;

        public int maxrounds;

        public string name;


        public SimulationParametersForm()
        {
            InitializeComponent();
            MaximumSize = Size;
            MinimumSize = Size;
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            
            

            if (simulationNameTextBox.Text != "")
            {
                name = simulationNameTextBox.Text;
                DialogResult = DialogResult.OK;
            }
            else DialogResult = DialogResult.No;

            boardsize = (int)boardSizeNumericUpDown.Value;
            maxrounds = (int)maxRoundsNumericUpDown.Value;

            if(DialogResult == DialogResult.OK)
            {
                Close();
            }
        }
    }
}
