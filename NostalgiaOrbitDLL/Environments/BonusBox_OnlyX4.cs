using System;
using System.Collections.Generic;

namespace NostalgiaOrbitDLL.Environments
{
    [Serializable]
    public class BonusBox_OnlyX4 : AbstractEnvironment
    {
        public static BonusBox_OnlyX4 Instance { get; } = new BonusBox_OnlyX4();
        public BonusBox_OnlyX4()
        {
            PrefabType = PrefabTypes.BonusBox_OnlyX4;

            IsCollectable = true;

            Cargos = new List<Cargo>()
            {
                new Cargo(ResourceTypes.Ammunition4, 1000),
            };
        }
    }
}