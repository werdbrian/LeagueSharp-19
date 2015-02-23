using System;
using LeagueSharp;
using LeagueSharp.Common;
using _Damage = LeagueSharp.Common.Damage;
using SharpDX;
using Color = System.Drawing.Color;

namespace DMGinc
{
    class Program
    {

        public static Obj_AI_Hero Player;
        private static Obj_AI_Hero _target;
        private static Menu _menu;
        public static Spell Q;
        public static Spell W;
        public static Spell E;
        public static Spell R;

        private static MenuItem drawFill;
        private static MenuItem drawLine;

        public delegate float DamageToUnitDelegate(Obj_AI_Hero hero);
        public static Orbwalking.Orbwalker Orbwalker;

        private const int XOffset = 10;
        private const int YOffset = 20;
        private const int Width = 103;
        private const int Height = 8;

        public static Color Color = Color.Lime;
        public static Color FillColor = Color.Goldenrod;
        public static bool Fill = true;

        public static bool Enabled = true;
        private static DamageToUnitDelegate _damageToUnit;
        private static Notification welcome;
        private static readonly Render.Text Text = new Render.Text(
            0, 0, "", 11, new ColorBGRA(255, 0, 0, 255), "monospace");


        static void Main(string[] args)
        {
            CustomEvents.Game.OnGameLoad += Game_OnGameLoad;
            Player = ObjectManager.Player;

            #region Hello

            //Game.PrintChat("<font color=\"#AF7AFF\"><b>Damage Indicator</b></font> for " + Player.ChampionName + " - Loaded");
            Notifications.AddNotification("Damage Indicator for " + Player.ChampionName, 10, true);
            
            #endregion

        }

        static void Game_OnGameLoad(EventArgs args)
        {
            
            #region Menushit
            _menu = new Menu("Damage Indicator", "damage.Indicator", true);
            var Drawings = new Menu("Drawings", "drawings");
            {
                //Drawings.AddItem(new MenuItem("drawq", "Show Q Range")).SetValue(true);
                //Drawings.AddItem(new MenuItem("draww", "Show W Range")).SetValue(true);
                //Drawings.AddItem(new MenuItem("drawe", "Show E Range")).SetValue(true);
                //Drawings.AddItem(new MenuItem("drawr", "Show R Range")).SetValue(true);
            }
            _menu.AddSubMenu(Drawings);
            drawFill = new MenuItem("Draw_Fill", "Draw Combo Damage (Fill)", true).SetValue(new Circle(true, Color.FromArgb(90, 255, 169, 4)));
            drawLine = new MenuItem("Draw_Line", "Draw Combo Damage (Line)", true).SetValue(new Circle(true, Color.FromArgb(90, 255, 169, 4)));
            Drawings.AddItem(drawFill);
            Drawings.AddItem(drawLine);
            _menu.AddToMainMenu();
            #endregion 

            Drawing.OnDraw += Drawing_OnDraw;

            Q = new Spell(SpellSlot.Q);
            W = new Spell(SpellSlot.W);
            E = new Spell(SpellSlot.E);
            R = new Spell(SpellSlot.R);
        }

        private static void Drawing_OnDraw(EventArgs args)
        {

            //if (_menu.Item("drawq").GetValue<bool>())
            //    Render.Circle.DrawCircle(Player.Position, Q.Range, System.Drawing.Color.White, 3);
            //if (_menu.Item("draww").GetValue<bool>())
            //    Render.Circle.DrawCircle(Player.Position, W.Range, System.Drawing.Color.White, 3);
            //if (_menu.Item("drawe").GetValue<bool>())
            //    Render.Circle.DrawCircle(Player.Position, E.Range, System.Drawing.Color.White, 3);
            //if (_menu.Item("drawr").GetValue<bool>())
            //    Render.Circle.DrawCircle(Player.Position, R.Range, System.Drawing.Color.White, 3);

            if (Player.IsDead != true)
            {
                Class1.DamageToUnit = GetComboDamage;
                Class1.Enabled = true;
                Class1.Fill = drawFill.GetValue<Circle>().Active;
                Class1.FillColor = drawFill.GetValue<Circle>().Color;
                Class1.Color = drawLine.GetValue<Circle>().Color;
                Class1.ColorFill = drawLine.GetValue<Circle>().Active;
            }

        }

        private static float GetComboDamage(Obj_AI_Base enemy)
        {
            if (enemy == null)
                return 0;

            double damage = 0d;

            #region Q Spell Calc
            if (Q.IsReady())
            {
                if (Q.DamageType == TargetSelector.DamageType.Magical)
                {
                    damage += Player.CalcDamage(enemy, _Damage.DamageType.Magical, Player.GetSpellDamage(enemy, SpellSlot.Q));
                }
                else if (Q.DamageType == TargetSelector.DamageType.Physical)
                {
                    damage += Player.CalcDamage(enemy, _Damage.DamageType.Physical, Player.GetSpellDamage(enemy, SpellSlot.Q));
                }
                else if (Q.DamageType == TargetSelector.DamageType.True)
                {
                    damage += Player.CalcDamage(enemy, _Damage.DamageType.True, Player.GetSpellDamage(enemy, SpellSlot.Q));
                }
            }
            #endregion

            #region W Spell Calc
            if (W.IsReady())
            {
                if (W.DamageType == TargetSelector.DamageType.Magical)
                {
                    damage += Player.CalcDamage(enemy, _Damage.DamageType.Magical, Player.GetSpellDamage(enemy, SpellSlot.W));
                }
                else if (W.DamageType == TargetSelector.DamageType.Physical)
                {
                    damage += Player.CalcDamage(enemy, _Damage.DamageType.Physical, Player.GetSpellDamage(enemy, SpellSlot.W));
                }
                else if (W.DamageType == TargetSelector.DamageType.True)
                {
                    damage += Player.CalcDamage(enemy, _Damage.DamageType.True, Player.GetSpellDamage(enemy, SpellSlot.W));
                }
            }
            #endregion

            #region E Spell Calc
            if (E.IsReady())
            {
                if (E.DamageType == TargetSelector.DamageType.Magical)
                {
                    damage += Player.CalcDamage(enemy, _Damage.DamageType.Magical, Player.GetSpellDamage(enemy, SpellSlot.E));
                }
                else if (E.DamageType == TargetSelector.DamageType.Physical)
                {
                    damage += Player.CalcDamage(enemy, _Damage.DamageType.Physical, Player.GetSpellDamage(enemy, SpellSlot.E));
                }
                else if (E.DamageType == TargetSelector.DamageType.True)
                {
                    damage += Player.CalcDamage(enemy, _Damage.DamageType.True, Player.GetSpellDamage(enemy, SpellSlot.E));
                }
            }
            #endregion

            #region R Spell Calc
            if (R.IsReady())
            {
                if (R.DamageType == TargetSelector.DamageType.Magical)
                {
                    damage += Player.CalcDamage(enemy, _Damage.DamageType.Magical, Player.GetSpellDamage(enemy, SpellSlot.R));
                }
                else if (R.DamageType == TargetSelector.DamageType.Physical)
                {
                    damage += Player.CalcDamage(enemy, _Damage.DamageType.Physical, Player.GetSpellDamage(enemy, SpellSlot.R));
                }
                else if (R.DamageType == TargetSelector.DamageType.True)
                {
                    damage += Player.CalcDamage(enemy, _Damage.DamageType.True, Player.GetSpellDamage(enemy, SpellSlot.R));
                }
            }
            #endregion

            damage += Player.CalcDamage(enemy, _Damage.DamageType.Physical, Player.GetAutoAttackDamage(enemy));
            
            damage = ActiveItems.CalcDamage(enemy, damage);
            
            return (float)damage;

        }
     }
}
