using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using LeagueSharp.Common;


namespace DMGinc
{
    class Program
    {
        public static Menu menu;
        static void Main(string[] args)
        {
            CustomEvents.Game.OnGameLoad += LoadReligion;
        }

        static void LoadReligion(EventArgs args)
        {

            var menuDrawing = new Menu("Drawing", "orb_Draw");
            menuDrawing.AddItem(new MenuItem("orb_Draw_AARange", "AA Circle").SetValue(new Circle(true, Color.FloralWhite)));
            menuDrawing.AddItem(new MenuItem("orb_Draw_AARange_Enemy", "AA Circle Enemy").SetValue(new Circle(true, Color.Pink)));
            menuDrawing.AddItem(new MenuItem("orb_Draw_Holdzone", "Holdzone").SetValue(new Circle(true, Color.FloralWhite)));
            menuDrawing.AddItem(new MenuItem("orb_Draw_MinionHPBar", "Minion HPBar").SetValue(new Circle(true, Color.Black)));
            menuDrawing.AddItem(new MenuItem("orb_Draw_MinionHPBar_thickness", "^ HPBar Thickness").SetValue(new Slider(1, 1, 3)));
            menuDrawing.AddItem(new MenuItem("orb_Draw_hitbox", "Show HitBoxes").SetValue(new Circle(true, Color.FloralWhite)));
            menuDrawing.AddItem(new MenuItem("orb_Draw_Lasthit", "Minion Lasthit").SetValue(new Circle(true, Color.Lime)));
            menuDrawing.AddItem(new MenuItem("orb_Draw_nearKill", "Minion nearKill").SetValue(new Circle(true, Color.Gold)));
            menu.AddSubMenu(menuDrawing);

            var menuMelee = new Menu("Melee", "orb_Melee");
            menuMelee.AddItem(new MenuItem("orb_Melee_Prediction", "Movement Prediction").SetValue(false));
            menu.AddSubMenu(menuMelee);

            menu.AddItem(new MenuItem("xSLx_info2", "Credits: xSLx & Esk0r"));

        }

    }
}
