using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SankeAndLader
{
    public class Rolling
    {
            const int position = 0;
            const int winning_position = 100;

            public static void gamestart()
            {
                //int n = 0;
                int position = 0;
                Random random = new Random();
                int d = random.Next(0, 7);
                
                Console.WriteLine("The dice rolled to " + d);
                Random random2 = new Random();
                int c = random2.Next(1, 4);
                switch (c)
                {
                    case 1:

                    Console.WriteLine("No Play the player will be in same place");
                    break;
                   case 2:
                    Console.WriteLine("It's ladder");
                    position += d;
                    break;
                   case 3:
                    Console.WriteLine("It's Sanke");
                    position -= d;
                    break;

                }
                Console.WriteLine("the position moved to " + position);

            }





    }
}
