using System;
using Xunit;
using static Lab04_TicTacToe.Program;
using Lab04_TicTacToe.Classes;

namespace XUnitTestProject1
{
    public class UnitTest1
    {


        [Fact]
        public void CheckingForWinner()
        {
            Player Biniam = new Player();
            Biniam.Marker = "X";
            Player Obama = new Player();
            Obama.Marker = "O";

            Game testGame = new Game(Biniam, Obama);
            testGame.Board.GameBoard[0, 0] = "X";
            testGame.Board.GameBoard[1, 1] = "X";
            testGame.Board.GameBoard[2, 2] = "X";
            Assert.True(testGame.CheckForWinner(testGame.Board));


        }


        [Fact]
        public void CheckingForTie()
        {
            Player Biniam = new Player();
            Biniam.Marker = "X";
            Player Obama = new Player();
            Obama.Marker = "O";

            Game testGame = new Game(Biniam, Obama);
            testGame.Board.GameBoard[0, 0] = "X";
            testGame.Board.GameBoard[0, 1] = "O";
            testGame.Board.GameBoard[0, 2] = "X";
            testGame.Board.GameBoard[1, 0] = "X";
            testGame.Board.GameBoard[1, 1] = "O";
            testGame.Board.GameBoard[1, 2] = "O";
            testGame.Board.GameBoard[2, 0] = "O";
            testGame.Board.GameBoard[2, 1] = "X";
            testGame.Board.GameBoard[2, 2] = "X";

            Assert.False(testGame.CheckForWinner(testGame.Board));


        }


    }
}

