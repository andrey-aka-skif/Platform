using System;

namespace PlatformGame
{
    public interface ILoseEventSource
    {
        event Action Lose;
    }
}
