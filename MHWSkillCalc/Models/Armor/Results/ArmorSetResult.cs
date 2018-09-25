using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Armor.Results
{
    public class ArmorSetResult
    {
        public int id { get; set; }
        public string name { get; set; }
        public Rank rank { get; set; }
        public IEnumerable<int> associatedArmorIds { get; set; }
        public SetBonus setBonus { get; set; }
    }
}
