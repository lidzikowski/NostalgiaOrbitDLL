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