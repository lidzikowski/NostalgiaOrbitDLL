using System;

namespace NostalgiaOrbitDLL.Core.Responses
{
    [Serializable]
    public class LogoutResponse : AbstractGameResponse
    {
        public bool IsWantLogout { get; set; }
        public int RequireLogoutTime { get; set; }
        public int LogoutTimer { get; set; }

        public LogoutResponse(bool isWantLogout, int requireLogoutTime, int logoutTimer)
        {
            IsWantLogout = isWantLogout;
            RequireLogoutTime = requireLogoutTime;
            LogoutTimer = logoutTimer;
        }
    }
}