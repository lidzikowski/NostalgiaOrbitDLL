using System;
using System.Collections.Generic;

namespace NostalgiaOrbitDLL.Items
{
    [Serializable]
    public class G3N_7900 : AbstractItem
    {
        public static G3N_7900 Instance { get; } = new G3N_7900();
        public G3N_7900()
        {
            ItemType = ItemTypes.G3N_7900;
            ItemShopType = ItemShopTypes.G3N_7900;

            CanBuyUridium = true;
            UridiumPurchase = new List<float>()
            {
                2000
            };

            CanSellByCredit = true;
            CreditSale = new List<float>()
            {
                8000
            };

            IsGear = true;
            GearSpeed = 10;

            CanBuyOnAuctionHouse = true;
        }
    }
}