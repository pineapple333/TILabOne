using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamInternationalFirst.Games
{
    public class GameProducer
    {
        public GameProducer()
        {

        }

        public BaseGame MakeGame(GameType gt)
        {
            if (gt == GameType.LongGame)
                return new LongGame();
            else if (gt == GameType.ShortGame)
                return new ShortGame();
            else
                return null;
        }
    }
}
