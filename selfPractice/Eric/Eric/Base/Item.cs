﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Eric.Items;

namespace Eric.Base
{
    public class Item
    {
        public string Name  { get; set; }
        public int Weight { get; set; }
        public ItemType Type { get; set; }
    }
}
