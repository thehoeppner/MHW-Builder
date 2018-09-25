using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Weapon
{
    public enum ElementType
    {
        Fire,
        Thunder,
        Poison,
        Water,
        Dragon,
        Sleep,
        Ice,
        Blast,
        Paralysis
    }

    public static class ElementTypeConverter
    {
        public static ElementType GetElementType(string type)
        {
            switch (type)
            {
                case "fire": return ElementType.Fire;
                case "thunder": return ElementType.Thunder;
                case "poison": return ElementType.Poison;
                case "water": return ElementType.Water;
                case "dragon": return ElementType.Dragon;
                case "sleep": return ElementType.Sleep;
                case "ice": return ElementType.Ice;
                case "blast": return ElementType.Blast;
                case "paralysis": return ElementType.Paralysis;
                default: return ElementType.Fire;
            }
        }
    }
}
