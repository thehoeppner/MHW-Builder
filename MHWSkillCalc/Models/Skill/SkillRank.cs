using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Skill
{
    public class SkillRank
    {
        public int id { get; set; }
        public string slug { get; set; }
        public int level { get; set; }
        public string description { get; set; }
        public string skill { get; set; }
        public string skillName { get; set; }
        //public Dictionary<string, int> modifiers { get; set; }
    }
}
