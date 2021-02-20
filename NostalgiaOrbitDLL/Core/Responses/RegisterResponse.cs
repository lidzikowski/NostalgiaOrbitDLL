using System;

namespace NostalgiaOrbitDLL.Core.Responses
{
    [Serializable]
    public class RegisterResponse : AbstractResponse
    {
        public Pilot Pilot { get; set; }
        public string JWToken { get; set; }

        public RegisterResponse()
        {

        }
        public RegisterResponse(Pilot pilot, string jwt)
        {
            Pilot = pilot;
            JWToken = jwt;
        }
    }
}