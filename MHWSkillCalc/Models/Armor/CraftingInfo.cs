using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Armor
{
    public class CraftingInfo
    {
        public IEnumerable<Crafting.CraftingCost> materials { get; set; }
    }
}
