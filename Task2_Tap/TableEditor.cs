using System.Collections.Generic;

namespace Task2_Tap
{
    class TableEditor
    {
        public List<string> ResultAdder(List<string> teams)
        {
            for (int i = 1; i < teams.Count; i++)
            {
                var team = new Team(teams[i]);

                string total = team.resultCounter().ToString();

                teams[i] = _replacer(teams[i], total);
            }

            return teams;
        }

        private string _replacer(string inputMessage, string add)
        {
            string outputMessage = inputMessage.Substring(0, inputMessage.Length - 1) + $";{add}";

            return outputMessage;
        }
    }
}
