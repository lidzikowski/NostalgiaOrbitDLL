using System;

namespace NostalgiaOrbitDLL.Core.Responses
{
    [Serializable]
    public class ConnectToChannelResponse : AbstractResponse
    {
        public Guid ChannelId { get; set; }
        public ChatChannelTypes ChannelType { get; set; }
        public ChatUser User { get; set; }

        public ConnectToChannelResponse(Guid channelId, ChatChannelTypes channelType, ChatUser user)
        {
            ChannelId = channelId;
            ChannelType = channelType;
            User = user;
        }
    }
}