using System;

namespace NostalgiaOrbitDLL.Core.Responses
{
    [Serializable]
    public class DisposeMapObjectResponse : AbstractGameResponse
    {
        public bool IsDead { get; set; }

        public DisposeMapObjectResponse(Guid objectId, bool isDead)
        {
            ObjectId = objectId;
            IsDead = isDead;
        }
    }
}