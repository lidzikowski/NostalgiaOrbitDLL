using System;
using System.Collections.Generic;

namespace NostalgiaOrbitDLL
{
    [Serializable]
    public class Reward
    {
        public int Experience { get; set; }
        public int Honor { get; set; }
        public Dictionary<ResourceTypes, float> Resources { get; set; } = new Dictionary<ResourceTypes, float>();
        public List<ItemTypes> Items { get; set; } = new List<ItemTypes>();
        public List<Cargo> Cargos { get; set; } = new List<Cargo>();
    }
}