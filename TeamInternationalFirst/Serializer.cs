using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeamInternationalFirst.Teams;

namespace TeamInternationalFirst
{
    class Serializer
    {
        public void OnGameFinished(object source, GameFinishedEventArgs gameFinishedEventArgs)
        {
            StringBuilder sb = new StringBuilder();
            Team winner = gameFinishedEventArgs.Winner;
            Team loser = gameFinishedEventArgs.Loser;
            Boolean draw = gameFinishedEventArgs.Draw;
            string result =
                "Winner: \n" +
                "TeamId: " + winner.TeamId +
                "\nTeam score: " + winner.getTeamScore() +
                "\nLoser: \n" +
                "TeamId: " + loser.TeamId +
                "\nTeam score: " + loser.getTeamScore() +
                "\nDraw: " + draw;
                
            Console.WriteLine(result);

            Console.WriteLine("\nAdditional:\nWinner: \n" + winner.ToString() + "\nLoser: \n" + loser.ToString());
        }
    }
}
