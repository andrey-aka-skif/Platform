using System.Collections.Generic;

namespace PlatformGame.Shoping
{
    public interface IShopRepository
    {
        IReadOnlyList<SkinCostPare> GetSkins();
    }
}
