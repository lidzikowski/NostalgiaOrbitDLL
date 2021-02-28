using System;
using System.Collections.Generic;

namespace NostalgiaOrbitDLL.Resources
{
    [Serializable]
    public class Mine : AbstractResource
    {
        public static Mine Instance { get; } = new Mine();
        public Mine()
        {
            ResourceType = ResourceTypes.Mine;
            ItemShopType = ItemShopTypes.Mine;

            ShotProbability = 100;

            Damage = 50000;

            CanBuyUridium = true;
            UridiumPurchase = new List<float>() {
                100,
            };

            CanSellByCredit = true;
            CreditSale = new List<float>() {
                500,
            };

            CanBuyOnAuctionHouse = true;
        }
    }
}