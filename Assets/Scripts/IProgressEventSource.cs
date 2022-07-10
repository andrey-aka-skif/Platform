using System;

namespace PlatformGame
{
    public interface IProgressEventSource
    {
        event Action<int> Progress;
    }
}
