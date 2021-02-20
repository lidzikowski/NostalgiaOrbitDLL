using System;
using System.Collections.Generic;

namespace NostalgiaOrbitDLL.Environments
{
    [Serializable]
    public class BonusBox_PvP : AbstractEnvironment
    {
        public static BonusBox_PvP Instance { get; } = new BonusBox_PvP();
        public BonusBox_PvP()
        {
            PrefabType = PrefabTypes.BonusBox_PvP;

            IsCollectable = true;

            RandomCargoReward = true;

            Cargos = new List<Cargo>()
            {
                new Cargo(ResourceTypes.Ammunition1, 15),
                new Cargo(ResourceTypes.Ammunition1, 30),
                new Cargo(ResourceTypes.Ammunition1, 75),

                new Cargo(ResourceTypes.Ammunition2, 8),
                new Cargo(ResourceTypes.Ammunition2, 15),
                new Cargo(ResourceTypes.Ammunition2, 30),

                new Cargo(ResourceTypes.Ammunition3, 8),
                new Cargo(ResourceTypes.Ammunition3, 15),
                new Cargo(ResourceTypes.Ammunition3, 30),

                new Cargo(ResourceTypes.Ammunition4, 5),

                new Cargo(ResourceTypes.AmmunitionSab, 8),
                new Cargo(ResourceTypes.AmmunitionSab, 15),
                new Cargo(ResourceTypes.AmmunitionSab, 30),

                new Cargo(ResourceTypes.Rocket1, 3),
                new Cargo(ResourceTypes.Rocket1, 5),

                new Cargo(ResourceTypes.Rocket2, 1),
                new Cargo(ResourceTypes.Rocket2, 3),

                new Cargo(ResourceTypes.Rocket3, 1),

                new Cargo(ResourceTypes.Jackpot, 0.38f),
                new Cargo(ResourceTypes.Jackpot, 0.75f),
                new Cargo(ResourceTypes.Jackpot, 1.5f),

                new Cargo(ResourceTypes.Credits, 300),
                new Cargo(ResourceTypes.Credits, 750),
                new Cargo(ResourceTypes.Credits, 1500),

                new Cargo(ResourceTypes.Uridium, 30),
                new Cargo(ResourceTypes.Uridium, 75),
                new Cargo(ResourceTypes.Uridium, 150),

                new Cargo(ResourceTypes.ExtraEnergy, 2),

                new Cargo(ResourceTypes.Xenomit, 25),
                new Cargo(ResourceTypes.Xenomit, 50),
                new Cargo(ResourceTypes.Xenomit, 75),
            };
        }
    }
}