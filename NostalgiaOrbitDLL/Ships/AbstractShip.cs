using NostalgiaOrbitDLL.Core;
using NostalgiaOrbitDLL.Drones;
using System;
using System.Collections.Generic;

namespace NostalgiaOrbitDLL.Ships
{
    [Serializable]
    public abstract class AbstractShip : ShopItem, IDroneLeveling
    {
        public PrefabTypes ShipType { get; protected set; }

        public long Hitpoints { get; protected set; }
        public long Speed { get; protected set; }

        public int LaserSlots { get; protected set; }
        public int ShieldAndGearSlots { get; protected set; }
        public int ExtrasSlots { get; protected set; }
        public int CargoSize { get; protected set; }

        //Ship bonuses on maps
        public bool Bonus_Statistics { get; protected set; }
        public bool Bonus_WorkOnlyFirmMap { get; protected set; }
        public List<MapTypes> Bonus_Maps { get; protected set; }
        public float Bonus_LasersDamageMultiplyInShip { get; protected set; }
        public float Bonus_ShieldMultiplyInShip { get; protected set; }
        public long Bonus_Hitpoints { get; protected set; }
        public long Bonus_Speed { get; protected set; }
        public long Bonus_CargoSize { get; protected set; }

        public Reward Reward { get; protected set; }

        public List<DroneExperience> ExperiencePerKill { get; protected set; }



        public static AbstractShip GetInstance(PrefabTypes shipType)
        {
            if (DLLHelpers.IsPrefabType(PrefabTypes.Phoenix_type, shipType))
            {
                return Phoenix.Instance;
            }
            else if (DLLHelpers.IsPrefabType(PrefabTypes.Yamato_type, shipType))
            {
                return Yamato.Instance;
            }
            else if (DLLHelpers.IsPrefabType(PrefabTypes.Leonov_type, shipType))
            {
                return Leonov.Instance;
            }
            else if (DLLHelpers.IsPrefabType(PrefabTypes.Defcom_type, shipType))
            {
                return Defcom.Instance;
            }
            else if (DLLHelpers.IsPrefabType(PrefabTypes.Liberator_type, shipType))
            {
                return Liberator.Instance;
            }
            else if (DLLHelpers.IsPrefabType(PrefabTypes.Piranha_type, shipType))
            {
                return Piranha.Instance;
            }
            else if (DLLHelpers.IsPrefabType(PrefabTypes.Nostromo_type, shipType))
            {
                return Nostromo.Instance;
            }
            else if (DLLHelpers.IsPrefabType(PrefabTypes.Vengeance_type, shipType))
            {
                return Vengeance.Instance;
            }
            else if (DLLHelpers.IsPrefabType(PrefabTypes.Bigboy_type, shipType))
            {
                return BigBoy.Instance;
            }
            else if (DLLHelpers.IsPrefabType(PrefabTypes.Bigboy_red_type, shipType))
            {
                return BigBoy_Red.Instance;
            }
            else if (DLLHelpers.IsPrefabType(PrefabTypes.Bigboy_green_type, shipType))
            {
                return BigBoy_Green.Instance;
            }
            else if (DLLHelpers.IsPrefabType(PrefabTypes.Goliath_type, shipType))
            {
                return Goliath.Instance;
            }
            else if (DLLHelpers.IsPrefabType(PrefabTypes.Goliath_yellow_type, shipType))
            {
                return Goliath_Yellow.Instance;
            }
            else if (DLLHelpers.IsPrefabType(PrefabTypes.Goliath_red_type, shipType))
            {
                return Goliath_Red.Instance;
            }
            else if (DLLHelpers.IsPrefabType(PrefabTypes.Goliath_blue_type, shipType))
            {
                return Goliath_Blue.Instance;
            }
            else if (shipType == PrefabTypes.Admin)
            {
                return Admin.Instance;
            }
            else
                throw new NotImplementedException(shipType.ToString());
        }
    }
}