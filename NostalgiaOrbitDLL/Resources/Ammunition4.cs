using System;

namespace NostalgiaOrbitDLL.Resources
{
    [Serializable]
    public class Ammunition4 : AbstractResource
    {
        public static Ammunition4 Instance { get; } = new Ammunition4();
        public Ammunition4()
        {
            ResourceType = ResourceTypes.Ammunition4;

            ShotProbability = 80;

            AmmunitionMultiplier = 4;
        }
    }
}