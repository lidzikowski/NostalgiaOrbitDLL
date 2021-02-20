using System;
using System.Collections.Generic;

namespace NostalgiaOrbitDLL.Maps
{
    [Serializable]
    public class VRU_3_2 : AbstractMap
    {
        public static VRU_3_2 Instance { get; } = new VRU_3_2();

        public VRU_3_2()
        {
            MapType = MapTypes.VRU_3_2;
            MapIsFirmType = FirmTypes.VRU;

            RequiredLevel = MMO_1_2.Instance.RequiredLevel;
            RequiredLevelForEnemy = MMO_1_2.Instance.RequiredLevelForEnemy;

            Portals = new List<Portal>()
            {
                new Portal(GetCalculatePosition(Positions.TopLeft), MapTypes.VRU_3_4, GetCalculatePosition(Positions.BottomRight)),
                new Portal(GetCalculatePosition(Positions.TopRight), MapTypes.VRU_3_3, GetCalculatePosition(Positions.BottomRight)),
                new Portal(GetCalculatePosition(Positions.BottomRight), MapTypes.VRU_3_1, GetCalculatePosition(Positions.TopLeft)),
            };

            Enemies = MMO_1_2.Instance.Enemies;

            Resources = MMO_1_2.Instance.Resources;
        }
    }
}