using System;
using System.Collections.Generic;

namespace NostalgiaOrbitDLL.Maps
{
    [Serializable]
    public class BATTLE_4_5 : AbstractMap
    {
        public static BATTLE_4_5 Instance { get; } = new BATTLE_4_5();

        public BATTLE_4_5()
        {
            MapType = MapTypes.BATTLE_4_5;
            MapIsFirmType = FirmTypes.None;

            IsPvp = true;

            MapSize = new PositionVector(1600, 1010);

            RequiredLevel = 10;
            RequiredLevelForEnemy = 10;

            Portals = new List<Portal>()
            {
                new Portal(GetCalculatePosition(Positions.MiddleLeft), MapTypes.MMO_1_5, GetCalculatePosition(Positions.BottomMiddle, NormalSize)),
                new Portal(GetCalculatePosition(Positions.TopMiddle, x:400), MapTypes.EIC_2_5, GetCalculatePosition(Positions.BottomRight, NormalSize)),
                new Portal(GetCalculatePosition(Positions.BottomMiddle, x:400), MapTypes.VRU_3_5, GetCalculatePosition(Positions.TopRight, NormalSize, x:-150)),

                new Portal(GetCalculatePosition(Positions.Middle)),
            };

            Enemies = new List<EnemyMap>()
            {
                new EnemyMap(PrefabTypes.BossStreuner, 5, this),
                new EnemyMap(PrefabTypes.BossLordakia, 5, this),
                new EnemyMap(PrefabTypes.BossSaimon, 5, this),
                new EnemyMap(PrefabTypes.BossMordon, 5, this),
                new EnemyMap(PrefabTypes.BossDevolarium, 5, this),
                new EnemyMap(PrefabTypes.BossSibelon, 5, this),
                new EnemyMap(PrefabTypes.BossSibelonit, 5, this),
                new EnemyMap(PrefabTypes.BossLordakium, 5, this),
                new EnemyMap(PrefabTypes.BossKristallin, 5, this),
                new EnemyMap(PrefabTypes.BossKristallon, 5, this),
                new EnemyMap(PrefabTypes.BossStreuner_2, 5, this),

                new EnemyMap(PrefabTypes.UberStreuner, 5, this),
                new EnemyMap(PrefabTypes.UberLordakia, 5, this),
                new EnemyMap(PrefabTypes.UberSaimon, 5, this),
                new EnemyMap(PrefabTypes.UberMordon, 5, this),
                new EnemyMap(PrefabTypes.UberDevolarium, 3, this),
                new EnemyMap(PrefabTypes.UberSibelon, 3, this),
                new EnemyMap(PrefabTypes.UberSibelonit, 5, this),
                new EnemyMap(PrefabTypes.UberLordakium, 3, this),
                new EnemyMap(PrefabTypes.UberKristallin, 5, this),
                new EnemyMap(PrefabTypes.UberKristallon, 3, this),
                new EnemyMap(PrefabTypes.UberStreuner_2, 5, this),
            };
        }
    }
}