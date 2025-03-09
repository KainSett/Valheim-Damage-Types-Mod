
namespace ValheimDamageTypesMod.Common
{
    public static class ValheimDamageBase
    {
        [Flags]
        public enum DamageType : byte
        {
            Blunt = 1 << 0,
            Pierce = 1 << 1,
            Slash = 1 << 2,
            Fire = 1 << 3,
            Frost = 1 << 4,
            Poison = 1 << 5,
            Lightning = 1 << 6,
            Spirit = 1 << 7
        }
        public static Dictionary<int, DamageType> Projectiles = [];
        public static Dictionary<int, DamageType> NPCs = [];
        public static Dictionary<int, DamageType> Items = [];
        public static string output = "";
        public static string ExpressInText(this DamageType type)
        {
            var result = "";

            var text = type.ToString().Split(", ");
            foreach (var line in text)
            {
                result += $"DamageType.{line} | ";
            }

            if (result.Last() == ' ')
                result = result.Remove(result.Length - 3);

            return result;
        }
        public static void AddWithoutOverriding(this Dictionary<int, DamageType> dict, int key, DamageType value)
        {
            dict[key] = dict.GetValueOrDefault(key) | value;
        }
        public static void AssignDamage(string list, DamageType type)
        {
            foreach (var name in list.Split(' '))
            {
                
                output += $"\nProjectiles[ProjectileID.{name}] = Projectiles.GetValueOrDefault{type.ExpressInText()});";
            }
            if (list != "")
            {
                Projectiles[ProjectileID.Bomb] = Projectiles.GetValueOrDefault(ProjectileID.Bomb) | DamageType.Blunt | DamageType.Fire;

                Projectiles.AddWithoutOverriding(ProjectileID.Bomb, DamageType.Frost | DamageType.Spirit);
            }
        }
    }
}