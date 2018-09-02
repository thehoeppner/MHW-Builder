using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Armor
{
    public class ArmorSet
    {
        public int id { get; set; }
        public string name { get; set; }
        public string rank { get; set; }
        public IEnumerable<Armor> pieces { get; set; }
        public SetBonus bonus { get; set; }
    }
}
