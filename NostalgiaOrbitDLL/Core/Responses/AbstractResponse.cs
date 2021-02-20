using NostalgiaOrbitDLL.Core.Commands;
using NostalgiaOrbitDLL.Core.Exceptions;
using System;
using System.Collections.Generic;

namespace NostalgiaOrbitDLL.Core.Responses
{
    [Serializable]
    public abstract class AbstractResponse
    {
        public Guid ResponseId { get; set; }
        public List<NostalgiaOrbitException> Exceptions { get; set; }

        public AbstractResponse SetResponseId(AbstractCommand abstractCommand)
        {
            ResponseId = abstractCommand.CommandId;
            return this;
        }
    }
}