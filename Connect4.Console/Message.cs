using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Connect4.Interfaces;

namespace Connect4.Console
{
    public class Message : IMessage
    {
        public void Write(State state)
        {
            System.Console.Write(state);
        }
        
        public void WriteLine(string message)
        {
            System.Console.WriteLine(message);
        }

        public void Clear()
        {
            System.Console.Clear();
        }
    }
}
