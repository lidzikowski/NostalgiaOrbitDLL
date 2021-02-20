using NostalgiaOrbitDLL.Core.Commands;
using NostalgiaOrbitDLL.Core.Exceptions;
using System;
using System.Collections.Generic;

namespace NostalgiaOrbitDLL.Core.Validators
{
    [Serializable]
    public class RegisterCommandValidator : CommandValidator<RegisterCommand>
    {
        public RegisterCommandValidator(RegisterCommand command) : base(command)
        {
        }

        public override List<NostalgiaOrbitException> IsValid()
        {
            var list = new List<NostalgiaOrbitException>();

            if (IncorrectTextLength(Command.Username, 3, 30))
                list.Add(new IncorrectUsernameException());
            if (IncorrectTextLength(Command.Password, 3, 128))
                list.Add(new IncorrectPasswordException());
            if (IncorrectEmailAddress(Command.Email))
                list.Add(new IncorrectEmailException());
            if (Command.Server == Servers.Main)
                list.Add(new IncorrectServerException());
            if (!Command.Rules)
                list.Add(new IncorrectRulesException());
            if (IncorrectTextLength(Command.PilotName, 3, 30))
                list.Add(new IncorrectPilotNameException());

            return list;
        }
    }
}