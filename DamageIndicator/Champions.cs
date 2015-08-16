using LeagueSharp;
using LeagueSharp.Common;
using damage = LeagueSharp.DamageType;

namespace DamageIndicator
{
    internal class Champions
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
                    Q = new Spell(SpellSlot.Q, 0, TargetSelector.DamageType.Magical);
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

                case "Kalista":
                    Q = new Spell(SpellSlot.Q, 0);
                    W = new Spell(SpellSlot.W, 0);
                    E = new Spell(SpellSlot.E, 0);
                    R = new Spell(SpellSlot.R, 0);
                    break;

                case "Karma":
                    Q = new Spell(SpellSlot.Q, 0, TargetSelector.DamageType.Magical);
                    W = new Spell(SpellSlot.W, 0, TargetSelector.DamageType.Magical);
                    E = new Spell(SpellSlot.E, 0, TargetSelector.DamageType.Magical);
                    R = new Spell(SpellSlot.R, 0, TargetSelector.DamageType.Magical);
                    break;

                case "Karthus":
                    Q = new Spell(SpellSlot.Q, 0, TargetSelector.DamageType.Magical);
                    W = new Spell(SpellSlot.W, 0, TargetSelector.DamageType.Magical);
                    E = new Spell(SpellSlot.E, 0, TargetSelector.DamageType.Magical);
                    R = new Spell(SpellSlot.R, 0, TargetSelector.DamageType.Magical);
                    break;

                case "Kassadin":
                    Q = new Spell(SpellSlot.Q, 0, TargetSelector.DamageType.Magical);
                    W = new Spell(SpellSlot.W, 0, TargetSelector.DamageType.Magical);
                    E = new Spell(SpellSlot.E, 0, TargetSelector.DamageType.Magical);
                    R = new Spell(SpellSlot.R, 0, TargetSelector.DamageType.Magical);
                    break;

                case "Katarina":
                    Q = new Spell(SpellSlot.Q, 0, TargetSelector.DamageType.Magical);
                    W = new Spell(SpellSlot.W, 0, TargetSelector.DamageType.Magical);
                    E = new Spell(SpellSlot.E, 0, TargetSelector.DamageType.Magical);
                    R = new Spell(SpellSlot.R, 0, TargetSelector.DamageType.Magical);
                    break;

                case "Kayle":
                    Q = new Spell(SpellSlot.Q, 0, TargetSelector.DamageType.Magical);
                    W = new Spell(SpellSlot.W, 0, TargetSelector.DamageType.Magical);
                    E = new Spell(SpellSlot.E, 0, TargetSelector.DamageType.Magical);
                    R = new Spell(SpellSlot.R, 0, TargetSelector.DamageType.Magical);
                    break;

                case "Kennen":
                    Q = new Spell(SpellSlot.Q, 0, TargetSelector.DamageType.Magical);
                    W = new Spell(SpellSlot.W, 0, TargetSelector.DamageType.Magical);
                    E = new Spell(SpellSlot.E, 0, TargetSelector.DamageType.Magical);
                    R = new Spell(SpellSlot.R, 0, TargetSelector.DamageType.Magical);
                    break;

                case "Kha'zix":
                    Q = new Spell(SpellSlot.Q, 0);
                    W = new Spell(SpellSlot.W, 0);
                    E = new Spell(SpellSlot.E, 0);
                    R = new Spell(SpellSlot.R, 0);
                    break;

                case "Kog'Maw":
                    Q = new Spell(SpellSlot.Q, 0, TargetSelector.DamageType.Magical);
                    W = new Spell(SpellSlot.W, 0, TargetSelector.DamageType.Magical);
                    E = new Spell(SpellSlot.E, 0, TargetSelector.DamageType.Magical);
                    R = new Spell(SpellSlot.R, 0, TargetSelector.DamageType.Magical);
                    break;

                case "LeBlanc":
                    Q = new Spell(SpellSlot.Q, 0, TargetSelector.DamageType.Magical);
                    W = new Spell(SpellSlot.W, 0, TargetSelector.DamageType.Magical);
                    E = new Spell(SpellSlot.E, 0, TargetSelector.DamageType.Magical);
                    R = new Spell(SpellSlot.R, 0, TargetSelector.DamageType.Magical);
                    break;

                case "Lee Sin":
                    Q = new Spell(SpellSlot.Q, 0);
                    W = new Spell(SpellSlot.W, 0);
                    E = new Spell(SpellSlot.E, 0, TargetSelector.DamageType.Magical);
                    R = new Spell(SpellSlot.R, 0);
                    break;

                case "Leona":
                    Q = new Spell(SpellSlot.Q, 0, TargetSelector.DamageType.Magical);
                    W = new Spell(SpellSlot.W, 0);
                    E = new Spell(SpellSlot.E, 0, TargetSelector.DamageType.Magical);
                    R = new Spell(SpellSlot.R, 0, TargetSelector.DamageType.Magical);
                    break;

                case "Lissandra":
                    Q = new Spell(SpellSlot.Q, 0, TargetSelector.DamageType.Magical);
                    W = new Spell(SpellSlot.W, 0, TargetSelector.DamageType.Magical);
                    E = new Spell(SpellSlot.E, 0, TargetSelector.DamageType.Magical);
                    R = new Spell(SpellSlot.R, 0, TargetSelector.DamageType.Magical);
                    break;

                case "Lucian":
                    Q = new Spell(SpellSlot.Q, 0);
                    W = new Spell(SpellSlot.W, 0);
                    E = new Spell(SpellSlot.E, 0);
                    R = new Spell(SpellSlot.R, 0);
                    break;

                case "Lulu":
                    Q = new Spell(SpellSlot.Q, 0, TargetSelector.DamageType.Magical);
                    W = new Spell(SpellSlot.W, 0, TargetSelector.DamageType.Magical);
                    E = new Spell(SpellSlot.E, 0, TargetSelector.DamageType.Magical);
                    R = new Spell(SpellSlot.R, 0, TargetSelector.DamageType.Magical);
                    break;

                case "Lux":
                    Q = new Spell(SpellSlot.Q, 0, TargetSelector.DamageType.Magical);
                    W = new Spell(SpellSlot.W, 0, TargetSelector.DamageType.Magical);
                    E = new Spell(SpellSlot.E, 0, TargetSelector.DamageType.Magical);
                    R = new Spell(SpellSlot.R, 0, TargetSelector.DamageType.Magical);
                    break;

                case "Malphite":
                    Q = new Spell(SpellSlot.Q, 0, TargetSelector.DamageType.Magical);
                    W = new Spell(SpellSlot.W, 0, TargetSelector.DamageType.Magical);
                    E = new Spell(SpellSlot.E, 0, TargetSelector.DamageType.Magical);
                    R = new Spell(SpellSlot.R, 0, TargetSelector.DamageType.Magical);
                    break;

                case "Malzahar":
                    Q = new Spell(SpellSlot.Q, 0, TargetSelector.DamageType.Magical);
                    W = new Spell(SpellSlot.W, 0, TargetSelector.DamageType.Magical);
                    E = new Spell(SpellSlot.E, 0, TargetSelector.DamageType.Magical);
                    R = new Spell(SpellSlot.R, 0, TargetSelector.DamageType.Magical);
                    break;

                case "Maokai":
                    Q = new Spell(SpellSlot.Q, 0, TargetSelector.DamageType.Magical);
                    W = new Spell(SpellSlot.W, 0, TargetSelector.DamageType.Magical);
                    E = new Spell(SpellSlot.E, 0, TargetSelector.DamageType.Magical);
                    R = new Spell(SpellSlot.R, 0, TargetSelector.DamageType.Magical);
                    break;

                case "Master Yi":
                    Q = new Spell(SpellSlot.Q, 0);
                    W = new Spell(SpellSlot.W, 0);
                    E = new Spell(SpellSlot.E, 0, TargetSelector.DamageType.True);
                    R = new Spell(SpellSlot.R, 0);
                    break;

                case "Miss Fortune":
                    Q = new Spell(SpellSlot.Q, 0);
                    W = new Spell(SpellSlot.W, 0, TargetSelector.DamageType.Magical);
                    E = new Spell(SpellSlot.E, 0, TargetSelector.DamageType.Magical);
                    R = new Spell(SpellSlot.R, 0);
                    break;

                case "Mordekaiser":
                    Q = new Spell(SpellSlot.Q, 0, TargetSelector.DamageType.Magical);
                    W = new Spell(SpellSlot.W, 0, TargetSelector.DamageType.Magical);
                    E = new Spell(SpellSlot.E, 0, TargetSelector.DamageType.Magical);
                    R = new Spell(SpellSlot.R, 0, TargetSelector.DamageType.Magical);
                    break;

                case "Morgana":
                    Q = new Spell(SpellSlot.Q, 0, TargetSelector.DamageType.Magical);
                    W = new Spell(SpellSlot.W, 0, TargetSelector.DamageType.Magical);
                    E = new Spell(SpellSlot.E, 0, TargetSelector.DamageType.Magical);
                    R = new Spell(SpellSlot.R, 0, TargetSelector.DamageType.Magical);
                    break;

                case "Nami":
                    Q = new Spell(SpellSlot.Q, 0, TargetSelector.DamageType.Magical);
                    W = new Spell(SpellSlot.W, 0, TargetSelector.DamageType.Magical);
                    E = new Spell(SpellSlot.E, 0, TargetSelector.DamageType.Magical);
                    R = new Spell(SpellSlot.R, 0, TargetSelector.DamageType.Magical);
                    break;

                case "Nasus":
                    Q = new Spell(SpellSlot.Q, 0);
                    W = new Spell(SpellSlot.W, 0);
                    E = new Spell(SpellSlot.E, 0, TargetSelector.DamageType.Magical);
                    R = new Spell(SpellSlot.R, 0, TargetSelector.DamageType.Magical);
                    break;

                case "Nautilus":
                    Q = new Spell(SpellSlot.Q, 0, TargetSelector.DamageType.Magical);
                    W = new Spell(SpellSlot.W, 0, TargetSelector.DamageType.Magical);
                    E = new Spell(SpellSlot.E, 0, TargetSelector.DamageType.Magical);
                    R = new Spell(SpellSlot.R, 0, TargetSelector.DamageType.Magical);
                    break;

                case "Nidalee":
                    Q = new Spell(SpellSlot.Q, 0, TargetSelector.DamageType.Magical);
                    W = new Spell(SpellSlot.W, 0, TargetSelector.DamageType.Magical);
                    E = new Spell(SpellSlot.E, 0, TargetSelector.DamageType.Magical);
                    R = new Spell(SpellSlot.R, 0, TargetSelector.DamageType.Magical);
                    break;

                case "Nocturne":
                    Q = new Spell(SpellSlot.Q, 0);
                    W = new Spell(SpellSlot.W, 0, TargetSelector.DamageType.Magical);
                    E = new Spell(SpellSlot.E, 0, TargetSelector.DamageType.Magical);
                    R = new Spell(SpellSlot.R, 0);
                    break;

                case "Nunu":
                    Q = new Spell(SpellSlot.Q, 0, TargetSelector.DamageType.Magical);
                    W = new Spell(SpellSlot.W, 0, TargetSelector.DamageType.Magical);
                    E = new Spell(SpellSlot.E, 0, TargetSelector.DamageType.Magical);
                    R = new Spell(SpellSlot.R, 0, TargetSelector.DamageType.Magical);
                    break;

                case "Olaf":
                    Q = new Spell(SpellSlot.Q, 0);
                    W = new Spell(SpellSlot.W, 0);
                    E = new Spell(SpellSlot.E, 0, TargetSelector.DamageType.True);
                    R = new Spell(SpellSlot.R, 0);
                    break;

                case "Orianna":
                    Q = new Spell(SpellSlot.Q, 0, TargetSelector.DamageType.Magical);
                    W = new Spell(SpellSlot.W, 0, TargetSelector.DamageType.Magical);
                    E = new Spell(SpellSlot.E, 0, TargetSelector.DamageType.Magical);
                    R = new Spell(SpellSlot.R, 0, TargetSelector.DamageType.Magical);
                    break;

                case "Phanteon":
                    Q = new Spell(SpellSlot.Q, 0);
                    W = new Spell(SpellSlot.W, 0, TargetSelector.DamageType.Magical);
                    E = new Spell(SpellSlot.E, 0);
                    R = new Spell(SpellSlot.R, 0, TargetSelector.DamageType.Magical);
                    break;

                case "Poppy":
                    Q = new Spell(SpellSlot.Q, 0, TargetSelector.DamageType.Magical);
                    W = new Spell(SpellSlot.W, 0, TargetSelector.DamageType.Magical);
                    E = new Spell(SpellSlot.E, 0, TargetSelector.DamageType.Magical);
                    R = new Spell(SpellSlot.R, 0, TargetSelector.DamageType.Magical);
                    break;

                case "Quinn":
                    Q = new Spell(SpellSlot.Q, 0);
                    W = new Spell(SpellSlot.W, 0);
                    E = new Spell(SpellSlot.E, 0);
                    R = new Spell(SpellSlot.R, 0);
                    break;

                case "Rammus":
                    Q = new Spell(SpellSlot.Q, 0, TargetSelector.DamageType.Magical);
                    W = new Spell(SpellSlot.W, 0, TargetSelector.DamageType.Magical);
                    E = new Spell(SpellSlot.E, 0, TargetSelector.DamageType.Magical);
                    R = new Spell(SpellSlot.R, 0, TargetSelector.DamageType.Magical);
                    break;

                case "Rek'Sai":
                    Q = new Spell(SpellSlot.Q, 0, TargetSelector.DamageType.Magical);
                    W = new Spell(SpellSlot.W, 0);
                    E = new Spell(SpellSlot.E, 0);
                    R = new Spell(SpellSlot.R, 0);
                    break;

                case "Renekton":
                    Q = new Spell(SpellSlot.Q, 0);
                    W = new Spell(SpellSlot.W, 0);
                    E = new Spell(SpellSlot.E, 0);
                    R = new Spell(SpellSlot.R, 0, TargetSelector.DamageType.Magical);
                    break;

                case "Rengar":
                    Q = new Spell(SpellSlot.Q, 0);
                    W = new Spell(SpellSlot.W, 0, TargetSelector.DamageType.Magical);
                    E = new Spell(SpellSlot.E, 0);
                    R = new Spell(SpellSlot.R, 0);
                    break;

                case "Riven":
                    Q = new Spell(SpellSlot.Q, 0);
                    W = new Spell(SpellSlot.W, 0);
                    E = new Spell(SpellSlot.E, 0);
                    R = new Spell(SpellSlot.R, 0);
                    break;

                case "Rumble":
                    Q = new Spell(SpellSlot.Q, 0, TargetSelector.DamageType.Magical);
                    W = new Spell(SpellSlot.W, 0, TargetSelector.DamageType.Magical);
                    E = new Spell(SpellSlot.E, 0, TargetSelector.DamageType.Magical);
                    R = new Spell(SpellSlot.R, 0, TargetSelector.DamageType.Magical);
                    break;

                case "Ryze":
                    Q = new Spell(SpellSlot.Q, 0, TargetSelector.DamageType.Magical);
                    W = new Spell(SpellSlot.W, 0, TargetSelector.DamageType.Magical);
                    E = new Spell(SpellSlot.E, 0, TargetSelector.DamageType.Magical);
                    R = new Spell(SpellSlot.R, 0, TargetSelector.DamageType.Magical);
                    break;

                case "Sejuani":
                    Q = new Spell(SpellSlot.Q, 0, TargetSelector.DamageType.Magical);
                    W = new Spell(SpellSlot.W, 0, TargetSelector.DamageType.Magical);
                    E = new Spell(SpellSlot.E, 0, TargetSelector.DamageType.Magical);
                    R = new Spell(SpellSlot.R, 0, TargetSelector.DamageType.Magical);
                    break;

                case "Shaco":
                    Q = new Spell(SpellSlot.Q, 0, TargetSelector.DamageType.Magical);
                    W = new Spell(SpellSlot.W, 0, TargetSelector.DamageType.Magical);
                    E = new Spell(SpellSlot.E, 0, TargetSelector.DamageType.Magical);
                    R = new Spell(SpellSlot.R, 0, TargetSelector.DamageType.Magical);
                    break;

                case "Shen":
                    Q = new Spell(SpellSlot.Q, 0, TargetSelector.DamageType.Magical);
                    W = new Spell(SpellSlot.W, 0);
                    E = new Spell(SpellSlot.E, 0, TargetSelector.DamageType.Magical);
                    R = new Spell(SpellSlot.R, 0);
                    break;

                case "Shyvana":
                    Q = new Spell(SpellSlot.Q, 0);
                    W = new Spell(SpellSlot.W, 0, TargetSelector.DamageType.Magical);
                    E = new Spell(SpellSlot.E, 0, TargetSelector.DamageType.Magical);
                    R = new Spell(SpellSlot.R, 0, TargetSelector.DamageType.Magical);
                    break;

                case "Singed":
                    Q = new Spell(SpellSlot.Q, 0, TargetSelector.DamageType.Magical);
                    W = new Spell(SpellSlot.W, 0, TargetSelector.DamageType.Magical);
                    E = new Spell(SpellSlot.E, 0, TargetSelector.DamageType.Magical);
                    R = new Spell(SpellSlot.R, 0, TargetSelector.DamageType.Magical);
                    break;

                case "Sion":
                    Q = new Spell(SpellSlot.Q, 0);
                    W = new Spell(SpellSlot.W, 0, TargetSelector.DamageType.Magical);
                    E = new Spell(SpellSlot.E, 0, TargetSelector.DamageType.Magical);
                    R = new Spell(SpellSlot.R, 0);
                    break;

                case "Sivir":
                    Q = new Spell(SpellSlot.Q, 0);
                    W = new Spell(SpellSlot.W, 0);
                    E = new Spell(SpellSlot.E, 0);
                    R = new Spell(SpellSlot.R, 0);
                    break;

                case "Skanar":
                    Q = new Spell(SpellSlot.Q, 0);
                    W = new Spell(SpellSlot.W, 0, TargetSelector.DamageType.Magical);
                    E = new Spell(SpellSlot.E, 0, TargetSelector.DamageType.Magical);
                    R = new Spell(SpellSlot.R, 0, TargetSelector.DamageType.Magical);
                    break;

                case "Sona":
                    Q = new Spell(SpellSlot.Q, 0, TargetSelector.DamageType.Magical);
                    W = new Spell(SpellSlot.W, 0, TargetSelector.DamageType.Magical);
                    E = new Spell(SpellSlot.E, 0, TargetSelector.DamageType.Magical);
                    R = new Spell(SpellSlot.R, 0, TargetSelector.DamageType.Magical);
                    break;

                case "Soraka":
                    Q = new Spell(SpellSlot.Q, 0, TargetSelector.DamageType.Magical);
                    W = new Spell(SpellSlot.W, 0, TargetSelector.DamageType.Magical);
                    E = new Spell(SpellSlot.E, 0, TargetSelector.DamageType.Magical);
                    R = new Spell(SpellSlot.R, 0, TargetSelector.DamageType.Magical);
                    break;

                case "Swain":
                    Q = new Spell(SpellSlot.Q, 0, TargetSelector.DamageType.Magical);
                    W = new Spell(SpellSlot.W, 0, TargetSelector.DamageType.Magical);
                    E = new Spell(SpellSlot.E, 0, TargetSelector.DamageType.Magical);
                    R = new Spell(SpellSlot.R, 0, TargetSelector.DamageType.Magical);
                    break;

                case "Syndra":
                    Q = new Spell(SpellSlot.Q, 0, TargetSelector.DamageType.Magical);
                    W = new Spell(SpellSlot.W, 0, TargetSelector.DamageType.Magical);
                    E = new Spell(SpellSlot.E, 0, TargetSelector.DamageType.Magical);
                    R = new Spell(SpellSlot.R, 0, TargetSelector.DamageType.Magical);
                    break;

                case "Tham Kench":
                    Q = new Spell(SpellSlot.Q, 0, TargetSelector.DamageType.Magical);
                    W = new Spell(SpellSlot.W, 0);
                    E = new Spell(SpellSlot.E, 0);
                    R = new Spell(SpellSlot.R, 0);
                    break;

                case "Talon":
                    Q = new Spell(SpellSlot.Q, 0);
                    W = new Spell(SpellSlot.W, 0);
                    E = new Spell(SpellSlot.E, 0);
                    R = new Spell(SpellSlot.R, 0);
                    break;

                case "Taric":
                    Q = new Spell(SpellSlot.Q, 0, TargetSelector.DamageType.Magical);
                    W = new Spell(SpellSlot.W, 0, TargetSelector.DamageType.Magical);
                    E = new Spell(SpellSlot.E, 0, TargetSelector.DamageType.Magical);
                    R = new Spell(SpellSlot.R, 0, TargetSelector.DamageType.Magical);
                    break;

                case "Teemo":
                    Q = new Spell(SpellSlot.Q, 0, TargetSelector.DamageType.Magical);
                    W = new Spell(SpellSlot.W, 0, TargetSelector.DamageType.Magical);
                    E = new Spell(SpellSlot.E, 0, TargetSelector.DamageType.Magical);
                    R = new Spell(SpellSlot.R, 0, TargetSelector.DamageType.Magical);
                    break;

                case "Thresh":
                    Q = new Spell(SpellSlot.Q, 0, TargetSelector.DamageType.Magical);
                    W = new Spell(SpellSlot.W, 0, TargetSelector.DamageType.Magical);
                    E = new Spell(SpellSlot.E, 0, TargetSelector.DamageType.Magical);
                    R = new Spell(SpellSlot.R, 0, TargetSelector.DamageType.Magical);
                    break;

                case "Tristana":
                    Q = new Spell(SpellSlot.Q, 0);
                    W = new Spell(SpellSlot.W, 0, TargetSelector.DamageType.Magical);
                    E = new Spell(SpellSlot.E, 0);
                    R = new Spell(SpellSlot.R, 0, TargetSelector.DamageType.Magical);
                    break;

                case "Trundle":
                    Q = new Spell(SpellSlot.Q, 0);
                    W = new Spell(SpellSlot.W, 0);
                    E = new Spell(SpellSlot.E, 0);
                    R = new Spell(SpellSlot.R, 0, TargetSelector.DamageType.Magical);
                    break;

                case "Tryndamere":
                    Q = new Spell(SpellSlot.Q, 0);
                    W = new Spell(SpellSlot.W, 0);
                    E = new Spell(SpellSlot.E, 0);
                    R = new Spell(SpellSlot.R, 0);
                    break;

                case "Twisted Fate":
                    Q = new Spell(SpellSlot.Q, 0, TargetSelector.DamageType.Magical);
                    W = new Spell(SpellSlot.W, 0, TargetSelector.DamageType.Magical);
                    E = new Spell(SpellSlot.E, 0, TargetSelector.DamageType.Magical);
                    R = new Spell(SpellSlot.R, 0, TargetSelector.DamageType.Magical);
                    break;

                case "Twitch":
                    Q = new Spell(SpellSlot.Q, 0);
                    W = new Spell(SpellSlot.W, 0);
                    E = new Spell(SpellSlot.E, 0);
                    R = new Spell(SpellSlot.R, 0);
                    break;

                case "Udyr":
                    Q = new Spell(SpellSlot.Q, 0);
                    W = new Spell(SpellSlot.W, 0, TargetSelector.DamageType.Magical);
                    E = new Spell(SpellSlot.E, 0);
                    R = new Spell(SpellSlot.R, 0, TargetSelector.DamageType.Magical);
                    break;

                case "Urgot":
                    Q = new Spell(SpellSlot.Q, 0);
                    W = new Spell(SpellSlot.W, 0, TargetSelector.DamageType.Magical);
                    E = new Spell(SpellSlot.E, 0);
                    R = new Spell(SpellSlot.R, 0);
                    break;

                case "Varus":
                    Q = new Spell(SpellSlot.Q, 0);
                    W = new Spell(SpellSlot.W, 0, TargetSelector.DamageType.Magical);
                    E = new Spell(SpellSlot.E, 0);
                    R = new Spell(SpellSlot.R, 0, TargetSelector.DamageType.Magical);
                    break;

                case "Vayne":
                    Q = new Spell(SpellSlot.Q, 0);
                    W = new Spell(SpellSlot.W, 0, TargetSelector.DamageType.True);
                    E = new Spell(SpellSlot.E, 0);
                    R = new Spell(SpellSlot.R, 0);
                    break;

                case "Veigar":
                    Q = new Spell(SpellSlot.Q, 0, TargetSelector.DamageType.Magical);
                    W = new Spell(SpellSlot.W, 0, TargetSelector.DamageType.Magical);
                    E = new Spell(SpellSlot.E, 0, TargetSelector.DamageType.Magical);
                    R = new Spell(SpellSlot.R, 0, TargetSelector.DamageType.Magical);
                    break;

                case "Vel'koz":
                    Q = new Spell(SpellSlot.Q, 0, TargetSelector.DamageType.Magical);
                    W = new Spell(SpellSlot.W, 0, TargetSelector.DamageType.Magical);
                    E = new Spell(SpellSlot.E, 0, TargetSelector.DamageType.Magical);
                    R = new Spell(SpellSlot.R, 0, TargetSelector.DamageType.Magical);
                    break;

                case "Vi":
                    Q = new Spell(SpellSlot.Q, 0);
                    W = new Spell(SpellSlot.W, 0);
                    E = new Spell(SpellSlot.E, 0);
                    R = new Spell(SpellSlot.R, 0);
                    break;

                case "Viktor":
                    Q = new Spell(SpellSlot.Q, 0, TargetSelector.DamageType.Magical);
                    W = new Spell(SpellSlot.W, 0, TargetSelector.DamageType.Magical);
                    E = new Spell(SpellSlot.E, 0, TargetSelector.DamageType.Magical);
                    R = new Spell(SpellSlot.R, 0, TargetSelector.DamageType.Magical);
                    break;

                case "Vladimir":
                    Q = new Spell(SpellSlot.Q, 0, TargetSelector.DamageType.Magical);
                    W = new Spell(SpellSlot.W, 0, TargetSelector.DamageType.Magical);
                    E = new Spell(SpellSlot.E, 0, TargetSelector.DamageType.Magical);
                    R = new Spell(SpellSlot.R, 0, TargetSelector.DamageType.Magical);
                    break;

                case "Volibear":
                    Q = new Spell(SpellSlot.Q, 0);
                    W = new Spell(SpellSlot.W, 0);
                    E = new Spell(SpellSlot.E, 0, TargetSelector.DamageType.Magical);
                    R = new Spell(SpellSlot.R, 0, TargetSelector.DamageType.Magical);
                    break;

                case "Warwick":
                    Q = new Spell(SpellSlot.Q, 0, TargetSelector.DamageType.Magical);
                    W = new Spell(SpellSlot.W, 0);
                    E = new Spell(SpellSlot.E, 0);
                    R = new Spell(SpellSlot.R, 0, TargetSelector.DamageType.Magical);
                    break;

                case "Wukong":
                    Q = new Spell(SpellSlot.Q, 0);
                    W = new Spell(SpellSlot.W, 0, TargetSelector.DamageType.Magical);
                    E = new Spell(SpellSlot.E, 0);
                    R = new Spell(SpellSlot.R, 0);
                    break;

                case "Xerath":
                    Q = new Spell(SpellSlot.Q, 0, TargetSelector.DamageType.Magical);
                    W = new Spell(SpellSlot.W, 0, TargetSelector.DamageType.Magical);
                    E = new Spell(SpellSlot.E, 0, TargetSelector.DamageType.Magical);
                    R = new Spell(SpellSlot.R, 0, TargetSelector.DamageType.Magical);
                    break;

                case "Xin Zhao":
                    Q = new Spell(SpellSlot.Q, 0);
                    W = new Spell(SpellSlot.W, 0);
                    E = new Spell(SpellSlot.E, 0, TargetSelector.DamageType.Magical);
                    R = new Spell(SpellSlot.R, 0);
                    break;

                case "Yasuo":
                    Q = new Spell(SpellSlot.Q, 0);
                    W = new Spell(SpellSlot.W, 0);
                    E = new Spell(SpellSlot.E, 0);
                    R = new Spell(SpellSlot.R, 0);
                    break;

                case "Yorick":
                    Q = new Spell(SpellSlot.Q, 0);
                    W = new Spell(SpellSlot.W, 0, TargetSelector.DamageType.Magical);
                    E = new Spell(SpellSlot.E, 0, TargetSelector.DamageType.Magical);
                    R = new Spell(SpellSlot.R, 0);
                    break;

                case "Zac":
                    Q = new Spell(SpellSlot.Q, 0, TargetSelector.DamageType.Magical);
                    W = new Spell(SpellSlot.W, 0, TargetSelector.DamageType.Magical);
                    E = new Spell(SpellSlot.E, 0, TargetSelector.DamageType.Magical);
                    R = new Spell(SpellSlot.R, 0, TargetSelector.DamageType.Magical);
                    break;

                case "Zed":
                    Q = new Spell(SpellSlot.Q, 0);
                    W = new Spell(SpellSlot.W, 0);
                    E = new Spell(SpellSlot.E, 0);
                    R = new Spell(SpellSlot.R, 0);
                    break;

                case "Ziggs":
                    Q = new Spell(SpellSlot.Q, 0, TargetSelector.DamageType.Magical);
                    W = new Spell(SpellSlot.W, 0, TargetSelector.DamageType.Magical);
                    E = new Spell(SpellSlot.E, 0, TargetSelector.DamageType.Magical);
                    R = new Spell(SpellSlot.R, 0, TargetSelector.DamageType.Magical);
                    break;

                case "Zilean":
                    Q = new Spell(SpellSlot.Q, 0, TargetSelector.DamageType.Magical);
                    W = new Spell(SpellSlot.W, 0, TargetSelector.DamageType.Magical);
                    E = new Spell(SpellSlot.E, 0, TargetSelector.DamageType.Magical);
                    R = new Spell(SpellSlot.R, 0, TargetSelector.DamageType.Magical);
                    break;

                case "Zyra":
                    Q = new Spell(SpellSlot.Q, 0, TargetSelector.DamageType.Magical);
                    W = new Spell(SpellSlot.W, 0, TargetSelector.DamageType.Magical);
                    E = new Spell(SpellSlot.E, 0, TargetSelector.DamageType.Magical);
                    R = new Spell(SpellSlot.R, 0, TargetSelector.DamageType.Magical);
                    break;
            }
        }
    }

}
