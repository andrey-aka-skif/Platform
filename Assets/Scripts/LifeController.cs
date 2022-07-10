using System;

namespace PlatformGame
{
    public class LifeController : IManaged, ILifeEventSource
    {
        public event Action RestartEvent;
        public event Action PauseEvent;
        public event Action ResumeEvent;
        public event Action ExitEvent;

        public void Pause()
        {
            throw new NotImplementedException();
        }

        public void Restart()
        {
            throw new NotImplementedException();
        }

        public void Resume()
        {
            throw new NotImplementedException();
        }
    }
}
