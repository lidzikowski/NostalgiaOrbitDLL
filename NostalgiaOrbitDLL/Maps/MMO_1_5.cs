using System;
using System.Collections.Generic;

namespace NostalgiaOrbitDLL.Maps
{
    [Serializable]
    public class MMO_1_5 : AbstractMap
    {
        public static MMO_1_5 Instance { get; } = new MMO_1_5();

        public MMO_1_5()
        {
            MapType = MapTypes.MMO_1_5;
            MapIsFirmType = FirmTypes.MMO;

            RequiredLevel = 10;
            RequiredLevelForEnemy = 14;

            Portals = new List<Portal>()
            {
                new Portal(GetCalculatePosition(Positions.TopLeft), MapTypes.MMO_1_6, GetCalculatePosition(Positions.BottomRight)),
                new Portal(GetCalculatePosition(Positions.BottomLeft), MapTypes.MMO_1_7, GetCalculatePosition(Positions.TopRight)),
                new Portal(GetCalculatePosition(Positions.MiddleRight), MapTypes.BATTLE_4_4, GetCalculatePosition(Positions.MiddleLeft, BigSize)),
                new Portal(GetCalculatePosition(Positions.BottomMiddle), MapTypes.BATTLE_4_5, GetCalculatePosition(Positions.MiddleLeft, BigSize)),
            };

            Enemies = new List<EnemyMap>()
            {
                new EnemyMap(PrefabTypes.Lordakia, 20, this),
                new EnemyMap(PrefabTypes.Sibelonit, 30, this),
                new EnemyMap(PrefabTypes.Lordakium, 15, this),

                new EnemyMap(PrefabTypes.BossSibelonit, 5, this),
                new EnemyMap(PrefabTypes.BossLordakium, 3, this),
            };

            Resources = new List<ResourceMap>()
            {
                new ResourceMap(PrefabTypes.BonusBox, 100, GetZeroPosition(), GetMaxPosition()),
            };
        }
    }
}