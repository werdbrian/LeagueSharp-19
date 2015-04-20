using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using LeagueSharp;
using LeagueSharp.Common;
using SharpDX;
using UtilityAIO;

namespace UtilityAIO.utilities
{
    class CSCounter
    {

        private static readonly Render.Text Text = new Render.Text(
            0, 0, "", 15, new ColorBGRA(red: 255, green: 0, blue: 0, alpha: 255), "Verdana");

        private const int XOffset = 15;
        private const int YOffset = 35;

        private static Menu _menu2;
        private static MenuItem _menuenable2;
        private static MenuItem _menuenable3;
        private static MenuItem _menuenable4;

        private static MenuItem _xPos;
        private static MenuItem _yPos;

        public static bool Enabled = true;

        public static void LoadCsCounter()
        {

            Game_OnGameLoad();

        }

        private static void Game_OnGameLoad()
        {
            //Notifications.AddNotification("CS Counter loaded.", 10);

            _menu2 = new Menu("CS Counter", "menu2", false);
            //var drawings2 = new Menu("Drawings", "drawings2");
            //_menu2.AddSubMenu(drawings2);


            _menuenable2 = new MenuItem("menu.drawings.enable2", "CS Count").SetValue(true);
            _menu2.AddItem(_menuenable2);
            _menuenable3 = new MenuItem("menu.drawings.enable3", "My CS Count").SetValue(true);
            _menu2.AddItem(_menuenable3);
            _menuenable4 = new MenuItem("menu.drawings.enable4", "Allies CS Count").SetValue(true);
            _menu2.AddItem(_menuenable4);
            _xPos = new MenuItem("menu.Calc.calc5", "X - Position").SetValue(new Slider(47));
            _menu2.AddItem(_xPos);
            _yPos = new MenuItem("menu.Calc.calc6", "Y - Position").SetValue(new Slider(-10));
            _menu2.AddItem(_yPos);


            UtilityAIO.Program.MainMenuOp.AddSubMenu(_menu2);
            
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

                if (hero.IsDead | !hero.IsVisible | !_menuenable2.GetValue<bool>() |
                    ( hero.IsAlly && !_menuenable4.GetValue<bool>() ) | (hero.IsMe && !_menuenable3.GetValue<bool>()))
                {
                    Text.text = "";
                    continue;
                }

                var cs = hero.MinionsKilled;
                var barPos = hero.HPBarPosition;

                if (hero.IsMe && _menuenable3.GetValue<bool>())
                {
                    Text.X = (int)barPos.X + XOffset + 42;
                    Text.Y = (int)barPos.Y + YOffset - 8;
                    Text.Color = new ColorBGRA(red: 255, green: 255, blue: 255, alpha: 255);
                    Text.text = "CS Count: " + cs;
                    Text.OnEndScene();

                    continue;
                }

                Text.X = (int)barPos.X + XOffset + _xPos.GetValue<Slider>().Value;
                Text.Y = (int)barPos.Y + YOffset + _yPos.GetValue<Slider>().Value;
                Text.Color = new ColorBGRA(red: 255, green: 255, blue: 255, alpha: 255);
                Text.text = "CS Count: " + cs;
                Text.OnEndScene();
                
            }

        }
    }
}
