using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Connect4.Players;

namespace Connect4.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            StartGame();
        }

        private static void StartGame()
        {
            BoardSettings boardSettings = new BoardSettings() { Columns = 7, Rows = 6, WinningCount = 4 };
            
            Connect4 c4 = new Connect4(boardSettings, new Message());
            c4.Player1 = new Human();
            c4.Player2 = new Computer(2, boardSettings);
                        
            c4.PlayGame();

            System.Console.Write("Would you like another game? (Y or N)");
            char c = System.Console.ReadKey().KeyChar;
            if (c.ToString().ToUpper() == "Y")
                StartGame();
            else
                Environment.Exit(0);
        }
    }
}
