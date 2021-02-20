using NostalgiaOrbitDLL.Drones;
using System;
using System.Collections.Generic;

namespace NostalgiaOrbitDLL.Ships
{
    [Serializable]
    public class Defcom : AbstractShip
    {
        public static Defcom Instance { get; } = new Defcom();
        public Defcom()
        {
            ShipType = PrefabTypes.defcom_type;

            Hitpoints = 12000;
            Speed = 280;

            LaserSlots = 3;
            ShieldAndGearSlots = 5;
            ExtrasSlots = 2;

            CargoSize = 300;

            CanBuyByCredit = true;
            CreditPurchase = new List<float>(32000);

            Reward = new Reward()
            {
                Experience = 800,
                Honor = 8,
            };

            ExperiencePerKill = new List<DroneExperience>()
            {
                new DroneExperience(PrefabTypes.phoenix_type,   4),
                new DroneExperience(PrefabTypes.yamato_type,    6),
                new DroneExperience(PrefabTypes.leonov_type,    8),
                new DroneExperience(PrefabTypes.defcom_type,    10),
                new DroneExperience(PrefabTypes.liberator_type, 10),
                new DroneExperience(PrefabTypes.piranha_type,   10),
                new DroneExperience(PrefabTypes.nostromo_type,  10),
                new DroneExperience(PrefabTypes.vengeance_type,  20),
                new DroneExperience(PrefabTypes.bigboy_type,    20),
                new DroneExperience(PrefabTypes.goliath_type,   25),
            };
        }
    }
}