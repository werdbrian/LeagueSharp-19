using System;
using System.Linq;
using LeagueSharp;
using LeagueSharp.Common;

using Color = System.Drawing.Color;

namespace KyonNautilus
{
    class Program
    {
        private static Orbwalking.Orbwalker _orbwalker;
        private static readonly Obj_AI_Hero Player = ObjectManager.Player;

        public static Spell Q { get; set; }
        public static Spell W { get; set; }
        public static Spell E { get; set; }
        public static Spell R { get; set; }

        public static Spell Ignite { get; set; }

        private static Menu _menu;

        static void Main(string[] args)
        {
            CustomEvents.Game.OnGameLoad += Game_OnGameLoad;
        }

        private static void Game_OnGameLoad(EventArgs args)
        {

            if (Player.ChampionName != "Nautilus")
                return;

            Q = new Spell(SpellSlot.Q, 900);
            Q.SetSkillshot(250, 90, 2000, true, SkillshotType.SkillshotLine);
            W = new Spell(SpellSlot.W);
            E = new Spell(SpellSlot.E, 550);
            R = new Spell(SpellSlot.R, 755);

            var slot = Player.GetSpellSlot("summonerdot");
            if (slot != SpellSlot.Unknown)
            {
                Ignite = new Spell(slot, 600);
            }

            _menu = new Menu("Kyon's " + Player.ChampionName, Player.ChampionName, true);

            Menu orbwalkerMenu = _menu.AddSubMenu(new Menu("Orbwalker", "Orbwalker"));
            _orbwalker = new Orbwalking.Orbwalker(orbwalkerMenu);

            Menu ts = _menu.AddSubMenu(new Menu("Target Selector", "Target Selector"));
            TargetSelector.AddToMenu(ts);

            Menu combo = _menu.AddSubMenu(new Menu("combo", "combo"));
            Menu laneclear = _menu.AddSubMenu(new Menu("laneclear", "laneclear"));
            Menu misc = _menu.AddSubMenu(new Menu("misc", "misc"));
            Menu drawings = _menu.AddSubMenu(new Menu("drawings", "drawings"));

            combo.AddItem(new MenuItem("CombouseQ", "Use Q").SetValue(true)); //y
            combo.AddItem(new MenuItem("CombouseQundert", "Use Q under tower ?").SetValue(true)); //y
            combo.AddItem(new MenuItem("CombouseW", "Use W").SetValue(true)); //y
            combo.AddItem(new MenuItem("CombouseE", "Use E").SetValue(true)); //y
            combo.AddItem(new MenuItem("CombouseR", "Use R").SetValue(true)); //y
            combo.AddItem(new MenuItem("CombouseRkill", "R Killsteal ?").SetValue(true)); //y

            laneclear.AddItem(new MenuItem("laneuseQ", "Use Q").SetValue(true));
            laneclear.AddItem(new MenuItem("laneuseW", "Use W").SetValue(true));
            laneclear.AddItem(new MenuItem("laneuseE", "Use E").SetValue(true));

            drawings.AddItem(new MenuItem("drawingsdrawQ", "Draw Q").SetValue(true)); //y
            drawings.AddItem(new MenuItem("drawingsdrawW", "Draw W").SetValue(true)); //y
            drawings.AddItem(new MenuItem("drawingsdrawE", "Draw E").SetValue(true)); //y
            drawings.AddItem(new MenuItem("drawingsdrawR", "Draw R").SetValue(true)); //y

            misc.AddItem(new MenuItem("miscigniteuse", "Use Ignite").SetValue(true)); //y

            _menu.AddToMainMenu();

            Drawing.OnDraw += Drawing_OnDraw;
            Game.OnUpdate += Game_OnUpdate;
        }

        private static void Game_OnUpdate(EventArgs args)
        {
            switch (_orbwalker.ActiveMode)
            {
                case Orbwalking.OrbwalkingMode.Combo:
                    Combo();
                    break;
                case Orbwalking.OrbwalkingMode.LaneClear:
                    Laneclear();
                    break;
            }
        }

        private static void Laneclear()
        {

            var minion = MinionManager.GetMinions(Player.Position, Q.Range, MinionTypes.All, MinionTeam.All);

            if (minion.Count >= 2 && E.IsReady() && minion.First().IsValidTarget(E.Range - 50) && _menu.Item("laneuseE").GetValue<bool>())
            {
                E.Cast(true);
            }

            if (Q.IsReady() && _menu.Item("laneuseQ").GetValue<bool>())
            {
                var jungleMobs = MinionManager.GetMinions(Q.Range, MinionTypes.All, MinionTeam.Neutral, MinionOrderTypes.MaxHealth);
                if (jungleMobs.Count >= 3)
                {
                    var target = jungleMobs.First();
                    Q.CastIfHitchanceEquals(target, HitChance.High, true);
                }
            }

            if (W.IsReady() && Player.HealthPercent <= 75 && _menu.Item("laneuseE").GetValue<bool>())
            {
                W.Cast(true);
            }

        }

        private static void Combo()
        {

            var ts = TargetSelector.GetTarget(Q.Range, TargetSelector.DamageType.Magical);

            if (Q.IsReady() && _menu.Item("CombouseQ").GetValue<bool>())
            {
                var qprediction = Q.GetPrediction(ts);
                if (!_menu.Item("CombouseQundert").GetValue<bool>())
                {
                    if (qprediction.Hitchance >= HitChance.VeryHigh &&
                        qprediction.CollisionObjects.Count(h => h.IsEnemy && !h.IsDead && h is Obj_AI_Minion) < 2 &&
                        !ts.UnderTurret())
                    {
                        Q.Cast(qprediction.CastPosition, true);
                    }
                }
                else
                {
                    if (qprediction.Hitchance >= HitChance.VeryHigh &&
                        qprediction.CollisionObjects.Count(h => h.IsEnemy && !h.IsDead && h is Obj_AI_Minion) < 2)
                    {
                        Q.Cast(qprediction.CastPosition, true);
                    }
                }
            }


            if (W.IsReady() && Player.HealthPercent >= 75 && _menu.Item("CombouseW").GetValue<bool>())
            {
                W.Cast(true);
            }


            if (E.IsReady() && ts.IsValidTarget(E.Range - 50)  && _menu.Item("CombouseE").GetValue<bool>())
            {
                E.Cast(ts, true, true);
            }


            if (_menu.Item("CombouseRkill").GetValue<bool>())
            {
                if (R.IsReady() && ts.IsValidTarget(R.Range) && ts.GetSpellDamage(ts, SpellSlot.R) >= ts.Health &&
                    _menu.Item("CombouseR").GetValue<bool>())
                {
                    R.CastOnUnit(ts, true);
                }
            }
            else
            {
                if (R.IsReady() && ts.IsValidTarget(R.Range) && ts.GetSpellDamage(ts, SpellSlot.R) <= ts.Health &&
                     _menu.Item("CombouseR").GetValue<bool>())
                {
                    R.CastOnUnit(ts, true);
                }
            }
            

            if (Ignite.IsReady() && ts.IsValidTarget(Ignite.Range) && ts.Health < Ignite.GetDamage(ts) && _menu.Item("miscigniteuse").GetValue<bool>())
            {
                Ignite.CastOnUnit(ts, true);
            }

        }
   

        private static void Drawing_OnDraw(EventArgs args)
        {

            if (Q.IsReady() && _menu.Item("drawingsdrawQ").GetValue<bool>())
            {
                Render.Circle.DrawCircle(Player.Position, Q.Range, Color.Crimson);
            }

            if (W.IsReady() && _menu.Item("drawingsdrawW").GetValue<bool>())
            {
                Render.Circle.DrawCircle(Player.Position, W.Range, Color.CornflowerBlue);
            }

            if (E.IsReady() && _menu.Item("drawingsdrawE").GetValue<bool>())
            {
                Render.Circle.DrawCircle(Player.Position, E.Range, Color.FloralWhite);
            }

            if (R.IsReady() && _menu.Item("drawingsdrawR").GetValue<bool>())
            {
                Render.Circle.DrawCircle(Player.Position, R.Range, Color.Orange);
            }

        }
    }
}
