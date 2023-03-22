using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SankeAndLader
{
    public class Winning
    {
        const int LADDER = 1, SNAKE = 2;
        public int rollDice()
        {
            Random random = new Random();
            int dice = random.Next(1, 7);
            return dice;
        }
        public  void playGame()
        {
            int pos = 0;
            Winning p = new Winning();
            int dice = 0, count = 0;
            Random random = new Random();
            while (pos < 100)
            {
                int check = random.Next(0, 3);
                dice = p.rollDice();
                switch (check)
                {
                    case LADDER:
                        pos += dice;
                        if (pos > 100)
                            pos -= dice;
                        break;
                    case SNAKE:
                        pos -= dice;
                        if (pos < 0)
                            pos = 0;
                        break;
                }
                count++;
            }
            Console.WriteLine(pos);
            Console.WriteLine("Number of times dice rolled to reach 100 is: " + count);
        }
    }
}