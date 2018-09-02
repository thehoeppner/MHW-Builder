using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Armor
{
    public class Armor
    {
        public int id { get; set; }
        public string slug { get; set; }
        public string name { get; set; }
        public string type { get; set; }
        public string rank { get; set; }
        public int rarity { get; set; }
        public Defense defense { get; set; }
        public Resistance resistance { get; set; }

        public ArmorType armorType { get { return ArmorTypeConverter.GetArmorTyp(type); } }
        public Rank armorRank { get { return RankConverter.GetRank(rank); } }
    }
}
