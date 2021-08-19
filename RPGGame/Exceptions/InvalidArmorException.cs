using System;
using System.Collections.Generic;
using System.Text;

namespace RPGGame
{
    public class InvalidArmorException : Exception
    {
        public InvalidArmorException(string message) : base(message)
        {
        }
    }
}
