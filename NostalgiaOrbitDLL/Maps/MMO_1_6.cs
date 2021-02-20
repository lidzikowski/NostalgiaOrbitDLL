using System;
using System.Collections.Generic;

namespace NostalgiaOrbitDLL.Maps
{
    [Serializable]
    public class MMO_1_6 : AbstractMap
    {
        public static MMO_1_6 Instance { get; } = new MMO_1_6();

        public MMO_1_6()
        {
            MapType = MapTypes.MMO_1_6;
            MapIsFirmType = FirmTypes.MMO;

            RequiredLevel = 11;
            RequiredLevelForEnemy = 15;

            Portals = new List<Portal>()
            {
                new Portal(GetCalculatePosition(Positions.BottomLeft), MapTypes.MMO_1_8, GetCalculatePosition(Positions.TopRight)),
                new Portal(GetCalculatePosition(Positions.BottomRight), MapTypes.MMO_1_5, GetCalculatePosition(Positions.TopLeft)),
            };

            Enemies = new List<EnemyMap>()
            {
                new EnemyMap(PrefabTypes.Kristallin, 30, this),
                new EnemyMap(PrefabTypes.Kristallon, 10, this),
                new EnemyMap(PrefabTypes.Cubikon, 4, this),

                new EnemyMap(PrefabTypes.BossKristallin, 5, this),
            };

            Resources = new List<ResourceMap>()
            {
                new ResourceMap(PrefabTypes.BonusBox, 100, GetZeroPosition(), GetMaxPosition()),
            };
        }
    }
}