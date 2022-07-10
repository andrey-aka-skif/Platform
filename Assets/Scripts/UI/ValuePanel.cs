using UnityEngine;
using TMPro;

namespace PlatformGame.UI
{
    public abstract class ValuePanel : MonoBehaviour
    {
        [SerializeField] private TMP_Text _text;
        public void SetValue(string value)
        {
            _text.text = value;
        }
    }
}
