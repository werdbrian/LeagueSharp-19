using System;
using System.Collections.Generic;
using System.Linq;
using LeagueSharp;
using LeagueSharp.Common;
using SharpDX;
using Color = System.Drawing.Color;



namespace TeddyBear
{
    class Program
    {
        private const string ChampionName = "Volibear";
        public static Obj_AI_Hero Player;
        private static Menu _menu;
        private static Orbwalking.Orbwalker _orbwalker;
        private static Spell _q, _w, _e, _r;
        static Items.Item _botrk, _cutlass;
        static SpellSlot _smiteslot;

        private static void Main(string[] args)
        {
            CustomEvents.Game.OnGameLoad += Game_OnLoad;
        }

        static void Game_OnLoad(EventArgs args)
        {
            #region main
            {
                Player = ObjectManager.Player;

                if (Player.ChampionName != ChampionName)
                {
                    ShowNotification("You aren't a TeddyBear !", 3000);
                    return;
                }

                _q = new Spell(SpellSlot.Q, 600, TargetSelector.DamageType.Physical);
                _w = new Spell(SpellSlot.W, 405, TargetSelector.DamageType.Physical);
                _e = new Spell(SpellSlot.E, 400, TargetSelector.DamageType.Magical);
                _r = new Spell(SpellSlot.R, 125, TargetSelector.DamageType.Magical);

                _botrk = new Items.Item(3153, 450f);
                _cutlass = new Items.Item(3144, 450f);

            }
            #endregion

            #region content menu

            _menu = new Menu("Teddy Bear - ThunderBuddy", "teddy.bear", true);
            var orbwalkerMenu = new Menu(("Orbwalker"), "teddy.bear.orbwalker");
            _orbwalker = new Orbwalking.Orbwalker(orbwalkerMenu);

            _menu.AddSubMenu(orbwalkerMenu);

            Menu targetSelector = new Menu("Target Selector", "teddy.bear.ts");
            TargetSelector.AddToMenu(targetSelector);
            _menu.AddSubMenu(targetSelector);



            var comboMenu = new Menu("Combo", "teddy.bear.combo");
            {
                comboMenu.AddItem(new MenuItem("teddy.bear.combo.useq", "Use Q").SetValue(true));
                comboMenu.AddItem(new MenuItem("teddy.bear.combo.usew", "Use W").SetValue(true));
                comboMenu.AddItem(new MenuItem("teddy.bear.combo.usee", "Use E").SetValue(true));
                comboMenu.AddItem(new MenuItem("teddy.bear.combo.user", "Use R").SetValue(true));
            }
            _menu.AddSubMenu(comboMenu);

            var harrassMenu = new Menu("Harass", "teddy.bear.harrass");
            {
                harrassMenu.AddItem(new MenuItem("teddy.bear.harrassuseq", "Use Q").SetValue(true));
                harrassMenu.AddItem(new MenuItem("teddy.bear.harrassusew", "Use W").SetValue(true));
                harrassMenu.AddItem(new MenuItem("teddy.bear.harrassusee", "Use E").SetValue(true));

            }
            _menu.AddSubMenu(harrassMenu);

            var fleeMenu = new Menu("Flee", "teddy.bear.flee");
            {
                fleeMenu.AddItem(new MenuItem("teddy.bear.flee.fleekey", "FLEEEEEEEEEE! ").SetValue(new KeyBind('A', KeyBindType.Press)));
                fleeMenu.AddItem(new MenuItem("teddy.bear.flee.usew", "Use W").SetValue(true));
                fleeMenu.AddItem(new MenuItem("teddy.bear.flee.usee", "Use E").SetValue(true));

            }
            _menu.AddSubMenu(fleeMenu);

            var misc = new Menu("Misc", "teddy.bear.misc");
            {
                misc.AddItem(new MenuItem("teddy.bear.misc.packets", "KS with W").SetValue(true));
                misc.AddItem(new MenuItem("teddy.bear.misc.packets", "safe kill with W").SetValue(true));
                misc.AddItem(new MenuItem("teddy.bear.misc.packets", "use packets").SetValue(true));
                misc.AddItem(new MenuItem("teddy.bear.misc.exhaust", "use smite").SetValue(true));
            }
            _menu.AddSubMenu(misc);

            var drawingMenu = new Menu("Drawing", "teddy.bear.drawing");
            {
                drawingMenu.AddItem(new MenuItem("DrawQ", "Draw Q range").SetValue(new Circle(true, Color.Aqua, _q.Range)));
                drawingMenu.AddItem(new MenuItem("DrawW", "Draw W range").SetValue(new Circle(true, Color.SpringGreen, _w.Range)));
                drawingMenu.AddItem(new MenuItem("DrawE", "Draw E range").SetValue(new Circle(true, Color.SlateBlue, _e.Range)));
                drawingMenu.AddItem(new MenuItem("DrawR", "Draw R range").SetValue(new Circle(true, Color.Red, _r.Range)));
            }
            _menu.AddSubMenu(drawingMenu);

            _menu.AddToMainMenu();

            #endregion

            Interrupter2.OnInterruptableTarget += Interrupter_OnPossibleToInterrupt;
            Game.OnUpdate += Game_OnUpdate;
            Drawing.OnDraw += Drawing_OnDraw;
            ShowNotification("TeddyBear - Loaded", 3000);

        }

        static void Interrupter_OnPossibleToInterrupt(Obj_AI_Base unit, Interrupter2.InterruptableTargetEventArgs args)
        {

        }

        public static void ShowNotification(string message, int duration = -1, bool dispose = true)
        {
            Notifications.AddNotification(new Notification(message, duration, dispose));
        }

        private static void Drawing_OnDraw(EventArgs args)
        {
            var menuItem1 = _menu.Item("DrawQ").GetValue<Circle>();
            var menuItem2 = _menu.Item("DrawE").GetValue<Circle>();
            var menuItem3 = _menu.Item("DrawW").GetValue<Circle>();
            var menuItem4 = _menu.Item("DrawR").GetValue<Circle>();

            if (menuItem1.Active && _q.IsReady()) Render.Circle.DrawCircle(Player.Position, _q.Range, Color.SpringGreen);
            if (menuItem2.Active && _e.IsReady()) Render.Circle.DrawCircle(Player.Position, _e.Range, Color.Crimson);
            if (menuItem3.Active && _w.IsReady()) Render.Circle.DrawCircle(Player.Position, _w.Range, Color.Aqua);
            if (menuItem4.Active && _r.IsReady()) Render.Circle.DrawCircle(Player.Position, _r.Range, Color.Firebrick);
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
                case Orbwalking.OrbwalkingMode.None:
                    break;
            }
        }

        private static void Laneclear() // jungle clear ^^
        {
            bool vQ = _q.IsReady() && _menu.Item("teddy.bear.laneclear.useq").GetValue<bool>();
            bool vW = _w.IsReady() && _menu.Item("teddy.bear.combo.usew").GetValue<bool>();
            bool vE = _e.IsReady() && _menu.Item("teddy.bear.combo.usee").GetValue<bool>();

            var minionBase = MinionManager.GetMinions(_w.Range, MinionTypes.All, MinionTeam.Neutral);
            var jungleBase = MinionManager.GetMinions(_e.Range, MinionTypes.All, MinionTeam.Neutral);

            #region W-Cast Jungle
            if (vW)
            {
                foreach (var minion in minionBase.Where(minion => minion.Health < Player.CalcDamage(minion, Damage.DamageType.Magical, 1)))
                {
                    _w.CastOnUnit(minion);
                }
            }
            #endregion

            #region E-Cast Jungle
            if (vE)
            {
                if (jungleBase.Count >= 2)
                {
                    _e.Cast();
                }

                foreach (Obj_AI_Minion junglemob in ObjectManager.Get<Obj_AI_Minion>().Where(
                    x => x.Name.Contains("SRU_Blue1.1.1") || x.Name.Contains("SRU_Blue7.1.1") || x.Name.Contains("SRU_Red4.1.1") || x.Name.Contains("SRU_Red10.1.1") && x.IsValidTarget()))
                {
                    _e.Cast(junglemob);
                }

            }
            #endregion
        } 

        private static void Combo()
        {
            bool vQ = _q.IsReady() && _menu.Item("teddy.bear.combo.useq").GetValue<bool>();
            bool vW = _w.IsReady() && _menu.Item("teddy.bear.combo.usew").GetValue<bool>();
            bool vE = _e.IsReady() && _menu.Item("teddy.bear.combo.usee").GetValue<bool>();
            bool vR = _r.IsReady() && _menu.Item("teddy.bear.combo.user").GetValue<bool>();

            Obj_AI_Hero tsQ = TargetSelector.GetTarget(_q.Range, TargetSelector.DamageType.Magical);
            Obj_AI_Hero tsR = TargetSelector.GetTarget(_r.Range, TargetSelector.DamageType.Magical);

        }

        static int AlliesInRange(float range)
        {
            int count = 0;
            foreach (Obj_AI_Hero hero in ObjectManager.Get<Obj_AI_Hero>())
                if (hero.IsAlly && !hero.IsMe && Vector3.Distance(Player.Position, hero.Position) <= range) count++;
            return count;
        }

    }
}