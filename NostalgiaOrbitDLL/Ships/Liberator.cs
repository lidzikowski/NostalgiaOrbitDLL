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
            ShipType = PrefabTypes.Liberator_type;
            ItemShopType = ItemShopTypes.Liberator;

            Hitpoints = 16000;
            Speed = 300;

            LaserSlots = 4;
            ShieldAndGearSlots = 6;
            ExtrasSlots = 2;

            CargoSize = 400;

            CanBuyByCredit = true;
            CreditPurchase = new List<float>()
            {
                64000
            };

            Reward = new Reward()
            {
                Experience = 1600,
                Honor = 16,
            };

            ExperiencePerKill = new List<DroneExperience>()
            {
                new DroneExperience(PrefabTypes.Phoenix_type,   2),
                new DroneExperience(PrefabTypes.Yamato_type,    4),
                new DroneExperience(PrefabTypes.Leonov_type,    6),
                new DroneExperience(PrefabTypes.Defcom_type,    8),
                new DroneExperience(PrefabTypes.Liberator_type, 10),
                new DroneExperience(PrefabTypes.Piranha_type,   10),
                new DroneExperience(PrefabTypes.Nostromo_type,  10),
                new DroneExperience(PrefabTypes.Vengeance_type, 20),
                new DroneExperience(PrefabTypes.Bigboy_type,    20),
                new DroneExperience(PrefabTypes.Goliath_type,   25),
            };
        }
    }
}