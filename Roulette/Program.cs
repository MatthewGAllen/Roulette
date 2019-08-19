using System;

namespace Roulette
{
    class Program
    {
        static void Main(string[] args)
        {
            GameBoard g = new GameBoard();

            g.IsColor();
            g.EvenOrOdd();
            g.WinningNumber();
            g.LowHigh();
            g.Thirds();
        }
    }
}
