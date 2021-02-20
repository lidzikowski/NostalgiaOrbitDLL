using System;
using System.Runtime.Serialization;

namespace NostalgiaOrbitDLL.Core.Exceptions
{
    [Serializable]
    public class UnknownChannelException : NostalgiaOrbitException, ISerializable
    {
        public ServerChannels ServerChannel { get; private set; }

        public UnknownChannelException(ServerChannels serverChannel)
        {
            ServerChannel = serverChannel;
        }
        public UnknownChannelException() { }
        protected UnknownChannelException(SerializationInfo info, StreamingContext context) { }
    }
}