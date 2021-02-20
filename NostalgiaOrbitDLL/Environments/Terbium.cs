using System;
using System.Collections.Generic;

namespace NostalgiaOrbitDLL.Environments
{
    [Serializable]
    public class Terbium : AbstractEnvironment
    {
        public static Terbium Instance { get; } = new Terbium();
        public Terbium()
        {
            PrefabType = PrefabTypes.Terbium;

            IsCollectable = true;
            CollectingTime = 0.5f;

            Cargos = new List<Cargo>()
            {
                new Cargo(ResourceTypes.Terbium, 1),
            };
        }
    }
}