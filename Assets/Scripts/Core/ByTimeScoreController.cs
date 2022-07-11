using PlatformGame.Infrastructure;
using PlatformGame.Shoping;
using System;
using System.Collections;

namespace PlatformGame.Core
{
    public class ByTimeScoreController : IManaged, IProgressEventSource
    {
        public event Action<int> Progress;

        private Wallet _wallet;
        private CoinsSpawner _spawner;
        private float _delay;

        public void Init(float delay)
        {

        }

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

        IEnumerator Tick()
        {
            return null;
        }
    }
}
