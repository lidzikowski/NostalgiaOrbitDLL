using System;

namespace NostalgiaOrbitDLL.Core.Commands
{
    [Serializable]
    public class LogoutCommand : AbstractCommand
    {
        public LogoutTypes LogoutType { get; private set; }
        public bool Cancel { get; private set; }

        public LogoutCommand(LogoutTypes logoutType, bool cancel = false)
        {
            LogoutType = logoutType;
            Cancel = cancel;
        }
    }

    [Serializable]
    public enum LogoutTypes
    {
        FromHome,
        FromMap
    }
}