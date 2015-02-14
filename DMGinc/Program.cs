using System;
using LeagueSharp.Common;

namespace DMGinc
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomEvents.Game.OnGameLoad += LoadReligion;
        }

        static void LoadReligion(EventArgs args)
        {
            loading champs = new Champion(true);
        }
    }
}
