﻿using NostalgiaOrbitDLL.Drones;
using System;
using System.Collections.Generic;

namespace NostalgiaOrbitDLL.Ships
{
    [Serializable]
    public class Leonov : AbstractShip
    {
        public static Leonov Instance { get; } = new Leonov();
        public Leonov()
        {
            ShipType = PrefabTypes.Leonov_type;
            ItemShopType = ItemShopTypes.Leonov;

            Hitpoints = 64000;
            Speed = 360;

            LaserSlots = 6;
            ShieldAndGearSlots = 6;
            ExtrasSlots = 1;

            CargoSize = 500;

            CanBuyUridium = true;
            UridiumPurchase = new List<float>()
            {
                9000
            };

            Reward = new Reward()
            {
                Experience = 400,
                Honor = 4,
            };

            Bonus_Statistics = true;
            Bonus_WorkOnlyFirmMap = true;
            Bonus_Maps = new List<MapTypes>() {
                MapTypes.MMO_1_1,
                MapTypes.MMO_1_2,
                MapTypes.MMO_1_3,
                MapTypes.MMO_1_4,

                MapTypes.EIC_2_1,
                MapTypes.EIC_2_2,
                MapTypes.EIC_2_3,
                MapTypes.EIC_2_4,

                MapTypes.VRU_3_1,
                MapTypes.VRU_3_2,
                MapTypes.VRU_3_3,
                MapTypes.VRU_3_4,
            };
            Bonus_LasersDamageMultiplyInShip = 2;
            Bonus_ShieldMultiplyInShip = 2;
            Bonus_Hitpoints = 96000;
            Bonus_Speed = 20;
            Bonus_CargoSize = 500;

            ExperiencePerKill = new List<DroneExperience>()
            {
                new DroneExperience(PrefabTypes.Phoenix_type,   6),
                new DroneExperience(PrefabTypes.Yamato_type,    8),
                new DroneExperience(PrefabTypes.Leonov_type,    10),
                new DroneExperience(PrefabTypes.Defcom_type,    10),
                new DroneExperience(PrefabTypes.Liberator_type, 10),
                new DroneExperience(PrefabTypes.Piranha_type,   10),
                new DroneExperience(PrefabTypes.Nostromo_type,  10),
                new DroneExperience(PrefabTypes.Vengeance_type, 20),
                new DroneExperience(PrefabTypes.Bigboy_type,    20),
                new DroneExperience(PrefabTypes.Goliath_type,   25),
            };

            CanBuyOnAuctionHouse = true;
        }
    }
}