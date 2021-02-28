using NostalgiaOrbitDLL.Drones;
using System;
using System.Collections.Generic;

namespace NostalgiaOrbitDLL.Enemies
{
    [Serializable]
    public class Streuner : AbstractEnemy
    {
        public static Streuner Instance { get; } = new Streuner();
        public Streuner()
        {
            EnemyType = PrefabTypes.Streuner;

            Hitpoints = 800;

            Shields = 400;

            Speed = 270;

            Aggresive = true;

            LaserDamage = 20;
            LaserPrefab = ResourceTypes.Ammunition1;

            UseRocket = true;
            RocketDamage = 200;
            RocketDelay = 5;
            RocketPrefab = ResourceTypes.Rocket1;

            ShotRange = 450;

            Reward = new Reward()
            {
                Experience = 400,
                Honor = 2,
                Resources = new Dictionary<ResourceTypes, float>()
                {
                    { ResourceTypes.Credits, 400 },
                    { ResourceTypes.Uridium, 1 },
                },
            };

            Cargo = new List<Cargo>()
            {
                new Cargo(ResourceTypes.Prometium, 10),
                new Cargo(ResourceTypes.Endurium, 10),
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