using System;

namespace NostalgiaOrbitDLL.Resources
{
    [Serializable]
    public class AmmunitionSab : AbstractResource
    {
        public static AmmunitionSab Instance { get; } = new AmmunitionSab();
        public AmmunitionSab()
        {
            ResourceType = ResourceTypes.AmmunitionSab;

            ShotProbability = 80;

            AmmunitionMultiplier = 2;
            ShotInOnlyShield = true;
        }
    }
}