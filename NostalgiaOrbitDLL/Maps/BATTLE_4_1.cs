using System;
using System.Collections.Generic;

namespace NostalgiaOrbitDLL.Maps
{
    [Serializable]
    public class BATTLE_4_1 : AbstractMap
    {
        public static BATTLE_4_1 Instance { get; } = new BATTLE_4_1();

        public BATTLE_4_1()
        {
            MapType = MapTypes.BATTLE_4_1;
            MapIsFirmType = FirmTypes.None;

            IsPvp = true;

            RequiredLevel = 8;
            RequiredLevelForEnemy = 8;

            Portals = new List<Portal>()
            {
                new Portal(GetCalculatePosition(Positions.MiddleLeft), MapTypes.MMO_1_4, GetCalculatePosition(Positions.MiddleRight)),
                new Portal(GetCalculatePosition(Positions.TopRight), MapTypes.BATTLE_4_2, GetCalculatePosition(Positions.BottomLeft)),
                new Portal(GetCalculatePosition(Positions.BottomRight), MapTypes.BATTLE_4_3, GetCalculatePosition(Positions.BottomLeft)),
                new Portal(GetCalculatePosition(Positions.Middle), MapTypes.BATTLE_4_4, GetCalculatePosition(Positions.Middle, BigSize, x:-100)),
            };

            Resources = new List<ResourceMap>()
            {
                new ResourceMap(PrefabTypes.BonusBox_PvP, 100, GetZeroPosition(), GetMaxPosition()),
            };
        }
    }
}