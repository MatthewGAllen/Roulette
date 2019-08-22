using System;

namespace Roulette
{
    class Program
    {
        static void Main(string[] args)
        {
            Player p = new Player(1000);
            GameBoard g = new GameBoard(p);
            Console.WriteLine("Press any key to start game, help will list out available bets");
            string input;
            while (Console.ReadKey().Key != ConsoleKey.Escape)
            {
                Console.Clear();

                Console.WriteLine("What kind of bet would you like to make? Help will list out available bets");
                input = Console.ReadLine();

                switch (input)
                {
                    case "red":
                        g.IsColor(input);
                        break;

                    case "help":
                        Console.WriteLine("Available bets are: [red or black],[even or odd],[low or high],[column]" +
                            ",[thirds],[row],[two rows],");
                        break;
                }

                if (input != "help")
                    Console.WriteLine("\nPress enter to play again or escape to exit\n");
            }
        }
    }
}
