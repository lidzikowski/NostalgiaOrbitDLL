using System;
using System.Runtime.Serialization;

namespace NostalgiaOrbitDLL.Core.Exceptions
{
    [Serializable]
    public class PortalRequiredLevelException : NostalgiaOrbitException, ISerializable
    {
        public PortalRequiredLevelException() { }
        protected PortalRequiredLevelException(SerializationInfo info, StreamingContext context) { }
    }
}