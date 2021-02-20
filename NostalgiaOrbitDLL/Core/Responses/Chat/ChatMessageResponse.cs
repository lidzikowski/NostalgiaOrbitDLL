using System;
using System.Collections.Generic;

namespace NostalgiaOrbitDLL.Core.Responses
{
    [Serializable]
    public class ChatMessageResponse : AbstractResponse
    {
        public List<ChatMessage> Messages { get; set; }

        public ChatMessageResponse(ChatMessage message)
        {
            Messages = new List<ChatMessage>() { message };
        }
        public ChatMessageResponse(List<ChatMessage> messages)
        {
            Messages = messages;
        }
    }
}