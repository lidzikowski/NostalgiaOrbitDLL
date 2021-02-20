using System;
using System.Collections.Generic;

namespace NostalgiaOrbitDLL.Maps
{
    [Serializable]
    public class VRU_3_7 : AbstractMap
    {
        public static VRU_3_7 Instance { get; } = new VRU_3_7();

        public VRU_3_7()
        {
            MapType = MapTypes.VRU_3_7;
            MapIsFirmType = FirmTypes.VRU;

            RequiredLevel = MMO_1_7.Instance.RequiredLevel;
            RequiredLevelForEnemy = MMO_1_7.Instance.RequiredLevelForEnemy;

            Portals = new List<Portal>()
            {
                new Portal(GetCalculatePosition(Positions.BottomLeft), MapTypes.VRU_3_5, GetCalculatePosition(Positions.BottomRight)),
                new Portal(GetCalculatePosition(Positions.BottomRight), MapTypes.VRU_3_8, GetCalculatePosition(Positions.TopLeft)),
            };

            Enemies = MMO_1_7.Instance.Enemies;

            Resources = MMO_1_7.Instance.Resources;
        }
    }
}