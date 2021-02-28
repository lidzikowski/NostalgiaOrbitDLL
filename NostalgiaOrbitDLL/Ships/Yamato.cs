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
            ShipType = PrefabTypes.Yamato_type;
            ItemShopType = ItemShopTypes.Yamato;

            Hitpoints = 8000;
            Speed = 240;

            LaserSlots = 2;
            ShieldAndGearSlots = 2;
            ExtrasSlots = 1;

            CargoSize = 200;

            CanBuyByCredit = true;
            CreditPurchase = new List<float>()
            {
                16000
            };

            Reward = new Reward()
            {
                Experience = 200,
                Honor = 2,
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