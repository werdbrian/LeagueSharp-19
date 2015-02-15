using System;
using System.Collections.Generic;
using System.Linq;
using LeagueSharp;
using LeagueSharp.Common;
using SharpDX;

namespace DMGinc
{
    class Champion
    {
        protected Champion()
        {
            //Events
            Game.OnGameUpdate += Game_OnGameUpdate;
            Drawing.OnDraw += Drawing_OnDraw;
            Interrupter2.OnInterruptableTarget += Interrupter_OnPosibleToInterrupt;
            AntiGapcloser.OnEnemyGapcloser += AntiGapcloser_OnEnemyGapcloser;
            GameObject.OnCreate += GameObject_OnCreate;
            Obj_AI_Base.OnProcessSpellCast += Obj_AI_Base_OnProcessSpellCast;
            Game.OnGameSendPacket += Game_OnSendPacket;
            Game.OnGameProcessPacket += Game_OnGameProcessPacket;
            GameObject.OnDelete += GameObject_OnDelete;
            Obj_AI_Base.OnIssueOrder += ObjAiHeroOnOnIssueOrder;
            Spellbook.OnUpdateChargedSpell += Spellbook_OnUpdateChargedSpell;

            if (menu.Item("Orbwalker_Mode", true).GetValue<bool>())
            {
                Orbwalking.AfterAttack += AfterAttack;
                Orbwalking.BeforeAttack += BeforeAttack;
            }
            else
            {
                xSLxOrbwalker.AfterAttack += AfterAttack;
                xSLxOrbwalker.BeforeAttack += BeforeAttack;
            }

        }

        public Champion(bool load)
        {
            if (load)
                GameOnLoad();
        }

        //Orbwalker instance
        private Orbwalking.Orbwalker _orbwalker;

        //Player instance
        protected readonly Obj_AI_Hero Player = ObjectManager.Player;

        //Spells
        protected readonly List<Spell> SpellList = new List<Spell>();

        //items
        protected readonly Items.Item Dfg = Utility.Map.GetMap().Type == Utility.Map.MapType.TwistedTreeline ? new Items.Item(3188, 750) : new Items.Item(3128, 750);
        protected int LastPlaced;
        protected Vector3 LastWardPos;

        //Menu
        protected static Menu menu;

        private void GameOnLoad()
        {
            Game.PrintChat("<font color = \"#FFB6C1\">xSalice's Religion AIO</font> by <font color = \"#00FFFF\">xSalice</font>");
            Game.PrintChat("<font color = \"#87CEEB\">Feel free to donate via Paypal to:</font> <font color = \"#FFFF00\">xSalicez@gmail.com</font>");

            menu = new Menu(Player.ChampionName, Player.ChampionName, true);

            //Info
            menu.AddSubMenu(new Menu("Info", "Info"));
            menu.SubMenu("Info").AddItem(new MenuItem("Author", "By xSalice"));
            menu.SubMenu("Info").AddItem(new MenuItem("Paypal", "Donate: xSalicez@gmail.com"));

            menu.AddToMainMenu();

            try
            {
                if (Activator.CreateInstance(null, "xSaliceReligionAIO.Champions." + Player.ChampionName) != null)
                {
                    Game.PrintChat("<font color = \"#FFB6C1\">xSalice's " + Player.ChampionName + " Loaded!</font>");
                }
            }
            catch
            {
                Game.PrintChat("xSalice's Religion => {0} Not Support !", Player.ChampionName);
            }


            DamageIndicator champs = new Champion(true);

        }

        protected bool packets()
        {
            return menu.Item("packet", true).GetValue<bool>();
        }

        protected float GetHealthPercent(Obj_AI_Hero unit = null)
        {
            if (unit == null)
                unit = Player;
            return (unit.Health / unit.MaxHealth) * 100f;
        }

        protected PredictionOutput GetP(Vector3 pos, Spell spell, Obj_AI_Base target, float delay, bool aoe)
        {
            return Prediction.GetPrediction(new PredictionInput
            {
                Unit = target,
                Delay = spell.Delay + delay,
                Radius = spell.Width,
                Speed = spell.Speed,
                From = pos,
                Range = spell.Range,
                Collision = spell.Collision,
                Type = spell.Type,
                RangeCheckFrom = Player.ServerPosition,
                Aoe = aoe,
            });
        }

        protected PredictionOutput GetP(Vector3 pos, Spell spell, Obj_AI_Base target, bool aoe)
        {
            return Prediction.GetPrediction(new PredictionInput
            {
                Unit = target,
                Delay = spell.Delay,
                Radius = spell.Width,
                Speed = spell.Speed,
                From = pos,
                Range = spell.Range,
                Collision = spell.Collision,
                Type = spell.Type,
                RangeCheckFrom = Player.ServerPosition,
                Aoe = aoe,
            });
        }
        protected PredictionOutput GetPCircle(Vector3 pos, Spell spell, Obj_AI_Base target, bool aoe)
        {
            return Prediction.GetPrediction(new PredictionInput
            {
                Unit = target,
                Delay = spell.Delay,
                Radius = 1,
                Speed = float.MaxValue,
                From = pos,
                Range = float.MaxValue,
                Collision = spell.Collision,
                Type = spell.Type,
                RangeCheckFrom = pos,
                Aoe = aoe,
            });
        }

        protected Object[] VectorPointProjectionOnLineSegment(Vector2 v1, Vector2 v2, Vector2 v3)
        {
            float cx = v3.X;
            float cy = v3.Y;
            float ax = v1.X;
            float ay = v1.Y;
            float bx = v2.X;
            float by = v2.Y;
            float rL = ((cx - ax) * (bx - ax) + (cy - ay) * (by - ay)) /
                       ((float)Math.Pow(bx - ax, 2) + (float)Math.Pow(by - ay, 2));
            var pointLine = new Vector2(ax + rL * (bx - ax), ay + rL * (by - ay));
            float rS;
            if (rL < 0)
            {
                rS = 0;
            }
            else if (rL > 1)
            {
                rS = 1;
            }
            else
            {
                rS = rL;
            }
            bool isOnSegment = rS.CompareTo(rL) == 0;
            Vector2 pointSegment = isOnSegment ? pointLine : new Vector2(ax + rS * (bx - ax), ay + rS * (@by - ay));
            return new object[] { pointSegment, pointLine, isOnSegment };
        }


    }
}