using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SankeAndLader
{
    public class Position
    {
        const int position = 0;
        const int winning_position= 100;

        public static void gamestart()
        {
            int n = 0;
            int position = 0;
            Random random = new Random();
            int d = random.Next(1, 6);
            Console.WriteLine("The dice rolled to " + d);

        }
       

    }


}

