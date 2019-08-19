using System;

namespace Roulette
{
    class Program
    {
        static void Main(string[] args)
        {
            while (Console.ReadKey().Key != ConsoleKey.Escape)
            {
                Console.Clear();
                GameBoard g = new GameBoard();


                g.IsColor();
                g.EvenOrOdd();
                g.WinningNumber();
                g.LowHigh();
                g.Thirds();
                g.Column();
                g.Row();
                g.TwoRows();
                Console.WriteLine("\nPress enter to play again or escape to exit\n");
            }
        }
    }
}
