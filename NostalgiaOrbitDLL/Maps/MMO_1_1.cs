using System;
using System.Collections.Generic;

namespace NostalgiaOrbitDLL.Maps
{
    [Serializable]
    public class MMO_1_1 : AbstractMap
    {
        public static MMO_1_1 Instance { get; } = new MMO_1_1();

        public MMO_1_1()
        {
            MapType = MapTypes.MMO_1_1;
            MapIsFirmType = FirmTypes.MMO;

            IsSafeMap = true;

            RequiredLevel = 1;
            RequiredLevelForEnemy = 16;

            Base_Position = GetCalculatePosition(Positions.TopLeft);
            Base_PrefabType = PrefabTypes.Base;

            Portals = new List<Portal>()
            {
                new Portal(GetCalculatePosition(Positions.BottomRight), MapTypes.MMO_1_2, GetCalculatePosition(Positions.TopLeft))
            };

            Enemies = new List<EnemyMap>()
            {
                new EnemyMap(PrefabTypes.Streuner, 30, this),
            };

            Resources = new List<ResourceMap>()
            {
                new ResourceMap(PrefabTypes.Prometium, 20, GetCalculatePosition(Positions.TopLeft), GetCalculatePosition(Positions.Middle)),

                new ResourceMap(PrefabTypes.BonusBox, 100, GetZeroPosition(), GetMaxPosition()),
            };
        }
    }
}