﻿using System;
using System.Collections.Generic;

namespace NostalgiaOrbitDLL.Items
{
    [Serializable]
    public class MP_1 : AbstractItem
    {
        public static MP_1 Instance { get; } = new MP_1();
        public MP_1()
        {
            ItemType = ItemTypes.MP_1;

            CanBuyByCredit = true;
            CreditPurchase = new List<int>(40000);

            CanSellByCredit = true;
            CreditSale = new List<int>(10000);

            IsLaser = true;
            LaserDamage = 80;
        }
    }
}