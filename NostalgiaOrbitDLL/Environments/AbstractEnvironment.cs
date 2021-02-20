using System;
using System.Collections.Generic;

namespace NostalgiaOrbitDLL.Environments
{
    [Serializable]
    public abstract class AbstractEnvironment
    {
        public PrefabTypes PrefabType { get; set; }
        public PrefabTypes? OccupiedPrefabType { get; set; }

        public bool IsCollectable { get; set; }
        public float CollectingTime { get; set; }

        public int? LifeTime { get; set; }
        public int? OccupiedLifeTime { get; set; }

        public List<Cargo> Cargos { get; set; }
        public bool RandomCargoReward { get; set; }



        public static int OffsetY = 7;
        public static AbstractEnvironment GetEnvironmentByType(PrefabTypes prefabType)
        {
            return prefabType switch
            {
                PrefabTypes.CargoBox => CargoBox.Instance,

                PrefabTypes.BonusBox => BonusBox.Instance,
                PrefabTypes.BonusBox_PvP => BonusBox_PvP.Instance,
                PrefabTypes.BonusBox_OnlyX4 => BonusBox_OnlyX4.Instance,
                PrefabTypes.Star => Star.Instance,

                PrefabTypes.Prometium => Prometium.Instance,
                PrefabTypes.Endurium => Endurium.Instance,
                PrefabTypes.Terbium => Terbium.Instance,

                PrefabTypes.Firebox => Firebox.Instance,

                _ => throw new NotImplementedException()
            };
        }
    }
}