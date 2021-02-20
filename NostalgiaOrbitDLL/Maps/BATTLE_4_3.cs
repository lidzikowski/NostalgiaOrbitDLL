using System;
using System.Collections.Generic;

namespace NostalgiaOrbitDLL.Maps
{
    [Serializable]
    public class BATTLE_4_3 : AbstractMap
    {
        public static BATTLE_4_3 Instance { get; } = new BATTLE_4_3();

        public BATTLE_4_3()
        {
            MapType = MapTypes.BATTLE_4_3;
            MapIsFirmType = FirmTypes.None;

            IsPvp = true;

            RequiredLevel = 8;
            RequiredLevelForEnemy = 8;

            Portals = new List<Portal>()
            {
                new Portal(GetCalculatePosition(Positions.MiddleRight), MapTypes.VRU_3_4, GetCalculatePosition(Positions.TopMiddle)),
                new Portal(GetCalculatePosition(Positions.BottomLeft), MapTypes.BATTLE_4_1, GetCalculatePosition(Positions.BottomRight)),
                new Portal(GetCalculatePosition(Positions.TopLeft), MapTypes.BATTLE_4_2, GetCalculatePosition(Positions.BottomRight)),
                new Portal(GetCalculatePosition(Positions.Middle), MapTypes.BATTLE_4_4, GetCalculatePosition(Positions.Middle, BigSize, x:100, y:-100)),
            };

            Resources = BATTLE_4_1.Instance.Resources;
        }
    }
}