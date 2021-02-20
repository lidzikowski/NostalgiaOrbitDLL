using NostalgiaOrbitDLL.Core.Exceptions;
using System;
using System.Collections.Generic;

namespace NostalgiaOrbitDLL.Core.Validators
{
    [Serializable]
    public abstract class CommandValidator<T>
    {
        public T Command { get; private set; }

        public CommandValidator(T command)
        {
            Command = command;
        }

        public abstract List<NostalgiaOrbitException> IsValid();

        protected bool IncorrectTextLength(string text, int minChar, int maxChar)
        {
            if (string.IsNullOrWhiteSpace(text))
                return true;

            if (text.Length < minChar || text.Length > maxChar)
                return true;

            return false;
        }
        protected bool IncorrectEmailAddress(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address != email;
            }
            catch
            {
                return true;
            }
        }
    }
}