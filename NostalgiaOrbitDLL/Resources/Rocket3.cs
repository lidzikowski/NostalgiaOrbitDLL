using System;
using System.Collections.Generic;

namespace NostalgiaOrbitDLL.Resources
{
    [Serializable]
    public class Rocket3 : AbstractResource
    {
        public static Rocket3 Instance { get; } = new Rocket3();
        public Rocket3()
        {
            ResourceType = ResourceTypes.Rocket3;

            ShotProbability = 90;

            Damage = 4000;

            CanBuyUridium = true;
            UridiumPurchase = new List<float>() {
                5,
            };

            CanSellByCredit = true;
            CreditSale = new List<float>() {
                50,
            };
        }
    }
}