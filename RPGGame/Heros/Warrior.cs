using System;
using System.Collections.Generic;
using System.Text;

namespace RPGGame
{
    public class Warrior : Hero
    {
        /// <summary>
        /// Setting up a constructor and defining all the base attributes for hero.
        /// </summary>
        /// <param name="name"></param>
        public Warrior(string name) : base()
        {
            this.Name = name;
            this.Level = 1;
            this.Type = "Warrior";
            PrimaryAttribute = new PrimaryAttributes() { Strength = 5, Vitality = 10, Dexterity = 2, Intelligence = 1 };
            SecondaryAttribute = new SecondaryAttributes()
            {
                Health = PrimaryAttribute.Vitality * 10,
                ArmorRating = PrimaryAttribute.Strength + PrimaryAttribute.Dexterity,
                ElementalResistance = PrimaryAttribute.Intelligence
            };
        }
        /// <summary>
        /// A Method to Update primary and secondary attributes, gets called inside LevelUp() method
        /// </summary>
        public override void UpdateAttributes()
        {
            PrimaryAttribute.Strength += 3;
            PrimaryAttribute.Vitality += 5;
            PrimaryAttribute.Dexterity += 2;
            PrimaryAttribute.Intelligence += 1;
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
            if (weapon.WeaponType == WeaponTypes.Staff || weapon.WeaponType == WeaponTypes.Wand)
            {
                throw new InvalidWeaponException("You can only use Axes, Hammers and Swords!");
            }
            if (weapon.LevelRequired > Level)
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
            if (armor.ArmorType == ArmorTypes.Cloth || armor.ArmorType == ArmorTypes.Leather)
            {
                throw new InvalidArmorException("You can only use Mails and Plates!");
            }
            if (armor.LevelRequired > Level)
            {
                throw new InvalidArmorException("You need to reach higher level to use this armor!");
            }
        }
    }
}
