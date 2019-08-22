using System;
using System.Collections.Generic;
using System.Text;

namespace Roulette
{
    class GameBoard
    {
        Wheel w = new Wheel();
        Ball b = new Ball();
        int column { get; set; }
        public void IsColor()
        {
            cash = player.Money;
        }
        public void IsColor(string s)
        {
            Ball b = new Ball();
            string color = "";
            w.wheel.TryGetValue(b.ballLocation, out color );
            Console.WriteLine($"{color} wins the bet");
        }

        public void WinningNumber()
        {
            Console.WriteLine($"{b.ballLocation} is the winning number");
        }

        public void EvenOrOdd(string s)
        {
            if(b.ballLocation %2 == 0 && b.ballLocation != 38)
            {
                if(s == "even")
                {
                    Console.WriteLine("Even Bets Win");
                }
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
            column = b.ballLocation % 3;
            
            if(b.ballLocation < 37)
            {
                if(column == 0)
                {
                    Console.WriteLine("Column 3 wins the bet");
                }
                else
                {
                    Console.WriteLine($"Column {column} wins the bet");
                }
                
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

        public void SplitBet()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Winning bets are: ");
            int betRight = b.ballLocation + 1;
            int betLeft = b.ballLocation - 1;
            int betUp = b.ballLocation - 3;
            int betDown = b.ballLocation + 3;

            if(betRight%3 == column +1 || betRight%3 == (column +1)%3)
            {
                sb.Append($"{b.ballLocation}\\{betRight} ");
            }
            if(betLeft%3 == column -1)
            {
                sb.Append($"{b.ballLocation}\\{betLeft} ");
            }
            if(betUp%3 == column && betUp > 0)
            {
                sb.Append($"{b.ballLocation}\\{betUp} ");
            }
            if(betDown%3 == column && betDown <=36)
            {
                sb.Append($"{b.ballLocation}\\{betDown} ");
            }
            Console.WriteLine(sb.ToString());
        }
    }
}
