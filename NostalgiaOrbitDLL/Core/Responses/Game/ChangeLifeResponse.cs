using System;

namespace NostalgiaOrbitDLL.Core.Responses
{
    [Serializable]
    public class ChangeLifeResponse : AbstractGameResponse
    {
        public long Hitpoints { get; set; }
        public long MaxHitpoints { get; set; }
        public long Shields { get; set; }
        public long MaxShields { get; set; }

        public ChangeLifeResponse(Guid objectId, long hitpoints, long maxHitpoints, long shields, long maxShields)
        {
            ObjectId = objectId;
            Hitpoints = hitpoints;
            MaxHitpoints = maxHitpoints;
            Shields = shields;
            MaxShields = maxShields;
        }
    }
}