using System;

namespace NostalgiaOrbitDLL.Core.Responses
{
    [Serializable]
    public class PilotDataResponse : AbstractResponse
    {
        public Pilot Pilot { get; set; }

        public PilotDataResponse(Pilot pilot)
        {
            Pilot = pilot;
        }
    }
}