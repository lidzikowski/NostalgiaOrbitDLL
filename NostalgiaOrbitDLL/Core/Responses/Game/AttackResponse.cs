using System;

namespace NostalgiaOrbitDLL.Core.Responses
{
    [Serializable]
    public class AttackResponse : AbstractGameResponse
    {
        public Guid AttackerId { get; set; }
        public Guid? TargetId { get; set; }
        public ResourceTypes? ResourceType { get; set; }

        public AttackResponse(Guid attackerId, Guid? targetId, ResourceTypes? resourceType)
        {
            AttackerId = attackerId;
            TargetId = targetId;
            ResourceType = resourceType;
        }
    }
}