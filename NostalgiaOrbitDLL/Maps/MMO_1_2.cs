using System;
using System.Collections.Generic;

namespace NostalgiaOrbitDLL.Maps
{
    [Serializable]
    public class MMO_1_2 : AbstractMap
    {
        public static MMO_1_2 Instance { get; } = new MMO_1_2();

        public MMO_1_2()
        {
            MapType = MapTypes.MMO_1_2;
            MapIsFirmType = FirmTypes.MMO;

            RequiredLevel = 1;
            RequiredLevelForEnemy = 13;

            Portals = new List<Portal>()
            {
                new Portal(GetCalculatePosition(Positions.TopLeft), MapTypes.MMO_1_1, GetCalculatePosition(Positions.BottomRight)),
                new Portal(GetCalculatePosition(Positions.TopRight), MapTypes.MMO_1_3, GetCalculatePosition(Positions.BottomLeft)),
                new Portal(GetCalculatePosition(Positions.BottomRight), MapTypes.MMO_1_4, GetCalculatePosition(Positions.TopLeft)),
            };

            Enemies = new List<EnemyMap>()
            {
                new EnemyMap(PrefabTypes.Streuner, 20, this),
                new EnemyMap(PrefabTypes.Lordakia, 20, this),
                new EnemyMap(PrefabTypes.BossStreuner, 5, this),
                new EnemyMap(PrefabTypes.BossLordakia, 5, this),
            };

            Resources = new List<ResourceMap>()
            {
                new ResourceMap(PrefabTypes.Prometium, 30, GetCalculatePosition(Positions.TopMiddle), GetCalculatePosition(Positions.MiddleRight)),
                new ResourceMap(PrefabTypes.Endurium, 30, GetCalculatePosition(Positions.TopLeft), GetCalculatePosition(Positions.BottomMiddle)),
                new ResourceMap(PrefabTypes.Terbium, 10, GetCalculatePosition(Positions.Middle), GetCalculatePosition(Positions.BottomRight)),

                new ResourceMap(PrefabTypes.BonusBox, 100, GetZeroPosition(), GetMaxPosition()),
            };
        }
    }
}