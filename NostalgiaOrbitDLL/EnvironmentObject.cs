using NostalgiaOrbitDLL.Environments;
using System;

namespace NostalgiaOrbitDLL
{
    [Serializable]
    public class EnvironmentObject
    {
        public Guid Id { get; set; }
        public AbstractEnvironment AbstractEnvironment { get; set; }
        public PositionVector Position { get; set; }
        public PrefabTypes PrefabType { get; set; }
        public Guid? OwnerId { get; set; }



        public EnvironmentObject(Guid id, AbstractEnvironment abstractEnvironment, PositionVector position, PrefabTypes prefabType, Guid? ownerId)
        {
            Id = id;
            AbstractEnvironment = abstractEnvironment;
            Position = position;
            PrefabType = prefabType;
            OwnerId = ownerId;
        }
    }
}