using NostalgiaOrbitDLL.Drones;
using System;
using System.Collections.Generic;

namespace NostalgiaOrbitDLL.Ships
{
    [Serializable]
    public class Phoenix : AbstractShip
    {
        public static Phoenix Instance { get; } = new Phoenix();
        public Phoenix()
        {
            ShipType = PrefabTypes.phoenix_type;

            Hitpoints = 4000;
            Speed = 320;

            LaserSlots = 1;
            ShieldAndGearSlots = 1;
            ExtrasSlots = 1;

            CargoSize = 200;

            CanBuyByCredit = true;
            CreditPurchase = new List<float>(0);

            Reward = new Reward()
            {
                Experience = 100,
            };

            ExperiencePerKill = new List<DroneExperience>()
            {
                new DroneExperience(PrefabTypes.phoenix_type,   10),
                new DroneExperience(PrefabTypes.yamato_type,    10),
                new DroneExperience(PrefabTypes.leonov_type,    10),
                new DroneExperience(PrefabTypes.defcom_type,    10),
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