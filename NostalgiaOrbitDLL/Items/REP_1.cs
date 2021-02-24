using System;
using System.Collections.Generic;

namespace NostalgiaOrbitDLL.Items
{
    [Serializable]
    public class REP_1 : AbstractItem
    {
        public static REP_1 Instance { get; } = new REP_1();
        public REP_1()
        {
            ItemType = ItemTypes.REP_1;
            ItemShopType = ItemShopTypes.REP_1;

            CanBuyByCredit = true;
            CreditPurchase = new List<float>()
            {
                10000
            };

            CanSellByCredit = true;
            CreditSale = new List<float>()
            {
                2500
            };

            IsExtras = true;
            ExtrasCanRepair = true;
            ExtrasRepairTime = 120;
        }
    }
}