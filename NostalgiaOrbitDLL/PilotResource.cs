using System;

namespace NostalgiaOrbitDLL
{
    [Serializable]
    public class PilotResource
    {
        public ResourceTypes ResourceType { get; set; }
        public float Quantity { get; set; }

        public PilotResource()
        {

        }
        public PilotResource(ResourceTypes resourceType, float quantity)
        {
            ResourceType = resourceType;
            Quantity = quantity;
        }
    }
}