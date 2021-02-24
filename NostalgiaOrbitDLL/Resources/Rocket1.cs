using System;
using System.Collections.Generic;

namespace NostalgiaOrbitDLL.Resources
{
    [Serializable]
    public class Rocket1 : AbstractResource
    {
        public static Rocket1 Instance { get; } = new Rocket1();
        public Rocket1()
        {
            ResourceType = ResourceTypes.Rocket1;
            ItemShopType = ItemShopTypes.Rocket1;

            ShotProbability = 70;

            Damage = 1000;

            CanBuyByCredit = true;
            CreditPurchase = new List<float>() {
                100,
            };

            CanSellByCredit = true;
            CreditSale = new List<float>() {
                10,
            };
        }
    }
}