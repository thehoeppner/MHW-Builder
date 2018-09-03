using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Charm
{
    public class Rank
    {
        public string name { get; set; }
        public int level { get; set; }
        public int rarity { get; set; }
        public IEnumerable<Skill.SkillRank> skills { get; set; }
        public CraftingInfo crafting { get; set; }
    }
}
