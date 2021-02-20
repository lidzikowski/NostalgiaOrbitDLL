using System;
using System.Collections.Generic;

namespace NostalgiaOrbitDLL.Maps
{
    [Serializable]
    public class EIC_2_6 : AbstractMap
    {
        public static EIC_2_6 Instance { get; } = new EIC_2_6();

        public EIC_2_6()
        {
            MapType = MapTypes.EIC_2_6;
            MapIsFirmType = FirmTypes.EIC;

            RequiredLevel = MMO_1_6.Instance.RequiredLevel;
            RequiredLevelForEnemy = MMO_1_6.Instance.RequiredLevelForEnemy;

            Portals = new List<Portal>()
            {
                new Portal(GetCalculatePosition(Positions.TopRight), MapTypes.EIC_2_8, GetCalculatePosition(Positions.BottomLeft)),
                new Portal(GetCalculatePosition(Positions.BottomLeft), MapTypes.EIC_2_5, GetCalculatePosition(Positions.TopLeft)),
            };

            Enemies = MMO_1_6.Instance.Enemies;

            Resources = MMO_1_6.Instance.Resources;
        }
    }
}