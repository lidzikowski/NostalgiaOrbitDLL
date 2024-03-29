﻿using System;
using System.Collections.Generic;

namespace NostalgiaOrbitDLL.Items
{
    [Serializable]
    public class G3N_1010 : AbstractItem
    {
        public static G3N_1010 Instance { get; } = new G3N_1010();
        public G3N_1010()
        {
            ItemType = ItemTypes.G3N_1010;
            ItemShopType = ItemShopTypes.G3N_1010;

            CanBuyByCredit = true;
            CreditPurchase = new List<float>()
            {
                2000
            };

            CanSellByCredit = true;
            CreditSale = new List<float>()
            {
                500
            };

            IsGear = true;
            GearSpeed = 2;
        }
    }
}