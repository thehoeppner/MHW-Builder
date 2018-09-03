using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Decoration
{
    public class Decoration
    {
        public int id { get; set; }
        public string slug { get; set; }
        public string name { get; set; }
        public int rarity { get; set; }
        public int slot { get; set; }
        public IEnumerable<Skill.SkillRank> skills { get; set; }
    }
}
