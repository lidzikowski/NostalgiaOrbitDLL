using System;

namespace NostalgiaOrbitDLL.Maps
{
    [Serializable]
    public class Portal
    {
        public PrefabTypes PrefabType { get; set; } = PrefabTypes.Portal;
        public PositionVector Position { get; set; }

        public bool RandomMapAndPosition { get; set; }

        public MapTypes Target_MapType { get; set; }
        public PositionVector Target_Position { get; set; }

        public static int JumpDistance { get; set; } = 40;
        public static int SafeZoneDistance { get; set; } = 70;

        public Portal(PositionVector position, MapTypes target_MapType, PositionVector target_Position)
        {
            Position = position;
            Target_MapType = target_MapType;
            Target_Position = target_Position;
        }
        public Portal(PositionVector position)
        {
            Position = position;
            RandomMapAndPosition = true;
            PrefabType = PrefabTypes.InvisiblePortal;
        }
    }
}