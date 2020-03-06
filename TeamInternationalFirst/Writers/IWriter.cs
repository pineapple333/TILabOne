using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeamInternationalFirst.Teams;

namespace TeamInternationalFirst
{
    public interface IWriter
    {
        void OnGameFinished(object source, GameFinishedEventArgs gameFinishedEventArgs);
    }
}
