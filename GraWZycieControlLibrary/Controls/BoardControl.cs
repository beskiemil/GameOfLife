using GameOfLifeService.Model;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace GraWZycieControlLibrary.Controls
{
    public partial class BoardControl : UserControl
    {
        //public delegate void BoardPropertyChangedHandler();
        //public event BoardPropertyChangedHandler PropertyChanged;


        private int boardSide = 15;
        [DefaultValue(15)]
        [Browsable(true)]
        [Category("Board Settings")]
        [Description("Size of the board side. The board is a square of a set side. f.e. :4 => 4x4")]
        public int BoardSide
        {
            get { return boardSide; }
            set { boardSide = value; SetBoardControlSize(); GenerateCellControls(); }
        }

        private int cellSize = 20;
        [DefaultValue(20)]
        [Browsable(true)]
        [Category("Board Settings")]
        [Description("Single cell size in pixels.")]
        public int CellSize
        {
            get { return cellSize; }
            set { cellSize = value; SetBoardControlSize(); GenerateCellControls(); }
        }

        private int spaceSize = 3;
        [DefaultValue(3)]
        [Browsable(true)]
        [Category("Board Settings")]
        [Description("Size of the space between cells in pixels.")]
        public int SpaceSize
        {
            get { return spaceSize; }
            set { spaceSize = value; SetBoardControlSize(); GenerateCellControls(); }
        }

        private CellControl[][] CellControls { get; set; }


        public BoardControl()
        {
            InitializeComponent();
            BackColor = Color.Wheat;
            SetBoardControlSize();
            GenerateCellControls();

        }
        public BoardControl(int boardSide)
        {
            InitializeComponent();
            BackColor = Color.Wheat;
            BoardSide = boardSide;
            SetBoardControlSize();
        }

        public void SetBoardControlSize()
        {
            Size boardSize = new Size(BoardSide * CellSize + (BoardSide - 1) * SpaceSize, BoardSide * CellSize + (BoardSide - 1) * SpaceSize);
            this.Size = boardSize;
            this.MaximumSize = boardSize;
            this.MinimumSize = boardSize;


            Invalidate();
        }


        public void GenerateCellControls()
        {
            this.Controls.Clear();
            CellControls = new CellControl[BoardSide][];

            for (int i = 0; i < BoardSide; i++)
            {
                CellControls[i] = new CellControl[BoardSide];
                for (int j = 0; j < BoardSide; j++)
                {
                    CellControl newCell = new CellControl($"{i}{j}", CellSize);
                    newCell.Location = new Point(i * (CellSize + SpaceSize), j * (CellSize + SpaceSize));
                    CellControls[i][j] = newCell;
                    this.Controls.Add(CellControls[i][j]);

                }
            }
        }

        public Cell[][] GetCellControlsState()
        {
            Cell[][] newCellsState = new Cell[BoardSide][];
            for (int i = 0; i < BoardSide; i++)
            {
                newCellsState[i] = new Cell[BoardSide];
                for (int j = 0; j < BoardSide; j++)
                {
                    newCellsState[i][j] = new Cell();
                    if (CellControls[i][j].Alive) newCellsState[i][j].Alive = true;
                }
            }


            return newCellsState;
        }

        public void SetCellControlsState(Cell[][] newCellState)
        {

            for (int i = 0; i < BoardSide; i++)
            {
                for (int j = 0; j < BoardSide; j++)
                {
                    if (CellControls[i][j].Alive != newCellState[i][j].Alive) CellControls[i][j].Alive = newCellState[i][j].Alive;

                }
            }
        }

        public void SwitchCellControls()
        {
            foreach (var c in CellControls)
            {
                foreach (var cell in c)
                {
                    if (cell.Enabled) cell.Enabled = false;
                    else cell.Enabled = true;
                }
            }
        }

        public void KillAllCells()
        {
            foreach (var c in CellControls)
            {
                foreach (var cell in c)
                {
                    cell.Alive = false;
                }
            }
        }
    }



}
