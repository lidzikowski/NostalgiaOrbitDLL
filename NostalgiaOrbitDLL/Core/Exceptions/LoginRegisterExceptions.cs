using System;
using System.Runtime.Serialization;

namespace NostalgiaOrbitDLL.Core.Exceptions
{
    [Serializable]
    public class IncorrectUsernameException : NostalgiaOrbitException, ISerializable
    {
        public IncorrectUsernameException() { }
        protected IncorrectUsernameException(SerializationInfo info, StreamingContext context) { }
    }

    [Serializable]
    public class IncorrectPasswordException : NostalgiaOrbitException, ISerializable
    {
        public IncorrectPasswordException() { }
        protected IncorrectPasswordException(SerializationInfo info, StreamingContext context) { }
    }

    [Serializable]
    public class IncorrectEmailException : NostalgiaOrbitException, ISerializable
    {
        public IncorrectEmailException() { }
        protected IncorrectEmailException(SerializationInfo info, StreamingContext context) { }
    }

    [Serializable]
    public class IncorrectServerException : NostalgiaOrbitException, ISerializable
    {
        public IncorrectServerException() { }
        protected IncorrectServerException(SerializationInfo info, StreamingContext context) { }
    }

    [Serializable]
    public class IncorrectPilotNameException : NostalgiaOrbitException, ISerializable
    {
        public IncorrectPilotNameException() { }
        protected IncorrectPilotNameException(SerializationInfo info, StreamingContext context) { }
    }

    [Serializable]
    public class IncorrectRulesException : NostalgiaOrbitException, ISerializable
    {
        public IncorrectRulesException() { }
        protected IncorrectRulesException(SerializationInfo info, StreamingContext context) { }
    }

    [Serializable]
    public class OccupiedUsernameException : NostalgiaOrbitException, ISerializable
    {
        public OccupiedUsernameException() { }
        protected OccupiedUsernameException(SerializationInfo info, StreamingContext context) { }
    }

    [Serializable]
    public class OccupiedEmailException : NostalgiaOrbitException, ISerializable
    {
        public OccupiedEmailException() { }
        protected OccupiedEmailException(SerializationInfo info, StreamingContext context) { }
    }

    [Serializable]
    public class OccupiedPilotNameException : NostalgiaOrbitException, ISerializable
    {
        public OccupiedPilotNameException() { }
        protected OccupiedPilotNameException(SerializationInfo info, StreamingContext context) { }
    }

    [Serializable]
    public class IncorrectUsernameOrPasswordException : NostalgiaOrbitException, ISerializable
    {
        public IncorrectUsernameOrPasswordException() { }
        protected IncorrectUsernameOrPasswordException(SerializationInfo info, StreamingContext context) { }
    }
}