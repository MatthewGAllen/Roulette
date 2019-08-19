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
                Console.WriteLine($"Number {b.ballLocation} is in the first row. First row bets win");
            }
            else if (b.ballLocation > 12 && b.ballLocation <= 24)
            {
                Console.WriteLine($"Number {b.ballLocation} is in the second row. Second row bets win");
            }
            else if (b.ballLocation > 24 && b.ballLocation <= 36)
            {
                Console.WriteLine($"Number {b.ballLocation} is in the third row. Third row bets win");
            }
            else if (b.ballLocation == 37 || b.ballLocation == 38)
            {
                Console.WriteLine("Green Wins");
            }
        }
    }
}
