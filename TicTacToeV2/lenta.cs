using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TicTacToeV2.Classes;

namespace TicTacToeV2
{
    public partial class lenta : Form
    {
        Button[,] button; // mygtuko inicializavimas
        private static int value_of_X; // lentos x
        private static int value_of_Y; // lentos y
        private static string X_or_O; // vartotjo pasirinkimas X ar O
        private static int max_steps; // maskimalus kiekis zingsiu pagal lentos dydi

        String turn;
        private static Logic logic = new Logic();
        private static board board;


        public lenta(int X, int Y, string XorY)
        {

            value_of_X = X;
            value_of_Y = Y;
            X_or_O = XorY;
            max_steps = value_of_X * value_of_Y;
            turn = X_or_O;
            InitializeComponent();
            board = new board(button, value_of_X, value_of_Y, turn);
            board.GenerateBoard(value_of_X, value_of_Y, panel1);
            logic.SetX(value_of_X);
            logic.SetY(value_of_Y);
            logic.SetChoice(turn);
            logic.SetMax_Steps(max_steps);
        }


        private void lenta_Load(object sender, EventArgs e)
        {

        }
    }
}