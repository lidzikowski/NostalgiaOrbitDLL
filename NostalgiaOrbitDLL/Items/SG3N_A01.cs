﻿using System;
using System.Collections.Generic;

namespace NostalgiaOrbitDLL.Items
{
    [Serializable]
    public class SG3N_A01 : AbstractItem
    {
        public static SG3N_A01 Instance { get; } = new SG3N_A01();
        public SG3N_A01()
        {
            ItemType = ItemTypes.SG3N_A01;
            ItemShopType = ItemShopTypes.SG3N_A01;

            CanBuyByCredit = true;
            CreditPurchase = new List<float>()
            {
                8000
            };

            CanSellByCredit = true;
            CreditSale = new List<float>()
            {
                2000
            };

            IsShield = true;
            Shield = 1000;
            ShieldAbsorption = 0.4f;
        }
    }
}