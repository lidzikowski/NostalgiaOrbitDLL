using NostalgiaOrbitDLL.Drones;
using System;
using System.Collections.Generic;

namespace NostalgiaOrbitDLL.Ships
{
    [Serializable]
    public class Goliath_Yellow : AbstractShip
    {
        public static Goliath_Yellow Instance { get; } = new Goliath_Yellow();
        public Goliath_Yellow()
        {
            ShipType = PrefabTypes.goliath_yellow_type;

            Hitpoints = 256000;
            Speed = 300;

            LaserSlots = 15;
            ShieldAndGearSlots = 15;
            ExtrasSlots = 3;

            CargoSize = 1500;

            CanBuyUridium = true;
            UridiumPurchase = new List<float>()
            {
                800000
            };

            Reward = new Reward()
            {
                Experience = 51200,
                Honor = 512,
            };

            ExperiencePerKill = new List<DroneExperience>()
            {
                new DroneExperience(PrefabTypes.phoenix_type,   0),
                new DroneExperience(PrefabTypes.yamato_type,    0),
                new DroneExperience(PrefabTypes.leonov_type,    0),
                new DroneExperience(PrefabTypes.defcom_type,    0),
                new DroneExperience(PrefabTypes.liberator_type, 1),
                new DroneExperience(PrefabTypes.piranha_type,   2),
                new DroneExperience(PrefabTypes.nostromo_type,  4),
                new DroneExperience(PrefabTypes.vengeance_type, 6),
                new DroneExperience(PrefabTypes.bigboy_type,    8),
                new DroneExperience(PrefabTypes.goliath_type,   25),
            };

            CanBuyOnAuctionHouse = true;
        }
    }
}