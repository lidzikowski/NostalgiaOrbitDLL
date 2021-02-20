using System;
using System.Collections.Generic;

namespace NostalgiaOrbitDLL.Maps
{
    [Serializable]
    public abstract class AbstractMap
    {
        public MapTypes MapType { get; protected set; }
        public FirmTypes MapIsFirmType { get; protected set; }

        public bool IsSafeMap { get; protected set; }
        public bool IsPvp { get; protected set; }

        public int RequiredLevel { get; protected set; }
        public int RequiredLevelForEnemy { get; protected set; }
        public int SynchronizeDistance { get; protected set; } = 100;

        public PositionVector MapSize { get; set; } = NormalSize;
        public static PositionVector NormalSize = new PositionVector(1000, 610);
        public static PositionVector BigSize = new PositionVector(1600, 1010);

        public static int BaseSafeZoneDistance = 100;
        public PositionVector Base_Position { get; set; }
        public PrefabTypes? Base_PrefabType { get; set; }

        public List<Portal> Portals { get; set; } = new List<Portal>();
        public List<ResourceMap> Resources { get; set; } = new List<ResourceMap>();
        public List<EnemyMap> Enemies { get; set; } = new List<EnemyMap>();


        public static AbstractMap GetMapByType(MapTypes mapType)
        {
            return mapType switch
            {
                MapTypes.MMO_1_1 => MMO_1_1.Instance,
                MapTypes.MMO_1_2 => MMO_1_2.Instance,
                MapTypes.MMO_1_3 => MMO_1_3.Instance,
                MapTypes.MMO_1_4 => MMO_1_4.Instance,
                MapTypes.MMO_1_5 => MMO_1_5.Instance,
                MapTypes.MMO_1_6 => MMO_1_6.Instance,
                MapTypes.MMO_1_7 => MMO_1_7.Instance,
                MapTypes.MMO_1_8 => MMO_1_8.Instance,

                MapTypes.EIC_2_1 => EIC_2_1.Instance,
                MapTypes.EIC_2_2 => EIC_2_2.Instance,
                MapTypes.EIC_2_3 => EIC_2_3.Instance,
                MapTypes.EIC_2_4 => EIC_2_4.Instance,
                MapTypes.EIC_2_5 => EIC_2_5.Instance,
                MapTypes.EIC_2_6 => EIC_2_6.Instance,
                MapTypes.EIC_2_7 => EIC_2_7.Instance,
                MapTypes.EIC_2_8 => EIC_2_8.Instance,

                MapTypes.VRU_3_1 => VRU_3_1.Instance,
                MapTypes.VRU_3_2 => VRU_3_2.Instance,
                MapTypes.VRU_3_3 => VRU_3_3.Instance,
                MapTypes.VRU_3_4 => VRU_3_4.Instance,
                MapTypes.VRU_3_5 => VRU_3_5.Instance,
                MapTypes.VRU_3_6 => VRU_3_6.Instance,
                MapTypes.VRU_3_7 => VRU_3_7.Instance,
                MapTypes.VRU_3_8 => VRU_3_8.Instance,

                MapTypes.BATTLE_4_1 => BATTLE_4_1.Instance,
                MapTypes.BATTLE_4_2 => BATTLE_4_2.Instance,
                MapTypes.BATTLE_4_3 => BATTLE_4_3.Instance,
                MapTypes.BATTLE_4_4 => BATTLE_4_4.Instance,
                MapTypes.BATTLE_4_5 => BATTLE_4_5.Instance,

                //MapTypes.GATE_ALPHA => GATE_ALPHA.Instance,
                //MapTypes.GATE_BETA => GATE_BETA.Instance,
                //MapTypes.GATE_GAMMA => GATE_GAMMA.Instance,
                //MapTypes.GATE_DELTA => GATE_DELTA.Instance,

                MapTypes.BONUS => BONUS.Instance,

                _ => throw new NotImplementedException()
            };
        }

        private readonly int distance = 75;
        public PositionVector GetCalculatePosition(Positions position, PositionVector mapSize = null, int x = 0, int y = 0)
        {
            mapSize = mapSize ?? MapSize;

            var result = position switch
            {
                Positions.TopLeft => new PositionVector(distance, -distance),
                Positions.TopMiddle => new PositionVector(mapSize.Position_X / 2, -distance),
                Positions.TopRight => new PositionVector(mapSize.Position_X - distance, -distance),

                Positions.MiddleLeft => new PositionVector(distance, -mapSize.Position_Y / 2),
                Positions.Middle => new PositionVector(mapSize.Position_X / 2, -mapSize.Position_Y / 2),
                Positions.MiddleRight => new PositionVector(mapSize.Position_X - distance, -mapSize.Position_Y / 2),

                Positions.BottomLeft => new PositionVector(distance, -(mapSize.Position_Y - distance)),
                Positions.BottomMiddle => new PositionVector(mapSize.Position_X / 2, -(mapSize.Position_Y - distance)),
                Positions.BottomRight => new PositionVector(mapSize.Position_X - distance, -(mapSize.Position_Y - distance)),

                _ => throw new NotImplementedException(),
            };

            if (x != 0)
                result.Position_X += x;
            if (y != 0)
                result.Position_Y += y;

            return result;
        }
        public PositionVector GetZeroPosition()
        {
            return new PositionVector(0, 0);
        }
        public PositionVector GetMaxPosition()
        {
            return new PositionVector(MapSize.Position_X, -MapSize.Position_Y);
        }
    }
}