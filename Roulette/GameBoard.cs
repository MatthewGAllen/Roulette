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

        

       
    }
}
