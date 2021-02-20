using System;
using System.Collections.Generic;

namespace NostalgiaOrbitDLL.Maps
{
    [Serializable]
    public class EIC_2_7 : AbstractMap
    {
        public static EIC_2_7 Instance { get; } = new EIC_2_7();

        public EIC_2_7()
        {
            MapType = MapTypes.EIC_2_7;
            MapIsFirmType = FirmTypes.EIC;

            RequiredLevel = MMO_1_7.Instance.RequiredLevel;
            RequiredLevelForEnemy = MMO_1_7.Instance.RequiredLevelForEnemy;

            Portals = new List<Portal>()
            {
                new Portal(GetCalculatePosition(Positions.TopRight), MapTypes.EIC_2_8, GetCalculatePosition(Positions.BottomRight)),
                new Portal(GetCalculatePosition(Positions.BottomLeft), MapTypes.EIC_2_5, GetCalculatePosition(Positions.TopRight)),
            };

            Enemies = MMO_1_7.Instance.Enemies;

            Resources = MMO_1_7.Instance.Resources;
        }
    }
}