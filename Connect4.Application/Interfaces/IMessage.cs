using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Connect4.Interfaces
{
    public interface IMessage
    {
        void Write(State GameState);
        void WriteLine(string message);
        void Clear();
    }
}
