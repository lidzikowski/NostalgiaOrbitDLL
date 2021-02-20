using System;

namespace NostalgiaOrbitDLL.Core.Commands
{
    [Serializable]
    public class LogoutCommand : AbstractCommand
    {
        public LogoutTypes LogoutType { get; private set; }

        public LogoutCommand(LogoutTypes logoutType)
        {
            LogoutType = logoutType;
        }
    }

    [Serializable]
    public enum LogoutTypes
    {
        FromHome,
        FromMap
    }
}