using NostalgiaOrbitDLL.Drones;
using System;
using System.Collections.Generic;

namespace NostalgiaOrbitDLL.Enemies
{
    [Serializable]
    public class Devolarium : AbstractEnemy
    {
        public static Devolarium Instance { get; } = new Devolarium();
        public Devolarium()
        {
            EnemyType = PrefabTypes.Devolarium;

            Hitpoints = 100000;

            Shields = 100000;

            Speed = 200;

            Aggresive = true;

            LaserDamage = 1200;
            LaserPrefab = ResourceTypes.ShotDevolarium;

            ShotRange = 530;

            Reward = new Reward()
            {
                Experience = 6400,
                Honor = 32,
                Resources = new Dictionary<ResourceTypes, float>()
                {
                    { ResourceTypes.Credits, 51200 },
                    { ResourceTypes.Uridium, 16 },
                },
            };

            Cargo = new List<Cargo>()
            {
                new Cargo(ResourceTypes.Prometium, 100),
                new Cargo(ResourceTypes.Endurium, 100),
                new Cargo(ResourceTypes.Terbium, 100),
                
                new Cargo(ResourceTypes.Prometid, 16),
                new Cargo(ResourceTypes.Duranium, 16),

                new Cargo(ResourceTypes.Promerium, 2),
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