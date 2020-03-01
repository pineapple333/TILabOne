using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeamInternationalFirst.Teams;

namespace TeamInternationalFirst
{
    class GameFinishedEventArgs: EventArgs
    {
        public Boolean Draw { get; set; }
        public Team Winner { get; set; }
        public Team Loser { get; set; }
    }
}
