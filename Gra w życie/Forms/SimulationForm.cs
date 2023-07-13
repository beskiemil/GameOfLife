using GameOfLifeService;
using GameOfLifeService.Model;
using Gra_w_życie.API;
using GraWZycieControlLibrary.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Gra_w_życie.Forms
{
    public partial class SimulationForm : Form
    {
        private int boardSize;
        public int BoardSide { get => boardSize; set { boardSize = value; SetBoardParameters(); } }

        private int maxRounds;
        public int MaxRounds { get => maxRounds; set { maxRounds = value; SetBoardParameters(); } }

        private string gameName = "";
        public string GameName { get => gameName; set { gameName = value; SetBoardParameters(); } }

        public int Round { get; set; }

        private Cell[][][] rounds;
        public Cell[][][] Rounds { get { return rounds; } set { rounds = value; } }

        public GoLServiceClient client = new GoLServiceClient();

        public SimulationForm()
        {
            

            InitializeComponent();
            SetBoardParameters();
            Round = 0;
        }

        public void SetBoardParameters()
        {
            boardControl.BoardSide = BoardSide;
            //Rounds = new Cell[MaxRounds][][];
            Size = new Size(boardControl.Size.Width+150, boardControl.Size.Height+40);

        }

        private async void pobierzSymulacjeButton_Click(object sender, EventArgs e)
        {
            if(thread == null)
            {
                var cellsState = boardControl.GetCellControlsState();
                Rounds = await client.GetAllRoundsAsync(BoardSide, MaxRounds, LoginCredensials.Nick, GameName, cellsState);
            }
            Round = 0; 
            
        }

        private void nextRoundButton_Click(object sender, EventArgs e)
        {
            if (Rounds != null)
            {
                if (Round < MaxRounds - 1)
                {
                    Round++;

                }
                boardControl.SetCellControlsState(Rounds[Round]);
            }
            else MessageBox.Show("Nie wygenerowano symulacji");
            
        }

        private void previousRound_Click(object sender, EventArgs e)
        {
            if (Rounds != null)
            {
                if (Round > 0)
                {
                    Round--;

                }
                boardControl.SetCellControlsState(Rounds[Round]);
            }
            else MessageBox.Show("Nie wygenerowano symulacji");
        }


        Thread thread;

        private void playButton_Click(object sender, EventArgs e)
        {
            if (Rounds != null)
            {
                if (thread == null)
                {
                    boardControl.SwitchCellControls();
                    var interval = (int)intervalNumericUpDown.Value;
                    thread = new Thread(() => runSimulation(interval));
                    thread.Start();
                }
            }else MessageBox.Show("Nie wygenerowano symulacji");

        }

        private void runSimulation(int interval)
        {
            for (int i = 0; i < MaxRounds; i++)
            {
                nextRoundButton_Click(new object(), new EventArgs());
                Thread.Sleep(interval);
                
            }
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            if (thread != null)
            {
                thread?.Abort();
                thread= null;
                boardControl.SwitchCellControls();
            }
            
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            if (thread == null)
                boardControl.KillAllCells();
        }
    }

    

}

