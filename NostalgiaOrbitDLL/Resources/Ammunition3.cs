using System;
using System.Collections.Generic;

namespace NostalgiaOrbitDLL.Resources
{
    [Serializable]
    public class Ammunition3 : AbstractResource
    {
        public static Ammunition3 Instance { get; } = new Ammunition3();
        public Ammunition3()
        {
            ResourceType = ResourceTypes.Ammunition3;

            ShotProbability = 80;

            AmmunitionMultiplier = 3;

            CanBuyUridium = true;
            UridiumPurchase = new List<float>() {
                1,
            };

            CanSellByCredit = true;
            CreditSale = new List<float>() {
                10,
            };
        }
    }
}