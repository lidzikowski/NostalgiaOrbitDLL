using System;

namespace NostalgiaOrbitDLL.Core.Responses
{
    [Serializable]
    public class RewardResponse : AbstractGameResponse
    {
        public Reward Reward { get; set; }
        public string MapObject { get; set; }

        public RewardResponse(Reward reward)
        {
            Reward = reward;
        }
        public RewardResponse(Reward reward, string mapObject)
        {
            Reward = reward;
            MapObject = mapObject;
        }
    }
}