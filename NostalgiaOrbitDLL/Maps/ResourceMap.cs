using System;

namespace NostalgiaOrbitDLL.Maps
{
    [Serializable]
    public class ResourceMap
    {
        public PrefabTypes PrefabType { get; protected set; }

        public int Quantity { get; protected set; }

        public PositionVector AreaSpawn_Min { get; protected set; }
        public PositionVector AreaSpawn_Max { get; protected set; }

        public ResourceMap(PrefabTypes prefabType, int quantity, PositionVector areaSpawn_Min, PositionVector areaSpawn_Max)
        {
            PrefabType = prefabType;
            Quantity = quantity;
            AreaSpawn_Min = areaSpawn_Min;
            AreaSpawn_Max = areaSpawn_Max;
        }
    }
}