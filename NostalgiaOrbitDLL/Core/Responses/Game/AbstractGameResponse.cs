using System;

namespace NostalgiaOrbitDLL.Core.Responses
{
    [Serializable]
    public abstract class AbstractGameResponse : AbstractResponse
    {
        public Guid ObjectId { get; set; }
    }
}