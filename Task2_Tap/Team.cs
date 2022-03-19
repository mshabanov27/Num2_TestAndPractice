using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2_Tap
{
    class Team
    {
        private string[,] _scores;
        public int result;

        public Team(string[][] table, int teamLine)
        {
            for (int i = 1; i < table.Length; i++)
            {
                if (i % 2 == 0)
                {
                    _scores[i - 1, 1] = table[teamLine][i];
                }
                else
                {
                    _scores[i - 1, 0] = table[teamLine][i];
                }
            }
        }

        public int ResultCounter()
        {
            for (int i = 0; i < _scores.GetLength(0); i++)
            {
                if (int.Parse(_scores[i, 0]) > int.Parse(_scores[i, 1]))
                {
                    result += 3;
                }
                else if(int.Parse(_scores[i, 0]) == int.Parse(_scores[i, 1]))
                {
                    result++;
                }
            }

            return result;
        }

    }
}
