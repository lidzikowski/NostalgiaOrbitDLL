using System;
using System.Collections.Generic;

namespace NostalgiaOrbitDLL.Items
{
    [Serializable]
    public class REP_2 : AbstractItem
    {
        public static REP_2 Instance { get; } = new REP_2();
        public REP_2()
        {
            ItemType = ItemTypes.REP_2;

            CanBuyUridium = true;
            UridiumPurchase = new List<int>(2000);

            CanSellByCredit = true;
            CreditSale = new List<int>(10000);

            IsExtras = true;
            ExtrasCanRepair = true;
            ExtrasRepairTime = 90;

            CanBuyOnAuctionHouse = true;
        }
    }
}