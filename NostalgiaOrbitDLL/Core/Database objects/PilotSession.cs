using System;
using System.Collections.Generic;

namespace NostalgiaOrbitDLL.Core.Database_objects
{
    [Serializable]
    public class PilotSession
    {
        public string JWToken { get; private set; }
        public Guid PilotId { get; private set; }
        public Dictionary<ServerChannels, string> ChannelSocketId { get; private set; }

        public PilotSession(string jWToken, Guid pilotId, ServerChannels channel, string socketId)
        {
            JWToken = jWToken;
            PilotId = pilotId;
            ChannelSocketId = new Dictionary<ServerChannels, string>()
            {
                { channel, socketId }
            };
        }
        public PilotSession(string jWToken, Guid pilotId, Dictionary<ServerChannels, string> channelSocketId)
        {
            JWToken = jWToken;
            PilotId = pilotId;
            ChannelSocketId = channelSocketId;
        }

        public void AddOrUpdateChannel(ServerChannels channel, string jwt, string socketId)
        {
            JWToken = jwt;

            if (!ChannelSocketId.ContainsKey(channel))
                ChannelSocketId.Add(channel, socketId);
            else
                ChannelSocketId[channel] = socketId;
        }

        public void RemoveChannel(ServerChannels channel, bool all = false)
        {
            if (all)
            {
                ChannelSocketId.Clear();
            }
            else if (ChannelSocketId.ContainsKey(channel))
            {
                ChannelSocketId.Remove(channel);
            }
        }
    }
}