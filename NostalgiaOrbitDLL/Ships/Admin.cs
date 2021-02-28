using NostalgiaOrbitDLL.Drones;
using System;
using System.Collections.Generic;

namespace NostalgiaOrbitDLL.Ships
{
    [Serializable]
    public class Admin : AbstractShip
    {
        public static Admin Instance { get; } = new Admin();
        public Admin()
        {
            ShipType = PrefabTypes.Admin;

            Hitpoints = 50000000;
            Speed = 1500;

            LaserSlots = 100;
            ShieldAndGearSlots = 30;
            ExtrasSlots = 20;

            CargoSize = 100000;

            Reward = new Reward()
            {
                Experience = 1638400,
                Honor = 16384,
                Resources = new Dictionary<ResourceTypes, float>()
                {
                    { ResourceTypes.Credits, 10000000 },
                    { ResourceTypes.Uridium, 10000 },
                },
            };

            ExperiencePerKill = new List<DroneExperience>()
            {
                new DroneExperience(PrefabTypes.Phoenix_type,   10),
                new DroneExperience(PrefabTypes.Yamato_type,    20),
                new DroneExperience(PrefabTypes.Leonov_type,    30),
                new DroneExperience(PrefabTypes.Defcom_type,    40),
                new DroneExperience(PrefabTypes.Liberator_type, 50),
                new DroneExperience(PrefabTypes.Piranha_type,   60),
                new DroneExperience(PrefabTypes.Nostromo_type,  70),
                new DroneExperience(PrefabTypes.Vengeance_type, 80),
                new DroneExperience(PrefabTypes.Bigboy_type,    90),
                new DroneExperience(PrefabTypes.Goliath_type,   100),
            };
        }
    }
}