using System;

namespace PlatformGame.Shoping
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
