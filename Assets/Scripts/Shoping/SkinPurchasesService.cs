using PlatformGame.Core;
using System.Collections.Generic;

namespace PlatformGame.Shoping
{
    public class SkinPurchasesService
    {
        public IReadOnlyList<Skin> PurchasedSkins { get; }

        private Wallet _wallet;
        private Shop _shop;
        private Purchases _purchases;

        public void Init(Shop shop, Wallet wallet, Purchases purchases)
        {

        }
        public bool TryBuySkin(Skin skin)
        {
            return false;
        }
    }
}
