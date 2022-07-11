namespace PlatformGame.Infrastructure
{
    public interface IManaged
    {
        void Restart();
        void Pause();
        void Resume();
    }
}
