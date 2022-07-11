using System;
using System.Collections.Generic;

namespace PlatformGame.Infrastructure
{
    public class LifeController : IManaged, ILifeEventSource
    {
        private List<IManaged> _managed;
        private List<ILoseEventSource> _loseSources;

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