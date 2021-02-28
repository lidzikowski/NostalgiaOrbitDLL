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

            CanBuyUridium = true;
            UridiumPurchase = new List<float>() {
                15000,  //1
                24000,  //2
                42000,  //3
                60000,  //4
                84000,  //5
                96000,  //6
                126000, //7
                200000, //8
            };

            CanSellByCredit = true;
            CreditSale = new List<float>() {
                37500,  //1
                60000,  //2
                105000, //3
                150000, //4
                210000, //5
                240000, //6
                315000, //7
                500000, //8
            };

            MaxDronesType = 8;
            CombineWithDrone = DroneTypes.Flax;

            CanBuyOnAuctionHouse = true;

            SurviveDestructions = 60;
        }
    }
}