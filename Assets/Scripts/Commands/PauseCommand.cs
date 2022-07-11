using PlatformGame.Infrastructure;

namespace PlatformGame.Commands
{
    public class PauseCommand : ICommand
    {
        private readonly LifeController _lifeController;

        public PauseCommand(LifeController lifeController)
        {
            _lifeController = lifeController;
        }

        public void Execute()
        {
            _lifeController.Pause();
        }
    }
}
