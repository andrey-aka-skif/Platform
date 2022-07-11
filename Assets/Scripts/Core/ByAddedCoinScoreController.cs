using PlatformGame.Infrastructure;
using PlatformGame.Shoping;
using System;

namespace PlatformGame.Core
{
    public class ByAddedCoinScoreController : IManaged, IProgressEventSource
    {
        public event Action<int> Progress;

        private Wallet _wallet;
        private CoinsSpawner _spawner;

        public void Init()
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

        private void OnCoinDropedOnPlatform()
        {

        }
    }
}
