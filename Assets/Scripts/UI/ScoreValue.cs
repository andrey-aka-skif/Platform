using UnityEngine;
using TMPro;
using PlatformGame.Core;

namespace PlatformGame.UI
{
    public class ScoreValue : MonoBehaviour
    {
        [SerializeField] private TMP_Text _text;

        public void Init(IProgressEventSource progressSource)
        {
            progressSource.Progress += OnProgressed;
        }

        private void OnProgressed(int score)
        {
            _text.text = score.ToString();
        }
    }
}
