using System;

namespace NostalgiaOrbitDLL
{
    [Serializable]
    public enum ResourceTypes
    {
        Ammunition1 = 0,
        Ammunition2 = 1,
        Ammunition3 = 2,
        Ammunition4 = 3,
        AmmunitionSab = 4,
        AmmunitionRsb = 5,

        Rocket1 = 10,
        Rocket2 = 11,
        Rocket3 = 12,

        Prometium = 20,
        Endurium = 21,
        Terbium = 22,
        Prometid = 23,
        Duranium = 24,
        Promerium = 25,
        Xenomit = 26,

        Credits = 100,
        Uridium = 101,
        Jackpot = 102,
        ExtraEnergy = 103,


        // Enemies
        None = 200,
        ShotLordakia = 201,
        ShotSaimon = 202,
        ShotMordon = 203,
        ShotSibelon = 204,
        ShotDevolarium = 205,
        ShotLordakium = 206,
        ShotSibelonit = 207,
        ShotKristallin = 208,
        ShotKristallon = 209,
        ShotProtegit = 210,
        ShotDemaner = 211,
    }
}