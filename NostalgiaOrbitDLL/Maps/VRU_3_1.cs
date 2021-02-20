using System;
using System.Collections.Generic;

namespace NostalgiaOrbitDLL.Maps
{
    [Serializable]
    public class VRU_3_1 : AbstractMap
    {
        public static VRU_3_1 Instance { get; } = new VRU_3_1();

        public VRU_3_1()
        {
            MapType = MapTypes.VRU_3_1;
            MapIsFirmType = FirmTypes.VRU;

            IsSafeMap = MMO_1_1.Instance.IsSafeMap;

            RequiredLevel = MMO_1_1.Instance.RequiredLevel;
            RequiredLevelForEnemy = MMO_1_1.Instance.RequiredLevelForEnemy;

            Base_Position = GetCalculatePosition(Positions.BottomRight);
            Base_PrefabType = PrefabTypes.Base;

            Portals = new List<Portal>()
            {
                new Portal(GetCalculatePosition(Positions.TopLeft), MapTypes.VRU_3_2, GetCalculatePosition(Positions.BottomRight))
            };

            Enemies = MMO_1_1.Instance.Enemies;

            Resources = MMO_1_1.Instance.Resources;
        }
    }
}