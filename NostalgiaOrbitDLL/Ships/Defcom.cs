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
            ShipType = PrefabTypes.Defcom_type;
            ItemShopType = ItemShopTypes.Defcom;

            Hitpoints = 12000;
            Speed = 280;

            LaserSlots = 3;
            ShieldAndGearSlots = 5;
            ExtrasSlots = 2;

            CargoSize = 300;

            CanBuyByCredit = true;
            CreditPurchase = new List<float>()
            {
                32000
            };

            Reward = new Reward()
            {
                Experience = 800,
                Honor = 8,
            };

            ExperiencePerKill = new List<DroneExperience>()
            {
                new DroneExperience(PrefabTypes.Phoenix_type,   4),
                new DroneExperience(PrefabTypes.Yamato_type,    6),
                new DroneExperience(PrefabTypes.Leonov_type,    8),
                new DroneExperience(PrefabTypes.Defcom_type,    10),
                new DroneExperience(PrefabTypes.Liberator_type, 10),
                new DroneExperience(PrefabTypes.Piranha_type,   10),
                new DroneExperience(PrefabTypes.Nostromo_type,  10),
                new DroneExperience(PrefabTypes.Vengeance_type,  20),
                new DroneExperience(PrefabTypes.Bigboy_type,    20),
                new DroneExperience(PrefabTypes.Goliath_type,   25),
            };
        }
    }
}