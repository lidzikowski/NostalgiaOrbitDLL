﻿using System;
using System.Collections.Generic;

namespace NostalgiaOrbitDLL.Drones
{
    [Serializable]
    public class Flax : AbstractDrone
    {
        public static Flax Instance { get; } = new Flax();

        public Flax()
        {
            DroneType = DroneTypes.Flax;

            LaserOrShieldSlots = 1;

            CanBuyByCredit = true;
            CreditPurchase = new List<int>() {
                100000,
                200000,
                400000,
                800000,
                1600000,
                3200000,
                6400000,
                12800000,
            };

            CanSellByCredit = true;
            CreditSale = new List<int>() {
                50000,
                100000,
                200000,
                400000,
                800000,
                1600000,
                3200000,
                6400000,
            };

            MaxDronesType = 8;
            CombineWithDrone = DroneTypes.Iris;

            SurviveDestructions = 40;
        }
    }
}