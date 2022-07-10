using PlatformGame.Commands;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace PlatformGame.UI
{
    public abstract class CommandedButton : Button, ICommandedButton
    {
        public ICommand Command { get; private set; }

        public void Init(ICommand command)
        {
            Command = command;
        }

        public override void OnPointerClick(PointerEventData eventData)
        {
            base.OnPointerClick(eventData);
            Command?.Execute();
        }
    }
}
