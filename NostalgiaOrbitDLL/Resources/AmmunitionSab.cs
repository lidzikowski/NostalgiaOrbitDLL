using System;
using System.Collections.Generic;

namespace NostalgiaOrbitDLL.Resources
{
    [Serializable]
    public class AmmunitionSab : AbstractResource
    {
        public static AmmunitionSab Instance { get; } = new AmmunitionSab();
        public AmmunitionSab()
        {
            ResourceType = ResourceTypes.AmmunitionSab;

            ShotProbability = 80;

            AmmunitionMultiplier = 2;
            ShotInOnlyShield = true;

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