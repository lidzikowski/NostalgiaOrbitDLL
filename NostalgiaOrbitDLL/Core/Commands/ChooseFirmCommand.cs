using System;

namespace NostalgiaOrbitDLL.Core.Commands
{
    [Serializable]
    public class ChooseFirmCommand : AbstractCommand
    {
        public FirmTypes FirmType { get; private set; }

        public ChooseFirmCommand(FirmTypes firmType)
        {
            FirmType = firmType;
        }
    }
}