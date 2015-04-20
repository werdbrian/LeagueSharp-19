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
            Menuxx = menu.AddSubMenu(new Menu("AutoPotting", "AutoPotting"));
            Menuxx.AddItem(new MenuItem("HPPotTrigger", "HP Percent Event").SetValue(new Slider(30)));
            Menuxx.AddItem(new MenuItem("HealthPotion", "Health Potion").SetValue(true));
            Menuxx.AddItem(new MenuItem("MPPotTrigger", "MP Percent Event").SetValue(new Slider(30)));
            Menuxx.AddItem(new MenuItem("ManaPotion", "Mana Potion").SetValue(true));
            _healthPotion = new Potion(ItemId.Health_Potion);
            _manaPotion = new Potion(ItemId.Mana_Potion);
            _biscuitPotion = new Potion((ItemId)2010);
            _flaskPotion = new Potion((ItemId)2041);
            
            Game.OnUpdate += Game_OnGameUpdate;
        }

        private void ResetTrigger()
        {
            HpTrigger = 100 - _healthPotion.HitHealthPercent;
            if (ObjectManager.Player.MaxMana <= 0)
            {
                ManaCheck = false;
                ManaTrigger = 0;
            }
            else
            {
                ManaTrigger = 100 - _manaPotion.HitManaPercent;
            }
        }


        private void Game_OnGameUpdate(EventArgs args)
        {
            if (!ObjectManager.Player.IsDead && !ObjectManager.Player.InFountain() && !ObjectManager.Player.HasBuff("Recall"))
            {
                BarPot lastBar = new BarPot(ObjectManager.Player.TotalHeal, ObjectManager.Player.Mana);
                bool hasEnemy = Utility.CountEnemiesInRange(800) > 0;
                if (HealthCheck && ((lastBar.HealthPercent <= HpTrigger && hasEnemy || (lastBar.HealthPercent < 50))))
                {
                    if ((lastBar.ManaPercent <= ManaTrigger && hasEnemy || lastBar.ManaPercent < 50) && _flaskPotion.IsReady())
                    {
                        _flaskPotion.Cast();
                        return;
                    }
                    if (_healthPotion.IsReady())
                    {
                        _healthPotion.Cast();
                    }
                    else if (_biscuitPotion.IsReady())
                    {
                        _biscuitPotion.Cast();
                    }
                    else if (_flaskPotion.IsReady())
                    {
                        _flaskPotion.Cast();
                        return;
                    }
                }
                if (ManaCheck && (lastBar.ManaPercent <= ManaTrigger && hasEnemy || lastBar.ManaPercent < 50))
                {
                    if (_manaPotion.IsReady())
                    {
                        _manaPotion.Cast();
                    }
                    else if (_flaskPotion.IsReady())
                    {
                        _flaskPotion.Cast();
                    }
                }
            }
        }
        public readonly Menu Menuxx;
        private readonly Potion _healthPotion;
        private readonly Potion _manaPotion;
        private readonly Potion _biscuitPotion;
        private readonly Potion _flaskPotion;

        public int HpTrigger
        {
            get { return Menuxx.Item("HPTrigger").GetValue<Slider>().Value; }
            set { Menuxx.Item("HPTrigger").SetValue(new Slider(value)); }
        }
        public int ManaTrigger
        {
            get { return Menuxx.Item("MPTrigger").GetValue<Slider>().Value; }
            set { Menuxx.Item("MPTrigger").SetValue(new Slider(value)); }
        }
        public bool HealthCheck
        {
            get { return Menuxx.Item("HealthPotion").GetValue<bool>(); }
            set { Menuxx.Item("HealthPotion").SetValue(value); }
        }
        public bool ManaCheck
        {
            get { return Menuxx.Item("ManaPotion").GetValue<bool>(); }
            set { Menuxx.Item("ManaPotion").SetValue(value); }
        }
    }
}
