using System;
using System.Collections.Generic;
using System.Text;

namespace RPGGame
{
    public class Mage : Hero
    {
        /// <summary>
        /// Setting up a constructor and defining all the base attributes for hero.
        /// </summary>
        /// <param name="name"></param>
        public Mage(string name):base()
        {
            this.Name = name;
            this.Level = 1;
            this.Type = "Mage";
            PrimaryAttribute = new PrimaryAttributes() { Strength = 1, Vitality = 5, Dexterity = 1, Intelligence = 8 };
            SecondaryAttribute = new SecondaryAttributes() 
            {
                Health = PrimaryAttribute.Vitality*10,
                ArmorRating = PrimaryAttribute.Strength+PrimaryAttribute.Dexterity,
                ElementalResistance = PrimaryAttribute.Intelligence 
            };
        }
        /// <summary>
        /// A Method to Update primary and secondary attributes, gets called inside LevelUp() method
        /// </summary>
        public override void UpdateAttributes()
        {
            PrimaryAttribute.Strength += 1;
            PrimaryAttribute.Vitality += 3;
            PrimaryAttribute.Dexterity += 1;
            PrimaryAttribute.Intelligence += 5;
            SecondaryAttribute = new SecondaryAttributes()
            {
                Health = PrimaryAttribute.Vitality * 10,
                ArmorRating = PrimaryAttribute.Strength + PrimaryAttribute.Dexterity,
                ElementalResistance = PrimaryAttribute.Intelligence
            };
        }
        /// <summary>
        /// Run out of time :(
        /// </summary>
        public override void TotalAttributes()
        {
            //Method body
        }
        /// <summary>
        /// Check if hero can use chosen weapon. In case hero can't, throw exception.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="weaponTypes"></param>
        public override void CheckIfWeaponFits(Weapons weapon)
        {
            if(weapon.WeaponType != WeaponTypes.Staff || weapon.WeaponType != WeaponTypes.Wand)
            {
                throw new InvalidWeaponException("You can only use Wands and Staffs!");
            }
            if(weapon.LevelRequired > Level)
            {
                throw new InvalidWeaponException("You need to reach higher level to use this weapon!");
            }
        }
        /// <summary>
        /// Check if hero can use chosen armor. In case hero can't, throw exception.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="armorTypes"></param>
        public override void CheckIfArmorFits(Armors armor)
        {
            if(armor.ArmorType != ArmorTypes.Cloth)
            {
                throw new InvalidArmorException("You can only use Cloths!");
            }
            if(armor.LevelRequired > Level)
            {
                throw new InvalidArmorException("You need to reach higher level to use this armor!");
            }
        }
    }
}
