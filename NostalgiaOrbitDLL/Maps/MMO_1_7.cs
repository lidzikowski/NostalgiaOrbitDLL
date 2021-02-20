using System;
using System.Collections.Generic;

namespace NostalgiaOrbitDLL.Maps
{
    [Serializable]
    public class MMO_1_7 : AbstractMap
    {
        public static MMO_1_7 Instance { get; } = new MMO_1_7();

        public MMO_1_7()
        {
            MapType = MapTypes.MMO_1_7;
            MapIsFirmType = FirmTypes.MMO;

            RequiredLevel = 11;
            RequiredLevelForEnemy = 15;

            Portals = new List<Portal>()
            {
                new Portal(GetCalculatePosition(Positions.TopLeft), MapTypes.MMO_1_8, GetCalculatePosition(Positions.BottomRight)),
                new Portal(GetCalculatePosition(Positions.TopRight), MapTypes.MMO_1_5, GetCalculatePosition(Positions.BottomLeft)),
            };

            Enemies = new List<EnemyMap>()
            {
                new EnemyMap(PrefabTypes.Kristallin, 30, this),
                new EnemyMap(PrefabTypes.Kristallon, 15, this),

                new EnemyMap(PrefabTypes.BossKristallin, 2, this),
                new EnemyMap(PrefabTypes.BossKristallon, 2, this),
            };

            Resources = new List<ResourceMap>()
            {
                new ResourceMap(PrefabTypes.BonusBox, 100, GetZeroPosition(), GetMaxPosition()),
            };
        }
    }
}