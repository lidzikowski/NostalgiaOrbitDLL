using System;
using System.Collections.Generic;

namespace NostalgiaOrbitDLL.Maps
{
    [Serializable]
    public class EIC_2_4 : AbstractMap
    {
        public static EIC_2_4 Instance { get; } = new EIC_2_4();

        public EIC_2_4()
        {
            MapType = MapTypes.EIC_2_4;
            MapIsFirmType = FirmTypes.EIC;

            RequiredLevel = MMO_1_4.Instance.RequiredLevel;
            RequiredLevelForEnemy = MMO_1_4.Instance.RequiredLevelForEnemy;

            Portals = new List<Portal>()
            {
                new Portal(GetCalculatePosition(Positions.TopLeft), MapTypes.EIC_2_2, GetCalculatePosition(Positions.BottomRight)),
                new Portal(GetCalculatePosition(Positions.TopRight), MapTypes.EIC_2_3, GetCalculatePosition(Positions.BottomRight)),
                new Portal(GetCalculatePosition(Positions.BottomLeft), MapTypes.VRU_3_3, GetCalculatePosition(Positions.TopLeft)),
                new Portal(GetCalculatePosition(Positions.BottomMiddle), MapTypes.BATTLE_4_2, GetCalculatePosition(Positions.TopMiddle)),
            };

            Enemies = MMO_1_4.Instance.Enemies;

            Resources = MMO_1_4.Instance.Resources;
        }
    }
}