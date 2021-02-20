using System;
using System.Runtime.Serialization;

namespace NostalgiaOrbitDLL.Core.Exceptions
{
    [Serializable]
    public class BugHandleException : NostalgiaOrbitException, ISerializable
    {
        public BugHandleException() { }
        protected BugHandleException(SerializationInfo info, StreamingContext context) { }
    }
}