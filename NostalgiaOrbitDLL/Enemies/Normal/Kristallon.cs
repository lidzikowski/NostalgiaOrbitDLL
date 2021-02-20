using NostalgiaOrbitDLL.Drones;
using System;
using System.Collections.Generic;

namespace NostalgiaOrbitDLL.Enemies
{
    [Serializable]
    public class Kristallon : AbstractEnemy
    {
        public static Kristallon Instance { get; } = new Kristallon();
        public Kristallon()
        {
            EnemyType = PrefabTypes.Kristallon;

            Hitpoints = 400000;

            Shields = 300000;

            Speed = 250;

            LaserDamage = 4450;
            LaserPrefab = ResourceTypes.ShotKristallon;

            ShotRange = 600;

            Reward = new Reward()
            {
                Experience = 51200,
                Honor = 256,
                Resources = new Dictionary<ResourceTypes, float>()
                {
                    { ResourceTypes.Credits, 409600 },
                    { ResourceTypes.Uridium, 128 },
                },
            };

            Cargo = new List<Cargo>()
            {
                new Cargo(ResourceTypes.Prometium, 300),
                new Cargo(ResourceTypes.Endurium, 300),
                new Cargo(ResourceTypes.Terbium, 300),

                new Cargo(ResourceTypes.Prometid, 128),
                new Cargo(ResourceTypes.Duranium, 128),

                new Cargo(ResourceTypes.Promerium, 16),
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