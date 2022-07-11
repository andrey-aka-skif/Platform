namespace PlatformGame
{
    public interface IPlatformRepository
    {
        Skin GetSkin();
        void SaveSkin(Skin skin);
    }
}
