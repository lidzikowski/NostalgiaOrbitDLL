using System;
using System.Collections.Generic;

namespace NostalgiaOrbitDLL.Drones
{
    [Serializable]
    public abstract class AbstractDrone : ShopItem
    {
        public DroneTypes DroneType { get; protected set; }
        public int LaserOrShieldSlots { get; protected set; }

        public int MaxDronesType { get; protected set; }
        public DroneTypes? CombineWithDrone { get; protected set; }

        public List<DroneLevel> Levels { get; protected set; } = new List<DroneLevel>()
            {
                new DroneLevel(1, 0, 0, 0),
                new DroneLevel(2, 100, 0.02f, 0.04f),
                new DroneLevel(3, 200, 0.04f, 0.08f),
                new DroneLevel(4, 400, 0.06f, 0.12f),
                new DroneLevel(5, 800, 0.08f, 0.16f),
                new DroneLevel(6, 1600, 0.10f, 0.20f),
            };

        public int SurviveDestructions { get; protected set; }

        public static AbstractDrone GetDroneByType(DroneTypes droneType)
        {
            return droneType switch
            {
                DroneTypes.Flax => Flax.Instance,
                DroneTypes.Iris => Iris.Instance,
                _ => null,
            };
        }
    }
}