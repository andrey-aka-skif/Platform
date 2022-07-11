namespace PlatformGame.Core
{
    public class PlatformUIProxy
    {
        private IPlatformRepository _platformRepository;

        public void Init(IPlatformRepository platformRepository)
        {

        }
        public bool TrySet(Skin skin)
        {
            return false;
        }
    }
}