using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Weapon
{
    public class WeaponElement
    {
        public string type { get; set; }
        public int damage { get; set; }
        public bool hidden { get; set; }

        public ElementType elementType { get { return ElementTypeConverter.GetElementType(type); } }
    }
}
