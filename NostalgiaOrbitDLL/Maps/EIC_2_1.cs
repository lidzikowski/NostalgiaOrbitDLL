using System;
using System.Collections.Generic;

namespace NostalgiaOrbitDLL.Maps
{
    [Serializable]
    public class EIC_2_1 : AbstractMap
    {
        public static EIC_2_1 Instance { get; } = new EIC_2_1();

        public EIC_2_1()
        {
            MapType = MapTypes.EIC_2_1;
            MapIsFirmType = FirmTypes.EIC;

            IsSafeMap = MMO_1_1.Instance.IsSafeMap;

            RequiredLevel = MMO_1_1.Instance.RequiredLevel;
            RequiredLevelForEnemy = MMO_1_1.Instance.RequiredLevelForEnemy;

            Base_Position = GetCalculatePosition(Positions.TopRight);
            Base_PrefabType = PrefabTypes.Base;

            Portals = new List<Portal>()
            {
                new Portal(GetCalculatePosition(Positions.BottomLeft), MapTypes.EIC_2_2, GetCalculatePosition(Positions.TopRight))
            };

            Enemies = MMO_1_1.Instance.Enemies;

            Resources = MMO_1_1.Instance.Resources;
        }
    }
}