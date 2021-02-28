using NostalgiaOrbitDLL.Drones;
using System;
using System.Collections.Generic;

namespace NostalgiaOrbitDLL.Enemies
{
    [Serializable]
    public class Sibelon : AbstractEnemy
    {
        public static Sibelon Instance { get; } = new Sibelon();
        public Sibelon()
        {
            EnemyType = PrefabTypes.Sibelon;

            Hitpoints = 200000;

            Shields = 200000;

            Speed = 100;

            Aggresive = true;

            LaserDamage = 2650;
            LaserPrefab = ResourceTypes.ShotSibelon;

            ShotRange = 530;

            Reward = new Reward()
            {
                Experience = 12800,
                Honor = 64,
                Resources = new Dictionary<ResourceTypes, float>()
                {
                    { ResourceTypes.Credits, 102400 },
                    { ResourceTypes.Uridium, 32 },
                },
            };

            Cargo = new List<Cargo>()
            {
                new Cargo(ResourceTypes.Prometium, 200),
                new Cargo(ResourceTypes.Endurium, 200),
                new Cargo(ResourceTypes.Terbium, 200),
                
                new Cargo(ResourceTypes.Prometid, 32),
                new Cargo(ResourceTypes.Duranium, 32),

                new Cargo(ResourceTypes.Promerium, 4),
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