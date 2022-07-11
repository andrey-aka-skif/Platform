namespace PlatformGame.Core
{
    public interface IPlatformRepository
    {
        Skin GetSkin();
        void SaveSkin(Skin skin);
    }
}
