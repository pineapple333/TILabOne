using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeamInternationalFirst.MyExceptions;

namespace TeamInternationalFirst.Teams
{
    class FootballTeam : Team
    {
        private MyCollection<Character> players = null;
        private Character coach = null;
        private int teamId = 0;

        public FootballTeam(int id)
        {
            teamId = id;
        }
        public override int TeamId { get => teamId; }
        public override MyCollection<Character> Players 
        { 
            set => this.players = value;
            get => this.players;
        }

        public override Character Coach 
        { 
            set => this.coach = value;
            get => this.coach;
        }
        public override double getTeamScore()
        {
            if (Players == null)
            {
                throw new BadTeamException();
            }
            else
            {
                double sum = 0;
                foreach (Character one in Players)
                    sum += one.Qualification;
                sum =+ Coach.Qualification;
                sum /= Players.Length + 1;
                return sum;
            }
        }

        //public override string ToString()
        //{
        //    StringBuilder sb = new StringBuilder();
        //    foreach (Character c in Players)
        //        sb.Append(c.ToString() + "\n");
        //    sb.Append(Coach.ToString() + "\n");
        //    sb.Append("The score is: " + getTeamScore() + "\n");
        //    return sb.ToString();
        //}
    }
}
