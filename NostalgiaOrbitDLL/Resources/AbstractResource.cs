using System;

namespace NostalgiaOrbitDLL.Resources
{
    [Serializable]
    public abstract class AbstractResource : ShopItem
    {
        public ResourceTypes ResourceType { get; set; }

        /// <summary>
        /// 0-100 szansa na celny strzal
        /// </summary>
        public int ShotProbability { get; set; }

        public float AmmunitionMultiplier { get; set; }
        public bool ShotInOnlyShield { get; set; }

        /// <summary>
        /// Rocket or Mines damage
        /// </summary>
        public int Damage { get; set; }

        public static AbstractResource GetResourceByType(ResourceTypes resourceType)
        {
            switch (resourceType)
            {
                case ResourceTypes.Ammunition1:
                    return Ammunition1.Instance;
                case ResourceTypes.Ammunition2:
                    return Ammunition2.Instance;
                case ResourceTypes.Ammunition3:
                    return Ammunition3.Instance;
                case ResourceTypes.Ammunition4:
                    return Ammunition4.Instance;
                case ResourceTypes.AmmunitionSab:
                    return AmmunitionSab.Instance;

                case ResourceTypes.Rocket1:
                    return Rocket1.Instance;
                case ResourceTypes.Rocket2:
                    return Rocket2.Instance;
                case ResourceTypes.Rocket3:
                    return Rocket3.Instance;

                default:
                    throw new NotImplementedException(resourceType.ToString());
            }
        }
    }
}