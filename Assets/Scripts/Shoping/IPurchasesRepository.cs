using PlatformGame.Core;
using System.Collections.Generic;

namespace PlatformGame.Shoping
{
    public interface IPurchasesRepository
    {
        IReadOnlyList<Skin> GetPurchasedSkins();
        void SavePurchasedSkins(IReadOnlyList<Skin> skins);
    }
}
