using System;
using LeagueSharp;
using LeagueSharp.Common;
using UtilityAIO.extras;

namespace UtilityAIO.utilities
{
    class AutoPot
    {
        class BarPot
        {
            public BarPot(float health, float mana = 0)
            {
                Health = health;
                Mana = mana;
                HealthPercent = Potion.GetPercent(Health, ObjectManager.Player.MaxHealth);
                ManaPercent = Potion.GetPercent(Mana, ObjectManager.Player.MaxMana);
            }

            private float Health { get; set; }
            private float Mana { get; set; }

            public float HealthPercent { get; private set; }
            public float ManaPercent { get; private set; }

            public static BarPot operator +(BarPot a, BarPot b)
            {
                return new BarPot(a.Health + b.Health, a.Mana + b.Mana);
            }
        }
        public AutoPot(Menu menu)
        {
             menu = _menu.AddSubMenu(new Menu("Potion Manager", "PotionManager"));
            _menu.AddItem(new MenuItem("HPTrigger", "HP Trigger Percent").SetValue(new Slider(30)));
            _menu.AddItem(new MenuItem("HealthPotion", "Health Potion").SetValue(true));
            _menu.AddItem(new MenuItem("MPTrigger", "MP Trigger Percent").SetValue(new Slider(30)));
            _menu.AddItem(new MenuItem("ManaPotion", "Mana Potion").SetValue(true));
            _healthPotion = new Potion(ItemId.Health_Potion);
            _manaPotion = new Potion(ItemId.Mana_Potion);
            _biscuitPotion = new Potion((ItemId)2010);
            _flaskPotion = new Potion((ItemId)2041);

            Game.OnUpdate += Game_OnGameUpdate;
        }

        private void Game_OnGameUpdate(EventArgs args)
        {
            var hasEnemy = Utility.CountEnemiesInRange(1200) > 0;
            Game.PrintChat(HealthCheck + " // " + _hero.HealthPercent + " // " + hasEnemy);

            if ( !_hero.IsDead && !_hero.InFountain() && !_hero.HasBuff("Recall"))
            {
                //gucken ob gegner in der Nähe sind
                
                

                //wenn Healautopot
                if (HealthCheck && _hero.HealthPercent <= HpTrigger && hasEnemy)
                {
                    // das nur benutzen wenn auch noch zusätzlich mana fehlt < 75%
                    BarPot lastPot = new BarPot(HealthPrediction.GetHealthPrediction(_hero, _healthPotion.ProcessTime), _hero.Mana);
                    if ((_hero.ManaPercent <= MpTrigger || _hero.ManaPercent < 75) && _flaskPotion.IsReady())
                    {
                        _flaskPotion.Cast();
                        return;
                    }

                    // die anderen beiden varianten testen
                    if (_biscuitPotion.IsReady())
                    {
                        _biscuitPotion.Cast();
                    }
                    else if (_healthPotion.IsReady())
                    {
                        _healthPotion.Cast();
                    }

                }

                if (ManaCheck && _hero.ManaPercent <= MpTrigger && hasEnemy)
                {
                    // benutzen für Mana logisch xD
                    if (_manaPotion.IsReady())
                    {
                        _manaPotion.Cast();
                    }// bei zusätzlich leben auch das :)
                    else if (_flaskPotion.IsReady() && _hero.HealthPercent < 75)
                    {
                        _flaskPotion.Cast();
                    }
                }
            }
        }

        private readonly Menu _menu;
        private readonly Potion _healthPotion;
        private readonly Potion _manaPotion;
        private readonly Potion _biscuitPotion;
        private readonly Potion _flaskPotion;
        private readonly Obj_AI_Hero _hero = ObjectManager.Player;

        public int HpTrigger
        {
            get { return _menu.Item("HPTrigger").GetValue<Slider>().Value; }
            set { _menu.Item("HPTrigger").SetValue(new Slider(value)); }
        }
        public int MpTrigger
        {
            get { return _menu.Item("MPTrigger").GetValue<Slider>().Value; }
            set { _menu.Item("MPTrigger").SetValue(new Slider(value)); }
        }           
        public bool HealthCheck
        {
            get { return _menu.Item("HealthPotion").GetValue<bool>(); }
            set { _menu.Item("HealthPotion").SetValue(value); }
        }
        public bool ManaCheck
        {
            get { return _menu.Item("ManaPotion").GetValue<bool>(); }
            set { _menu.Item("ManaPotion").SetValue(value); }
        }
    }
}
