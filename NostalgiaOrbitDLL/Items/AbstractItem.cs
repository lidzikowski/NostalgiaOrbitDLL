using System;

namespace NostalgiaOrbitDLL.Items
{
    [Serializable]
    public abstract class AbstractItem : ShopItem
    {
        public ItemTypes ItemType { get; protected set; }

        // Laser
        public bool IsLaser { get; protected set; }
        public int LaserDamage { get; protected set; }

        // Shield
        public bool IsShield { get; protected set; }
        public int Shield { get; protected set; }
        public float ShieldAbsorption { get; protected set; }

        // Gear
        public bool IsGear { get; protected set; }
        public int GearSpeed { get; protected set; }

        // Extras
        public bool IsExtras { get; protected set; }
        public bool ExtrasCanRepair { get; protected set; }
        public int ExtrasRepairTime { get; protected set; }

        public static AbstractItem GetItemByType(ItemTypes itemType)
        {
            return itemType switch
            {
                ItemTypes.LF_1 => LF_1.Instance,
                ItemTypes.MP_1 => MP_1.Instance,
                ItemTypes.LF_2 => LF_2.Instance,
                ItemTypes.LF_3 => LF_3.Instance,
                ItemTypes.SG3N_A01 => SG3N_A01.Instance,
                ItemTypes.SG3N_A02 => SG3N_A02.Instance,
                ItemTypes.SG3N_A03 => SG3N_A03.Instance,
                ItemTypes.B01 => B01.Instance,
                ItemTypes.B02 => B02.Instance,
                ItemTypes.G3N_1010 => G3N_1010.Instance,
                ItemTypes.G3N_2010 => G3N_2010.Instance,
                ItemTypes.G3N_3210 => G3N_3210.Instance,
                ItemTypes.G3N_3310 => G3N_3310.Instance,
                ItemTypes.G3N_6900 => G3N_6900.Instance,
                ItemTypes.G3N_7900 => G3N_7900.Instance,
                ItemTypes.REP_1 => REP_1.Instance,
                ItemTypes.REP_2 => REP_2.Instance,
                ItemTypes.REP_3 => REP_3.Instance,
                _ => null,
            };
        }
    }
}