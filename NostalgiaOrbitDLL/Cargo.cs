using System;

namespace NostalgiaOrbitDLL
{
    [Serializable]
    public class Cargo
    {
        public ResourceTypes Resource { get; set; }
        public float Quantity { get; set; }

        public Cargo(ResourceTypes resource, float quantity)
        {
            Resource = resource;
            Quantity = quantity;
        }
    }
}