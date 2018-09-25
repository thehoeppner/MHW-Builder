using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Weapon
{
    public class Weapon
    {
        public int id { get; set; }
        public string slug { get; set; }
        public string name { get; set; }
        public string type { get; set; }
        public int rarity { get; set; }
        public Attack attack { get; set; }
        public IEnumerable<Slot> slots { get; set; }
        public IEnumerable<WeaponElement> elements { get; set; }
        public WeaponCraftingInfo crafting { get; set; }
        public Assets assets { get; set; }
        public IEnumerable<WeaponSharpness> durability { get; set; }

        public WeaponType weaponType { get { return WeaponTypeConverter.GetWeaponType(type); } }
    }
}
