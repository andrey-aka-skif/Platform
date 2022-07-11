using System;

namespace PlatformGame.Core
{
    public interface IProgressEventSource
    {
        event Action<int> Progress;
    }
}
