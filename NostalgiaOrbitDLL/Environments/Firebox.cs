using System;

namespace NostalgiaOrbitDLL.Environments
{
    [Serializable]
    public class Firebox : AbstractEnvironment
    {
        public static Firebox Instance { get; } = new Firebox();
        public Firebox()
        {
            PrefabType = PrefabTypes.Firebox;

            IsCollectable = true;

            LifeTime = 10;
        }
    }
}