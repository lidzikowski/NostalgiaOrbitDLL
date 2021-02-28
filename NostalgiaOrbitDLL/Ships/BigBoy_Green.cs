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
            ShipType = PrefabTypes.Bigboy_green_type;

            Hitpoints = 128000;

            Speed = 260;

            LaserSlots = 7;
            ShieldAndGearSlots = 15;
            ExtrasSlots = 3;

            CargoSize = 700;

            CanBuyByCredit = true;
            CreditPurchase = new List<float>()
            {
                200000
            };

            Reward = new Reward()
            {
                Experience = 25600,
                Honor = 256,
            };

            ExperiencePerKill = new List<DroneExperience>()
            {
                new DroneExperience(PrefabTypes.Phoenix_type,   0),
                new DroneExperience(PrefabTypes.Yamato_type,    0),
                new DroneExperience(PrefabTypes.Leonov_type,    0),
                new DroneExperience(PrefabTypes.Defcom_type,    1),
                new DroneExperience(PrefabTypes.Liberator_type, 2),
                new DroneExperience(PrefabTypes.Piranha_type,   4),
                new DroneExperience(PrefabTypes.Nostromo_type,  6),
                new DroneExperience(PrefabTypes.Vengeance_type, 8),
                new DroneExperience(PrefabTypes.Bigboy_type,    20),
                new DroneExperience(PrefabTypes.Goliath_type,   25),
            };
        }
    }
}