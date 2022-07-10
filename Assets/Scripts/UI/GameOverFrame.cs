using UnityEngine;
using System;

namespace PlatformGame.UI
{
    public class GameOverFrame : Frame
    {
        [SerializeField] private BestScoreValuePanel _bestScore;
        [SerializeField] private AvailableMoneyValuePanel _availableMoney;

        private IStatistics _statistics;

        public void Init(IStatistics statistics)
        {
            _statistics = statistics;
        }

        public void Show()
        {
            _bestScore.SetValue(_statistics.BestScore.ToString());
            _availableMoney.SetValue(_statistics.BestScore.ToString());
        }

        public void Close()
        {
            throw new NotImplementedException();
        }
    }
}
