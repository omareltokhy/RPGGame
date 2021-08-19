using System;
using System.Collections.Generic;
using System.Text;

namespace RPGGame
{
    public class PrimaryAttributes
    {
        public int Strength { get; set; }
        public int Dexterity { get; set; }
        public int Vitality { get; set; }
        public int Intelligence { get; set; }

        public static PrimaryAttributes operator + (PrimaryAttributes lhs, PrimaryAttributes rhs)
        {
            return new PrimaryAttributes
            {
                Vitality = lhs.Vitality + rhs.Vitality,
                Strength = lhs.Strength + rhs.Strength,
                Dexterity = lhs.Dexterity + rhs.Dexterity,
                Intelligence = lhs.Intelligence + rhs.Intelligence
            };
        }
    }
}
