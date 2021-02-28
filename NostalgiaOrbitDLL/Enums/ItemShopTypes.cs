using System;

namespace NostalgiaOrbitDLL
{
    [Serializable]
    public enum ItemShopTypes
    {
        // Ships
        Phoenix = 0,
        Yamato = 1,
        Leonov = 2,
        Defcom = 3,
        Liberator = 4,
        Piranha = 5,
        Nostromo = 6,
        Vengeance = 7,
        BigBoy = 8,
        Goliath = 9,

        // Drones
        Flax = 20,
        Iris = 21,

        // Lasers
        LF_1 = 30,
        MP_1 = 31,
        LF_2 = 32,
        LF_3 = 33,

        // Ammunitions
        AmmunitionBuy = 40,
        Ammunition1 = 41,
        Ammunition2 = 42,
        Ammunition3 = 43,
        AmmunitionSab = 44,

        // Rockets
        Rocket1 = 50,
        Rocket2 = 51,
        Rocket3 = 52,

        // Mines
        Mine = 60,

        //Gears
        G3N_1010 = 70,
        G3N_2010 = 71,
        G3N_3210 = 72,
        G3N_3310 = 73,
        G3N_6900 = 74,
        G3N_7900 = 75,

        //Shields
        SG3N_A01 = 80,
        SG3N_A02 = 81,
        SG3N_A03 = 82,
        B01 = 83,
        B02 = 84,

        //Extras
        REP_1 = 90,
        REP_2 = 91,
        REP_3 = 92,
    }
}