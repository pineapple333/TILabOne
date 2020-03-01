using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeamInternationalFirst.Teams;

namespace TeamInternationalFirst
{
    class GameHandler
    {
        public GameHandler()
        {

        }

        public delegate void GameFinishedEvenHandler(object source, 
            GameFinishedEventArgs gameFinishedEvenArgs);

        public event GameFinishedEvenHandler GameFinished;

        public void RunGame(TeamType tt)
        {
            TeamBuilder tb = new TeamBuilder();
            Team teamOne = tb.buildTeam(tt);
            Team teamTwo = tb.buildTeam(tt);
            Team winner = Game.Run(teamOne, teamTwo);
            Boolean draw = false;
            if (winner is null)
            {
                draw = true;
                OnGameFinished(teamOne, teamTwo, draw);
                return;
            }
            Team loser = (teamOne == winner)? teamTwo : teamOne;
            OnGameFinished(winner, loser, draw);
        }

        public virtual void OnGameFinished(Team winner, Team loser, Boolean draw)
        {
            if (GameFinished != null)
                GameFinished(this, new GameFinishedEventArgs()
                { Winner = winner, Loser = loser, Draw = draw });
        }
    }
}
