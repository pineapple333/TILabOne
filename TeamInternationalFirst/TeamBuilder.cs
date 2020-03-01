using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeamInternationalFirst.Teams;
using TeamInternationalFirst.Characters;

namespace TeamInternationalFirst
{
    class TeamBuilder
    {
        private Random rnd = null;

        public TeamBuilder()
        {
            rnd = new Random();
        }
        public Team buildTeam(TeamType tt)
        {
            if (tt == TeamType.Football)
                return buildFootballTeam();
            if (tt == TeamType.Basketball)
                return buildBasketballTeam();
            else
                return null;
        }

        private Team buildFootballTeam()
        {
            Team team = new FootballTeam(rnd.Next(1000000));
            MyCollection<Character> characters = new MyCollection<Character>();
            for (int i = 0; i < (int)TeamType.Football; i++)
            {
                characters.pushBack(getPlayer());
            }
            team.Coach = getCoach();
            team.Players = characters;
            return team;
        }

        private Team buildBasketballTeam()
        {
            Team team = new BasketballTeam(rnd.Next(1000000));
            MyCollection<Character> characters = new MyCollection<Character>();
            for (int i = 0; i < (int)TeamType.Basketball; i++)
            {
                characters.pushBack(getPlayer());
            }
            team.Coach = getCoach();
            team.Players = characters;
            return team;
        }

        private Character getPlayer()
        {
            return new FieldPlayer(rnd.NextDouble());
        }

        private Character getCoach()
        {
            return new Coach(rnd.NextDouble());
        }
    }
}
