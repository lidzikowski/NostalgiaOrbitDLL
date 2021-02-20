
using System;
using System.Collections.Generic;

namespace NostalgiaOrbitDLL.Maps
{
    [Serializable]
    public class EIC_2_8 : AbstractMap
    {
        public static EIC_2_8 Instance { get; } = new EIC_2_8();

        public EIC_2_8()
        {
            MapType = MapTypes.EIC_2_8;
            MapIsFirmType = FirmTypes.EIC;

            RequiredLevel = MMO_1_8.Instance.RequiredLevel;
            RequiredLevelForEnemy = MMO_1_8.Instance.RequiredLevelForEnemy;

            Base_Position = GetCalculatePosition(Positions.TopMiddle);
            Base_PrefabType = PrefabTypes.Base;

            Portals = new List<Portal>()
            {
                new Portal(GetCalculatePosition(Positions.BottomLeft), MapTypes.EIC_2_6, GetCalculatePosition(Positions.TopRight)),
                new Portal(GetCalculatePosition(Positions.BottomRight), MapTypes.EIC_2_7, GetCalculatePosition(Positions.TopRight)),
            };

            Enemies = MMO_1_8.Instance.Enemies;

            Resources = MMO_1_8.Instance.Resources;
        }
    }
}