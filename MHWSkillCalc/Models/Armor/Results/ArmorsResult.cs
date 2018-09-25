using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Armor.Results
{
    public class ArmorsResult
    { 
        public IEnumerable<Armor> armors { get; set; }
        public IEnumerable<ArmorSetResult> armorSets { get; set; }
    }
}
