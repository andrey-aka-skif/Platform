using System;

namespace PlatformGame.Shoping
{
    public class Wallet
    {
        public event Action<int> CoinsAmountChange;

        public Money CoinsAmount { get; }

        private IWalletRepository _repository;

        public void Init()
        {

        }
        public void AddCoins(Money amount)
        {

        }
        public void RemoveCoins(Money amount)
        {

        }
    }
}
