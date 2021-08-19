using System;

namespace RPGGame
{
    class Program
    {
        /// <summary>
        /// Printing stats to console
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Mage testMage = new Mage("Make");
            testMage.DisplayStats();
            testMage.LevelUp();
            testMage.DisplayStats();
            Console.WriteLine("=======================");
        }

    }
}
