using System;
using System.Collections.Generic;

namespace NostalgiaOrbitDLL.Drones
{
    [Serializable]
    public class Iris : AbstractDrone
    {
        public static Iris Instance { get; } = new Iris();

        public Iris()
        {
            DroneType = DroneTypes.Iris;
            ItemShopType = ItemShopTypes.Iris;

            LaserOrShieldSlots = 2;

            CanBuyByCredit = true;
            CreditPurchase = new List<float>() {
                15000,
                24000,
                42000,
                60000,
                84000,
                96000,
                126000,
                200000,
            };

            CanSellByCredit = true;
            CreditSale = new List<float>() {
                37500,
                60000,
                105000,
                150000,
                210000,
                240000,
                315000,
                500000,
            };

            MaxDronesType = 8;
            CombineWithDrone = DroneTypes.Flax;

            SurviveDestructions = 60;
        }
    }
}