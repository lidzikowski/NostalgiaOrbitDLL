using System;

namespace NostalgiaOrbitDLL.Core.Responses
{
    [Serializable]
    public class ChangeMapObjectPositionResponse : AbstractGameResponse
    {
        public PositionVector Position { get; set; }
        public PositionVector TargetPosition { get; set; }
        public long Speed { get; set; }

        public ChangeMapObjectPositionResponse(Guid objectId, PositionVector position, PositionVector targetPosition, long speed)
        {
            ObjectId = objectId;
            Position = position;
            TargetPosition = targetPosition;
            Speed = speed;
        }
    }
}