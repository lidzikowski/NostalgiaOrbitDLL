using System;

namespace NostalgiaOrbitDLL.Core.Responses
{
    [Serializable]
    public class JoinToMapResponse : AbstractGameResponse
    {
        public Pilot Pilot { get; set; }

        public JoinToMapResponse(Pilot pilot)
        {
            Pilot = pilot;
        }
    }
}