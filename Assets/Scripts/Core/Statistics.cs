using PlatformGame.Infrastructure;
using PlatformGame.Shoping;

namespace PlatformGame.Core
{
    public class Statistics : IStatistics
    {
        public Money CoinsAmount { get; }
        public Money BestScore { get; }

        private Wallet _wallet;

        public void Init(Wallet wallet)
        {

        }
    }
}
