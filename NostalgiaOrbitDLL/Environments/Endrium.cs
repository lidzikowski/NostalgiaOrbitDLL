using System;
using System.Collections.Generic;

namespace NostalgiaOrbitDLL.Environments
{
    [Serializable]
    public class Endurium : AbstractEnvironment
    {
        public static Endurium Instance { get; } = new Endurium();
        public Endurium()
        {
            PrefabType = PrefabTypes.Endurium;

            IsCollectable = true;
            CollectingTime = 0.35f;

            Cargos = new List<Cargo>()
            {
                new Cargo(ResourceTypes.Endurium, 1),
            };
        }
    }
}