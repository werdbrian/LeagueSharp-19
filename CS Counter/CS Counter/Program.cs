using System;
using LeagueSharp;
using LeagueSharp.Common;
using LeagueSharp.Common.Render;
using SharpDX;

namespace CS_Counter
{
    class Program
    {

        private static readonly Text Text = new Text(
            0, 0, "", 15, new ColorBGRA(red: 255, green: 0, blue: 0, alpha: 255), "Verdana");

        private const int XOffset = 15;
        private const int YOffset = 35;

        private static Menu _menu;
        private static MenuItem _menuenable;

        public static bool Enabled = true;

        static void Main(string[] args)
        {
            if (args == null) throw new ArgumentNullException("args");
            CustomEvents.Game.OnGameLoad += Game_OnGameLoad;
        }

        private static void Game_OnGameLoad(EventArgs args)
        {
            Notifications.AddNotification("CS Counter loaded.", 10);

            _menu = new Menu("CS Counter", "menu", true);
            var drawings = new Menu("drawings", "drawings");
            _menu.AddSubMenu(drawings);

            _menuenable = new MenuItem("menu.drawings.enable", "Enable CS Count").SetValue(true);
            drawings.AddItem(_menuenable);

            _menu.AddItem(new MenuItem("422442<ef<ef4242f", ""));
            _menu.AddItem(new MenuItem("42f<afsf", "Version: 1.3.3.7"));
            _menu.AddItem(new MenuItem("fsfqwfa", "Made by Kyon"));
            _menu.AddItem(new MenuItem("awfafaF", "Thanks for using !"));

            _menu.AddToMainMenu();

            Drawing.OnDraw += Drawing_OnDraw;
            
        }

        private static void Drawing_OnDraw(EventArgs args)
        {
            GetCsEnemy();
        }

        private static void GetCsEnemy()
        {
            foreach (var hero in ObjectManager.Get<Obj_AI_Hero>())
            {

                if (hero.IsDead | !hero.IsVisible | !_menu.Item("menu.drawings.enable").GetValue<bool>())
                {
                    Text.text = "";
                    continue;
                }

                var cs = hero.MinionsKilled;
                var barPos = hero.HPBarPosition;

                if (hero.IsMe)
                {
                    Text.X = (int)barPos.X + XOffset+45;
                    Text.Y = (int)barPos.Y + YOffset-10;
                    Text.Color = new ColorBGRA(red: 255, green: 255, blue: 255, alpha: 255);
                    Text.text = "CS Count: " + cs;
                    Text.OnEndScene();

                    continue;
                }

                Text.X = (int)barPos.X + XOffset-6;
                Text.Y = (int)barPos.Y + YOffset+3;
                Text.Color = new ColorBGRA(red: 255, green: 255, blue: 255, alpha: 255);
                Text.text = "CS Count: " + cs;
                Text.OnEndScene();
                
            }

        }
    }
}
