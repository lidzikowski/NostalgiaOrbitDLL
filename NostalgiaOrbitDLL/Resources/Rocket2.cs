using System;

namespace NostalgiaOrbitDLL.Resources
{
    [Serializable]
    public class Rocket2 : AbstractResource
    {
        public static Rocket2 Instance { get; } = new Rocket2();
        public Rocket2()
        {
            ResourceType = ResourceTypes.Rocket2;

            ShotProbability = 80;

            Damage = 2000;
        }
    }
}