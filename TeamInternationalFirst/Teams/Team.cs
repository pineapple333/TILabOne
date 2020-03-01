using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeamInternationalFirst.MyExceptions;

namespace TeamInternationalFirst.Teams
{
    abstract class Team
    {
        public abstract int TeamId { get; }

        public abstract MyCollection<Character> Players { set; get; }

        public abstract Character Coach { set; get; }

        public abstract double getTeamScore();

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            foreach (Character c in Players)
                sb.Append(c.ToString() + "\n");
            sb.Append(Coach.ToString() + "\n");
            sb.Append("The score is: " + getTeamScore() + "\n");
            return sb.ToString();
        }
    }
}
