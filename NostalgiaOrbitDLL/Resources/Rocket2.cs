using System;
using System.Collections.Generic;

namespace NostalgiaOrbitDLL.Resources
{
    [Serializable]
    public class Rocket2 : AbstractResource
    {
        public static Rocket2 Instance { get; } = new Rocket2();
        public Rocket2()
        {
            ResourceType = ResourceTypes.Rocket2;

            ShotProbability = 80;

            Damage = 2000;

            CanBuyByCredit = true;
            CreditPurchase = new List<float>() {
                500,
            };

            CanSellByCredit = true;
            CreditSale = new List<float>() {
                50,
            };
        }
    }
}