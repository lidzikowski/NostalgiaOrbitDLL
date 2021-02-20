using System;

namespace NostalgiaOrbitDLL.Drones
{
    [Serializable]
    public class DroneLevel
    {
        public int Level { get; protected set; }
        public int RequiredExperience { get; protected set; }
        public float LaserBonus { get; protected set; }
        public float ShieldBonus { get; protected set; }

        public DroneLevel(int level, int requiredExperience, float laserBonus, float shieldBonus)
        {
            Level = level;
            RequiredExperience = requiredExperience;
            LaserBonus = laserBonus;
            ShieldBonus = shieldBonus;
        }
    }
}