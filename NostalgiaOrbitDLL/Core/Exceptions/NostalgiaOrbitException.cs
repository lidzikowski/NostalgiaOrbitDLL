using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace NostalgiaOrbitDLL.Core.Exceptions
{
    [Serializable]
    public abstract class NostalgiaOrbitException : Exception, ISerializable
    {
        public NostalgiaOrbitException() { }
        protected NostalgiaOrbitException(SerializationInfo info, StreamingContext context) { }
    
        public static List<NostalgiaOrbitException> One(NostalgiaOrbitException exception)
        {
            return new List<NostalgiaOrbitException>() { exception };
        }
    }
}