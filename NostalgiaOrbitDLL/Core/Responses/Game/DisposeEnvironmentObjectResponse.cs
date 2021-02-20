using System;

namespace NostalgiaOrbitDLL.Core.Responses
{
    [Serializable]
    public class DisposeEnvironmentObjectResponse : AbstractGameResponse
    {
        public DisposeEnvironmentObjectResponse(Guid objectId)
        {
            ObjectId = objectId;
        }
    }
}