using NostalgiaOrbitDLL.Drones;
using System;
using System.Collections.Generic;

namespace NostalgiaOrbitDLL.Ships
{
    [Serializable]
    public class Goliath_Red : AbstractShip
    {
        public static Goliath_Red Instance { get; } = new Goliath_Red();
        public Goliath_Red()
        {
            ShipType = PrefabTypes.Goliath_red_type;

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
                new DroneExperience(PrefabTypes.Phoenix_type,   0),
                new DroneExperience(PrefabTypes.Yamato_type,    0),
                new DroneExperience(PrefabTypes.Leonov_type,    0),
                new DroneExperience(PrefabTypes.Defcom_type,    0),
                new DroneExperience(PrefabTypes.Liberator_type, 1),
                new DroneExperience(PrefabTypes.Piranha_type,   2),
                new DroneExperience(PrefabTypes.Nostromo_type,  4),
                new DroneExperience(PrefabTypes.Vengeance_type, 6),
                new DroneExperience(PrefabTypes.Bigboy_type,    8),
                new DroneExperience(PrefabTypes.Goliath_type,   25),
            };

            CanBuyOnAuctionHouse = true;
        }
    }
}