using LeagueSharp;
using LeagueSharp.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using SharpDX;
using Color = System.Drawing.Color;


namespace DMGinc
{
    class Program
    {
       
        public static Menu Menu;
        public static Obj_AI_Hero MyHero = ObjectManager.Player;
        public static AttackableUnit ForcedTarget = null;
        public static IEnumerable<Obj_AI_Hero> AllEnemys = ObjectManager.Get<Obj_AI_Hero>().Where(hero => hero.IsEnemy);
        public static IEnumerable<Obj_AI_Hero> AllAllys = ObjectManager.Get<Obj_AI_Hero>().Where(hero => hero.IsAlly);
        public static bool CustomOrbwalkMode;
        
        private static bool _drawing = true;
        private static bool _attack = true;
        private static bool _movement = true;
        private static bool _disableNextAttack;
        private const float LaneClearWaitTimeMod = 2f;
        private static int _lastAATick;
        private static AttackableUnit _lastTarget;
        private static Spell _movementPrediction;
        private static int _lastMovement;
        private static int _windup;
        private static int lastRealAttack;

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
            Menu.AddSubMenu(menuDrawing);

            var menuMelee = new Menu("Melee", "orb_Melee");
            menuMelee.AddItem(new MenuItem("orb_Melee_Prediction", "Movement Prediction").SetValue(false));
            Menu.AddSubMenu(menuMelee);

            Menu.AddItem(new MenuItem("xSLx_info2", "Credits: xSLx & Esk0r"));

        }

        private static void OnDraw(EventArgs args)
        {
            if (!_drawing)
                return;

            if (Menu.Item("orb_Draw_AARange").GetValue<Circle>().Active)
            {
                Render.Circle.DrawCircle(MyHero.Position, GetAutoAttackRange(), Menu.Item("orb_Draw_AARange").GetValue<Circle>().Color);
            }

            if (Menu.Item("orb_Draw_AARange_Enemy").GetValue<Circle>().Active ||
                Menu.Item("orb_Draw_hitbox").GetValue<Circle>().Active)
            {
                foreach (var enemy in AllEnemys.Where(enemy => enemy.IsValidTarget(1500)))
                {
                    if (Menu.Item("orb_Draw_AARange_Enemy").GetValue<Circle>().Active)
                        Render.Circle.DrawCircle(enemy.Position, GetAutoAttackRange(enemy, MyHero), Menu.Item("orb_Draw_AARange_Enemy").GetValue<Circle>().Color);
                    if (Menu.Item("orb_Draw_hitbox").GetValue<Circle>().Active)
                        Render.Circle.DrawCircle(enemy.Position, enemy.BoundingRadius, Menu.Item("orb_Draw_hitbox").GetValue<Circle>().Color);
                }
            }
        }

        public static float GetAutoAttackRange(Obj_AI_Base source = null, AttackableUnit target = null)
        {
            if (source == null)
                source = MyHero;
            var ret = source.AttackRange + MyHero.BoundingRadius;
            if (target != null)
                ret += target.BoundingRadius;
            return ret;
        }

    }
}
