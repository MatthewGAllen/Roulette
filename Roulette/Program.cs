using System;

namespace Roulette
{
    class Program
    {
        static void Main(string[] args)
        {
            Player p = new Player(1000);
            GameBoard g = new GameBoard(p);

            Console.WriteLine("Let's Play! \nType 'red' or 'black', \n'even' or 'odd', \n'low' or 'high', \n'column', \n'thirds', \n'row', \n'two rows'");
            Console.WriteLine("Press any key to start game");
            string input;
            while (Console.ReadKey().Key != ConsoleKey.Escape)
            {
                Console.Clear();
                Ball b = new Ball();

                Console.WriteLine("Let's Play! \nType 'red' or 'black', \n'even' or 'odd', \n'low' or 'high', \n'column', \n'thirds', \n'row', \n'two rows'");
                Console.WriteLine("What kind of bet would you like to make?");
                input = Console.ReadLine();

                switch (input)
                {
                    case "red":
                        g.IsColor(b, input);
                        break;

                    case "black":
                        g.IsColor(b, input);
                        break;

                    case "even":
                        g.EvenOrOdd(b, input);
                        break;

                    case "odd":
                        g.EvenOrOdd(b, input);
                        break;
                    case "corner":
                        g.Corners(b);
                        break;
                    case "split":
                        g.SplitBet(b);
                        break;


                }

                if (input != "help")
                    Console.WriteLine("\nPress enter to play again or escape to exit\n");
            }
        }
    }
}
