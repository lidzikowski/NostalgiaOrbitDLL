using NostalgiaOrbitDLL.Drones;
using System;
using System.Collections.Generic;

namespace NostalgiaOrbitDLL.Ships
{
    [Serializable]
    public class Piranha : AbstractShip
    {
        public static Piranha Instance { get; } = new Piranha();
        public Piranha()
        {
            ShipType = PrefabTypes.piranha_type;

            Hitpoints = 32000;
            Speed = 320;

            LaserSlots = 5;
            ShieldAndGearSlots = 7;
            ExtrasSlots = 2;

            CargoSize = 500;

            CanBuyByCredit = true;
            CreditPurchase = new List<int>(80000);

            Reward = new Reward()
            {
                Experience = 3200,
                Honor = 32,
            };

            ExperiencePerKill = new List<DroneExperience>()
            {
                new DroneExperience(PrefabTypes.phoenix_type,   1),
                new DroneExperience(PrefabTypes.yamato_type,    2),
                new DroneExperience(PrefabTypes.leonov_type,    4),
                new DroneExperience(PrefabTypes.defcom_type,    6),
                new DroneExperience(PrefabTypes.liberator_type, 8),
                new DroneExperience(PrefabTypes.piranha_type,   10),
                new DroneExperience(PrefabTypes.nostromo_type,  10),
                new DroneExperience(PrefabTypes.vengeance_type, 20),
                new DroneExperience(PrefabTypes.bigboy_type,    20),
                new DroneExperience(PrefabTypes.goliath_type,   25),
            };
        }
    }
}