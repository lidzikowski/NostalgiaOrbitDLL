using NostalgiaOrbitDLL.Drones;
using System;
using System.Collections.Generic;

namespace NostalgiaOrbitDLL.Enemies
{
    [Serializable]
    public class Protegit : AbstractEnemy
    {
        public static Protegit Instance { get; } = new Protegit();
        public Protegit()
        {
            EnemyType = PrefabTypes.Protegit;

            Hitpoints = 50000;

            Shields = 40000;

            Speed = 420;

            Aggresive = true;

            LaserDamage = 1400;
            LaserPrefab = ResourceTypes.ShotProtegit;

            ShotRange = 525;

            Reward = new Reward()
            {
                Experience = 6400,
                Honor = 32,
                Resources = new Dictionary<ResourceTypes, float>()
                {
                    { ResourceTypes.Credits, 12800 },
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