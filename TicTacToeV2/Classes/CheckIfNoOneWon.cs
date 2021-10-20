using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToeV2.Classes
{
    public class CheckIfNoOneWon
    {
        private static int value_of_X; // lentos x
        private static int value_of_Y; // lentos y
        private static string choice; //vartotojo pasirinktas X arba O
        private static int max_steps;
        private static int performed_steps;
        public static string[,] boardArray;
        public static bool there_is_a_winner=false;
        public CheckIfNoOneWon(int x, int y, string choice)
        {
            SetX(x);
            SetY(y);
            SetChoice(choice);
            max_steps = x * y;
            boardArray = new string[GetX(), GetY()];
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
        public void Generate_Board()
        {
            for (int i = 0; i < value_of_X; i++)
            {
                
                for (int j = 0; j < value_of_X; j++)
                {



                    for (int z = 0; z < i+j+1; z++)
                    {
                        boardArray[i, j ] += "0";
                    }
                        
                    
                    
                } 
            } 
        }
        public string CheckAll()
        {
            Generate_Board();
            try
            {
              
            checkHorizontalWinner();
            checkVerticalWinner();
            Check_Diagnol_Left_To_Right();
            Check_Diagnol_Right_To_Left();
            if(there_is_a_winner==false)
                {
                    return "NoOneWon";
                }
            }
            
            catch { }
            return "test";
        }
        public string checkHorizontalWinner()
        {
            for (int i = 0; i < value_of_X; i++)
            {
                for (int j = 0; j < value_of_Y - 2; j++)
                {
                    try
                    {

                        if (boardArray[i, j] == choice && boardArray[i, j + 1] == choice && boardArray[i, j + 2] == choice)
                        {
                            there_is_a_winner = true;
                            return choice;
                        }


                    }
                    catch
                    {

                    }
                }
            }

            return "Failed nax";

        }
        public string checkVerticalWinner()
        {
            

            for (int i = 0; i < value_of_X - 2; i++)
            {
                for (int j = 0; j < value_of_Y; j++)
                {
                    try
                    {

                        if (boardArray[i, j] == choice && boardArray[i + 1, j] == choice && boardArray[i + 2, j] == choice)
                        {
                            there_is_a_winner = true;
                            return choice;

                        }


                    }
                    catch
                    {

                    }
                }
            }
            return "failed";

        }
        public string Check_Diagnol_Left_To_Right()
        {
            

            for (int i = 0; i < value_of_X - 2; i++)
            {
                for (int j = 0; j < value_of_Y - 2; j++)
                {
                    try
                    {


                        if (boardArray[i, j] == choice && boardArray[i + 1, j + 1] == choice && boardArray[i + 2, j + 2] == choice)
                        {
                            there_is_a_winner = true;
                            return choice;
                        }


                    }
                    catch
                    {

                    }
                }
            }
            return "failed";

        }
        public string Check_Diagnol_Right_To_Left()
        {
            

            for (int i = 0; i < value_of_X - 2; i++)
            {
                for (int j = 2; j < value_of_Y; j++)
                {
                    try
                    {


                        if (boardArray[i, j] == choice && boardArray[i + 1, j - 1] == choice && boardArray[i + 2, j - 2] == choice)
                        {
                            there_is_a_winner = true;
                            return choice;
                        }


                    }
                    catch
                    {

                    }
                }
            }
            return "failed";

        }
    }
}
