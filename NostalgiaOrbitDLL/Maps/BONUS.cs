using System;
using System.Collections.Generic;

namespace NostalgiaOrbitDLL.Maps
{
    [Serializable]
    public class BONUS : AbstractMap
    {
        public static BONUS Instance { get; } = new BONUS();

        public BONUS()
        {
            MapType = MapTypes.BONUS;
            MapIsFirmType = FirmTypes.None;

            IsPvp = true;

            MapSize = new PositionVector(1600, 1010);

            RequiredLevel = 1;
            RequiredLevelForEnemy = 1;

            Enemies = new List<EnemyMap>()
            {
                new EnemyMap(PrefabTypes.Cubikon, 15, this),

                new EnemyMap(PrefabTypes.UberProtegit, 100, this),
            };

            Resources = new List<ResourceMap>()
            {
                new ResourceMap(PrefabTypes.BonusBox_OnlyX4, 100, GetZeroPosition(), GetMaxPosition()),
            };
        }
    }
}