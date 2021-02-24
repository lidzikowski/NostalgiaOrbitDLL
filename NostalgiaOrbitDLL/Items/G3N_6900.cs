using System;
using System.Collections.Generic;

namespace NostalgiaOrbitDLL.Items
{
    [Serializable]
    public class G3N_6900 : AbstractItem
    {
        public static G3N_6900 Instance { get; } = new G3N_6900();
        public G3N_6900()
        {
            ItemType = ItemTypes.G3N_6900;
            ItemShopType = ItemShopTypes.G3N_6900;

            CanBuyUridium = true;
            UridiumPurchase = new List<float>()
            {
                1000
            };

            CanSellByCredit = true;
            CreditSale = new List<float>()
            {
                4000
            };

            IsGear = true;
            GearSpeed = 7;

            CanBuyOnAuctionHouse = true;
        }
    }
}