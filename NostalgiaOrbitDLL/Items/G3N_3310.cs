using System;
using System.Collections.Generic;

namespace NostalgiaOrbitDLL.Items
{
    [Serializable]
    public class G3N_3310 : AbstractItem
    {
        public static G3N_3310 Instance { get; } = new G3N_3310();
        public G3N_3310()
        {
            ItemType = ItemTypes.G3N_3310;
            ItemShopType = ItemShopTypes.G3N_3310;

            CanBuyByCredit = true;
            CreditPurchase = new List<float>()
            {
                16000
            };

            CanSellByCredit = true;
            CreditSale = new List<float>()
            {
                4000
            };

            IsGear = true;
            GearSpeed = 5;
        }
    }
}