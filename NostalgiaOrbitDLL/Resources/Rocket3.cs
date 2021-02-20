using System;

namespace NostalgiaOrbitDLL.Resources
{
    [Serializable]
    public class Rocket3 : AbstractResource
    {
        public static Rocket3 Instance { get; } = new Rocket3();
        public Rocket3()
        {
            ResourceType = ResourceTypes.Rocket3;

            ShotProbability = 90;

            Damage = 4000;
        }
    }
}