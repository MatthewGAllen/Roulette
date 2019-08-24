using System;

namespace Roulette
{
    class Program
    {
        static void Main(string[] args)
        {
            Player p = new Player(1000);
            GameBoard g = new GameBoard(p);

            
            bool truther = true;
            string input;
            while (truther)
            {
                
                Console.Clear();
                Ball b = new Ball();

                Console.WriteLine("Let's Play! \nType 'red' or 'black', \n'even' or 'odd', \n'low high', \n'column'," +
                    " \n'thirds', \n'row', \n'two rows', \n'split', \n'corner', \n'number',");
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
                    case "number":
                        g.WinningNumber(b);
                        break;
                    case "row":
                        g.Row(b);
                        break;
                    case "two rows":
                        g.TwoRows(b);
                        break;
                    case "thirds":
                        g.Thirds(b);
                        break;
                    case "low high":
                        g.LowHigh(b);
                        break;
                    case "column":
                        g.Column(b);
                        break;

                }

                
                Console.WriteLine("\nPress enter to play again or escape to exit\n");
                
                if(Console.ReadKey().Key == ConsoleKey.Escape)
                {
                    truther = false;
                }

            }
        }
    }
}
