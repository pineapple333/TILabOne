using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeamInternationalFirst.Teams;

namespace TeamInternationalFirst
{
    public abstract class BaseGame
    {

        protected int numberOfRounds;

        protected Team Run(Team first, Team second)
        {
            double firstScore = first.getTeamScore();
            double secondScore = second.getTeamScore();
            if (firstScore > secondScore)
            {
                return first;
            }
            else if (firstScore == secondScore)
            {
                return null;
            }
            else
            {
                return second;
            }
        }

        // runs a special game (football, basketball, etc.)
        public Team RunSpecificGame(Team teamOne, Team teamTwo)
        {
            int cntTeamOne = 0;
            int cntTeamTwo = 0;
            int cnt = 0;
            while (cnt++ < numberOfRounds)
            {
                Team winner = this.Run(teamOne, teamTwo);
                if (winner == teamOne)
                    cntTeamOne++;
                else
                    cntTeamTwo++;
                Console.WriteLine("Running the game the {0} times", cnt);
            }
            return cntTeamOne > cntTeamTwo ? teamOne : teamTwo;
        }
    }
}
