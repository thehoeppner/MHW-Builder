using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Armor
{
    public enum ArmorType
    {
        Head = 0,
        Chest = 1,
        Gloves = 2,
        Waist = 3,
        Legs = 4
    }

    public static class ArmorTypeConverter
    {
        public static ArmorType GetArmorTyp(string typ)
        {
            switch (typ){
                case "head": return ArmorType.Head;
                case "chest": return ArmorType.Chest;
                case "gloves": return ArmorType.Gloves;
                case "waist": return ArmorType.Waist;
                case "legs": return ArmorType.Legs;
                default : return ArmorType.Head;
            }
        }
    }
}
