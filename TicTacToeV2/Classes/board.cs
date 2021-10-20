using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToeV2.Classes
{
    
    public class board
    {
        Button[,] button;
        private static int x; // x asis lentos
        private static int y; // y asis lentos
        private static int max_steps; // maskimalus kiekis zingsiu pagal lentos dydi
        private static int performed_steps;
        private static Logic logic = new Logic();
        String turn;

        public board(Button[,] buttons, int x, int y,string turn)
        {
            SetButton(buttons);
            Set_X_Axis(x);
            Set_Y_Axis(y);
            SetTurn(turn);
            max_steps = x * y;
            

        }

        public int Get_X_Axis()
        {
            return x;
        }
        public int Set_X_Axis(int x_axis)
        {
            x=x_axis;
            return x;
        }
        public int Get_Y_Axis()
        {
            return y;
        }
        public int Set_Y_Axis(int y_axis)
        {
            y = y_axis;
            return y;
        }
        public Button[,] GetButton()
        {
            return button;
        }
        public Button[,] SetButton(Button[,] buttons)
        {
            button = buttons;
            return button;

        }
        public string GetTurn()
        {
            return turn;
        }
        public string SetTurn(string turnS)
        {
            turn = turnS;
            return turn;
        }
        public void GenerateBoard(int X, int Y,Panel panel1)
        {
            

            button = new Button[X, Y];
            int increments = 0; 
            for (int i = 0; i < X; i++)
            {
                for (int j = 0; j < Y; j++)
                {
                    button[i, j] = new Button(); 
                    button[i, j].Parent = panel1; 
                    button[i, j].Width = panel1.Width / X; 
                    button[i, j].Height = panel1.Height / X;

                    button[i, j].Top = j * panel1.Height / X; 
                    button[i, j].Left = i * panel1.Width / X; 
                    button[i, j].Click += new EventHandler(onclick);
                    button[i, j].MouseEnter += new EventHandler(button_enter); 
                    button[i, j].MouseLeave += new EventHandler(button_leave); 

                    button[i, j].Tag = increments; 

                    int newSize = 22;
                    button[i, j].Font = new Font(button[i, j].Font.FontFamily, newSize, FontStyle.Bold);
                    increments++;



                }
            }
            logic.SetButton(button);
        }
        private void onclick(object sender, EventArgs e)
        {

            
            Button b = (Button)sender;

            performed_steps++;
            logic.SetPerformed_Steps(performed_steps);
          
            if (turn == "X")
            {
                turn = "0";
            }
            else
            {
                turn = "X";
            }
            b.Enabled = false;
            checker();


        }
        private void checker()
        {

            logic.check3x3();

        }


        private void button_enter(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (b.Text == "")
            {
                if (turn == "X")
                {
                    b.Text = "X";
                }
                else
                {
                    b.Text = "0";
                }
            }

            // Switch from X to O

        }

        private void button_leave(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (b.Enabled)
            {
                b.Text = "";
            }

        }




    }
}
