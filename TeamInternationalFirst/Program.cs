using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeamInternationalFirst.Teams;

namespace TeamInternationalFirst
{
    public enum TeamType { Football = 11, Basketball = 7}
    class Program
    {
        static void Main(string[] args)
        {
            GameHandler gh = new GameHandler();
            gh.GameFinished += new Serializer().OnGameFinished;
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
                Console.ReadLine();
            }
        }
    }
}
