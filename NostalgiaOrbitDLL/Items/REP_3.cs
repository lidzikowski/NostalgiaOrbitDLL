using System;
using System.Collections.Generic;

namespace NostalgiaOrbitDLL.Items
{
    [Serializable]
    public class REP_3 : AbstractItem
    {
        public static REP_3 Instance { get; } = new REP_3();
        public REP_3()
        {
            ItemType = ItemTypes.REP_3;
            ItemShopType = ItemShopTypes.REP_3;

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

            IsExtras = true;
            ExtrasCanRepair = true;
            ExtrasRepairTime = 60;

            CanBuyOnAuctionHouse = true;
        }
    }
}