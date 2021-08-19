using System;
using System.Collections.Generic;
using System.Text;

namespace RPGGame
{
    public class Weapons : Items
    {
        public Weapons() { }
        public WeaponAttributes WeaponAttribute { get; set; }
        public WeaponTypes WeaponType { get; set; }
        /// <summary>
        /// Calculating weapon DPS
        /// </summary>
        /// <returns></returns>
        public double DamagePerSecond()
        {
            return WeaponAttribute.Damage * WeaponAttribute.AttackSpeed;
        }
    }
}
