using System;

namespace NostalgiaOrbitDLL.Resources
{
    [Serializable]
    public class Ammunition1 : AbstractResource
    {
        public static Ammunition1 Instance { get; } = new Ammunition1();
        public Ammunition1()
        {
            ResourceType = ResourceTypes.Ammunition1;

            ShotProbability = 80;

            AmmunitionMultiplier = 1;
        }
    }
}