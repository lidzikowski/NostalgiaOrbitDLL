using System;
using System.Runtime.Serialization;

namespace NostalgiaOrbitDLL.Core.Exceptions
{
    [Serializable]
    public class PortalNotFoundException : NostalgiaOrbitException, ISerializable
    {
        public PortalNotFoundException() { }
        protected PortalNotFoundException(SerializationInfo info, StreamingContext context) { }
    }
}