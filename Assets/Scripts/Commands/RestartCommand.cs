using PlatformGame.Infrastructure;
using System;

namespace PlatformGame.Commands
{
    public class RestartCommand : ICommand
    {
        public RestartCommand(LifeController lifeController)
        {

        }

        public void Execute()
        {
            throw new NotImplementedException();
        }
    }
}
