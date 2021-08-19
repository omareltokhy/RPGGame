using System;
using System.Collections.Generic;
using System.Text;

namespace RPGGame
{
    public class Armors : Items
    {
        public ArmorTypes ArmorType { get; set; }
        public PrimaryAttributes ArmorAttributes { get; set; }
    }
}
