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
            ShipType = PrefabTypes.Piranha_type;
            ItemShopType = ItemShopTypes.Piranha;

            Hitpoints = 32000;
            Speed = 320;

            LaserSlots = 5;
            ShieldAndGearSlots = 7;
            ExtrasSlots = 2;

            CargoSize = 500;

            CanBuyByCredit = true;
            CreditPurchase = new List<float>()
            {
                80000
            };

            Reward = new Reward()
            {
                Experience = 3200,
                Honor = 32,
            };

            ExperiencePerKill = new List<DroneExperience>()
            {
                new DroneExperience(PrefabTypes.Phoenix_type,   1),
                new DroneExperience(PrefabTypes.Yamato_type,    2),
                new DroneExperience(PrefabTypes.Leonov_type,    4),
                new DroneExperience(PrefabTypes.Defcom_type,    6),
                new DroneExperience(PrefabTypes.Liberator_type, 8),
                new DroneExperience(PrefabTypes.Piranha_type,   10),
                new DroneExperience(PrefabTypes.Nostromo_type,  10),
                new DroneExperience(PrefabTypes.Vengeance_type, 20),
                new DroneExperience(PrefabTypes.Bigboy_type,    20),
                new DroneExperience(PrefabTypes.Goliath_type,   25),
            };
        }
    }
}