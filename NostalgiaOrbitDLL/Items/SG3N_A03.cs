using System;
using System.Collections.Generic;

namespace NostalgiaOrbitDLL.Items
{
    [Serializable]
    public class SG3N_A03 : AbstractItem
    {
        public static SG3N_A03 Instance { get; } = new SG3N_A03();
        public SG3N_A03()
        {
            ItemType = ItemTypes.SG3N_A03;
            ItemShopType = ItemShopTypes.SG3N_A03;

            CanBuyByCredit = true;
            CreditPurchase = new List<float>()
            {
                256000
            };

            CanSellByCredit = true;
            CreditSale = new List<float>()
            {
                64000
            };

            IsShield = true;
            Shield = 5000;
            ShieldAbsorption = 0.6f;
        }
    }
}