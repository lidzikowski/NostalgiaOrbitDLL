using System;
using System.Collections.Generic;

namespace NostalgiaOrbitDLL.Maps
{
    [Serializable]
    public class MMO_1_3 : AbstractMap
    {
        public static MMO_1_3 Instance { get; } = new MMO_1_3();

        public MMO_1_3()
        {
            MapType = MapTypes.MMO_1_3;
            MapIsFirmType = FirmTypes.MMO;

            RequiredLevel = 2;
            RequiredLevelForEnemy = 6;

            Portals = new List<Portal>()
            {
                new Portal(GetCalculatePosition(Positions.TopRight), MapTypes.EIC_2_3, GetCalculatePosition(Positions.BottomLeft)),
                new Portal(GetCalculatePosition(Positions.BottomLeft), MapTypes.MMO_1_2, GetCalculatePosition(Positions.TopRight)),
                new Portal(GetCalculatePosition(Positions.BottomRight), MapTypes.MMO_1_4, GetCalculatePosition(Positions.TopRight)),
            };

            Enemies = new List<EnemyMap>()
            {
                new EnemyMap(PrefabTypes.Lordakia, 15, this),
                new EnemyMap(PrefabTypes.Saimon, 20, this),
                new EnemyMap(PrefabTypes.Mordon, 30, this),
                new EnemyMap(PrefabTypes.Devolarium, 10, this),

                new EnemyMap(PrefabTypes.BossMordon, 5, this),
                new EnemyMap(PrefabTypes.BossDevolarium, 3, this),
            };

            Resources = new List<ResourceMap>()
            {
                new ResourceMap(PrefabTypes.Endurium, 50, GetCalculatePosition(Positions.TopLeft), GetCalculatePosition(Positions.Middle)),
                new ResourceMap(PrefabTypes.Terbium, 50, GetCalculatePosition(Positions.TopLeft), GetCalculatePosition(Positions.Middle)),

                new ResourceMap(PrefabTypes.BonusBox, 100, GetZeroPosition(), GetMaxPosition()),
            };
        }
    }
}