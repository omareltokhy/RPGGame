using System;
using System.Collections.Generic;
using System.Text;

namespace RPGGame
{
    public abstract class Hero
    {
        ///Declaring common variables for all heroes
        public string Name { get; set; }
        public string Type { get; set; }
        public int Level { get; set; }
        public int CharacterDps { get; set; }
        public PrimaryAttributes PrimaryAttribute { get; set; }
        public TotalPrimaryAttributes TotalPrimaryAttribute { get; set; }
        public SecondaryAttributes SecondaryAttribute { get; set; }

        /// <summary>
        /// Declaring Dictionary for Heros equipment
        /// </summary>
        public Dictionary<ItemSlot, Object> Equipment = new Dictionary<ItemSlot, object>();

        
        ///Creating methods for levelling up and updating
        ///attributes for different heroes to implement in subclasses
        public void LevelUp()
        {
            Level++;
            Console.WriteLine($"You levelled up to level {Level}!");
            UpdateAttributes();
        }
        /// <summary>
        /// Method which uses two other methods to check if item is valid and adds
        /// it to correct equipment slot
        /// </summary>
        /// <param name="weapon"></param>
        public string EquipWeapon(Weapons weapon)
        {
             CheckIfWeaponFits(weapon);
             WeaponToSlot(weapon);
             return "New weapon equipped!";
        }
        public string EquipArmor(Armors armor)
        {
             CheckIfArmorFits(armor);
             ArmorToSlot(armor);
             return "New armour equipped!";
        }
        /// <summary>
        /// Method to make sure that items go to their valid places. Throws exception if slot is wrong
        /// </summary>
        /// <param name="weapon"></param>
        public string WeaponToSlot(Weapons weapon)
        {
            if (weapon.Slot == ItemSlot.Weapon) { Equipment.Add(ItemSlot.Weapon, weapon); return "New weapon equipped!"; }
            else { throw new InvalidWeaponException("Invalid Slot!"); }
        }
        /// <summary>
        /// Method to make sure that items go to their valid places. Throws exception if slot is wrong
        /// </summary>
        /// <param name="armor"></param>
        public string ArmorToSlot(Armors armor)
        {
            if(armor.Slot == ItemSlot.Head) { Equipment.Add(ItemSlot.Head, armor); return "New armour equipped!"; }
            if(armor.Slot == ItemSlot.Body) { Equipment.Add(ItemSlot.Body, armor); return "New armour equipped!"; }
            if(armor.Slot == ItemSlot.Legs) { Equipment.Add(ItemSlot.Legs, armor); return "New armour equipped!"; }
            else { throw new InvalidArmorException("Invalid Slot!"); }
        }
        /// <summary>
        /// Method to Display stats of any hero on console
        /// </summary>
        public void DisplayStats()
        {
            Console.WriteLine($"Name: {Name}| Type: {Type} | Lvl: {Level}| Vit: {PrimaryAttribute.Vitality}| Str: {PrimaryAttribute.Strength}| Dex: { PrimaryAttribute.Dexterity}| Int: { PrimaryAttribute.Intelligence}| Hlt: { SecondaryAttribute.Health}| ArmR: { SecondaryAttribute.ArmorRating}| ElmR: {SecondaryAttribute.ElementalResistance}");
        }
        public abstract void CheckIfWeaponFits(Weapons weapon);
        public abstract void CheckIfArmorFits(Armors armor);
        public abstract void UpdateAttributes();
        public abstract void TotalAttributes();
    }
}
