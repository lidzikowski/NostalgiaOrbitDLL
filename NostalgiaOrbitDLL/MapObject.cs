using System;
using System.Collections.Generic;

namespace NostalgiaOrbitDLL
{
    [Serializable]
    public class MapObject
    {
        public Guid Id { get; set; }
        public string Name { get; set; }

        public PrefabTypes ShipType { get; set; }
        public List<Drone> Drones { get; set; }

        public PositionVector Position { get; set; }
        public PositionVector TargetPosition { get; set; }

        public long Hitpoints { get; set; }
        public long MaxHitpoints { get; set; }
        public long Shields { get; set; }
        public long MaxShields { get; set; }
        public long Speed { get; set; }

        public FirmTypes? FirmType { get; set; }
        public RankTypes? RankType { get; set; }

        public MapObject()
        {

        }
        public MapObject(Pilot pilot, PositionVector targetPosition = default)
        {
            Id = pilot.Id;
            Name = pilot.PilotName;
            ShipType = pilot.ShipType;
            Drones = pilot.Drones;
            Position = pilot.Position;
            TargetPosition = targetPosition == default ? pilot.Position : targetPosition;

            Hitpoints = pilot.HaveHitpoints;
            MaxHitpoints = pilot.Equipment_Hitpoints;
            Shields = pilot.HaveShields;
            MaxShields = pilot.Equipment_Shields;

            Speed = pilot.Equipment_Speed;

            FirmType = pilot.FirmType;
            RankType = pilot.RankType;
        }
    }
}