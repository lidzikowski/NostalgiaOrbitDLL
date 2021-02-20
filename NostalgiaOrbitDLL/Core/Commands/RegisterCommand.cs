using System;

namespace NostalgiaOrbitDLL.Core.Commands
{
    [Serializable]
    public class RegisterCommand : AbstractCommand
    {
        public string Username { get; private set; }
        public string Password { get; private set; }
        public string Email { get; private set; }
        public Servers Server { get; private set; }
        public bool Rules { get; private set; }
        public bool Newsletter { get; private set; }
        public string PilotName { get; private set; }

        public RegisterCommand(string username, string password, string email, Servers server, bool rules, bool newsletter, string pilotName)
        {
            Username = username;
            Password = password;
            Email = email;
            Server = server;
            Rules = rules;
            Newsletter = newsletter;
            PilotName = pilotName;
        }

        public void HashPassword()
        {
            Password = DLLHelpers.HashSHA512(Password);
        }
    }
}