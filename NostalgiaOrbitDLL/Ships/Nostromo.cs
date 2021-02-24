using NostalgiaOrbitDLL.Drones;
using System;
using System.Collections.Generic;

namespace NostalgiaOrbitDLL.Ships
{
    [Serializable]
    public class Nostromo : AbstractShip
    {
        public static Nostromo Instance { get; } = new Nostromo();
        public Nostromo()
        {
            ShipType = PrefabTypes.nostromo_type;
            ItemShopType = ItemShopTypes.Nostromo;

            Hitpoints = 64000;
            Speed = 340;

            LaserSlots = 6;
            ShieldAndGearSlots = 8;
            ExtrasSlots = 2;

            CargoSize = 600;

            CanBuyByCredit = true;
            CreditPurchase = new List<float>()
            {
                100000
            };

            Reward = new Reward()
            {
                Experience = 6400,
                Honor = 64,
            };

            ExperiencePerKill = new List<DroneExperience>()
            {
                new DroneExperience(PrefabTypes.phoenix_type,   0),
                new DroneExperience(PrefabTypes.yamato_type,    1),
                new DroneExperience(PrefabTypes.leonov_type,    2),
                new DroneExperience(PrefabTypes.defcom_type,    4),
                new DroneExperience(PrefabTypes.liberator_type, 6),
                new DroneExperience(PrefabTypes.piranha_type,   8),
                new DroneExperience(PrefabTypes.nostromo_type,  10),
                new DroneExperience(PrefabTypes.vengeance_type, 20),
                new DroneExperience(PrefabTypes.bigboy_type,    20),
                new DroneExperience(PrefabTypes.goliath_type,   25),
            };
        }
    }
}