using System;
using System.Collections.Generic;

namespace NostalgiaOrbitDLL.Maps
{
    [Serializable]
    public class MMO_1_4 : AbstractMap
    {
        public static MMO_1_4 Instance { get; } = new MMO_1_4();

        public MMO_1_4()
        {
            MapType = MapTypes.MMO_1_4;
            MapIsFirmType = FirmTypes.MMO;

            RequiredLevel = 3;
            RequiredLevelForEnemy = 5;

            Portals = new List<Portal>()
            {
                new Portal(GetCalculatePosition(Positions.TopLeft), MapTypes.MMO_1_2, GetCalculatePosition(Positions.BottomRight)),
                new Portal(GetCalculatePosition(Positions.TopRight), MapTypes.MMO_1_3, GetCalculatePosition(Positions.BottomRight)),
                new Portal(GetCalculatePosition(Positions.BottomRight), MapTypes.VRU_3_4, GetCalculatePosition(Positions.TopLeft)),
                new Portal(GetCalculatePosition(Positions.MiddleRight), MapTypes.BATTLE_4_1, GetCalculatePosition(Positions.MiddleLeft)),
            };

            Enemies = new List<EnemyMap>()
            {
                new EnemyMap(PrefabTypes.Lordakia, 15, this),
                new EnemyMap(PrefabTypes.Saimon, 30, this),
                new EnemyMap(PrefabTypes.Mordon, 20, this),
                new EnemyMap(PrefabTypes.Sibelon, 10, this),

                new EnemyMap(PrefabTypes.BossSaimon, 5, this),
                new EnemyMap(PrefabTypes.BossSibelon, 3, this),
            };

            Resources = new List<ResourceMap>()
            {
                new ResourceMap(PrefabTypes.Endurium, 50, GetCalculatePosition(Positions.TopMiddle), GetCalculatePosition(Positions.BottomRight)),
                new ResourceMap(PrefabTypes.Terbium, 50, GetCalculatePosition(Positions.TopLeft), GetCalculatePosition(Positions.BottomMiddle)),

                new ResourceMap(PrefabTypes.BonusBox, 100, GetZeroPosition(), GetMaxPosition()),
            };
        }
    }
}