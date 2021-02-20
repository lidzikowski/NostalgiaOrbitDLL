using System;

namespace NostalgiaOrbitDLL.Core.Responses
{
    [Serializable]
    public class OnlinePlayersResponse : AbstractResponse
    {
        public int OnlinePilots { get; private set; }
        public long RegisteredPilots { get; private set; }

        public OnlinePlayersResponse(int onlinePilots, long registeredPilots)
        {
            OnlinePilots = onlinePilots;
            RegisteredPilots = registeredPilots;
        }
    }
}