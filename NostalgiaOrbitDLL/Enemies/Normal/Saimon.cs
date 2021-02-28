using NostalgiaOrbitDLL.Drones;
using System;
using System.Collections.Generic;

namespace NostalgiaOrbitDLL.Enemies
{
    [Serializable]
    public class Saimon : AbstractEnemy
    {
        public static Saimon Instance { get; } = new Saimon();
        public Saimon()
        {
            EnemyType = PrefabTypes.Saimon;

            Hitpoints = 6000;

            Shields = 3000;

            Speed = 320;

            Aggresive = true;

            LaserDamage = 190;
            LaserPrefab = ResourceTypes.ShotSaimon;

            ShotRange = 500;

            Reward = new Reward()
            {
                Experience = 1600,
                Honor = 8,
                Resources = new Dictionary<ResourceTypes, float>()
                {
                    { ResourceTypes.Credits, 1600 },
                    { ResourceTypes.Uridium, 4 },
                },
            };

            Cargo = new List<Cargo>()
            {
                new Cargo(ResourceTypes.Prometium, 40),
                new Cargo(ResourceTypes.Endurium, 40),
                new Cargo(ResourceTypes.Terbium, 40),
                
                new Cargo(ResourceTypes.Prometid, 2),
                new Cargo(ResourceTypes.Duranium, 2),
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