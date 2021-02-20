using NostalgiaOrbitDLL.Drones;
using System;
using System.Collections.Generic;

namespace NostalgiaOrbitDLL.Enemies
{
    [Serializable]
    public class Mordon : AbstractEnemy
    {
        public static Mordon Instance { get; } = new Mordon();
        public Mordon()
        {
            EnemyType = PrefabTypes.Mordon;

            Hitpoints = 20000;

            Shields = 10000;

            Speed = 125;

            Aggresive = true;

            LaserDamage = 390;
            LaserPrefab = ResourceTypes.ShotMordon;

            ShotRange = 500;

            Reward = new Reward()
            {
                Experience = 3200,
                Honor = 16,
                Resources = new Dictionary<ResourceTypes, float>()
                {
                    { ResourceTypes.Credits, 6400 },
                    { ResourceTypes.Uridium, 8 },
                },
            };

            Cargo = new List<Cargo>()
            {
                new Cargo(ResourceTypes.Prometium, 80),
                new Cargo(ResourceTypes.Endurium, 80),
                new Cargo(ResourceTypes.Terbium, 80),
                
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