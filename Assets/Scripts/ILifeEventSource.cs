using System;

namespace PlatformGame
{
    public interface ILifeEventSource
    {
        event Action RestartEvent;
        event Action PauseEvent;
        event Action ResumeEvent;
        event Action ExitEvent;
    }
}
