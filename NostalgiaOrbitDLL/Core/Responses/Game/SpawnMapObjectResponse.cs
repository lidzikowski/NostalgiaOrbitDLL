using System;

namespace NostalgiaOrbitDLL.Core.Responses
{
    [Serializable]
    public class SpawnMapObjectResponse : AbstractGameResponse
    {
        public MapObject MapObject { get; set; }

        public SpawnMapObjectResponse(MapObject mapObject)
        {
            MapObject = mapObject;
        }
    }
}