using PlatformGame.Shoping;

namespace PlatformGame.Core
{
    public interface IStatisticsRepository
    {
        Money GetBestScore();
        void SaveBestScore(Money score);
    }
}
