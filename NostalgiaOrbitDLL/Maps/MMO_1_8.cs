using System;
using System.Collections.Generic;

namespace NostalgiaOrbitDLL.Maps
{
    [Serializable]
    public class MMO_1_8 : AbstractMap
    {
        public static MMO_1_8 Instance { get; } = new MMO_1_8();

        public MMO_1_8()
        {
            MapType = MapTypes.MMO_1_8;
            MapIsFirmType = FirmTypes.MMO;

            RequiredLevel = 12;
            RequiredLevelForEnemy = 17;

            Base_Position = GetCalculatePosition(Positions.MiddleLeft);
            Base_PrefabType = PrefabTypes.Base;

            Portals = new List<Portal>()
            {
                new Portal(GetCalculatePosition(Positions.TopRight), MapTypes.MMO_1_6, GetCalculatePosition(Positions.BottomLeft)),
                new Portal(GetCalculatePosition(Positions.BottomRight), MapTypes.MMO_1_7, GetCalculatePosition(Positions.TopLeft)),
            };

            Enemies = new List<EnemyMap>()
            {
                new EnemyMap(PrefabTypes.Streuner_2, 30, this),

                new EnemyMap(PrefabTypes.BossStreuner_2, 10, this),
            };

            Resources = new List<ResourceMap>()
            {
                new ResourceMap(PrefabTypes.BonusBox, 100, GetZeroPosition(), GetMaxPosition()),
            };
        }
    }
}