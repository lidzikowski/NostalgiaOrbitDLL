using NostalgiaOrbitDLL.Drones;
using System;
using System.Collections.Generic;

namespace NostalgiaOrbitDLL.Enemies
{
    [Serializable]
    public class Lordakia : AbstractEnemy
    {
        public static Lordakia Instance { get; } = new Lordakia();
        public Lordakia()
        {
            EnemyType = PrefabTypes.Lordakia;

            Hitpoints = 2000;

            Shields = 2000;

            Speed = 320;

            Aggresive = true;

            LaserDamage = 80;
            LaserPrefab = ResourceTypes.ShotLordakia;

            ShotRange = 450;

            Reward = new Reward()
            {
                Experience = 800,
                Honor = 4,
                Resources = new Dictionary<ResourceTypes, float>()
                {
                    { ResourceTypes.Credits, 800 },
                    { ResourceTypes.Uridium, 2 },
                },
            };

            Cargo = new List<Cargo>()
            {
                new Cargo(ResourceTypes.Prometium, 20),
                new Cargo(ResourceTypes.Endurium, 20),
                new Cargo(ResourceTypes.Terbium, 20),
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