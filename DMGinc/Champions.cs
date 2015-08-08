using LeagueSharp;
using LeagueSharp.Common;

namespace DMGinc
{
    class Champions
    {
        public static Spell Q;
        public static Spell W;
        public static Spell E;
        public static Spell R;
        public static Obj_AI_Hero Player = ObjectManager.Player;
        public static void Load()
        {

            switch (Player.ChampionName)
            {
                case "Ahri":
                    Q = new Spell(SpellSlot.Q, 0 , TargetSelector.DamageType.True);
                    W = new Spell(SpellSlot.W, 0, TargetSelector.DamageType.Magical);
                    E = new Spell(SpellSlot.E, 0, TargetSelector.DamageType.Magical);
                    R = new Spell(SpellSlot.R, 0, TargetSelector.DamageType.Magical);
                    break;

                case "Aatrox":
                    Q = new Spell(SpellSlot.Q, 0);
                    W = new Spell(SpellSlot.W, 0);
                    E = new Spell(SpellSlot.E, 0);
                    R = new Spell(SpellSlot.R, 0);
                    break;

                case "Akali":
                    Q = new Spell(SpellSlot.Q, 0, TargetSelector.DamageType.Magical);
                    W = new Spell(SpellSlot.W, 0, TargetSelector.DamageType.Magical);
                    E = new Spell(SpellSlot.E, 0, TargetSelector.DamageType.Magical);
                    R = new Spell(SpellSlot.R, 0, TargetSelector.DamageType.Magical);
                    break;

                case "Alistar":
                    Q = new Spell(SpellSlot.Q, 0, TargetSelector.DamageType.Magical);
                    W = new Spell(SpellSlot.W, 0, TargetSelector.DamageType.Magical);
                    E = new Spell(SpellSlot.E, 0, TargetSelector.DamageType.Magical);
                    R = new Spell(SpellSlot.R, 0, TargetSelector.DamageType.Magical);
                    break;

                case "Amumu":
                    Q = new Spell(SpellSlot.Q, 0, TargetSelector.DamageType.Magical);
                    W = new Spell(SpellSlot.W, 0, TargetSelector.DamageType.Magical);
                    E = new Spell(SpellSlot.E, 0, TargetSelector.DamageType.Magical);
                    R = new Spell(SpellSlot.R, 0, TargetSelector.DamageType.Magical);
                    break;

                case "Anivia":
                    Q = new Spell(SpellSlot.Q, 0, TargetSelector.DamageType.Magical);
                    W = new Spell(SpellSlot.W, 0, TargetSelector.DamageType.Magical);
                    E = new Spell(SpellSlot.E, 0, TargetSelector.DamageType.Magical);
                    R = new Spell(SpellSlot.R, 0, TargetSelector.DamageType.Magical);
                    break;

                case "Annie":
                    Q = new Spell(SpellSlot.Q, 0, TargetSelector.DamageType.Magical);
                    W = new Spell(SpellSlot.W, 0, TargetSelector.DamageType.Magical);
                    E = new Spell(SpellSlot.E, 0, TargetSelector.DamageType.Magical);
                    R = new Spell(SpellSlot.R, 0, TargetSelector.DamageType.Magical);
                    break;

                case "Ashe":
                    Q = new Spell(SpellSlot.Q, 0);
                    W = new Spell(SpellSlot.W, 0);
                    E = new Spell(SpellSlot.E, 0);
                    R = new Spell(SpellSlot.R, 0);
                    break;

                case "Azir":
                    Q = new Spell(SpellSlot.Q, 0, TargetSelector.DamageType.Magical);
                    W = new Spell(SpellSlot.W, 0, TargetSelector.DamageType.Magical);
                    E = new Spell(SpellSlot.E, 0, TargetSelector.DamageType.Magical);
                    R = new Spell(SpellSlot.R, 0, TargetSelector.DamageType.Magical);
                    break;

                case "Bard":
                    Q = new Spell(SpellSlot.Q, 0, TargetSelector.DamageType.Magical);
                    W = new Spell(SpellSlot.W, 0, TargetSelector.DamageType.Magical);
                    E = new Spell(SpellSlot.E, 0, TargetSelector.DamageType.Magical);
                    R = new Spell(SpellSlot.R, 0, TargetSelector.DamageType.Magical);
                    break;

                case "Blitzcrank":
                    Q = new Spell(SpellSlot.Q, 0, TargetSelector.DamageType.Magical);
                    W = new Spell(SpellSlot.W, 0, TargetSelector.DamageType.Magical);
                    E = new Spell(SpellSlot.E, 0, TargetSelector.DamageType.Magical);
                    R = new Spell(SpellSlot.R, 0, TargetSelector.DamageType.Magical);
                    break;

                case "Brand":
                    Q = new Spell(SpellSlot.Q, 0, TargetSelector.DamageType.Magical);
                    W = new Spell(SpellSlot.W, 0, TargetSelector.DamageType.Magical);
                    E = new Spell(SpellSlot.E, 0, TargetSelector.DamageType.Magical);
                    R = new Spell(SpellSlot.R, 0, TargetSelector.DamageType.Magical);
                    break;

                case "Braum":
                    Q = new Spell(SpellSlot.Q, 0, TargetSelector.DamageType.Magical);
                    W = new Spell(SpellSlot.W, 0, TargetSelector.DamageType.Magical);
                    E = new Spell(SpellSlot.E, 0, TargetSelector.DamageType.Magical);
                    R = new Spell(SpellSlot.R, 0, TargetSelector.DamageType.Magical);
                    break;

                case "Caitlyn":
                    Q = new Spell(SpellSlot.Q, 0);
                    W = new Spell(SpellSlot.W, 0, TargetSelector.DamageType.Magical);
                    E = new Spell(SpellSlot.E, 0, TargetSelector.DamageType.Magical);
                    R = new Spell(SpellSlot.R, 0);
                    break;

                case "Cassiopeia":
                    Q = new Spell(SpellSlot.Q, 0, TargetSelector.DamageType.Magical);
                    W = new Spell(SpellSlot.W, 0, TargetSelector.DamageType.Magical);
                    E = new Spell(SpellSlot.E, 0, TargetSelector.DamageType.Magical);
                    R = new Spell(SpellSlot.R, 0, TargetSelector.DamageType.Magical);
                    break;

                case "Cho'Gath":
                    Q = new Spell(SpellSlot.Q, 0, TargetSelector.DamageType.Magical);
                    W = new Spell(SpellSlot.W, 0, TargetSelector.DamageType.Magical);
                    E = new Spell(SpellSlot.E, 0, TargetSelector.DamageType.Magical);
                    R = new Spell(SpellSlot.R, 0, TargetSelector.DamageType.True);
                    break;

                case "Corki":
                    Q = new Spell(SpellSlot.Q, 0, TargetSelector.DamageType.Magical);
                    W = new Spell(SpellSlot.W, 0, TargetSelector.DamageType.Magical);
                    E = new Spell(SpellSlot.E, 0);
                    R = new Spell(SpellSlot.R, 0, TargetSelector.DamageType.Magical);
                    break;

                case "Darius":
                    Q = new Spell(SpellSlot.Q, 0);
                    W = new Spell(SpellSlot.W, 0);
                    E = new Spell(SpellSlot.E, 0);
                    R = new Spell(SpellSlot.R, 0, TargetSelector.DamageType.True);
                    break;

                case "Diana":
                    Q = new Spell(SpellSlot.Q, 0, TargetSelector.DamageType.Magical);
                    W = new Spell(SpellSlot.W, 0, TargetSelector.DamageType.Magical);
                    E = new Spell(SpellSlot.E, 0, TargetSelector.DamageType.Magical);
                    R = new Spell(SpellSlot.R, 0, TargetSelector.DamageType.Magical);
                    break;

                case "Dr. Mundo":
                    Q = new Spell(SpellSlot.Q, 0, TargetSelector.DamageType.Magical);
                    W = new Spell(SpellSlot.W, 0, TargetSelector.DamageType.Magical);
                    E = new Spell(SpellSlot.E, 0, TargetSelector.DamageType.Magical);
                    R = new Spell(SpellSlot.R, 0, TargetSelector.DamageType.Magical);
                    break;

                case "Draven":
                    Q = new Spell(SpellSlot.Q, 0);
                    W = new Spell(SpellSlot.W, 0, TargetSelector.DamageType.Magical);
                    E = new Spell(SpellSlot.E, 0);
                    R = new Spell(SpellSlot.R, 0);
                    break;

                case "Ekko":
                    Q = new Spell(SpellSlot.Q, 0, TargetSelector.DamageType.Magical);
                    W = new Spell(SpellSlot.W, 0, TargetSelector.DamageType.Magical);
                    E = new Spell(SpellSlot.E, 0, TargetSelector.DamageType.Magical);
                    R = new Spell(SpellSlot.R, 0, TargetSelector.DamageType.Magical);
                    break;

                case "Elise":
                    Q = new Spell(SpellSlot.Q, 0, TargetSelector.DamageType.Magical);
                    W = new Spell(SpellSlot.W, 0, TargetSelector.DamageType.Magical);
                    E = new Spell(SpellSlot.E, 0, TargetSelector.DamageType.Magical);
                    R = new Spell(SpellSlot.R, 0, TargetSelector.DamageType.Magical);
                    break;

                case "Evelynn":
                    Q = new Spell(SpellSlot.Q, 0, TargetSelector.DamageType.Magical);
                    W = new Spell(SpellSlot.W, 0, TargetSelector.DamageType.Magical);
                    E = new Spell(SpellSlot.E, 0);
                    R = new Spell(SpellSlot.R, 0, TargetSelector.DamageType.Magical);
                    break;

                case "Ezreal":
                    Q = new Spell(SpellSlot.Q, 0);
                    W = new Spell(SpellSlot.W, 0, TargetSelector.DamageType.Magical);
                    E = new Spell(SpellSlot.E, 0, TargetSelector.DamageType.Magical);
                    R = new Spell(SpellSlot.R, 0, TargetSelector.DamageType.Magical);
                    break;

                case "Fiddlesticks":
                    Q = new Spell(SpellSlot.Q, 0, TargetSelector.DamageType.Magical);
                    W = new Spell(SpellSlot.W, 0, TargetSelector.DamageType.Magical);
                    E = new Spell(SpellSlot.E, 0, TargetSelector.DamageType.Magical);
                    R = new Spell(SpellSlot.R, 0, TargetSelector.DamageType.Magical);
                    break;

                case "Fiora":
                    Q = new Spell(SpellSlot.Q, 0);
                    W = new Spell(SpellSlot.W, 0, TargetSelector.DamageType.Magical);
                    E = new Spell(SpellSlot.E, 0);
                    R = new Spell(SpellSlot.R, 0);
                    break;

                case "Fizz":
                    Q = new Spell(SpellSlot.Q, 0, TargetSelector.DamageType.Magical);
                    W = new Spell(SpellSlot.W, 0, TargetSelector.DamageType.Magical);
                    E = new Spell(SpellSlot.E, 0, TargetSelector.DamageType.Magical);
                    R = new Spell(SpellSlot.R, 0, TargetSelector.DamageType.Magical);
                    break;

                case "Galio":
                    Q = new Spell(SpellSlot.Q, 0, TargetSelector.DamageType.Magical);
                    W = new Spell(SpellSlot.W, 0, TargetSelector.DamageType.Magical);
                    E = new Spell(SpellSlot.E, 0, TargetSelector.DamageType.Magical);
                    R = new Spell(SpellSlot.R, 0, TargetSelector.DamageType.Magical);
                    break;

                case "Gankplank":
                    Q = new Spell(SpellSlot.Q, 0);
                    W = new Spell(SpellSlot.W, 0, TargetSelector.DamageType.Magical);
                    E = new Spell(SpellSlot.E, 0);
                    R = new Spell(SpellSlot.R, 0, TargetSelector.DamageType.Magical);
                    break;

                case "Garen":
                    Q = new Spell(SpellSlot.Q, 0);
                    W = new Spell(SpellSlot.W, 0, TargetSelector.DamageType.Magical);
                    E = new Spell(SpellSlot.E, 0);
                    R = new Spell(SpellSlot.R, 0, TargetSelector.DamageType.Magical);
                    break;

                case "Gnar":
                    Q = new Spell(SpellSlot.Q, 0);
                    W = new Spell(SpellSlot.W, 0, TargetSelector.DamageType.Magical);
                    E = new Spell(SpellSlot.E, 0);
                    R = new Spell(SpellSlot.R, 0);
                    break;

                case "Gragas":
                    Q = new Spell(SpellSlot.Q, 0, TargetSelector.DamageType.Magical);
                    W = new Spell(SpellSlot.W, 0, TargetSelector.DamageType.Magical);
                    E = new Spell(SpellSlot.E, 0, TargetSelector.DamageType.Magical);
                    R = new Spell(SpellSlot.R, 0, TargetSelector.DamageType.Magical);
                    break;

                case "Graves":
                    Q = new Spell(SpellSlot.Q, 0);
                    W = new Spell(SpellSlot.W, 0, TargetSelector.DamageType.Magical);
                    E = new Spell(SpellSlot.E, 0, TargetSelector.DamageType.Magical);
                    R = new Spell(SpellSlot.R, 0);
                    break;

                case "Hecarim":
                    Q = new Spell(SpellSlot.Q, 0);
                    W = new Spell(SpellSlot.W, 0, TargetSelector.DamageType.Magical);
                    E = new Spell(SpellSlot.E, 0);
                    R = new Spell(SpellSlot.R, 0, TargetSelector.DamageType.Magical);
                    break;

                case "Heimerdinger":
                    Q = new Spell(SpellSlot.Q, 0, TargetSelector.DamageType.Magical);
                    W = new Spell(SpellSlot.W, 0, TargetSelector.DamageType.Magical);
                    E = new Spell(SpellSlot.E, 0, TargetSelector.DamageType.Magical);
                    R = new Spell(SpellSlot.R, 0, TargetSelector.DamageType.Magical);
                    break;

                case "Irelia":
                    Q = new Spell(SpellSlot.Q, 0);
                    W = new Spell(SpellSlot.W, 0, TargetSelector.DamageType.True);
                    E = new Spell(SpellSlot.E, 0, TargetSelector.DamageType.Magical);
                    R = new Spell(SpellSlot.R, 0);
                    break;

                case "Janna":
                    Q = new Spell(SpellSlot.Q, 0, TargetSelector.DamageType.Magical);
                    W = new Spell(SpellSlot.W, 0, TargetSelector.DamageType.Magical);
                    E = new Spell(SpellSlot.E, 0, TargetSelector.DamageType.Magical);
                    R = new Spell(SpellSlot.R, 0, TargetSelector.DamageType.Magical);
                    break;

                case "Jarvan IV":
                    Q = new Spell(SpellSlot.Q, 0);
                    W = new Spell(SpellSlot.W, 0, TargetSelector.DamageType.Magical);
                    E = new Spell(SpellSlot.E, 0, TargetSelector.DamageType.Magical);
                    R = new Spell(SpellSlot.R, 0);
                    break;

                case "Jax":
                    Q = new Spell(SpellSlot.Q, 0);
                    W = new Spell(SpellSlot.W, 0, TargetSelector.DamageType.Magical);
                    E = new Spell(SpellSlot.E, 0);
                    R = new Spell(SpellSlot.R, 0, TargetSelector.DamageType.Magical);
                    break;

                case "Jayce":
                    Q = new Spell(SpellSlot.Q, 0);
                    W = new Spell(SpellSlot.W, 0, TargetSelector.DamageType.Magical);
                    E = new Spell(SpellSlot.E, 0, TargetSelector.DamageType.Magical);
                    R = new Spell(SpellSlot.R, 0, TargetSelector.DamageType.Magical);
                    break;

                case "Jinx":
                    Q = new Spell(SpellSlot.Q, 0);
                    W = new Spell(SpellSlot.W, 0);
                    E = new Spell(SpellSlot.E, 0, TargetSelector.DamageType.Magical);
                    R = new Spell(SpellSlot.R, 0);
                    break;

            }
        }
    }
}
