using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace New_Flood_it
{
    public partial class Board_Flood_It_Control : UserControl
    {
        public Board_Flood_It_Control()
        {
            InitializeComponent();
            ResizeRedraw = true;
            //_Board = new Flood_It_Logic(8, 8);
        }

        Flood_It_Logic _Board;
        public Flood_It_Logic Board
        {
            get { return _Board; }
            set
            {
                _Board = value;
                Invalidate();
            }
        }

        private void Board_Flood_It_Control_Paint(object sender, PaintEventArgs e)
        {
            float width_square = this.Width / _Board.Columns;
            float heigth_square = this.Height / _Board.Rows;
            for (int i = 0; i < _Board.Columns; i++)
            {
                for (int j = 0; j < _Board.Rows; j++)
                {                    
                    SolidBrush b = new SolidBrush(_Board.Color_Square(i,j));
                    e.Graphics.FillRectangle(b, i * width_square, j * heigth_square, width_square, heigth_square);
                }
            }
        }
    }
}
