using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Exercises
{
    internal class TicTok
    {
        char[][] chars;
        char player1 = 'X';
        char player2 = 'Y';

        public TicTok()
        {
            chars = new char[3][];
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    chars[i][j] = '_';
                }
            }

        }

        public void Play()
        {
            bool isWin = false;
            int rounds = 0;
            while (!isWin && rounds <= 9)
            {

            }
        }
    }
}
