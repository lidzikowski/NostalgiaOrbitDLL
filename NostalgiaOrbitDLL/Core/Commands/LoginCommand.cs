using System;

namespace NostalgiaOrbitDLL.Core.Commands
{
    [Serializable]
    public class LoginCommand : AbstractCommand
    {
        public string Username { get; private set; }
        public string Password { get; private set; }

        public LoginCommand(string username, string password)
        {
            Username = username;
            Password = password;
        }

        public void HashPassword()
        {
            Password = DLLHelpers.HashSHA512(Password);
        }
    }
}