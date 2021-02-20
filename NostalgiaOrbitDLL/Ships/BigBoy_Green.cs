using NostalgiaOrbitDLL.Drones;
using System;
using System.Collections.Generic;

namespace NostalgiaOrbitDLL.Ships
{
    [Serializable]
    public class BigBoy_Green : AbstractShip
    {
        public static BigBoy_Green Instance { get; } = new BigBoy_Green();
        public BigBoy_Green()
        {
            ShipType = PrefabTypes.bigboy_green_type;

            Hitpoints = 128000;

            Speed = 260;

            LaserSlots = 7;
            ShieldAndGearSlots = 15;
            ExtrasSlots = 3;

            CargoSize = 700;

            CanBuyByCredit = true;
            CreditPurchase = new List<float>(200000);

            Reward = new Reward()
            {
                Experience = 25600,
                Honor = 256,
            };

            ExperiencePerKill = new List<DroneExperience>()
            {
                new DroneExperience(PrefabTypes.phoenix_type,   0),
                new DroneExperience(PrefabTypes.yamato_type,    0),
                new DroneExperience(PrefabTypes.leonov_type,    0),
                new DroneExperience(PrefabTypes.defcom_type,    1),
                new DroneExperience(PrefabTypes.liberator_type, 2),
                new DroneExperience(PrefabTypes.piranha_type,   4),
                new DroneExperience(PrefabTypes.nostromo_type,  6),
                new DroneExperience(PrefabTypes.vengeance_type, 8),
                new DroneExperience(PrefabTypes.bigboy_type,    20),
                new DroneExperience(PrefabTypes.goliath_type,   25),
            };
        }
    }
}