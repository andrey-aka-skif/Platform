using System;

namespace PlatformGame.Infrastructure
{
    public interface ILoseEventSource
    {
        event Action Lose;
    }
}
