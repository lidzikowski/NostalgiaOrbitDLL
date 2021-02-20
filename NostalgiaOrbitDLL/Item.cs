using MongoDB.Bson;
using System;

namespace NostalgiaOrbitDLL
{
    [Serializable]
    public class Item
    {
        public Guid Id { get; set; }
        public ItemTypes ItemType { get; set; }
        public bool IsEquipConfiguration1 { get; set; }
        public bool IsEquipConfiguration2 { get; set; }

        public bool IsEquipInDroneConfiguration1 { get; set; }
        public bool IsEquipInDroneConfiguration2 { get; set; }
        public Guid? DroneIdConfiguration1 { get; set; }
        public Guid? DroneIdConfiguration2 { get; set; }

        public Item()
        {

        }
        public Item(ItemTypes itemType, bool isEquipConfiguration1, bool isEquipConfiguration2)
        {
            Id = Guid.NewGuid();
            ItemType = itemType;
            IsEquipConfiguration1 = isEquipConfiguration1;
            IsEquipConfiguration2 = isEquipConfiguration2;
        }
    }
}