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
            return resourceType switch
            {
                ResourceTypes.Ammunition1 => Ammunition1.Instance,
                ResourceTypes.Ammunition2 => Ammunition2.Instance,
                ResourceTypes.Ammunition3 => Ammunition3.Instance,
                ResourceTypes.Ammunition4 => Ammunition4.Instance,
                ResourceTypes.AmmunitionSab => AmmunitionSab.Instance,

                ResourceTypes.Rocket1 => Rocket1.Instance,
                ResourceTypes.Rocket2 => Rocket2.Instance,
                ResourceTypes.Rocket3 => Rocket3.Instance,

                ResourceTypes.Mine => Mine.Instance,

                _ => throw new NotImplementedException(resourceType.ToString()),
            };
        }
    }
}