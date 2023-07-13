using GameOfLifeService.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GraWZycieControlLibrary.Controls
{
    public partial class CellControl : UserControl
    {
        private bool alive = false;
        public bool Alive
        {
            get { return alive; }
            set {
                alive = value;
                if (value) _Color = Brushes.Blue;
                else _Color = Brushes.White;
                Invalidate(); 
            }
        }


        private Brush color = Brushes.White;
        private Brush _Color
        {
            get { return color; }
            set { color = value; }
        }


        private Rectangle cellRect;
        private Rectangle CellRect
        {
            get { return cellRect; }
            set { cellRect = value; }
        }



        public CellControl()
        {
            Text = "cell";

            Size = new Size(30, 30);
            MaximumSize = Size;
            MinimumSize = Size;

            Rectangle newRect = new Rectangle(0, 0, Size.Width-1, Size.Height-1);
            CellRect = newRect;

            InitializeComponent();
        }
        public CellControl(string number, int cellSize)
        {
            Text = $"cell{number}";

            this.Size = new Size(cellSize, cellSize);
            MaximumSize = Size;
            MinimumSize = Size;

            Rectangle newRect = new Rectangle(0, 0, Size.Width - 1, Size.Height - 1);
            CellRect = newRect;

            InitializeComponent();

        }

        
        public virtual void DieOrRevive()
        {
            if (Alive)
            {
                Alive = false;
                _Color = Brushes.White;
            }
            else
            {
                Alive = true;
                _Color = Brushes.Blue;
            }
            Invalidate();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            OnCellPaint(e.Graphics);
        }

        protected virtual void OnCellPaint(Graphics g)
        {
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            Pen pen = new Pen(Color.Black, 1);
            g.FillRectangle(_Color, CellRect);
            g.DrawRectangle(pen, CellRect);

        }

        protected virtual void Cell_Click(object sender, EventArgs e)
        {
            DieOrRevive();
        }

        
    }
}
