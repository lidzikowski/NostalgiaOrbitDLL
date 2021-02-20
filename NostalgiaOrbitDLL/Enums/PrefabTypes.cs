using System;

namespace NostalgiaOrbitDLL
{
    [Serializable]
    public enum PrefabTypes
    {
        // Ships

        Phoenix_normal = 0,
        Phoenix_medium = 1,
        Phoenix_full = 2,

        phoenix_type = 3,// = Phoenix_normal | Phoenix_medium | Phoenix_full,

        Yamato_normal = 10,
        Yamato_medium = 11,
        Yamato_full = 12,

        yamato_type = 13,//  = Yamato_normal | Yamato_medium | Yamato_full,

        Leonov_normal = 20,
        Leonov_medium = 21,
        Leonov_full = 22,

        leonov_type = 23,//  = Leonov_normal | Leonov_medium | Leonov_full,

        Defcom_normal = 30,
        Defcom_medium = 31,
        Defcom_full = 32,

        defcom_type = 33,//  = Defcom_normal | Defcom_medium | Defcom_full,

        Liberator_normal = 40,
        Liberator_medium = 41,
        Liberator_full = 42,

        liberator_type = 43,//  = Liberator_normal | Liberator_medium | Liberator_full,

        Piranha_normal = 50,
        Piranha_medium = 51,
        Piranha_full = 52,

        piranha_type = 53,//  = Piranha_normal | Piranha_medium | Piranha_full,

        Nostromo_normal = 60,
        Nostromo_medium = 61,
        Nostromo_full = 62,

        nostromo_type = 63,//  = Nostromo_normal | Nostromo_medium | Nostromo_full,

        Vengeance_normal = 70,
        Vengeance_medium = 71,
        Vengeance_full = 72,

        vengeance_type = 73,//  = Vengeance_normal | Vengeance_medium | Vengeance_full,

        Bigboy_normal = 80,
        Bigboy_medium = 81,
        Bigboy_full = 82,

        bigboy_type = 83,//  = Bigboy_normal | Bigboy_medium | Bigboy_full | Bigboy_red_normal | Bigboy_red_medium | Bigboy_red_full | Bigboy_green_normal | Bigboy_green_medium | Bigboy_green_full,

        Bigboy_red_normal = 90,
        Bigboy_red_medium = 91,
        Bigboy_red_full = 92,

        bigboy_red_type = 93,

        Bigboy_green_normal = 100,
        Bigboy_green_medium = 101,
        Bigboy_green_full = 102,

        bigboy_green_type = 103,

        all_bigboy_type = 104,//  = Bigboy_normal | Bigboy_medium | Bigboy_full | Bigboy_red_normal | Bigboy_red_medium | Bigboy_red_full | Bigboy_green_normal | Bigboy_green_medium | Bigboy_green_full,


        Goliath_normal = 110,
        Goliath_medium = 111,
        Goliath_full = 112,

        goliath_type = 113,//  = Goliath_normal | Goliath_medium | Goliath_full | Goliath_yellow_normal | Goliath_yellow_medium | Goliath_yellow_full | Goliath_red_normal | Goliath_red_medium | Goliath_red_full | Goliath_blue_normal,

        Goliath_yellow_normal = 120,
        Goliath_yellow_medium = 121,
        Goliath_yellow_full = 122,

        goliath_yellow_type = 123, //

        Goliath_red_normal = 130,
        Goliath_red_medium = 131,
        Goliath_red_full = 132,

        goliath_red_type = 133, //

        Goliath_blue_normal = 140,

        goliath_blue_type = 141, //

        all_goliath_type = 142,

        Admin = 170,

        playerShips,//  = phoenix_type | yamato_type | leonov_type | defcom_type | liberator_type | piranha_type | nostromo_type | vengeance_type | bigboy_type | goliath_type | Admin,

        // Aliens

        Streuner = 200,
        BossStreuner = 201,
        UberStreuner = 202,

        streuner_type = 203,//  = Streuner | BossStreuner | UberStreuner,

        Lordakia = 210,
        BossLordakia = 211,
        UberLordakia = 212,

        lordakia_type = 213,//  = Lordakia | BossLordakia | UberLordakia,

        Saimon = 220,
        BossSaimon = 221,
        UberSaimon = 222,

        saimon_type = 223,//  = Saimon | BossSaimon | UberSaimon,

        Mordon = 230,
        BossMordon = 231,
        UberMordon = 232,

        mordon_type = 233,//  = Mordon | BossMordon | UberMordon,

        Devolarium = 240,
        BossDevolarium = 241,
        UberDevolarium = 242,

        devolarium_type = 234,//  = Devolarium | BossDevolarium | UberDevolarium,

        Sibelon = 250,
        BossSibelon = 251,
        UberSibelon = 252,

        sibelon_type = 253,//  = Sibelon | BossSibelon | UberSibelon,

        Sibelonit = 260,
        BossSibelonit = 261,
        UberSibelonit = 262,

        sibelonit_type = 263,//  = Sibelonit | BossSibelonit | UberSibelonit,

        Lordakium = 270,
        BossLordakium = 271,
        UberLordakium = 272,

        lordakium_type = 273,//  = Lordakium | BossLordakium | UberLordakium,

        Kristallin = 280,
        BossKristallin = 281,
        UberKristallin = 282,

        kristallin_type = 283,//  = Kristallin | BossKristallin | UberKristallin,

        Kristallon = 290,
        BossKristallon = 291,
        UberKristallon = 292,

        kristallon_type = 293,//  = Kristallon | BossKristallon | UberKristallon,

        Cubikon = 300,
        BossCubikon = 301,
        UberCubikon = 302,

        cubikon_type = 303,//  = Cubikon | BossCubikon | UberCubikon,

        Protegit = 310,
        BossProtegit = 311,
        UberProtegit = 312,

        protegit_type = 313,//  = Protegit | BossProtegit | UberProtegit,

        Streuner_2 = 320,
        BossStreuner_2 = 321,
        UberStreuner_2 = 322,

        streuner_2_type = 323,//  = StreuneR | BossStreuneR | UberStreuneR,

        Cucurbium = 340,
        BossCucurbium = 341,

        cucurbium_type = 342,//  = Cucurbium | BossCucurbium,

        Demaner = 350,
        BossDemaner = 351,

        demaner_type = 352,// = Demaner | BossDemaner,

        Ufo = 360,

        enemyShips,//  = streuner_type | lordakia_type | saimon_type | mordon_type | devolarium_type | sibelon_type | sibelonit_type | lordakium_type | kristallin_type | kristallon_type | cubikon_type | protegit_type | streuneR_type | cucurbium_type | demaner_type | Ufo,

        // Drones

        Flax_1 = 500,
        Flax_2 = 501,
        Flax_3 = 502,
        Flax_4 = 503,
        Flax_5 = 504,
        Flax_6 = 505,

        flax_type = 506,//  = Flax_1 | Flax_2 | Flax_3 | Flax_4 | Flax_5 | Flax_6,

        Iris_1 = 510,
        Iris_2 = 511,
        Iris_3 = 512,
        Iris_4 = 513,
        Iris_5 = 514,
        Iris_6 = 515,

        iris_type = 516,//  = Iris_1 | Iris_2 | Iris_3 | Iris_4 | Iris_5 | Iris_6,

        drone_type,//  = flax_type | iris_type,

        // Boxes

        CargoBox = 600,
        CargoBox_Occupied = 601,
        CargoBox_occupied_animation = 602,

        cargo_type = 603,//  = CargoBox | CargoBox_Occupied,

        BonusBox = 610,
        BonusBox_PvP = 611,
        BonusBox_OnlyX4 = 612,

        box_type = 613,//  = BonusBox,

        boxes_type,//  = cargo_type | box_type,

        // Others

        Engine = 700,

        Firebox = 701,

        Loading = 702,

        Repair_robot = 703,

        Star = 704,

        Portal = 705,
        InvisiblePortal = 706,

        Base = 710,

        Explosion = 711,

        Prometium = 712,
        Endurium = 713,
        Terbium = 714,
    }
}