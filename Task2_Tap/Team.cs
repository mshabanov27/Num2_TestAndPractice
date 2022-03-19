using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2_Tap
{
    class Team
    {
        public int teamLine;
        private string[,] scores;
        public int result;

        public Team(string[][] table)
        {
            for (int i = 1; i < table.Length; i++)
            {
                if (i % 2 == 0)
                {
                    scores[i - 1, 1] = table[teamLine][i];
                }
                else
                {
                    scores[i - 1, 0] = table[teamLine][i];
                }
            }
        }

        public int ResultCounter()
        {
            for (int i = 0; i < scores.GetLength(0); i++)
            {
                if (int.Parse(scores[i, 0]) > int.Parse(scores[i, 1]))
                {
                    result += 3;
                }
                else if(int.Parse(scores[i, 0]) == int.Parse(scores[i, 1]))
                {
                    result++;
                }
            }

            return result;
        }

    }
}
