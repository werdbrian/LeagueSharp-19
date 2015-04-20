using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LeagueSharp;
using LeagueSharp.Common;

namespace UtilityAIO
{
    class Program
    {
        static void Main(string[] args)
        {

            CustomEvents.Game.OnGameLoad += GameOnOnGameLoad;

        }

        private static void GameOnOnGameLoad(EventArgs args)
        {
            //TODO: Edit things !?!
            // adding something :S
        }
    }
}
