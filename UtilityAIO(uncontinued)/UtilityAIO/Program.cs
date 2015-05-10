using System;
using LeagueSharp.Common;
using UtilityAIO.utilities;
using UtilityAIO.extras;

namespace UtilityAIO
{
    class Program
    {
        public static Menu MainMenuOp;
        public static Menu Menu;
        static void Main(string[] args)
        {

            CustomEvents.Game.OnGameLoad += GameOnOnGameLoad;

        }

        private static void GameOnOnGameLoad(EventArgs args)
        {

            //TODO: Edit things !?!
            LeagueSharp.Game.PrintChat("<font color=\"#AF7AFF\"><b>UtilityAiO</b></font> LOADED!");
            Notifications.AddNotification("UtilityAiO loaded!", 10, true);

            MainMenuOp = new Menu("UtilityAIO", "mainMenu", true);

            DamageIndicator.LoadIndicator();
            CSCounter.LoadCsCounter();
            new AutoPot(MainMenuOp);

            MainMenuOp.AddItem(new MenuItem("422442<ef<ef4242fxx", ""));
            MainMenuOp.AddItem(new MenuItem("42f<afsfxx", "PRE-RELEASE"));
            MainMenuOp.AddItem(new MenuItem("fsfqwfaxx", "Made By Kyon"));

            MainMenuOp.AddToMainMenu();

        }
    }
}
