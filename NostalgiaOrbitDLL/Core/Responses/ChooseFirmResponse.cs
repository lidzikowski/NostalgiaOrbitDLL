using NostalgiaOrbitDLL.Core.Commands;
using System;

namespace NostalgiaOrbitDLL.Core.Responses
{
    [Serializable]
    public class ChooseFirmResponse : AbstractResponse
    {
        public FirmTypes FirmType { get; set; }

        public ChooseFirmResponse()
        {

        }
        public ChooseFirmResponse(ChooseFirmCommand chooseFirmCommand)
        {
            FirmType = chooseFirmCommand.FirmType;
        }
    }
}