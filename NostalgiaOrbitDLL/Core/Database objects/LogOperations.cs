using System;
namespace NostalgiaOrbitDLL.Core.Database_objects
{
    [Serializable]
    public enum LogOperations
    {
        ServerStart,
        ServerStop,
        ServerError,

        SocketOpen,
        SocketClose,
        SocketError,
        SocketMessage,
    }
}