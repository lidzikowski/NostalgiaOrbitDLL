using System;
using System.Collections.Generic;

namespace NostalgiaOrbitDLL.Core.Responses
{
    [Serializable]
    public class ResourceUpdateResponse : AbstractGameResponse
    {
        public List<PilotResource> PilotResource { get; set; }

        public ResourceUpdateResponse(PilotResource pilotResource)
        {
            PilotResource = new List<PilotResource>() { pilotResource };
        }
        public ResourceUpdateResponse(List<PilotResource> pilotResources)
        {
            PilotResource = pilotResources;
        }
    }
}