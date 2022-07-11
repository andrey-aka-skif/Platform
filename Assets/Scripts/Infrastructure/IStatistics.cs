using PlatformGame.Shoping;

namespace PlatformGame.Infrastructure
{
    public interface IStatistics
    {
        Money CoinsAmount { get; }
        Money BestScore { get; }
    }
}
