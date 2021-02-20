using System;

namespace NostalgiaOrbitDLL.Core.Responses
{
    [Serializable]
    public class ChangeMapResponse : AbstractGameResponse
    {
        public MapTypes MapType { get; set; }

        public ChangeMapResponse()
        {

        }
        public ChangeMapResponse(MapTypes mapType)
        {
            MapType = mapType;
        }
    }
}