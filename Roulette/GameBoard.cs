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

        public void Row()
        {
            string value = $"Row {b.row} Wins";
            Console.WriteLine(value);
        }

        public void TwoRows()
        {
            //string value = $"Rows {} Win"

            if (b.row == 1)
            {
                Console.WriteLine("Rows 1 and 2 win"); 
            }

            if (b.row == 2)
            {
                Console.WriteLine("Rows 1, 2 & 3 win");
            }

            if (b.row == 3)
            {
                Console.WriteLine("Rows 2, 3 & 4 win");
            }

            if (b.row == 4)
            {
                Console.WriteLine("Rows 3, 4 & 5 win");
            }

            if (b.row == 5)
            {
                Console.WriteLine("Rows 4, 5 & 6 win");
            }

            if (b.row == 6)
            {
                Console.WriteLine("Rows 5, 6 & 7 win");
            }

            if (b.row == 7)
            {
                Console.WriteLine("Rows 6, 7 & 8 win");
            }

            if (b.row == 8)
            {
                Console.WriteLine("Rows 7, 8 & 9 win");
            }

            if (b.row == 9)
            {
                Console.WriteLine("Rows 8, 9 & 10 win");
            }

            if (b.row == 10)
            {
                Console.WriteLine("Rows 9, 10 & 11 win");
            }

            if (b.row == 11)
            {
                Console.WriteLine("Rows 10, 11 & 12 win");
            }

            if (b.row == 12)
            {
                Console.WriteLine("Rows 11 & 12 win");
            }
        }
    }
}
