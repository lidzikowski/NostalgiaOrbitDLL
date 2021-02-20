using System.Collections.Generic;

namespace NostalgiaOrbitDLL.Drones
{
    public interface IDroneLeveling
    {
        List<DroneExperience> ExperiencePerKill { get; }
    }
}