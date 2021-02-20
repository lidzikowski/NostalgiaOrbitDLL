using System;

namespace NostalgiaOrbitDLL.Resources
{
    [Serializable]
    public class Rocket1 : AbstractResource
    {
        public static Rocket1 Instance { get; } = new Rocket1();
        public Rocket1()
        {
            ResourceType = ResourceTypes.Rocket1;

            ShotProbability = 70;

            Damage = 1000;
        }
    }
}