using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Weapon
{
    public enum WeaponType
    {
        GreatSword,
        DualBlades,
        Lance,
        ChargeBlade,
        HeavyBowgun,
        LongSword,
        Hammer,
        Gunlance,
        InsectGlaive,
        Bow,
        SwordAndShield,
        HuntingHorn,
        SwitchAxe,
        LightBowgun
    }

    public static class WeaponTypeConverter
    {
        public static WeaponType GetWeaponType(string type)
        {
            switch (type)
            {
                case "great-sword": return WeaponType.GreatSword;
                case "dual-blades":return WeaponType.DualBlades;
                case "lance": return WeaponType.Lance;
                case "charge-blade":return WeaponType.ChargeBlade;
                case "heavy-bowgun": return WeaponType.HeavyBowgun;
                case "long-sword": return WeaponType.LongSword;
                case "hammer": return WeaponType.Hammer;
                case "gunlance": return WeaponType.Gunlance;
                case "insect-glaive": return WeaponType.InsectGlaive;
                case "bow": return WeaponType.Bow;
                case "sword-and-shield": return WeaponType.SwordAndShield;
                case "hunting-horn": return WeaponType.HuntingHorn;
                case "switch-axe":return WeaponType.SwitchAxe;
                case "light-bowgun": return WeaponType.LightBowgun;
                default: return WeaponType.GreatSword;
            }
        }
    }
}
