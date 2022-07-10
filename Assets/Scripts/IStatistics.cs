namespace PlatformGame
{
    public interface IStatistics
    {
        Money CoinsAmount { get; }
        Money BestScore { get; }
    }
}