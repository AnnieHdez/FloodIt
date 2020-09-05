using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace New_Flood_it
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            board_Flood_It_Control.Board = new Flood_It_Logic(8, 8);
        }

        private void butRed_Click(object sender, EventArgs e)
        {
            board_Flood_It_Control.Board.FloodBoard(Color.Red);
            board_Flood_It_Control.Invalidate();
            labSteps.Text = board_Flood_It_Control.Board.Count_Steps + " steps";
            if(board_Flood_It_Control.Board.IsGameOver())
                MessageBox.Show("Ha terminado la partida en " + board_Flood_It_Control.Board.Count_Steps + " steps");
        }

        private void butBlue_Click(object sender, EventArgs e)
        {
            board_Flood_It_Control.Board.FloodBoard(Color.Blue);
            board_Flood_It_Control.Invalidate();
            labSteps.Text = board_Flood_It_Control.Board.Count_Steps + " steps";
            if(board_Flood_It_Control.Board.IsGameOver())
                MessageBox.Show("Ha terminado la partida en " + board_Flood_It_Control.Board.Count_Steps + " steps");
        }

        private void butPurple_Click(object sender, EventArgs e)
        {
            board_Flood_It_Control.Board.FloodBoard(Color.Purple);
            board_Flood_It_Control.Invalidate();
            labSteps.Text = board_Flood_It_Control.Board.Count_Steps + " steps";
           if (board_Flood_It_Control.Board.IsGameOver())
               MessageBox.Show("Ha terminado la partida en " + board_Flood_It_Control.Board.Count_Steps + " steps");
        }

        private void butGreen_Click(object sender, EventArgs e)
        {
            board_Flood_It_Control.Board.FloodBoard(Color.Green);
            board_Flood_It_Control.Invalidate();
            labSteps.Text = board_Flood_It_Control.Board.Count_Steps + " steps";
            if(board_Flood_It_Control.Board.IsGameOver())
                MessageBox.Show("Ha terminado la partida en " + board_Flood_It_Control.Board.Count_Steps + " steps");
        }

        private void butYellow_Click(object sender, EventArgs e)
        {
            board_Flood_It_Control.Board.FloodBoard(Color.Yellow);
            board_Flood_It_Control.Invalidate();
            labSteps.Text = board_Flood_It_Control.Board.Count_Steps + " steps";
            if (board_Flood_It_Control.Board.IsGameOver())
                MessageBox.Show("Ha terminado la partida en " + board_Flood_It_Control.Board.Count_Steps + " steps");
        }

        private void butOrange_Click(object sender, EventArgs e)
        {
            board_Flood_It_Control.Board.FloodBoard(Color.Orange);
            board_Flood_It_Control.Invalidate();
            labSteps.Text = board_Flood_It_Control.Board.Count_Steps + " steps";
            if(board_Flood_It_Control.Board.IsGameOver())
                MessageBox.Show("Ha terminado la partida en " + board_Flood_It_Control.Board.Count_Steps + " steps");
        }

        private void butResert_Click(object sender, EventArgs e)
        {
            board_Flood_It_Control.Board.InitializeBoard();
            board_Flood_It_Control.Invalidate();
            labSteps.Text = board_Flood_It_Control.Board.Count_Steps + " steps";
            
        }

        private void comSize_SelectedValueChanged(object sender, EventArgs e)
        {
            if (comSize.SelectedIndex == 0)
            {
                board_Flood_It_Control.Board.Rows = 8;
                board_Flood_It_Control.Board.Columns = 8;
            }
            else if (comSize.SelectedIndex == 1)
            {
                board_Flood_It_Control.Board.Rows = 10;
                board_Flood_It_Control.Board.Columns = 10;
            }
            else
            {
                board_Flood_It_Control.Board.Rows = 16;
                board_Flood_It_Control.Board.Columns = 16;
            }
            board_Flood_It_Control.Board.InitializeBoard();
            board_Flood_It_Control.Invalidate();
            labSteps.Text = board_Flood_It_Control.Board.Count_Steps + " steps";
        }

        private void butSolve_Click(object sender, EventArgs e)
        {
            Color[] solutions =  board_Flood_It_Control.Board.SearchForTheBestSolutions();
        }
       
    }
}
