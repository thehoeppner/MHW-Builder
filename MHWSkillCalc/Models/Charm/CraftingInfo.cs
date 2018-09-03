using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Charm
{
    public class CraftingInfo
    {
        public bool craftable { get; set; }
        public IEnumerable<Crafting.CraftingCost> materials { get; set; }
    }
}
