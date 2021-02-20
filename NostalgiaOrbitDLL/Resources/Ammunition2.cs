using System;

namespace NostalgiaOrbitDLL.Resources
{
    [Serializable]
    public class Ammunition2 : AbstractResource
    {
        public static Ammunition2 Instance { get; } = new Ammunition2();
        public Ammunition2()
        {
            ResourceType = ResourceTypes.Ammunition2;

            ShotProbability = 80;

            AmmunitionMultiplier = 2;
        }
    }
}