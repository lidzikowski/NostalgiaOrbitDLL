using System;

namespace NostalgiaOrbitDLL
{
    [Serializable]
    public class OwnedShip
    {
        public PrefabTypes ShipType { get; set; }
        public long Hitpoints { get; set; }

        public OwnedShip(PrefabTypes shipType, long hitpoints = 1000)
        {
            ShipType = shipType;
            Hitpoints = hitpoints;
        }
    }
}