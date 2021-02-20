using System;
using System.Collections.Generic;

namespace NostalgiaOrbitDLL.Items
{
    [Serializable]
    public class G3N_3210 : AbstractItem
    {
        public static G3N_3210 Instance { get; } = new G3N_3210();
        public G3N_3210()
        {
            ItemType = ItemTypes.G3N_3210;

            CanBuyByCredit = true;
            CreditPurchase = new List<int>(8000);

            CanSellByCredit = true;
            CreditSale = new List<int>(2000);

            IsGear = true;
            GearSpeed = 4;
        }
    }
}