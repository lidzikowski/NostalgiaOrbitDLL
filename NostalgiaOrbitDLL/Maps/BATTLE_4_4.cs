using System;
using System.Collections.Generic;

namespace NostalgiaOrbitDLL.Maps
{
    [Serializable]
    public class BATTLE_4_4 : AbstractMap
    {
        public static BATTLE_4_4 Instance { get; } = new BATTLE_4_4();

        public BATTLE_4_4()
        {
            MapType = MapTypes.BATTLE_4_4;
            MapIsFirmType = FirmTypes.None;

            IsPvp = true;

            MapSize = new PositionVector(1600, 1010);

            RequiredLevel = 9;
            RequiredLevelForEnemy = 9;

            Portals = new List<Portal>()
            {
                new Portal(GetCalculatePosition(Positions.MiddleLeft), MapTypes.MMO_1_5, GetCalculatePosition(Positions.MiddleRight, NormalSize)),
                new Portal(GetCalculatePosition(Positions.TopMiddle, x:400), MapTypes.EIC_2_5, GetCalculatePosition(Positions.BottomLeft, NormalSize)),
                new Portal(GetCalculatePosition(Positions.BottomMiddle, x:400), MapTypes.VRU_3_5, GetCalculatePosition(Positions.TopLeft, NormalSize)),

                new Portal(GetCalculatePosition(Positions.Middle, x:-100), MapTypes.BATTLE_4_1, GetCalculatePosition(Positions.Middle, NormalSize)),
                new Portal(GetCalculatePosition(Positions.Middle, x:100, y:100), MapTypes.BATTLE_4_2, GetCalculatePosition(Positions.Middle, NormalSize)),
                new Portal(GetCalculatePosition(Positions.Middle, x:100, y:-100), MapTypes.BATTLE_4_3, GetCalculatePosition(Positions.Middle, NormalSize)),
            };
        }
    }
}