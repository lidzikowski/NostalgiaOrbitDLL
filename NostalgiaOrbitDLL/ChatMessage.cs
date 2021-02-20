using System;

namespace NostalgiaOrbitDLL
{
    [Serializable]
    public class ChatMessage
    {
        public Guid MessageId { get; set; }
        public DateTime Time { get; set; }

        public Guid ChannelId { get; set; }
        public ChatChannelTypes ChannelTyp { get; set; }

        public ChatUser ChatUser { get; set; }
        public string Message { get; set; }

        public bool Banned { get; set; }



        public ChatMessage(Guid channelId, ChatChannelTypes channelTyp, ChatUser chatUser, string message)
        {
            MessageId = Guid.NewGuid();
            Time = DateTime.Now;

            ChannelId = channelId;
            ChannelTyp = channelTyp;

            ChatUser = chatUser;
            Message = message;
        }
    }
}