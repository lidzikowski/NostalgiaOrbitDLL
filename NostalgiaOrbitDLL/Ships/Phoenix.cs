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
            ShipType = PrefabTypes.Phoenix_type;
            ItemShopType = ItemShopTypes.Phoenix;

            Hitpoints = 4000;
            Speed = 320;

            LaserSlots = 1;
            ShieldAndGearSlots = 1;
            ExtrasSlots = 1;

            CargoSize = 200;

            CanBuyByCredit = true;
            CreditPurchase = new List<float>()
            {
                0
            };

            Reward = new Reward()
            {
                Experience = 100,
            };

            ExperiencePerKill = new List<DroneExperience>()
            {
                new DroneExperience(PrefabTypes.Phoenix_type,   10),
                new DroneExperience(PrefabTypes.Yamato_type,    10),
                new DroneExperience(PrefabTypes.Leonov_type,    10),
                new DroneExperience(PrefabTypes.Defcom_type,    10),
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