using System;
using System.Collections.Generic;

namespace NostalgiaOrbitDLL.Maps
{
    [Serializable]
    public class VRU_3_4 : AbstractMap
    {
        public static VRU_3_4 Instance { get; } = new VRU_3_4();

        public VRU_3_4()
        {
            MapType = MapTypes.VRU_3_4;
            MapIsFirmType = FirmTypes.VRU;

            RequiredLevel = MMO_1_4.Instance.RequiredLevel;
            RequiredLevelForEnemy = MMO_1_4.Instance.RequiredLevelForEnemy;

            Portals = new List<Portal>()
            {
                new Portal(GetCalculatePosition(Positions.TopLeft), MapTypes.MMO_1_4, GetCalculatePosition(Positions.BottomRight)),
                new Portal(GetCalculatePosition(Positions.TopMiddle), MapTypes.BATTLE_4_3, GetCalculatePosition(Positions.MiddleRight)),
                new Portal(GetCalculatePosition(Positions.TopRight), MapTypes.VRU_3_3, GetCalculatePosition(Positions.BottomLeft)),
                new Portal(GetCalculatePosition(Positions.BottomRight), MapTypes.VRU_3_2, GetCalculatePosition(Positions.TopLeft)),
            };

            Enemies = MMO_1_4.Instance.Enemies;

            Resources = MMO_1_4.Instance.Resources;
        }
    }
}