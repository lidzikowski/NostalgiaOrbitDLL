using System;

namespace NostalgiaOrbitDLL.Core.Database_objects
{
    [Serializable]
    public class Log
    {
        public Guid Guid { get; set; }
        public DateTime Time { get; set; } = DateTime.Now;
        public LogOperations Operation { get; set; }
        public string Header { get; set; }
        public string SocketId { get; set; }

        public string Message { get; set; }
        public string Data { get; set; }

        public Log(LogOperations operation)
        {
            Operation = operation;
        }
        public Log(LogOperations operation, Exception exception)
        {
            Operation = operation;
            Message = exception.Message;
            Data = exception.StackTrace;
        }
        public Log(LogOperations operation, string header, string socketId, string message, string data)
        {
            Operation = operation;
            Header = header;
            SocketId = socketId;
            Message = message;
            Data = data;
        }
        public Log(LogOperations operation, string header, string socketId, Exception exception) : this(operation, header, socketId, exception.Message, exception.StackTrace)
        {
        }
    }
}