using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToeV2.Classes
{
    public class Logic
    {
        Button[,] button;
        private static int value_of_X; // lentos x
        private static int value_of_Y; // lentos y
        private static string choice; //vartotojo pasirinktas X arba O
        private static int max_steps;
        private static int performed_steps;
        public Logic()
        {

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

        public int GetX()
        {
            return value_of_X;
        }
        public int SetX(int received_value_of_X)
        {
            value_of_X = received_value_of_X;
            return value_of_X;

        }

        public int GetY()
        {
            return value_of_Y;
        }
        public int SetY(int received_value_of_Y)
        {
            value_of_Y = received_value_of_Y;
            return value_of_Y;

        }
        public string GetChoice()
        {

            return choice;

        }
        public string SetChoice(string received_value_of_choice)
        {
            choice = received_value_of_choice;
            return choice;

        }
        public int GetMax_Steps()
        {
            return max_steps;
        }
        public int SetMax_Steps(int steps)
        {
            max_steps = steps;
            return max_steps;
        }
        public int GetPerformed_Steps()
        {
            return performed_steps;
        }
        public int SetPerformed_Steps(int steps)
        {
            performed_steps = steps;
            return performed_steps;
        }



        public void check3x3()
        {
            for (int i = 0; i < value_of_X; i++)
            {
                for (int j = 0; j < value_of_Y; j++)
                {
                    check1(i, j, "X");
                    check1(i, j, "0");
                }
            }
            if (max_steps == performed_steps)
            {
                DialogResult result = MessageBox.Show("Lygiosios", " Zaisti is naujo?", MessageBoxButtons.YesNo);

                if (Convert.ToString(result) == "Yes")
                {
                    lenta.ActiveForm.Hide();


                    performed_steps = 0;
                    max_steps = 0;
                    Form1 form = new Form1();
                    form.ShowDialog();
                }
                else
                {
                    // lenta.ActiveForm.Close();
                    Application.Exit();
                }
            }


        }
        public void check1(int i, int j, string x)
        {
            try
            {
                CheckHorizontal(x);
                CheckVertical(x);
                CheckDiagnoal1( x);
                CheckDiagnoal2( x);
                

            }
            catch
            {
               
            }


        }
        public void CheckHorizontal(string x)
        {
            for (int i = 0; i < value_of_X - 2; i++)
            {
                for (int j = 0; j < value_of_Y; j++)
                {
                    try
                    {

                        if (button[i, j].Text == x && button[i + 1, j].Text == x && button[i + 2, j].Text == x)
                        {
                            win(x);
                        }


                    }
                    catch
                    {

                    }
                }
            }


        }
        private void CheckVertical(string x)
        {
            for (int i = 0; i < value_of_X; i++)
            {
                for (int j = 0; j < value_of_Y - 2; j++)
                {
                    try
                    {

                        if (button[i, j].Text == x && button[i, j + 1].Text == x && button[i, j + 2].Text == x)
                        {
                            win(x);
                        }


                    }
                    catch
                    {

                    }
                }
            }

        }
        private void CheckDiagnoal1( string x)
        {
            for (int i = 0; i < value_of_X; i++)
            {
                for (int j = 0; j < value_of_Y - 2; j++)
                {
                    try
                    {

                        if (button[i, j].Text == x && button[i+1, j + 1].Text == x && button[i+2, j + 2].Text == x)
                        {
                            win(x);
                        }


                    }
                    catch
                    {

                    }
                }
            }

        }
        private void CheckDiagnoal2( string x)
        {
            for (int i = 2; i < value_of_X; i++)
            {
                for (int j = 0; j < value_of_Y - 2; j++)
                {
                    try
                    {

                        if (button[i, j].Text == x && button[i - 1, j + 1].Text == x && button[i - 2, j + 2].Text == x)
                        {
                            win(x);
                        }


                    }
                    catch
                    {

                    }
                }
            }

        }
        public string win(string Xor0)
        {

            for (int i = 0; i < value_of_X; i++)
            {
                for (int j = 0; j < value_of_Y; j++)
                {


                    if (button[i, j].Text == "")
                    {
                        button[i, j].Enabled = false;
                        
                    }

                }
            }
            DialogResult result = MessageBox.Show(Xor0 + " Laimejo", "Zaisti is naujo?", MessageBoxButtons.YesNo);

            if (Convert.ToString(result) == "Yes")
            {
                lenta.ActiveForm.Hide();

                performed_steps = 0;
                max_steps = 0;
                Form1 form = new Form1();
                form.ShowDialog();
            }
            else
            {
                // lenta.ActiveForm.Close();
                Application.Exit();
            }
            return (Xor0);


        }







    }
}
