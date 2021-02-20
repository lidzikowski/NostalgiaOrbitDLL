using NostalgiaOrbitDLL.Core;
using NostalgiaOrbitDLL.Drones;
using System;
using System.Collections.Generic;
using System.Linq;

namespace NostalgiaOrbitDLL.Enemies
{
    [Serializable]
    public abstract class AbstractEnemy : IDroneLeveling
    {
        public PrefabTypes EnemyType { get; protected set; }

        public long Hitpoints { get; protected set; }
        public long Shields { get; protected set; }
        public int Speed { get; protected set; }
        public bool Aggresive { get; protected set; }

        public long LaserDamage { get; protected set; }
        public ResourceTypes LaserPrefab { get; protected set; }

        public bool UseRocket { get; protected set; }
        public long RocketDamage { get; protected set; }
        public int RocketDelay { get; protected set; }
        public ResourceTypes? RocketPrefab { get; protected set; }

        public int ShotRange { get; protected set; }
        public int ShieldAbsorption { get; protected set; } = 50;

        public Reward Reward { get; protected set; }
        public List<Cargo> Cargo { get; protected set; } = new List<Cargo>();

        public List<DroneExperience> ExperiencePerKill { get; protected set; }

        public void MakeUber(AbstractEnemy abstractEnemy, int multiply = 2, int shot_range = 15, int cargoMultiply = 2)
        {
            MakeBoss(abstractEnemy, multiply, shot_range, cargoMultiply);
        }
        public void MakeBoss(AbstractEnemy abstractEnemy, int multiply = 4, int shot_range = 15, int cargoMultiply = 4)
        {
            Hitpoints = abstractEnemy.Hitpoints * multiply;
            Shields = abstractEnemy.Shields * multiply;
            Speed = abstractEnemy.Speed;
            Aggresive = abstractEnemy.Aggresive;

            LaserDamage = abstractEnemy.LaserDamage * multiply;
            LaserPrefab = abstractEnemy.LaserPrefab;

            UseRocket = abstractEnemy.UseRocket;
            RocketDamage = abstractEnemy.RocketDamage * multiply;
            RocketDelay = abstractEnemy.RocketDelay;
            RocketPrefab = abstractEnemy.RocketPrefab;

            ShotRange = abstractEnemy.ShotRange + shot_range;
            ShieldAbsorption = abstractEnemy.ShieldAbsorption;

            Reward = new Reward()
            {
                Experience = abstractEnemy.Reward.Experience * multiply,
                Honor = abstractEnemy.Reward.Experience * multiply,
                Resources = abstractEnemy.Reward.Resources.ToDictionary(o => o.Key, o => o.Value * multiply),
                Items = MultiplyItems(abstractEnemy.Reward.Items, multiply),
            };

            Cargo = abstractEnemy.Cargo.Select(o => new Cargo(o.Resource, o.Quantity * cargoMultiply)).ToList();

            ExperiencePerKill = abstractEnemy.ExperiencePerKill;
        }
        private List<ItemTypes> MultiplyItems(List<ItemTypes> items, int multiply)
        {
            var result = new List<ItemTypes>();
            foreach (var item in items)
            {
                for (int i = 0; i < multiply; i++)
                {
                    result.Add(item);
                }
            }
            return result;
        }


        public static AbstractEnemy GetEnemyByType(PrefabTypes enemyType)
        {
            return enemyType switch
            {
                PrefabTypes.Streuner => Streuner.Instance,
                PrefabTypes.BossStreuner => BossStreuner.Instance,
                PrefabTypes.UberStreuner => UberStreuner.Instance,

                PrefabTypes.Lordakia => Lordakia.Instance,
                PrefabTypes.BossLordakia => BossLordakia.Instance,
                PrefabTypes.UberLordakia => UberLordakia.Instance,

                PrefabTypes.Saimon => Saimon.Instance,
                PrefabTypes.BossSaimon => BossSaimon.Instance,
                PrefabTypes.UberSaimon => UberSaimon.Instance,

                PrefabTypes.Mordon => Mordon.Instance,
                PrefabTypes.BossMordon => BossMordon.Instance,
                PrefabTypes.UberMordon => UberMordon.Instance,

                PrefabTypes.Devolarium => Devolarium.Instance,
                PrefabTypes.BossDevolarium => BossDevolarium.Instance,
                PrefabTypes.UberDevolarium => UberDevolarium.Instance,

                PrefabTypes.Sibelon => Sibelon.Instance,
                PrefabTypes.BossSibelon => BossSibelon.Instance,
                PrefabTypes.UberSibelon => UberSibelon.Instance,

                PrefabTypes.Sibelonit => Sibelonit.Instance,
                PrefabTypes.BossSibelonit => BossSibelonit.Instance,
                PrefabTypes.UberSibelonit => UberSibelonit.Instance,

                PrefabTypes.Lordakium => Lordakium.Instance,
                PrefabTypes.BossLordakium => BossLordakium.Instance,
                PrefabTypes.UberLordakium => UberLordakium.Instance,

                PrefabTypes.Kristallin => Kristallin.Instance,
                PrefabTypes.BossKristallin => BossKristallin.Instance,
                PrefabTypes.UberKristallin => UberKristallin.Instance,

                PrefabTypes.Kristallon => Kristallon.Instance,
                PrefabTypes.BossKristallon => BossKristallon.Instance,
                PrefabTypes.UberKristallon => UberKristallon.Instance,

                PrefabTypes.Cubikon => Cubikon.Instance,

                PrefabTypes.Protegit => Protegit.Instance,
                PrefabTypes.BossProtegit => BossProtegit.Instance,
                PrefabTypes.UberProtegit => UberProtegit.Instance,

                PrefabTypes.Streuner_2 => Streuner_2.Instance,
                PrefabTypes.BossStreuner_2 => BossStreuner_2.Instance,
                PrefabTypes.UberStreuner_2 => UberStreuner_2.Instance,

                //PrefabTypes.Cucurbium => Cucurbium.Instance,
                //PrefabTypes.BossCucurbium => BossCucurbium.Instance,

                //PrefabTypes.Demaner => Demaner.Instance,
                //PrefabTypes.BossDemaner => BossDemaner.Instance,

                //PrefabTypes.Ufo => Ufo.Instance,

                _ => throw new NotImplementedException(),
            };
        }

        private static Func<string, string> normal => (o) => $"-=[ {o} ]=-";
        private static Func<string, string> boss => (o) => $".::( {o} )::.";
        private static Func<string, string> uber => (o) => $"«¤( {o} )¤»";
        public static string GetEnemyName(PrefabTypes enemyType)
        {
            return enemyType switch
            {
                PrefabTypes.Streuner => normal("Streuner"),
                PrefabTypes.BossStreuner => boss("Boss Streuner"),
                PrefabTypes.UberStreuner => uber("Uber Streuner"),

                PrefabTypes.Lordakia => normal("Lordakia"),
                PrefabTypes.BossLordakia => boss("Boss Lordakia"),
                PrefabTypes.UberLordakia => uber("Uber Lordakia"),

                PrefabTypes.Saimon => normal("Saimon"),
                PrefabTypes.BossSaimon => boss("Boss Saimon"),
                PrefabTypes.UberSaimon => uber("Uber Saimon"),

                PrefabTypes.Mordon => normal("Mordon"),
                PrefabTypes.BossMordon => boss("Boss Mordon"),
                PrefabTypes.UberMordon => uber("Uber Mordon"),

                PrefabTypes.Devolarium => normal("Devolarium"),
                PrefabTypes.BossDevolarium => boss("Boss Devolarium"),
                PrefabTypes.UberDevolarium => uber("Uber Devolarium"),

                PrefabTypes.Sibelon => normal("Sibelon"),
                PrefabTypes.BossSibelon => boss("Boss Sibelon"),
                PrefabTypes.UberSibelon => uber("Uber Sibelon"),

                PrefabTypes.Sibelonit => normal("Sibelonit"),
                PrefabTypes.BossSibelonit => boss("Boss Sibelonit"),
                PrefabTypes.UberSibelonit => uber("Uber Sibelonit"),

                PrefabTypes.Lordakium => normal("Lordakium"),
                PrefabTypes.BossLordakium => boss("Boss Lordakium"),
                PrefabTypes.UberLordakium => uber("Uber Lordakium"),

                PrefabTypes.Kristallin => normal("Kristallin"),
                PrefabTypes.BossKristallin => boss("Boss Kristallin"),
                PrefabTypes.UberKristallin => uber("Uber Kristallin"),

                PrefabTypes.Kristallon => normal("Kristallon"),
                PrefabTypes.BossKristallon => boss("Boss Kristallon"),
                PrefabTypes.UberKristallon => uber("Uber Kristallon"),

                PrefabTypes.Cubikon => normal("Cubicon"),
                PrefabTypes.BossCubikon => boss("Boss Cubicon"),
                PrefabTypes.UberCubikon => uber("Uber Cubicon"),

                PrefabTypes.Protegit => normal("Protegit"),
                PrefabTypes.BossProtegit => boss("Boss Protegit"),
                PrefabTypes.UberProtegit => uber("Uber Protegit"),

                PrefabTypes.Streuner_2 => normal("StreuneR"),
                PrefabTypes.BossStreuner_2 => boss("Boss StreuneR"),
                PrefabTypes.UberStreuner_2 => uber("Uber StreuneR"),

                PrefabTypes.Cucurbium => normal("Cucurbium"),
                PrefabTypes.BossCucurbium => boss("Boss Cucurbium"),

                PrefabTypes.Demaner => normal("Demaner"),
                PrefabTypes.BossDemaner => boss("Boss Demaner"),

                PrefabTypes.Ufo => normal("Ufo"),

                _ => throw new NotImplementedException(),
            };
        }

        public static PrefabTypes GetEnemyPrefab(PrefabTypes enemyType)
        {
            if (DLLHelpers.IsPrefabType(PrefabTypes.streuner_type, enemyType))
            {
                return PrefabTypes.Streuner;
            }
            else if (DLLHelpers.IsPrefabType(PrefabTypes.lordakia_type, enemyType))
            {
                return PrefabTypes.Lordakia;
            }
            else if (DLLHelpers.IsPrefabType(PrefabTypes.saimon_type, enemyType))
            {
                return PrefabTypes.Saimon;
            }
            else if (DLLHelpers.IsPrefabType(PrefabTypes.mordon_type, enemyType))
            {
                return PrefabTypes.Mordon;
            }
            else if (DLLHelpers.IsPrefabType(PrefabTypes.devolarium_type, enemyType))
            {
                return PrefabTypes.Devolarium;
            }
            else if (DLLHelpers.IsPrefabType(PrefabTypes.sibelon_type, enemyType))
            {
                return PrefabTypes.Sibelon;
            }
            else if (DLLHelpers.IsPrefabType(PrefabTypes.sibelonit_type, enemyType))
            {
                return PrefabTypes.Sibelonit;
            }
            else if (DLLHelpers.IsPrefabType(PrefabTypes.lordakium_type, enemyType))
            {
                return PrefabTypes.Lordakium;
            }
            else if (DLLHelpers.IsPrefabType(PrefabTypes.kristallin_type, enemyType))
            {
                return PrefabTypes.Kristallin;
            }
            else if (DLLHelpers.IsPrefabType(PrefabTypes.kristallon_type, enemyType))
            {
                return PrefabTypes.Kristallon;
            }
            else if (DLLHelpers.IsPrefabType(PrefabTypes.streuner_2_type, enemyType))
            {
                return PrefabTypes.Streuner_2;
            }
            else if (DLLHelpers.IsPrefabType(PrefabTypes.protegit_type, enemyType))
            {
                return PrefabTypes.Protegit;
            }
            else if (DLLHelpers.IsPrefabType(PrefabTypes.cubikon_type, enemyType))
            {
                return PrefabTypes.Cubikon;
            }
            else if (DLLHelpers.IsPrefabType(PrefabTypes.cucurbium_type, enemyType))
            {
                return PrefabTypes.Cucurbium;
            }
            else if (DLLHelpers.IsPrefabType(PrefabTypes.demaner_type, enemyType))
            {
                return PrefabTypes.Demaner;
            }
            else if (PrefabTypes.Ufo == enemyType)
            {
                return PrefabTypes.Demaner;
            }
            else
                throw new NotImplementedException(enemyType.ToString());
        }
    }
}