using System;

namespace PlatformGame.Infrastructure
{
    public interface ILifeEventSource
    {
        event Action RestartEvent;
        event Action PauseEvent;
        event Action ResumeEvent;
        event Action ExitEvent;
    }
}
