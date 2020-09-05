using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace New_Flood_it
{
    public class Flood_It_Logic
    {
        Color[] colores = new Color[] { Color.Black, Color.Blue, Color.Red, Color.Purple, Color.Yellow, Color.Green, Color.Orange };
        int row, col;
        // Almacena el color que tiene cada casilla del tablero
        Color[,] board;
        // Almacena la informacion de si la casilla esta o no inundada (True = Inundada)
        bool[,] flooded;
        // Almacena la cantidad de casillas inundadas que hay en el tablero
        int count_flooded;
        // Almacena la cantidad de obstaculos que hay en el tablero ( casillas de color negro)
        int count_obstacle;
        // Almacena la cantidad de pasos que se han ejecutado 
        int count_steps;

        // Constructor de la Clase Flood_It_Logic 
        public Flood_It_Logic(int row, int col)
        {
            this.row = row;
            this.col = col;
            InitializeBoard();        
        }

        //Asigna los colores iniciales al tablero asegirando que el resultado sea un tablero valido
        public void InitializeBoard()
        {
            board = new Color[row, col];
            flooded = new bool[row, col];
            // Se marca la casilla [0,0] como inundada porque esta en las reglas del juego
            flooded[0, 0] = true;
            // Se inicializa la cantidad de casillas inundadas en 1
            count_flooded = 1;
            // Se inicializa la cantidad de pasos en 0
            count_steps = 0;
            // Se llama al metodo InitializeBoard() que asigna los colores iniciales al tablero asegirando que el resultado sea un tablero valido
           
            Random random = new Random();
            do
            {
                count_obstacle = 0;
                board[0, 0] = colores[random.Next(1, 7)];
                for (int i = 0; i < Rows; i++)
                {
                    for (int j = 0; j < Columns; j++)
                    {
                        if (i == 0 && j == 0)
                            continue;
                        board[i, j] = colores[random.Next(7)];
                        if (board[i, j] == Color.Black)
                            count_obstacle++;
                    }
                }
            } while (!IsValidBoard());

            FloodBoard(Color_Square(0, 0));
        }

        // Comprueba que el tablero sea valido
        public bool IsValidBoard()
        {
            bool[,] visit = new bool[Rows, Columns];
            int count_square_can_reach = IsValidBoard(0, 0, visit);
            return count_square_can_reach == Total_Square - Count_Obstacle;
        }

        public int IsValidBoard(int posx, int posy, bool[,] visit)
        {
            if ((posx < 0 || posx >= Rows) || (posy < 0 || posy >= Columns))
                return 0;
            if (visit[posx, posy])
                return 0;
            if (board[posx, posy] == Color.Black)
                return 0;
            else
            {
                int result = 1;
                visit[posx, posy] = true;
                result += IsValidBoard(posx, posy - 1, visit);
                result += IsValidBoard(posx, posy + 1, visit);
                result += IsValidBoard(posx - 1, posy, visit);
                result += IsValidBoard(posx + 1, posy, visit);
                return result;
            }
        }

        public int FloodBoard(Color color)
        {
            count_steps++;
            Count_Flooded = 0;
            bool[,] visit = new bool[Rows, Columns];
            FloodBoard(color, 0, 0, visit);
            return Count_Flooded;
        }

        public void FloodBoard(Color color, int posx, int posy, bool[,] visit)
        {
            if (posx < 0 || posx >= Rows || posy < 0 || posy >= Columns)
                return;
            if (visit[posx, posy])
                return;
            if (board[posx, posy] != color && !flooded[posx, posy])
                return;
            else
            {
                board[posx, posy] = color;
                flooded[posx, posy] = true;
                count_flooded++;
                visit[posx, posy] = true;
                FloodBoard(color, posx, posy - 1, visit);
                FloodBoard(color, posx, posy + 1, visit);
                FloodBoard(color, posx - 1, posy, visit);
                FloodBoard(color, posx + 1, posy, visit);
                return;
            }
        }

        //Devuelve Falso cuando todas las casillas no han sido inundadas y True en caso contrario y el juego terminó
        public bool IsGameOver()
        {
            return (Count_Flooded == Total_Square - Count_Obstacle);
        }

        public Color Color_Square(int posx, int posy)
        {
            return this.board[posx, posy];
        }

        public Color[] SearchForTheBestSolutions()
        {
            int[] cant_steps = new int[6];
            for (int i = 0; i < cant_steps.Length; i++)
            {
                cant_steps[i] = int.MaxValue;
            }
            Color[] solutions = new Color[0];
            SearchForTheBestSolutions(ref solutions,ref cant_steps);
            return solutions;
        }

        private int SearchForTheBestSolutions(ref Color[] solutions,ref int[] cant_steps)
        {           
           
            
            Color[,] board_aux = (Color[,])board.Clone();
            bool[,] flooded_aux = (bool[,])flooded.Clone();

            int Count_Flooded_Before = Count_Flooded;
            if (FloodBoard(Color.Red) == Total_Square - Count_Obstacle)
            {
                cant_steps[FindPositionForColor(Color.Red) - 1] = 1;
            }
            else if(Count_Flooded > Count_Flooded_Before)
            {
                cant_steps[FindPositionForColor(Color.Red) - 1] = 1 + SearchForTheBestSolutions(ref solutions,ref cant_steps);
            }


            flooded = (bool[,])flooded_aux.Clone();
            board = (Color[,])board_aux.Clone();            
            if (FloodBoard(Color.Green) == Total_Square - Count_Obstacle)
            {
                cant_steps[FindPositionForColor(Color.Green) - 1] = 1;
            }
            else if (Count_Flooded > Count_Flooded_Before)
            {
                cant_steps[FindPositionForColor(Color.Green) - 1] = 1 + SearchForTheBestSolutions(ref solutions, ref cant_steps);
            }

            board = (Color[,])board_aux.Clone();
            flooded = (bool[,])flooded_aux.Clone();
            if (FloodBoard(Color.Yellow) == Total_Square - Count_Obstacle)
            {
                cant_steps[FindPositionForColor(Color.Yellow) - 1] = 1;
            }
            else if (Count_Flooded > Count_Flooded_Before)
            {
                cant_steps[FindPositionForColor(Color.Yellow) - 1] = 1 + SearchForTheBestSolutions(ref solutions, ref cant_steps);
            }

            board = (Color[,])board_aux.Clone();
            flooded = (bool[,])flooded_aux.Clone();
            if (FloodBoard(Color.Blue) == Total_Square - Count_Obstacle)
            {
                cant_steps[FindPositionForColor(Color.Blue) - 1] = 1;
            }
            else if (Count_Flooded > Count_Flooded_Before)
            {
                cant_steps[FindPositionForColor(Color.Blue) - 1] = 1 + SearchForTheBestSolutions(ref solutions, ref cant_steps);
            }

            board = (Color[,])board_aux.Clone();
            flooded = (bool[,])flooded_aux.Clone();
            if (FloodBoard(Color.Purple) == Total_Square - Count_Obstacle)
            {
                cant_steps[FindPositionForColor(Color.Purple) - 1] = 1;
            }
            else if (Count_Flooded > Count_Flooded_Before)
            {
                cant_steps[FindPositionForColor(Color.Purple) - 1] = 1 + SearchForTheBestSolutions(ref solutions, ref cant_steps);
            }

            board = (Color[,])board_aux.Clone();
            flooded = (bool[,])flooded_aux.Clone();
            if (FloodBoard(Color.Orange) == Total_Square - Count_Obstacle)
            {
                cant_steps[FindPositionForColor(Color.Orange) - 1] = 1;
            }
            else if (Count_Flooded > Count_Flooded_Before)
            {
                cant_steps[FindPositionForColor(Color.Orange) - 1] = 1 + SearchForTheBestSolutions(ref solutions, ref cant_steps);
            }

            solutions = AddColorArrayColores(solutions, colores[FindPositionForMin(cant_steps) + 1]);
            flooded = (bool[,])flooded_aux.Clone();
            board = (Color[,])board_aux.Clone(); 
            return cant_steps.Min();


        }

        private Color[] AddColorArrayColores(Color[] array, Color color)
        {
            Color[] result = new Color[array.Length + 1];
            for (int i = 0; i < array.Length; i++)
            {
                result[i] = array[i];
            }
            result[result.Length - 1] = color;
            return result;
        }

        private int FindPositionForMin(int[] numbers)
        {
            int min = numbers[0];
            int pos = 0;
            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] < min)
                {
                    pos = i;
                    min = numbers[i];
                }
            }
            return pos;
        }

        private int FindPositionForColor(Color color)
        {
            for (int i = 0; i < colores.Length; i++)
            {
                if (colores[i] == color)
                    return i;
            }
            return -1;
        }

        #region Propiedades

        // Devuelve la cantidad de filas
        public int Rows
        { get { return row; }
            set { row = value; }
        }

        // Devuelve la cantidad de columnas
        public int Columns
        { get { return col; }
            set { col = value; }
        }

        // Devuelve la cantidad de obstaculos (casillas de color negro)
        public int Count_Obstacle
        { get { return this.count_obstacle; } }

        // Devuelve la cantidad total de casillas
        public int Total_Square
        { get { return Rows * Columns; } }

        public int Count_Flooded
        { 
            get { return this.count_flooded; }
            set { this.count_flooded = value; }
        }

        public int Count_Steps
        { get { return this.count_steps-1; } }

      

        #endregion

    }
}
