using System;
using System.Collections.Generic;

namespace NostalgiaOrbitDLL.Items
{
    [Serializable]
    public class G3N_2010 : AbstractItem
    {
        public static G3N_2010 Instance { get; } = new G3N_2010();
        public G3N_2010()
        {
            ItemType = ItemTypes.G3N_2010;
            ItemShopType = ItemShopTypes.G3N_2010;

            CanBuyByCredit = true;
            CreditPurchase = new List<float>()
            {
                4000
            };

            CanSellByCredit = true;
            CreditSale = new List<float>()
            {
                1000
            };

            IsGear = true;
            GearSpeed = 3;
        }
    }
}