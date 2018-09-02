using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Armor
{
    public class SetInfo
    {
        public int id { get; set; }
        public string name { get; set; }
        public string rank { get; set; }
        public IEnumerable<int> pieces { get; set; }

        public Rank armorRank { get { return RankConverter.GetRank(rank); } }
    }
}
