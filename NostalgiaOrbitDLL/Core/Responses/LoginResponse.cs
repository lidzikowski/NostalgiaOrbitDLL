using System;

namespace NostalgiaOrbitDLL.Core.Responses
{
    [Serializable]
    public class LoginResponse : AbstractResponse
    {
        public Pilot Pilot { get; set; }
        public string JWToken { get; set; }

        public LoginResponse()
        {

        }
        public LoginResponse(Pilot pilot, string jwt)
        {
            Pilot = pilot;
            JWToken = jwt;
        }
    }
}