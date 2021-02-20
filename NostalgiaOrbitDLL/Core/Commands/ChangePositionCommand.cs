using System;

namespace NostalgiaOrbitDLL.Core.Commands
{
    [Serializable]
    public class ChangePositionCommand : AbstractCommand
    {
        public PositionVector TargetPosition { get; private set; }

        public ChangePositionCommand(MapObject mapObject)
        {
            TargetPosition = mapObject.TargetPosition;
        }
    }
}