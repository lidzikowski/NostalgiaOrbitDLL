using System;
using System.Collections.Generic;

namespace NostalgiaOrbitDLL.Maps
{
    [Serializable]
    public class VRU_3_6 : AbstractMap
    {
        public static VRU_3_6 Instance { get; } = new VRU_3_6();

        public VRU_3_6()
        {
            MapType = MapTypes.VRU_3_6;
            MapIsFirmType = FirmTypes.VRU;

            RequiredLevel = MMO_1_6.Instance.RequiredLevel;
            RequiredLevelForEnemy = MMO_1_6.Instance.RequiredLevelForEnemy;

            Portals = new List<Portal>()
            {
                new Portal(GetCalculatePosition(Positions.TopLeft), MapTypes.VRU_3_5, GetCalculatePosition(Positions.BottomLeft)),
                new Portal(GetCalculatePosition(Positions.BottomRight), MapTypes.VRU_3_8, GetCalculatePosition(Positions.BottomLeft)),
            };

            Enemies = MMO_1_6.Instance.Enemies;

            Resources = MMO_1_6.Instance.Resources;
        }
    }
}