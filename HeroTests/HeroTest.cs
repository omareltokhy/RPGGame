using RPGGame;
using System;
using Xunit;

namespace HeroTests
{
    public class HeroTest
    {
        [Fact]
        public void Mage_MageLevelWhenCreated_ShouldBeOne()
        {
            //Arrange
            string name = "Make";
            Mage mage = new Mage(name);
            int expected = 1;
            //Act
            int actual = mage.Level;
            //Assert
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void Mage_MageShouldLevelUp_ShoulldLevelUpByOne()
        {
            //Arrange
            string name = "Make";
            Mage mage = new Mage(name);
            mage.Level = 1;
            int expected = 2;
            //Act
            mage.LevelUp();
            int actual = mage.Level;
            //Assert
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void Mage_MageStartingStats_ShouldBeDefault()
        {
            //Arrange
            string name = "Make";
            Mage mage = new Mage(name);
            int expectedVitality = 5;
            int expectedStrength = 1;
            int expectedDexterity = 1;
            int expectedIntelligence = 8;
            //Act
            int actualVitality = mage.PrimaryAttribute.Vitality;
            int actualStrength = mage.PrimaryAttribute.Strength;
            int actualDexterity = mage.PrimaryAttribute.Dexterity;
            int actualIntelligence = mage.PrimaryAttribute.Intelligence;
            //Assert
            Assert.Equal(expectedVitality, actualVitality);
            Assert.Equal(expectedStrength, actualStrength);
            Assert.Equal(expectedDexterity, actualDexterity);
            Assert.Equal(expectedIntelligence, actualIntelligence);
        }
        [Fact]
        public void Rogue_RogueStartingStats_ShouldBeDefault()
        {
            //Arrange
            string name = "Roki";
            Rogue rogue = new Rogue(name);
            int expectedVitality = 8;
            int expectedStrength = 2;
            int expectedDexterity = 6;
            int expectedIntelligence = 1;
            //Act
            int actualVitality = rogue.PrimaryAttribute.Vitality;
            int actualStrength = rogue.PrimaryAttribute.Strength;
            int actualDexterity = rogue.PrimaryAttribute.Dexterity;
            int actualIntelligence = rogue.PrimaryAttribute.Intelligence;
            //Assert
            Assert.Equal(expectedVitality, actualVitality);
            Assert.Equal(expectedStrength, actualStrength);
            Assert.Equal(expectedDexterity, actualDexterity);
            Assert.Equal(expectedIntelligence, actualIntelligence);
        }
        [Fact]
        public void Ranger_RangerStartingStats_ShouldBeDefault()
        {
            //Arrange
            string name = "Rako";
            Ranger ranger = new Ranger(name);
            int expectedVitality = 8;
            int expectedStrength = 1;
            int expectedDexterity = 7;
            int expectedIntelligence = 1;
            //Act
            int actualVitality = ranger.PrimaryAttribute.Vitality;
            int actualStrength = ranger.PrimaryAttribute.Strength;
            int actualDexterity = ranger.PrimaryAttribute.Dexterity;
            int actualIntelligence = ranger.PrimaryAttribute.Intelligence;
            //Assert
            Assert.Equal(expectedVitality, actualVitality);
            Assert.Equal(expectedStrength, actualStrength);
            Assert.Equal(expectedDexterity, actualDexterity);
            Assert.Equal(expectedIntelligence, actualIntelligence);
        }
        [Fact]
        public void Warrior_WarriorStartingStats_ShouldBeDefault()
        {
            //Arrange
            string name = "Weli";
            Warrior warrior = new Warrior(name);
            int expectedVitality = 10;
            int expectedStrength = 5;
            int expectedDexterity = 2;
            int expectedIntelligence = 1;
            //Act
            int actualVitality = warrior.PrimaryAttribute.Vitality;
            int actualStrength = warrior.PrimaryAttribute.Strength;
            int actualDexterity = warrior.PrimaryAttribute.Dexterity;
            int actualIntelligence = warrior.PrimaryAttribute.Intelligence;
            //Assert
            Assert.Equal(expectedVitality, actualVitality);
            Assert.Equal(expectedStrength, actualStrength);
            Assert.Equal(expectedDexterity, actualDexterity);
            Assert.Equal(expectedIntelligence, actualIntelligence);
        }
        [Fact]
        public void Mage_MageLevelUPStats_ShouldBeIncreased()
        {
            //Arrange
            string name = "Make";
            Mage mage = new Mage(name);
            int expectedVitality = 8;
            int expectedStrength = 2;
            int expectedDexterity = 2;
            int expectedIntelligence = 13;
            //Act
            mage.LevelUp();
            int actualVitality = mage.PrimaryAttribute.Vitality;
            int actualStrength = mage.PrimaryAttribute.Strength;
            int actualDexterity = mage.PrimaryAttribute.Dexterity;
            int actualIntelligence = mage.PrimaryAttribute.Intelligence;
            //Assert
            Assert.Equal(expectedVitality, actualVitality);
            Assert.Equal(expectedStrength, actualStrength);
            Assert.Equal(expectedDexterity, actualDexterity);
            Assert.Equal(expectedIntelligence, actualIntelligence);
        }
        [Fact]
        public void Rogue_RogueLevelUPStats_ShouldBeIncreased()
        {
            //Arrange
            string name = "Roki";
            Rogue rogue = new Rogue(name);
            int expectedVitality = 11;
            int expectedStrength = 3;
            int expectedDexterity = 10;
            int expectedIntelligence = 2;
            //Act
            rogue.LevelUp();
            int actualVitality = rogue.PrimaryAttribute.Vitality;
            int actualStrength = rogue.PrimaryAttribute.Strength;
            int actualDexterity = rogue.PrimaryAttribute.Dexterity;
            int actualIntelligence = rogue.PrimaryAttribute.Intelligence;
            //Assert
            Assert.Equal(expectedVitality, actualVitality);
            Assert.Equal(expectedStrength, actualStrength);
            Assert.Equal(expectedDexterity, actualDexterity);
            Assert.Equal(expectedIntelligence, actualIntelligence);
        }
        [Fact]
        public void Ranger_RangerLevelUPStats_ShouldBeIncreased()
        {
            //Arrange
            string name = "Rako";
            Ranger ranger = new Ranger(name);
            int expectedVitality = 10;
            int expectedStrength = 2;
            int expectedDexterity = 12;
            int expectedIntelligence = 2;
            //Act
            ranger.LevelUp();
            int actualVitality = ranger.PrimaryAttribute.Vitality;
            int actualStrength = ranger.PrimaryAttribute.Strength;
            int actualDexterity = ranger.PrimaryAttribute.Dexterity;
            int actualIntelligence = ranger.PrimaryAttribute.Intelligence;
            //Assert
            Assert.Equal(expectedVitality, actualVitality);
            Assert.Equal(expectedStrength, actualStrength);
            Assert.Equal(expectedDexterity, actualDexterity);
            Assert.Equal(expectedIntelligence, actualIntelligence);
        }
        [Fact]
        public void Warrior_WarriorLevelUPStats_ShouldBeIncreased()
        {
            //Arrange
            string name = "Weli";
            Warrior warrior = new Warrior(name);
            int expectedVitality = 15;
            int expectedStrength = 8;
            int expectedDexterity = 4;
            int expectedIntelligence = 2;
            //Act
            warrior.LevelUp();
            int actualVitality = warrior.PrimaryAttribute.Vitality;
            int actualStrength = warrior.PrimaryAttribute.Strength;
            int actualDexterity = warrior.PrimaryAttribute.Dexterity;
            int actualIntelligence = warrior.PrimaryAttribute.Intelligence;
            //Assert
            Assert.Equal(expectedVitality, actualVitality);
            Assert.Equal(expectedStrength, actualStrength);
            Assert.Equal(expectedDexterity, actualDexterity);
            Assert.Equal(expectedIntelligence, actualIntelligence);
        }
        [Fact]
        public void Warrior_WarriorLevelUPSecondaryStats_ShouldBeIncreased()
        {
            //Arrange
            string name = "Weli";
            Warrior warrior = new Warrior(name);
            int expectedHealth = 150;
            int expectedArmorRating = 12;
            int expectedElementalResistance = 2;
            //Act
            warrior.LevelUp();
            int actualHealth = warrior.SecondaryAttribute.Health;
            int actualArmorRating = warrior.SecondaryAttribute.ArmorRating;
            int actualElementalResistance = warrior.SecondaryAttribute.ElementalResistance;
            //Assert
            Assert.Equal(expectedHealth, actualHealth);
            Assert.Equal(expectedArmorRating, actualArmorRating);
            Assert.Equal(expectedElementalResistance, actualElementalResistance);
        }
    }
}
