using System;
using Lab04_TicTacToe.Classes;


namespace Lab04_TicTacToe
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Press 'ENTER' to play");
            Console.ReadLine();
            PlayGame();
        }

        static void PlayGame()
            {
            Player Biniam = new Player();
            Biniam.Name = "Biniam";
            Biniam.Marker = "O";
            Biniam.IsTurn = true;

            Player Obama = new Player();
            Obama.Name = "Obama";
            Obama.Marker = "X";
            Obama.IsTurn = false;
            

            Game game = new Game(Biniam, Obama);
            game.Play();
            
        }

        // TODO: Setup your game. Create a new method that creates your players and instantiates the game class. Call that method in your Main method.
        // You are requesting a Winner to be returned, Determine who the winner is output the celebratory message to the correct player. If it's a draw, tell them that there is no winner. 
    }
}
