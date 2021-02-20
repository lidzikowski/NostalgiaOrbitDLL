using System;
using System.Collections.Generic;

namespace NostalgiaOrbitDLL.Maps
{
    [Serializable]
    public class VRU_3_8 : AbstractMap
    {
        public static VRU_3_8 Instance { get; } = new VRU_3_8();

        public VRU_3_8()
        {
            MapType = MapTypes.VRU_3_8;
            MapIsFirmType = FirmTypes.VRU;

            RequiredLevel = MMO_1_8.Instance.RequiredLevel;
            RequiredLevelForEnemy = MMO_1_8.Instance.RequiredLevelForEnemy;

            Base_Position = GetCalculatePosition(Positions.MiddleRight);
            Base_PrefabType = PrefabTypes.Base;

            Portals = new List<Portal>()
            {
                new Portal(GetCalculatePosition(Positions.TopLeft), MapTypes.VRU_3_7, GetCalculatePosition(Positions.BottomRight)),
                new Portal(GetCalculatePosition(Positions.BottomLeft), MapTypes.VRU_3_6, GetCalculatePosition(Positions.BottomRight)),
            };

            Enemies = MMO_1_8.Instance.Enemies;

            Resources = MMO_1_8.Instance.Resources;
        }
    }
}