using System;
using System.Collections.Generic;
using System.Linq;

namespace Task2_Tap
{
    class Team
    {
        private string _teamName;
        private List<string> _scores;
        private int _result;

        public Team(string teamInfo)
        {
            var nameAndResults = teamInfo.Split(';').ToList();

            _teamName = nameAndResults[0];

            for (int i = 1; i < nameAndResults.Count; i++)
            {
                _scores.Add(nameAndResults[i]);
            }
        }

        public int resultCounter()
        {
            for (int i = 0; i < _scores.Count; i++)
            {
                var currentMatch = new MatchResult(_scores[i]);

                if (currentMatch.getMyScore > currentMatch.getOpponentScore)
                {
                    _result += 3;
                }
                else if (currentMatch.getMyScore == currentMatch.getOpponentScore)
                {
                    _result++;
                }
            }

            return _result;
        }
       
    }

    class MatchResult
    {
        private int _teamScore;
        private int _opponentScore;
        
        public MatchResult(string matchResults)
        {
            var pair = matchResults.Split(':').ToList();
            _teamScore = int.Parse(pair[0]);
            _opponentScore = int.Parse(pair[1]);
        }

        public int getMyScore { get { return _teamScore; } }
        public int getOpponentScore { get { return _opponentScore; } }
    }
}
