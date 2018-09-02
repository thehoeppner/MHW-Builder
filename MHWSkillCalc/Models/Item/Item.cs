using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Item
{
    public class Item
    {
        public int id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public int rarity { get; set;}
        public int carryLimit { get; set; }
        public int value { get; set; }
    }
}
