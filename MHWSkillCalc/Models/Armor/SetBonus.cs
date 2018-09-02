using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Armor
{
    public class SetBonus
    {
        public int id { get; set; }
        public string name { get; set; }
        public IEnumerable<SetBonusRank> ranks { get; set; }
    }
}
