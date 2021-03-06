﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeamInternationalFirst.Teams;
using TeamInternationalFirst.Writers;

namespace TeamInternationalFirst
{
    public enum TeamType { Football = 11, Basketball = 7}
    public enum GameType { LongGame, ShortGame}

    class Program
    {
        static void Main(string[] args)
        {
            GameHandler gh = new GameHandler();
            gh.GameFinished += new ConsoleWriter().OnGameFinished;
            gh.GameFinished += new JSONFileWriter().OnGameFinished;
            while (true)
            {
                Console.WriteLine("To break enter 1");
                int res = 0;
                if (int.TryParse(Console.ReadLine(), out res))
                    if (res == 1)
                        break;
                Console.WriteLine("Which team would you like to choose ? \nFootball - 0\nBasketball - 1");
                if (int.TryParse(Console.ReadLine(), out res))
                    if (res == 0)
                        gh.RunGame(TeamType.Football);
                    else if (res == 1)
                        gh.RunGame(TeamType.Basketball);
            }
        }
    }
}
