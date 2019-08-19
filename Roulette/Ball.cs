using System;
using System.Collections.Generic;
using System.Text;

namespace Roulette
{
    class Ball 
    {
        public int ballLocation { get; set; }
        public Ball()
        {
            Random r = new Random();
            ballLocation = r.Next(1, 39);

            
        }
    }
}
