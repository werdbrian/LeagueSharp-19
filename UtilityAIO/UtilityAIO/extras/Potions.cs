using System.Linq;
using LeagueSharp;

namespace UtilityAIO.extras
{
    class Potion
    {
        public int HealthAmount { get; set; }
        public int ManaAmount { get; set; }
        public int ProcessTime { get; set; }
        public Potion(ItemId id)
        {
            Id = id;
            switch (Id)
            {
                case ItemId.Health_Potion://Mau
                    Name = "RegenerationPotion";
                    HealthAmount = 150;
                    ProcessTime = 15;
                    break;
                case ItemId.Mana_Potion://Mana
                    Name = "FlaskOfCrystalWater";
                    ManaAmount = 100;
                    ProcessTime = 15;
                    break;
                case (ItemId)2041://Mau va Mana
                    Name = "ItemCrystalFlask";
                    HealthAmount = 120;
                    ManaAmount = 60;
                    ProcessTime = 12;
                    break;
                case (ItemId)2010://Banh quy
                    Name = "ItemMiniRegenPotion";
                    HealthAmount = 170;
                    ManaAmount = 10;
                    ProcessTime = 15;
                    break;
            }
        }
        public int HitHealthPercent
        {
            get { return GetPercent(HealthAmount, (int)ObjectManager.Player.MaxHealth); }
        }
        public int HitManaPercent
        {
            get { return GetPercent(ManaAmount, (int)ObjectManager.Player.MaxMana); }
        }
        public bool IsReady()
        {
            if (Id == (ItemId)2041)
            {
                return ObjectManager.Player.InventoryItems.Any(slot => slot.Id == Id && slot.Charges > 1) && !ObjectManager.Player.HasBuff(Name);
            }
            return ObjectManager.Player.InventoryItems.Any(slot => slot.Id == Id) && !ObjectManager.Player.HasBuff(Name);
        }
        public bool Cast()
        {
            return ObjectManager.Player.InventoryItems.Where(slot => slot.Id == Id).Select(slot => ObjectManager.Player.Spellbook.CastSpell(slot.SpellSlot)).FirstOrDefault();
        }

        public ItemId Id { get; set; }

        public string Name { get; set; }

        public static int GetPercent(float cur, float max)
        {
            return (int)((cur * 1.0) / max * 100);
        }
    }
}