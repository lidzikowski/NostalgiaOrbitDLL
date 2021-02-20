using System;

namespace NostalgiaOrbitDLL.Core.Responses
{
    [Serializable]
    public class SafeZoneResponse : AbstractGameResponse
    {
        public bool Status { get; set; }

        public SafeZoneResponse(Guid objectId, bool status)
        {
            ObjectId = objectId;
            Status = status;
        }
    }
}