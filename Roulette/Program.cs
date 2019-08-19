using System;

namespace Roulette
{
    class Program
    {
        static void Main(string[] args)
        {
            Player p = new Player(1000);
            GameBoard g = new GameBoard(p);
            while (Console.ReadKey().Key != ConsoleKey.Escape)
            {
                string input;
                Console.Clear();

                Console.WriteLine("What kind of bet would you like to make?");
                input = Console.ReadLine();

                switch (input)
                {
                    case "red":
                        g.IsColor(input);
                        break;
                }


                Console.WriteLine("\nPress enter to play again or escape to exit\n");
            }
        }
    }
}
