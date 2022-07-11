using PlatformGame.Infrastructure;
using System;

namespace PlatformGame.Commands
{
    public class ExitCommand : ICommand
    {
        public ExitCommand(LifeController lifeController)
        {

        }

        public void Execute()
        {
            throw new NotImplementedException();
        }
    }
}