using System;

namespace NostalgiaOrbitDLL.Core.Commands
{
    [Serializable]
    public class ForgotCommand : AbstractCommand
    {
        public string UsernameOrEmail { get; private set; }

        public ForgotCommand(string usernameOrEmail)
        {
            UsernameOrEmail = usernameOrEmail;
        }
    }
}