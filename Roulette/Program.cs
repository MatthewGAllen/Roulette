using System;

namespace Roulette
{
    class Program
    {
        static void Main(string[] args)
        {
            Wheel w = new Wheel();
            Ball b = new Ball();
            if(w.wheel.ContainsKey(b.ballLocation))
                Console.WriteLine(b.ballLocation);
            GameBoard g = new GameBoard();
            g.IsColor();
        }
    }
}
