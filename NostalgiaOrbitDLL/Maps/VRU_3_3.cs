using System;
using System.Collections.Generic;

namespace NostalgiaOrbitDLL.Maps
{
    [Serializable]
    public class VRU_3_3 : AbstractMap
    {
        public static VRU_3_3 Instance { get; } = new VRU_3_3();

        public VRU_3_3()
        {
            MapType = MapTypes.VRU_3_3;
            MapIsFirmType = FirmTypes.VRU;

            RequiredLevel = MMO_1_3.Instance.RequiredLevel;
            RequiredLevelForEnemy = MMO_1_3.Instance.RequiredLevelForEnemy;

            Portals = new List<Portal>()
            {
                new Portal(GetCalculatePosition(Positions.TopLeft), MapTypes.EIC_2_4, GetCalculatePosition(Positions.BottomLeft)),
                new Portal(GetCalculatePosition(Positions.BottomLeft), MapTypes.VRU_3_4, GetCalculatePosition(Positions.TopRight)),
                new Portal(GetCalculatePosition(Positions.BottomRight), MapTypes.VRU_3_2, GetCalculatePosition(Positions.TopRight)),
            };

            Enemies = MMO_1_3.Instance.Enemies;

            Resources = MMO_1_3.Instance.Resources;
        }
    }
}