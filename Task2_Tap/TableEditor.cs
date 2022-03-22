using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2_Tap
{
    class TableEditor
    {
        public List<string> resultAdder(List<string> teams)
        {
            for (int i = 0; i < teams.Count; i++)
            {
                var team = new Team(teams[i]);

                string total = team.resultCounter().ToString();

                teams.Add(total);
            }

            return teams;
        }
    }
}
