using NostalgiaOrbitDLL.Core.Commands;
using NostalgiaOrbitDLL.Core.Exceptions;
using System;
using System.Collections.Generic;

namespace NostalgiaOrbitDLL.Core.Validators
{
    [Serializable]
    public class LoginCommandValidator : CommandValidator<LoginCommand>
    {
        public LoginCommandValidator(LoginCommand command) : base(command)
        {
        }

        public override List<NostalgiaOrbitException> IsValid()
        {
            var list = new List<NostalgiaOrbitException>();

            if (IncorrectTextLength(Command.Username, 3, 30))
                list.Add(new IncorrectUsernameException());
            if (IncorrectTextLength(Command.Password, 3, 128))
                list.Add(new IncorrectPasswordException());

            return list;
        }
    }
}