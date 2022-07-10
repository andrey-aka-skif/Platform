using System;

namespace PlatformGame
{
    public class Money
    {
        public int Value { get; }

        public Money(int value)
        {
            if (value < 0) throw new ArgumentNullException();
            Value = value;
        }
    }
}