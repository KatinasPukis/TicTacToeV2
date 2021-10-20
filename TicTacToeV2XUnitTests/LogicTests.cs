using System;
using System.Windows.Forms;
using TicTacToeV2;
using TicTacToeV2.Classes;
using Xunit;

namespace TicTacToeV2XUnitTests
{
    public class LogicTests
    {
        
        [Theory]
        [InlineData(3,3,"X")]
        [InlineData(4, 4, "0")]
        [InlineData(5, 5, "0")]
        public void Check_Horizontal_Win(int x, int y, string choice)
        {
            
            CheckHorizontalWin checkHorizontal = new CheckHorizontalWin(x, y, choice);
            Assert.Equal(choice, checkHorizontal.checkHorizontalWinner());
        }

        [Theory]
        [InlineData(3, 3, "X")]
        [InlineData(4, 4, "X")]
        [InlineData(5, 5, "X")]
        public void Check_Vetical_Win(int x, int y, string choice)
        {
            
            CheckVerticalWin checkVerticalWin = new CheckVerticalWin(x, y, choice);
            Assert.Equal(choice, checkVerticalWin.checkVerticalWinner());
        }

        [Theory]
        [InlineData(3, 3, "X")]
        [InlineData(4, 4, "X")]
        [InlineData(5, 5, "X")]
        public void Check_Diagnol_Left_To_Right_Win(int x, int y, string choice)
        {

            CheckDiagnolLeftToRight checkDiagnolLeftToRight = new CheckDiagnolLeftToRight(x, y, choice);
            Assert.Equal(choice, checkDiagnolLeftToRight.Check_Diagnol_Left_To_Right());
        }

        [Theory]
        [InlineData(3, 3, "X")]
        [InlineData(4, 4, "X")]
        [InlineData(5, 5, "X")]
        public void Check_Diagnol_Right_To_Left_Win3x3(int x, int y, string choice)
        {

            CheckDiagnolRightToLeft checkDiagnolRightToLeft = new CheckDiagnolRightToLeft(x, y, choice);
            Assert.Equal(choice, checkDiagnolRightToLeft.Check_Diagnol_Right_To_Left());
        }
        [Theory]
        [InlineData(3, 3, "NoOneWon")]
        [InlineData(4, 4, "NoOneWon")]
        [InlineData(5, 5, "NoOneWon")]
        public void Check_If_No_One_Won(int x, int y, string choice)
        {

            CheckIfNoOneWon checkIfNoOneWon = new CheckIfNoOneWon(x,y,choice);
            Assert.Equal(choice, checkIfNoOneWon.CheckAll());
        }

    }
}
