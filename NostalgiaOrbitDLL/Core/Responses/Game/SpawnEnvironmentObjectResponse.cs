using System;

namespace NostalgiaOrbitDLL.Core.Responses
{
    [Serializable]
    public class SpawnEnvironmentObjectResponse : AbstractGameResponse
    {
        public EnvironmentObject EnvironmentObject { get; set; }
        public PrefabTypes OriginalPrefabType { get; set; }

        public SpawnEnvironmentObjectResponse(EnvironmentObject environmentObject, PrefabTypes originalPrefabType)
        {
            EnvironmentObject = environmentObject;
            OriginalPrefabType = originalPrefabType;
        }
    }
}