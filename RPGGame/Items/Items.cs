using System;
using System.Collections.Generic;
using System.Text;

namespace RPGGame
{
    public abstract class Items
    {
        public string Name { get; set; }
        public int LevelRequired { get; set; }
        public ItemSlot Slot { get; set; }
    }
}
