using System;

namespace NostalgiaOrbitDLL.Core.Commands
{
    [Serializable]
    public class ChannelMessageCommand : AbstractCommand
    {
        public Guid ChannelId { get; set; }
        public string Message { get; set; }

        public ChannelMessageCommand(Guid channelId, string message)
        {
            ChannelId = channelId;
            Message = message;
        }
    }
}