using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeamInternationalFirst.Teams;

namespace TeamInternationalFirst
{
    class Game
    { 
        public static Team Run(Team first, Team second)
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
    }
}
