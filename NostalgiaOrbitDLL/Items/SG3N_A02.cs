using System;
using System.Collections.Generic;

namespace NostalgiaOrbitDLL.Items
{
    [Serializable]
    public class SG3N_A02 : AbstractItem
    {
        public static SG3N_A02 Instance { get; } = new SG3N_A02();
        public SG3N_A02()
        {
            ItemType = ItemTypes.SG3N_A02;

            CanBuyByCredit = true;
            CreditPurchase = new List<int>(16000);

            CanSellByCredit = true;
            CreditSale = new List<int>(4000);

            IsShield = true;
            Shield = 2000;
            ShieldAbsorption = 0.5f;
        }
    }
}