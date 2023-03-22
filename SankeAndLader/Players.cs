using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SankeAndLader
{
    public class Players
    {
        const int LADDER = 1, SNAKE = 2;
        public int rollDice()
        {
            Random random = new Random();
            int dice = random.Next(1, 7);
            return dice;
        }
        public int playGame(int dice, int check)
        {
            int pos = 0;
            switch (check)
            {
                case LADDER:
                    pos += dice;
                    /*if (pos > 3)
                        pos -= dice;*/
                    break;
                case SNAKE:
                    pos -= dice;
                    if (pos < 0)
                        pos = 0;
                    break;
            }
            return pos;
        }
        public void multiPlayer()
        {
            const int PLAYER1 = 1;
            int pos1 = 0, pos2 = 0;
            int player = 1;
            Players p = new Players();
            Random random = new Random();
            while (pos1 < 100 && pos2 < 100)
            {
                int dice = p.rollDice();
                int check = random.Next(0, 3);
                if (player == PLAYER1)
                {
                    pos1 += p.playGame(dice, check);
                    if (pos1 > 100)
                        pos1 -= dice;
                    if (check == LADDER)
                        player = 1;
                    else
                        player = 2;
                }
                else
                {
                    pos2 += p.playGame(dice, check);
                    if (pos2 > 100)
                        pos2 -= dice;
                    if (check == LADDER)
                        player = 2;
                    else
                        player = 1;
                }
            }
            if (pos1 == 100)
                Console.WriteLine("Player1 won the game");
            else
                Console.WriteLine("player2 won the game");
        }
    }
}
