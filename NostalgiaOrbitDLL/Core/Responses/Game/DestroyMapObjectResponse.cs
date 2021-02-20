using System;

namespace NostalgiaOrbitDLL.Core.Responses
{
    [Serializable]
    public class DestroyMapObjectResponse : AbstractGameResponse
    {
        public Guid? KillByObjectId { get; set; }
        public string KillbyName { get; set; }

        public DestroyMapObjectResponse(Guid objectId, Guid? killByObjectId, string killbyName)
        {
            ObjectId = objectId;
            KillByObjectId = killByObjectId;
            KillbyName = killbyName;
        }
    }
}