using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeamInternationalFirst.Teams;
using TeamInternationalFirst.Games;

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
            BaseGame game = GetGame();
            Team winner = game.RunSpecificGame(teamOne, teamTwo);
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

        private BaseGame GetGame()
        {
            int res = 0;
            while(true)
            {
                Console.WriteLine("Which game would you like to run ? \nShort - 0\nLong - 1");
                if (int.TryParse(Console.ReadLine(), out res))
                    if (res == 0)
                        return new GameProducer().MakeGame(GameType.ShortGame);
                    else if (res == 1)
                        return new GameProducer().MakeGame(GameType.LongGame);
                    else
                        Console.WriteLine("Invalid input ...");
            }
        }
    }
}
