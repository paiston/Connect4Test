using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Connect4.Interfaces.Players;

namespace Connect4.Players
{
    public class Human: IPlayer
    {
        public Human()
        {
        }

        public int PlayerTurn(State state)
        {
            Console.Clear();
            Console.WriteLine(" # # # #   CONNECT 4   # # # # \n");
            Console.WriteLine(state);
            Console.Write("Whats your move (1-7)?");
            char c = Console.ReadKey().KeyChar;
            int move; 

            if(!int.TryParse(c.ToString(), out move))
            {
                throw new ArgumentOutOfRangeException(string.Format("'{0}' is not a valid move. Please enter a value between 1-7", move));
            }

            return move;
        }
    }
}
