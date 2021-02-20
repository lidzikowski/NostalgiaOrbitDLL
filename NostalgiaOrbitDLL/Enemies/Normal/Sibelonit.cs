using NostalgiaOrbitDLL.Drones;
using System;
using System.Collections.Generic;

namespace NostalgiaOrbitDLL.Enemies
{
    [Serializable]
    public class Sibelonit : AbstractEnemy
    {
        public static Sibelonit Instance { get; } = new Sibelonit();
        public Sibelonit()
        {
            EnemyType = PrefabTypes.Sibelonit;

            Hitpoints = 40000;

            Shields = 40000;

            Speed = 320;

            Aggresive = true;

            LaserDamage = 1250;
            LaserPrefab = ResourceTypes.ShotSibelonit;

            ShotRange = 575;

            Reward = new Reward()
            {
                Experience = 3200,
                Honor = 16,
                Resources = new Dictionary<ResourceTypes, float>()
                {
                    { ResourceTypes.Credits, 12800 },
                    { ResourceTypes.Uridium, 12 },
                },
            };

            Cargo = new List<Cargo>()
            {
                new Cargo(ResourceTypes.Prometium, 100),
                new Cargo(ResourceTypes.Endurium, 100),
                new Cargo(ResourceTypes.Terbium, 100),
                
                new Cargo(ResourceTypes.Prometid, 8),
                new Cargo(ResourceTypes.Duranium, 8),

                new Cargo(ResourceTypes.Promerium, 1),
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