using System;

namespace NostalgiaOrbitDLL.Core.Commands
{
    [Serializable]
    public class CollectEnvironmentCommand : AbstractCommand
    {
        public Guid EnvironmentId { get; private set; }

        public CollectEnvironmentCommand(Guid environmentId)
        {
            EnvironmentId = environmentId;
        }
    }
}