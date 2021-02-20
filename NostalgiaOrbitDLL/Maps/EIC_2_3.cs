using System;
using System.Collections.Generic;

namespace NostalgiaOrbitDLL.Maps
{
    [Serializable]
    public class EIC_2_3 : AbstractMap
    {
        public static EIC_2_3 Instance { get; } = new EIC_2_3();

        public EIC_2_3()
        {
            MapType = MapTypes.EIC_2_3;
            MapIsFirmType = FirmTypes.EIC;

            RequiredLevel = MMO_1_3.Instance.RequiredLevel;
            RequiredLevelForEnemy = MMO_1_3.Instance.RequiredLevelForEnemy;

            Portals = new List<Portal>()
            {
                new Portal(GetCalculatePosition(Positions.TopRight), MapTypes.EIC_2_2, GetCalculatePosition(Positions.BottomLeft)),
                new Portal(GetCalculatePosition(Positions.BottomLeft), MapTypes.MMO_1_3, GetCalculatePosition(Positions.TopRight)),
                new Portal(GetCalculatePosition(Positions.BottomRight), MapTypes.EIC_2_4, GetCalculatePosition(Positions.TopRight)),
            };

            Enemies = MMO_1_3.Instance.Enemies;

            Resources = MMO_1_3.Instance.Resources;
        }
    }
}