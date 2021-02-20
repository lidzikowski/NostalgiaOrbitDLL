using NostalgiaOrbitDLL.Core.Commands;
using NostalgiaOrbitDLL.Core.Exceptions;
using System;
using System.Collections.Generic;

namespace NostalgiaOrbitDLL.Core.Validators
{
    [Serializable]
    public class ChooseFirmCommandValidator : CommandValidator<ChooseFirmCommand>
    {
        public ChooseFirmCommandValidator(ChooseFirmCommand command) : base(command)
        {
        }

        public override List<NostalgiaOrbitException> IsValid()
        {
            var list = new List<NostalgiaOrbitException>();

            if (Command.FirmType == FirmTypes.None)
                list.Add(new BugHandleException());

            return list;
        }
    }
}