using NostalgiaOrbitDLL.Core;
using System;

namespace NostalgiaOrbitDLL
{
    [Serializable]
    public class Drone
    {
        public Guid Id { get; set; }
        public DroneTypes DroneType { get; set; }
        public int Level { get; set; } = 1;
        public int Experience { get; set; }
        public int Destructions { get; set; }
        public PrefabTypes DronePrefab { get => DroneType.GetDronePrefab(Level); }

        public Drone(DroneTypes droneType)
        {
            Id = Guid.NewGuid();
            DroneType = droneType;
        }
    }
}