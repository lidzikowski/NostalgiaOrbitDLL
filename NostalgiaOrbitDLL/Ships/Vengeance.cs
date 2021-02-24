using NostalgiaOrbitDLL.Drones;
using System;
using System.Collections.Generic;

namespace NostalgiaOrbitDLL.Ships
{
    [Serializable]
    public class Vengeance : AbstractShip
    {
        public static Vengeance Instance { get; } = new Vengeance();
        public Vengeance()
        {
            ShipType = PrefabTypes.vengeance_type;
            ItemShopType = ItemShopTypes.Vengeance;

            Hitpoints = 180000;
            Speed = 360;

            LaserSlots = 10;
            ShieldAndGearSlots = 10;
            ExtrasSlots = 2;

            CargoSize = 1000;

            CanBuyUridium = true;
            UridiumPurchase = new List<float>()
            {
                30000
            };

            Reward = new Reward()
            {
                Experience = 12800,
                Honor = 128,
            };

            ExperiencePerKill = new List<DroneExperience>()
            {
                new DroneExperience(PrefabTypes.phoenix_type,   0),
                new DroneExperience(PrefabTypes.yamato_type,    0),
                new DroneExperience(PrefabTypes.leonov_type,    1),
                new DroneExperience(PrefabTypes.defcom_type,    2),
                new DroneExperience(PrefabTypes.liberator_type, 4),
                new DroneExperience(PrefabTypes.piranha_type,   6),
                new DroneExperience(PrefabTypes.nostromo_type,  8),
                new DroneExperience(PrefabTypes.vengeance_type, 20),
                new DroneExperience(PrefabTypes.bigboy_type,    20),
                new DroneExperience(PrefabTypes.goliath_type,   25),
            };

            CanBuyOnAuctionHouse = true;
        }
    }
}