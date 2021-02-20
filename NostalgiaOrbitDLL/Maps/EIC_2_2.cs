using System;
using System.Collections.Generic;

namespace NostalgiaOrbitDLL.Maps
{
    [Serializable]
    public class EIC_2_2 : AbstractMap
    {
        public static EIC_2_2 Instance { get; } = new EIC_2_2();

        public EIC_2_2()
        {
            MapType = MapTypes.EIC_2_2;
            MapIsFirmType = FirmTypes.EIC;

            RequiredLevel = MMO_1_2.Instance.RequiredLevel;
            RequiredLevelForEnemy = MMO_1_2.Instance.RequiredLevelForEnemy;

            Portals = new List<Portal>()
            {
                new Portal(GetCalculatePosition(Positions.TopRight), MapTypes.EIC_2_1, GetCalculatePosition(Positions.BottomLeft)),
                new Portal(GetCalculatePosition(Positions.BottomLeft), MapTypes.EIC_2_3, GetCalculatePosition(Positions.TopRight)),
                new Portal(GetCalculatePosition(Positions.BottomRight), MapTypes.EIC_2_4, GetCalculatePosition(Positions.TopLeft)),
            };

            Enemies = MMO_1_2.Instance.Enemies;

            Resources = MMO_1_2.Instance.Resources;
        }
    }
}