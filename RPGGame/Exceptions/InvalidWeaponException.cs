using System;
using System.Collections.Generic;
using System.Text;

namespace RPGGame
{
    public class InvalidWeaponException : Exception
    {
        public InvalidWeaponException(string message) : base(message)
        {
        }
    }
}
