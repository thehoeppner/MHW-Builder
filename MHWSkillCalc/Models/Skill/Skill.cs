using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Skill
{
    public class Skill
    {
        public int id { get; set; }
        public string slug { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public IEnumerable<SkillRank> ranks { get; set; }
    }
}
