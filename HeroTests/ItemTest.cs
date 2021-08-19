using System;
using Xunit;
using RPGGame;

namespace HeroTests
{
    public class ItemTest
    {
        [Fact]
        public void EquipWeapon_EquipWeaponWithTooHighLevel_ShouldReturnException()
        {
            //Arrange
            Weapons axe = new Weapons()
            {
                Name = "Axe",
                LevelRequired = 2,
                Slot = ItemSlot.Weapon,
                WeaponType = WeaponTypes.Axe,
                WeaponAttribute = new WeaponAttributes() { Damage = 7, AttackSpeed = 1.1}
            };
            Warrior warrior = new Warrior("Weli") { };
            //Act&Assert
            Assert.Throws<InvalidWeaponException>(() => warrior.EquipWeapon(axe));
        }
        [Fact]
        public void EquipArmor_EquipArmorWithTooHighLevel_ShouldReturnException()
        {
            //Arrange
            Armors armor = new Armors()
            {
                Name = "armor",
                LevelRequired = 2,
                Slot = ItemSlot.Body,
                ArmorType = ArmorTypes.Plate,
                ArmorAttributes = new PrimaryAttributes() { Vitality = 2, Strength = 1 }
            };
            Warrior warrior = new Warrior("Weli") { };
            //Act&Assert
            Assert.Throws<InvalidArmorException>(() => warrior.EquipArmor(armor));
        }
        [Fact]
        public void EquipWeapon_EquipWeaponWithWrongType_ShouldReturnException()
        {
            //Arrange
            Weapons axe = new Weapons()
            {
                Name = "Axe",
                LevelRequired = 1,
                Slot = ItemSlot.Body,
                WeaponType = WeaponTypes.Axe,
                WeaponAttribute = new WeaponAttributes() { Damage = 7, AttackSpeed = 1.1 }
            };
            Warrior warrior = new Warrior("Weli") { };
            //Act&Assert
            Assert.Throws<InvalidWeaponException>(() => warrior.EquipWeapon(axe));
        }
        [Fact]
        public void EquipArmor_EquipArmorWithWrongType_ShouldReturnException()
        {
            //Arrange
            Armors ake = new Armors()
            {
                Name = "Axe",
                LevelRequired = 2,
                Slot = ItemSlot.Weapon,
                ArmorType = ArmorTypes.Leather,
                ArmorAttributes = new PrimaryAttributes() { Vitality = 3, Strength = 1 }
            };
            Warrior warrior = new Warrior("Weli") { };
            //Act&Assert
            Assert.Throws<InvalidArmorException>(() => warrior.EquipArmor(ake));
        }
        [Fact]
        public void EquipWeapon_EquipWeaponSuccesfully_ShouldReturnGreeting()
        {
            //Arrange
            Weapons axe = new Weapons()
            {
                Name = "Axe",
                LevelRequired = 1,
                Slot = ItemSlot.Weapon,
                WeaponType = WeaponTypes.Axe,
                WeaponAttribute = new WeaponAttributes() { Damage = 7, AttackSpeed = 1.1 }
            };
            Warrior warrior = new Warrior("Weli") { };
            string expected = "New weapon equipped!";
            //Act
            string actual = warrior.EquipWeapon(axe);
            //Assert
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void EquipArmor_EquipArmorSuccesfully_ShouldReturnGreeting()
        {
            //Arrange
            Armors armor = new Armors()
            {
                Name = "armor",
                LevelRequired = 1,
                Slot = ItemSlot.Body,
                ArmorType = ArmorTypes.Mail,
                ArmorAttributes = new PrimaryAttributes() { Vitality = 2, Strength = 1 }
            };
            Warrior warrior = new Warrior("Weli") { };
            string expected = "New armour equipped!";
            //Act
            string actual = warrior.EquipArmor(armor);
            //Assert
            Assert.Equal(expected, actual);
        }

    }
}
