using System.Collections.Generic;
using Models.Skill;

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
        public IEnumerable<Slot> slots { get; set; }
        public IEnumerable<SkillRank> skills { get; set; }
        public SetInfo armorSet { get; set; }
        public Assets assets { get; set; }
        public CraftingInfo crafting { get; set; }


        public ArmorType armorType { get { return ArmorTypeConverter.GetArmorTyp(type); } }
        public Rank armorRank { get { return RankConverter.GetRank(rank); } }
    }
}
