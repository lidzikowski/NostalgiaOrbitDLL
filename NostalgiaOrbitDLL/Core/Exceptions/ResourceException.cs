using System;
using System.Runtime.Serialization;

namespace NostalgiaOrbitDLL.Core.Exceptions
{
    [Serializable]
    public class ResourceException : NostalgiaOrbitException, ISerializable
    {
        public ResourceException() { }
        protected ResourceException(SerializationInfo info, StreamingContext context) { }
    }
}