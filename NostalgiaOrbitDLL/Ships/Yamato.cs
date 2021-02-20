using NostalgiaOrbitDLL.Drones;
using System;
using System.Collections.Generic;

namespace NostalgiaOrbitDLL.Ships
{
    [Serializable]
    public class Yamato : AbstractShip
    {
        public static Yamato Instance { get; } = new Yamato();
        public Yamato()
        {
            ShipType = PrefabTypes.yamato_type;

            Hitpoints = 8000;
            Speed = 240;

            LaserSlots = 2;
            ShieldAndGearSlots = 2;
            ExtrasSlots = 1;

            CargoSize = 200;

            CanBuyByCredit = true;
            CreditPurchase = new List<int>(16000);

            Reward = new Reward()
            {
                Experience = 200,
                Honor = 2,
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