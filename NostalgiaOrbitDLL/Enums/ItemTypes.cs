using System;

namespace NostalgiaOrbitDLL
{
    [Serializable]
    public enum ItemTypes
    {
        //Lasers
        LF_1 = 0,
        MP_1 = 1,
        LF_2 = 2,
        LF_3 = 3,

        lasers,//  = LF_1 | MP_1 | LF_2 | LF_3,

        //Shields
        SG3N_A01 = 10,
        SG3N_A02 = 11,
        SG3N_A03 = 12,
        B01 = 13,
        B02 = 14,

        shields,//  = SG3N_A01 | SG3N_A02 | SG3N_A03 | B01 | B02,

        //Gears
        G3N_1010 = 20,
        G3N_2010 = 21,
        G3N_3210 = 22,
        G3N_3310 = 23,
        G3N_6900 = 24,
        G3N_7900 = 25,

        gears,//  = G3N_1010 | G3N_2010 | G3N_3210 | G3N_3310 | G3N_6900 | G3N_7900,

        //Extras
        REP_1 = 30,
        REP_2 = 31,
        REP_3 = 32,

        extras,//  = REP_1 | REP_2 | REP_3,
    }
}