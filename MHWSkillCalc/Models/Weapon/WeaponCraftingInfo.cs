using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Weapon
{
    public class WeaponCraftingInfo
    {
        public bool craftable { get; set; }
        public int? previous { get; set; }
        public IEnumerable<int> branches { get; set; }
        public IEnumerable<Crafting.CraftingCost> craftingMaterials { get; set; }
        public IEnumerable<Crafting.CraftingCost> upgradeMaterials { get; set; }
    }
}
