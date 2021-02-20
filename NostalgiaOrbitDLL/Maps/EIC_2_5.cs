using System;
using System.Collections.Generic;

namespace NostalgiaOrbitDLL.Maps
{
    [Serializable]
    public class EIC_2_5 : AbstractMap
    {
        public static EIC_2_5 Instance { get; } = new EIC_2_5();

        public EIC_2_5()
        {
            MapType = MapTypes.EIC_2_5;
            MapIsFirmType = FirmTypes.EIC;

            RequiredLevel = MMO_1_5.Instance.RequiredLevel;
            RequiredLevelForEnemy = MMO_1_5.Instance.RequiredLevelForEnemy;

            Portals = new List<Portal>()
            {
                new Portal(GetCalculatePosition(Positions.TopLeft), MapTypes.EIC_2_6, GetCalculatePosition(Positions.BottomLeft)),
                new Portal(GetCalculatePosition(Positions.TopRight), MapTypes.EIC_2_7, GetCalculatePosition(Positions.BottomLeft)),
                new Portal(GetCalculatePosition(Positions.BottomLeft), MapTypes.BATTLE_4_4, GetCalculatePosition(Positions.TopMiddle, BigSize, x:400)),
                new Portal(GetCalculatePosition(Positions.BottomRight), MapTypes.BATTLE_4_5, GetCalculatePosition(Positions.TopMiddle, BigSize, x:400)),
            };

            Enemies = MMO_1_5.Instance.Enemies;

            Resources = MMO_1_5.Instance.Resources;
        }
    }
}