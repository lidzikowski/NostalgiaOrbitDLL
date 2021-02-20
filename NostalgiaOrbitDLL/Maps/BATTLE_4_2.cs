using System;
using System.Collections.Generic;

namespace NostalgiaOrbitDLL.Maps
{
    [Serializable]
    public class BATTLE_4_2 : AbstractMap
    {
        public static BATTLE_4_2 Instance { get; } = new BATTLE_4_2();

        public BATTLE_4_2()
        {
            MapType = MapTypes.BATTLE_4_2;
            MapIsFirmType = FirmTypes.None;

            IsPvp = true;

            RequiredLevel = 8;
            RequiredLevelForEnemy = 8;

            Portals = new List<Portal>()
            {
                new Portal(GetCalculatePosition(Positions.TopMiddle), MapTypes.EIC_2_4, GetCalculatePosition(Positions.BottomMiddle)),
                new Portal(GetCalculatePosition(Positions.BottomLeft), MapTypes.BATTLE_4_1, GetCalculatePosition(Positions.TopRight)),
                new Portal(GetCalculatePosition(Positions.BottomRight), MapTypes.BATTLE_4_3,GetCalculatePosition(Positions.TopLeft)),
                new Portal(GetCalculatePosition(Positions.Middle), MapTypes.BATTLE_4_4, GetCalculatePosition(Positions.Middle, BigSize, x:100, y:100)),
            };

            Resources = BATTLE_4_1.Instance.Resources;
        }
    }
}