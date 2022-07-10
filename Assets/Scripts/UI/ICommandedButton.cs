using PlatformGame.Commands;

namespace PlatformGame.UI
{
    internal interface ICommandedButton
    {
        ICommand Command { get; }
        void Init(ICommand command);
    }
}
