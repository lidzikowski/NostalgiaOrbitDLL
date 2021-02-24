using System;
using System.Collections.Generic;

namespace NostalgiaOrbitDLL.Items
{
    [Serializable]
    public class B01 : AbstractItem
    {
        public static B01 Instance { get; } = new B01();
        public B01()
        {
            ItemType = ItemTypes.B01;
            ItemShopType = ItemShopTypes.B01;

            CanBuyUridium = true;
            UridiumPurchase = new List<float>()
            {
                2500
            };

            CanSellByCredit = true;
            CreditSale = new List<float>()
            {
                10000
            };

            IsShield = true;
            Shield = 4000;
            ShieldAbsorption = 0.7f;

            CanBuyOnAuctionHouse = true;
        }
    }
}