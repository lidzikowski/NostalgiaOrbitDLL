﻿using System;
using System.Collections.Generic;

namespace NostalgiaOrbitDLL.Items
{
    [Serializable]
    public class LF_1 : AbstractItem
    {
        public static LF_1 Instance { get; } = new LF_1();
        public LF_1()
        {
            ItemType = ItemTypes.LF_1;
            ItemShopType = ItemShopTypes.LF_1;

            CanBuyByCredit = true;
            CreditPurchase = new List<float>()
            {
                10000
            };

            CanSellByCredit = true;
            CreditSale = new List<float>()
            {
                2500
            };

            IsLaser = true;
            LaserDamage = 60;
        }
    }
}