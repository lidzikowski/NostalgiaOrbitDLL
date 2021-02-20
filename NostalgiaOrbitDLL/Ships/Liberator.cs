using NostalgiaOrbitDLL.Drones;
using System;
using System.Collections.Generic;

namespace NostalgiaOrbitDLL.Ships
{
    [Serializable]
    public class Liberator : AbstractShip
    {
        public static Liberator Instance { get; } = new Liberator();
        public Liberator()
        {
            ShipType = PrefabTypes.liberator_type;

            Hitpoints = 16000;
            Speed = 300;

            LaserSlots = 4;
            ShieldAndGearSlots = 6;
            ExtrasSlots = 2;

            CargoSize = 400;

            CanBuyByCredit = true;
            CreditPurchase = new List<int>(64000);

            Reward = new Reward()
            {
                Experience = 1600,
                Honor = 16,
            };

            ExperiencePerKill = new List<DroneExperience>()
            {
                new DroneExperience(PrefabTypes.phoenix_type,   2),
                new DroneExperience(PrefabTypes.yamato_type,    4),
                new DroneExperience(PrefabTypes.leonov_type,    6),
                new DroneExperience(PrefabTypes.defcom_type,    8),
                new DroneExperience(PrefabTypes.liberator_type, 10),
                new DroneExperience(PrefabTypes.piranha_type,   10),
                new DroneExperience(PrefabTypes.nostromo_type,  10),
                new DroneExperience(PrefabTypes.vengeance_type, 20),
                new DroneExperience(PrefabTypes.bigboy_type,    20),
                new DroneExperience(PrefabTypes.goliath_type,   25),
            };
        }
    }
}