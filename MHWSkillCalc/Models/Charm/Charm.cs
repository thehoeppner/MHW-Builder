﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Charm
{
    public class Charm
    {
        public int id { get; set; }
        public string slug { get; set; }
        public string name { get; set; }
        public IEnumerable<Rank> ranks { get; set; }
    }
}