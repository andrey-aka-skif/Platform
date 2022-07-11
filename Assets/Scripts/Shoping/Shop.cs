using PlatformGame.Core;
using System;
using System.Collections.Generic;

namespace PlatformGame.Shoping
{
    public class Shop
    {
        public event Action<Skin> PurchaseDone;
        public event Action<Skin> PurchaseFailure;
        public IReadOnlyList<SkinCostPare> SkinsForSale;

        public void Init()
        {

        }
        public Skin BuySkin(Skin skin)
        {
            return null;
        }
    }
}
