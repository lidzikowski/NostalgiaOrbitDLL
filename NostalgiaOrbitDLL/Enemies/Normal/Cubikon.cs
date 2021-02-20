using NostalgiaOrbitDLL.Drones;
using System;
using System.Collections.Generic;

namespace NostalgiaOrbitDLL.Enemies
{
    [Serializable]
    public class Cubikon : AbstractEnemy
    {
        public static Cubikon Instance { get; } = new Cubikon();
        public Cubikon()
        {
            EnemyType = PrefabTypes.Cubikon;

            Hitpoints = 1600000;

            Shields = 1200000;

            Speed = 30;

            Reward = new Reward()
            {
                Experience = 204800,
                Honor = 1024,
                Resources = new Dictionary<ResourceTypes, float>()
                {
                    { ResourceTypes.Credits, 1638400 },
                    { ResourceTypes.Uridium, 512 },
                },
            };

            Cargo = new List<Cargo>()
            {
                new Cargo(ResourceTypes.Prometium, 1200),
                new Cargo(ResourceTypes.Endurium, 1200),
                new Cargo(ResourceTypes.Terbium, 1200),

                new Cargo(ResourceTypes.Prometid, 512),
                new Cargo(ResourceTypes.Duranium, 512),

                new Cargo(ResourceTypes.Promerium, 128),

                new Cargo(ResourceTypes.Xenomit, 64),
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