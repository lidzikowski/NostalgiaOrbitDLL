using System;
using System.Collections.Generic;

namespace NostalgiaOrbitDLL.Environments
{
    [Serializable]
    public class BonusBox : AbstractEnvironment
    {
        public static BonusBox Instance { get; } = new BonusBox();
        public BonusBox()
        {
            PrefabType = PrefabTypes.BonusBox;

            IsCollectable = true;

            RandomCargoReward = true;

            Cargos = new List<Cargo>()
            {
                new Cargo(ResourceTypes.Ammunition1, 10),
                new Cargo(ResourceTypes.Ammunition1, 20),
                new Cargo(ResourceTypes.Ammunition1, 50),

                new Cargo(ResourceTypes.Ammunition2, 5),
                new Cargo(ResourceTypes.Ammunition2, 10),
                new Cargo(ResourceTypes.Ammunition2, 20),

                new Cargo(ResourceTypes.Ammunition3, 5),
                new Cargo(ResourceTypes.Ammunition3, 10),
                new Cargo(ResourceTypes.Ammunition3, 20),

                new Cargo(ResourceTypes.AmmunitionSab, 5),
                new Cargo(ResourceTypes.AmmunitionSab, 10),
                new Cargo(ResourceTypes.AmmunitionSab, 20),

                new Cargo(ResourceTypes.Jackpot, 0.25f),
                new Cargo(ResourceTypes.Jackpot, 0.5f),
                new Cargo(ResourceTypes.Jackpot, 1),

                new Cargo(ResourceTypes.Credits, 200),
                new Cargo(ResourceTypes.Credits, 500),
                new Cargo(ResourceTypes.Credits, 1000),

                new Cargo(ResourceTypes.Uridium, 20),
                new Cargo(ResourceTypes.Uridium, 50),
                new Cargo(ResourceTypes.Uridium, 100),

                new Cargo(ResourceTypes.ExtraEnergy, 1),
            };
        }
    }
}