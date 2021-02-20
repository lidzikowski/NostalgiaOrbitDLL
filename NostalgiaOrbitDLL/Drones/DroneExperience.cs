using System;

namespace NostalgiaOrbitDLL.Drones
{
    [Serializable]
    public class DroneExperience
    {
        public PrefabTypes ShipType { get; protected set; }
        public int Experience { get; protected set; }

        public DroneExperience(PrefabTypes shipType, int experience)
        {
            ShipType = shipType;
            Experience = experience;
        }
    }
}