using System;
using System.Collections.Generic;

namespace NostalgiaOrbitDLL.Resources
{
    [Serializable]
    public class Ammunition1 : AbstractResource
    {
        public static Ammunition1 Instance { get; } = new Ammunition1();
        public Ammunition1()
        {
            ResourceType = ResourceTypes.Ammunition1;

            ShotProbability = 80;

            AmmunitionMultiplier = 1;

            CanBuyByCredit = true;
            CreditPurchase = new List<float>() {
                10,
            };

            CanSellByCredit = true;
            CreditSale = new List<float>() {
                1,
            };
        }
    }
}