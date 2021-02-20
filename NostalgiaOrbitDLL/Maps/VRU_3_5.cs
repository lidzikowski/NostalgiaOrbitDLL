using System;
using System.Collections.Generic;

namespace NostalgiaOrbitDLL.Maps
{
    [Serializable]
    public class VRU_3_5 : AbstractMap
    {
        public static VRU_3_5 Instance { get; } = new VRU_3_5();

        public VRU_3_5()
        {
            MapType = MapTypes.VRU_3_5;
            MapIsFirmType = FirmTypes.VRU;

            RequiredLevel = MMO_1_5.Instance.RequiredLevel;
            RequiredLevelForEnemy = MMO_1_5.Instance.RequiredLevelForEnemy;

            Portals = new List<Portal>()
            {
                new Portal(GetCalculatePosition(Positions.TopLeft), MapTypes.BATTLE_4_4, GetCalculatePosition(Positions.BottomMiddle, BigSize, x:400)),
                new Portal(GetCalculatePosition(Positions.TopRight, x:-150), MapTypes.BATTLE_4_5, GetCalculatePosition(Positions.BottomMiddle, BigSize, x:400)),
                new Portal(GetCalculatePosition(Positions.BottomLeft), MapTypes.VRU_3_6, GetCalculatePosition(Positions.TopLeft)),
                new Portal(GetCalculatePosition(Positions.BottomRight), MapTypes.VRU_3_7, GetCalculatePosition(Positions.BottomLeft)),
            };

            Enemies = MMO_1_5.Instance.Enemies;

            Resources = MMO_1_5.Instance.Resources;
        }
    }
}