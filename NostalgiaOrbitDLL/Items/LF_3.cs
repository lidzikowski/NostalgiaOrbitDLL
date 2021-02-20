using System;
using System.Collections.Generic;

namespace NostalgiaOrbitDLL.Items
{
    [Serializable]
    public class LF_3 : AbstractItem
    {
        public static LF_3 Instance { get; } = new LF_3();
        public LF_3()
        {
            ItemType = ItemTypes.LF_3;

            CanBuyUridium = true;
            CreditPurchase = new List<int>(10000);

            CanSellByCredit = true;
            CreditSale = new List<int>(50000);

            IsLaser = true;
            LaserDamage = 180;

            CanBuyOnAuctionHouse = true;
        }
    }
}