using System;

namespace NostalgiaOrbitDLL.Core.Commands
{
    [Serializable]
    public abstract class AbstractCommand
    {
        public string JWToken { get; protected set; }
        public Guid CommandId { get; set; }

        public void ConfigureJWToken(string token)
        {
            JWToken = token;
        }
    }
}