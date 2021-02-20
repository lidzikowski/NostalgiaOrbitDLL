using System;

namespace NostalgiaOrbitDLL.Core.Responses
{
    [Serializable]
    public class ChangeEnvironmentObjectResponse : AbstractGameResponse
    {
        public PrefabTypes NewPrefabType { get; set; }

        public ChangeEnvironmentObjectResponse(Guid objectId, PrefabTypes newPrefabType)
        {
            ObjectId = objectId;
            NewPrefabType = newPrefabType;
        }
    }
}