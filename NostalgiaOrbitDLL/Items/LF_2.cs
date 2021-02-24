using System;
using System.Collections.Generic;

namespace NostalgiaOrbitDLL.Items
{
    [Serializable]
    public class LF_2 : AbstractItem
    {
        public static LF_2 Instance { get; } = new LF_2();
        public LF_2()
        {
            ItemType = ItemTypes.LF_2;
            ItemShopType = ItemShopTypes.LF_2;

            CanBuyUridium = true;
            UridiumPurchase = new List<float>()
            {
                5000
            };

            CanSellByCredit = true;
            CreditSale = new List<float>()
            {
                25000
            };

            IsLaser = true;
            LaserDamage = 120;

            CanBuyOnAuctionHouse = true;
        }
    }
}