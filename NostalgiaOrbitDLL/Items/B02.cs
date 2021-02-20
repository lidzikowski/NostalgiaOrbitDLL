using System;
using System.Collections.Generic;

namespace NostalgiaOrbitDLL.Items
{
    [Serializable]
    public class B02 : AbstractItem
    {
        public static B02 Instance { get; } = new B02();
        public B02()
        {
            ItemType = ItemTypes.B02;

            CanBuyUridium = true;
            UridiumPurchase = new List<int>(10000);

            CanSellByCredit = true;
            CreditSale = new List<int>(50000);

            IsShield = true;
            Shield = 10000;
            ShieldAbsorption = 0.8f;

            CanBuyOnAuctionHouse = true;
        }
    }
}