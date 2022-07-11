namespace PlatformGame.Shoping
{
    public interface IWalletRepository
    {
        Money GetCoins();
        void SaveCoins(Money amount);
    }
}
