using NostalgiaOrbitDLL.Drones;
using System;
using System.Collections.Generic;

namespace NostalgiaOrbitDLL.Enemies
{
    [Serializable]
    public class Lordakium : AbstractEnemy
    {
        public static Lordakium Instance { get; } = new Lordakium();
        public Lordakium()
        {
            EnemyType = PrefabTypes.Lordakium;

            Hitpoints = 300000;

            Shields = 200000;

            Speed = 230;

            LaserDamage = 3500;
            LaserPrefab = ResourceTypes.ShotLordakium;

            ShotRange = 610;

            Reward = new Reward()
            {
                Experience = 25600,
                Honor = 128,
                Resources = new Dictionary<ResourceTypes, float>()
                {
                    { ResourceTypes.Credits, 204800 },
                    { ResourceTypes.Uridium, 64 },
                },
            };

            Cargo = new List<Cargo>()
            {
                new Cargo(ResourceTypes.Prometium, 200),
                new Cargo(ResourceTypes.Endurium, 200),
                new Cargo(ResourceTypes.Terbium, 200),
                
                new Cargo(ResourceTypes.Prometid, 64),
                new Cargo(ResourceTypes.Duranium, 64),

                new Cargo(ResourceTypes.Promerium, 8),
            };

            ExperiencePerKill = new List<DroneExperience>() // TODO
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