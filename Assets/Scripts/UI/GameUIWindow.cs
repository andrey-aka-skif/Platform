using PlatformGame.Infrastructure;
using UnityEngine;

namespace PlatformGame.UI
{
    public class GameUIWindow : UIWindow
    {
        [SerializeField] private GameOverFrame _gameOverFrame;
        public void Init(ILoseEventSource loseEventSource, ILifeEventSource lifeEventSource)
        {
            loseEventSource.Lose += OnLosed;
            lifeEventSource.PauseEvent += OnPauseEvented;
        }

        private void OnPauseEvented()
        {
            throw new System.NotImplementedException();
        }

        private void OnLosed()
        {
            _gameOverFrame.Show();
        }
    }
}
