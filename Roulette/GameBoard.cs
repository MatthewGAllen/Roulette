using System;
using System.Collections.Generic;
using System.Text;

namespace Roulette
{
    class GameBoard
    {
        Wheel w = new Wheel();
        Ball b = new Ball();

        public void IsColor()
        {
            string color = "";
            w.wheel.TryGetValue(b.ballLocation, out color );
            Console.WriteLine($"{color} wins the bet");
        }

        public void WinningNumber()
        {
            Console.WriteLine($"{b.ballLocation} is the winning number");
        }

        public void EvenOrOdd()
        {
            if(b.ballLocation %2 == 0 && b.ballLocation != 38)
            {
                Console.WriteLine("Even Bets Win");
            }
            else if(b.ballLocation %2 != 0 && b.ballLocation!= 37)
            {
                Console.WriteLine("Odd Bets Win");
            }
        }

        public void LowHigh()
        {
            if(b.ballLocation <= 18)
            {
                Console.WriteLine("Low Bets Win");
            }
            else
            {
                Console.WriteLine("High Bets Win");
            }
        }

        //Dozens: rowthirds,1–12,13–24,25–36
        public void Thirds()
        {
            if(b.ballLocation <= 12)
            {
                Console.WriteLine($"Number {b.ballLocation} is in the first third. First third bets win");
            }
            else if (b.ballLocation > 12 && b.ballLocation <= 24)
            {
                Console.WriteLine($"Number {b.ballLocation} is in the second third. Second third bets win");
            }
            else if (b.ballLocation > 24 && b.ballLocation <= 36)
            {
                Console.WriteLine($"Number {b.ballLocation} is in the third third. Third third bets win");
            }
            else if (b.ballLocation == 37 || b.ballLocation == 38)
            {
                Console.WriteLine("Green Wins");
            }
        }

        public void Row()
        {
            if(b.ballLocation <= 3)
            {
                Console.WriteLine("First Row Wins");
            }

            else if (b.ballLocation > 3 && b.ballLocation <= 6)
            {
                Console.WriteLine("Second Row Wins");
            }

            else if (b.ballLocation > 6 && b.ballLocation <= 9)
            {
                Console.WriteLine("Third Row Wins");
            }

            else if (b.ballLocation > 9 && b.ballLocation <= 12)
            {
                Console.WriteLine("Fourth Row Wins");
            }

            else if (b.ballLocation > 12 && b.ballLocation <= 15)
            {
                Console.WriteLine("Fifth Row Wins");
            }

            else if (b.ballLocation > 15 && b.ballLocation <= 18)
            {
                Console.WriteLine("Sixth Row Wins");
            }

            else if (b.ballLocation > 18 && b.ballLocation <= 21)
            {
                Console.WriteLine("Seventh Row Wins");
            }

            else if (b.ballLocation > 21 && b.ballLocation <= 24)
            {
                Console.WriteLine("Eighth Row Wins");
            }

            else if (b.ballLocation > 24 && b.ballLocation <= 27)
            {
                Console.WriteLine("Ninth Row Wins");
            }

            else if (b.ballLocation > 27 && b.ballLocation <= 30)
            {
                Console.WriteLine("Tenth Row Wins");
            }

            else if (b.ballLocation > 30 && b.ballLocation <= 33)
            {
                Console.WriteLine("Eleventh Row Wins");
            }

            else if (b.ballLocation > 33 && b.ballLocation <= 36)
            {
                Console.WriteLine("Twelfth Row Wins");
            }

            else if (b.ballLocation == 37 || b.ballLocation == 38)
            {
                Console.WriteLine("Green Row Wins");
            }
        }

        public void Column()
        {
            int column = b.ballLocation % 3;
            if(column == 0)
            {
                column = 3;
            }
            if(b.ballLocation < 37)
            {
                Console.WriteLine($"Column {column} wins the bet");
            }
            else if(b.ballLocation == 37)
            {
                Console.WriteLine("0 wins over columns");
            }
            else if(b.ballLocation == 38)
            {
                Console.WriteLine("00 wins over columns");
            }
        }
    }
}
