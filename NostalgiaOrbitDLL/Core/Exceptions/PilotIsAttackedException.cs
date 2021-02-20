using System;
using System.Runtime.Serialization;

namespace NostalgiaOrbitDLL.Core.Exceptions
{
    [Serializable]
    public class PilotIsAttackedException : NostalgiaOrbitException, ISerializable
    {
        public PilotIsAttackedException() { }
        protected PilotIsAttackedException(SerializationInfo info, StreamingContext context) { }
    }
}