using System;
using System.Collections.Generic;

namespace NostalgiaOrbitDLL.Environments
{
    [Serializable]
    public class Prometium : AbstractEnvironment
    {
        public static Prometium Instance { get; } = new Prometium();
        public Prometium()
        {
            PrefabType = PrefabTypes.Prometium;

            IsCollectable = true;
            CollectingTime = 0.2f;

            Cargos = new List<Cargo>()
            {
                new Cargo(ResourceTypes.Prometium, 1),
            };
        }
    }
}