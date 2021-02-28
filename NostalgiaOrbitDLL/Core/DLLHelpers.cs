using NostalgiaOrbitDLL.Drones;
using NostalgiaOrbitDLL.Items;
using NostalgiaOrbitDLL.Resources;
using NostalgiaOrbitDLL.Ships;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Security.Cryptography;
using System.Text;

namespace NostalgiaOrbitDLL.Core
{
    [Serializable]
    public static class DLLHelpers
    {
        #region Pilot ship
        public static long CalculateShieldAbsorptionFromEquipmentShield(List<AbstractItem> shields)
        {
            if (shields.Count == 0)
                return 0;

            float shieldSum = 0;
            foreach (var shield in shields)
            {
                shieldSum += shield.ShieldAbsorption;
            }
            float result = shieldSum / shields.Count;

            var shd = Convert.ToInt32(Math.Round(result));

            return shd;
        }
        #endregion Pilot ship

        #region Serialize / Deserialize
        public static byte[] Serialize(object obj)
        {
            if (obj == null)
                return null;

            BinaryFormatter bf = new BinaryFormatter();
            using (MemoryStream ms = new MemoryStream())
            {
                bf.Serialize(ms, obj);
                return ms.ToArray();
            }
        }

        public static T Deserialize<T>(byte[] array)
        {
            if (array == null)
                return default(T);

            BinaryFormatter bf = new BinaryFormatter();
            using (MemoryStream ms = new MemoryStream(array))
            {
                return (T)bf.Deserialize(ms);
            }
        }
        #endregion Serialize / Deserialize

        #region BCrypt SHA512
        private const string HashSalt = "Tr0l010{0}S@lT-N0sT@|g|@0rb|t";
        //public static string HashBCrypt(string text)
        //{
        //    var passwordWithSalt = string.Format(HashSalt, text);
        //    var hashedPassword = BCrypt.Net.BCrypt.EnhancedHashPassword(passwordWithSalt);

        //    return hashedPassword;
        //}
        //public static bool PasswordBCryptMatch(string hashedPassword, string passwordDatabase)
        //{
        //    return BCrypt.Net.BCrypt.EnhancedVerify(string.Format(HashSalt, hashedPassword), passwordDatabase);
        //}
        public static string HashSHA512(string text)
        {
            var bytes = Encoding.UTF8.GetBytes(string.Format(HashSalt, text));
            using (SHA512 shaM = new SHA512Managed())
            {
                var output = shaM.ComputeHash(bytes);

                var stringBuilder = new StringBuilder(128);
                for (int i = 0; i < output.Length; i++)
                {
                    stringBuilder.Append(output[i].ToString("X2"));
                }

                return stringBuilder.ToString();
            }

        }
        #endregion BCrypt SHA512

        #region Enum helpers
        public static ShopItem GetShopItem(ItemShopTypes itemShopType)
        {
            return itemShopType switch
            {
                ItemShopTypes.Phoenix => Phoenix.Instance,
                ItemShopTypes.Yamato => Yamato.Instance,
                ItemShopTypes.Leonov => Leonov.Instance,
                ItemShopTypes.Defcom => Defcom.Instance,
                ItemShopTypes.Liberator => Liberator.Instance,
                ItemShopTypes.Piranha => Piranha.Instance,
                ItemShopTypes.Nostromo => Nostromo.Instance,
                ItemShopTypes.Vengeance => Vengeance.Instance,
                ItemShopTypes.BigBoy => BigBoy.Instance,
                ItemShopTypes.Goliath => Goliath.Instance,
                ItemShopTypes.Flax => Flax.Instance,
                ItemShopTypes.Iris => Iris.Instance,
                ItemShopTypes.LF_1 => LF_1.Instance,
                ItemShopTypes.MP_1 => MP_1.Instance,
                ItemShopTypes.LF_2 => LF_2.Instance,
                ItemShopTypes.LF_3 => LF_3.Instance,
                ItemShopTypes.Ammunition1 => Ammunition1.Instance,
                ItemShopTypes.Ammunition2 => Ammunition2.Instance,
                ItemShopTypes.Ammunition3 => Ammunition3.Instance,
                ItemShopTypes.AmmunitionSab => AmmunitionSab.Instance,
                ItemShopTypes.Rocket1 => Rocket1.Instance,
                ItemShopTypes.Rocket2 => Rocket2.Instance,
                ItemShopTypes.Rocket3 => Rocket3.Instance,
                ItemShopTypes.Mine => Mine.Instance,
                ItemShopTypes.G3N_1010 => G3N_1010.Instance,
                ItemShopTypes.G3N_2010 => G3N_2010.Instance,
                ItemShopTypes.G3N_3210 => G3N_3210.Instance,
                ItemShopTypes.G3N_3310 => G3N_3310.Instance,
                ItemShopTypes.G3N_6900 => G3N_6900.Instance,
                ItemShopTypes.G3N_7900 => G3N_7900.Instance,
                ItemShopTypes.SG3N_A01 => SG3N_A01.Instance,
                ItemShopTypes.SG3N_A02 => SG3N_A02.Instance,
                ItemShopTypes.SG3N_A03 => SG3N_A03.Instance,
                ItemShopTypes.B01 => B01.Instance,
                ItemShopTypes.B02 => B02.Instance,
                ItemShopTypes.REP_1 => REP_1.Instance,
                ItemShopTypes.REP_2 => REP_2.Instance,
                ItemShopTypes.REP_3 => REP_3.Instance,

                _ => throw new NotImplementedException(itemShopType.ToString()),
            };
        }

        public static bool IsCompanyMap(FirmTypes firmType, MapTypes currentMap, List<MapTypes> bonusMaps)
        {
            if (!bonusMaps.Contains(currentMap))
                return false;

            return IsCompanyMap(firmType, currentMap);
        }

        public static bool IsCompanyMap(FirmTypes firmType, MapTypes currentMap)
        {
            return firmType switch
            {
                FirmTypes.MMO => currentMap switch
                {
                    MapTypes.MMO_1_1 => true,
                    MapTypes.MMO_1_2 => true,
                    MapTypes.MMO_1_3 => true,
                    MapTypes.MMO_1_4 => true,
                    MapTypes.MMO_1_5 => true,
                    MapTypes.MMO_1_6 => true,
                    MapTypes.MMO_1_7 => true,
                    MapTypes.MMO_1_8 => true,
                    _ => false,
                },
                FirmTypes.EIC => currentMap switch
                {
                    MapTypes.EIC_2_1 => true,
                    MapTypes.EIC_2_2 => true,
                    MapTypes.EIC_2_3 => true,
                    MapTypes.EIC_2_4 => true,
                    MapTypes.EIC_2_5 => true,
                    MapTypes.EIC_2_6 => true,
                    MapTypes.EIC_2_7 => true,
                    MapTypes.EIC_2_8 => true,
                    _ => false,
                },
                FirmTypes.VRU => currentMap switch
                {
                    MapTypes.VRU_3_1 => true,
                    MapTypes.VRU_3_2 => true,
                    MapTypes.VRU_3_3 => true,
                    MapTypes.VRU_3_4 => true,
                    MapTypes.VRU_3_5 => true,
                    MapTypes.VRU_3_6 => true,
                    MapTypes.VRU_3_7 => true,
                    MapTypes.VRU_3_8 => true,
                    _ => false,
                },
                _ => false,
            };
        }

        public static bool IsBattleMap(MapTypes currentMap)
        {
            return currentMap switch
            {
                MapTypes.BATTLE_4_1 => true,
                MapTypes.BATTLE_4_2 => true,
                MapTypes.BATTLE_4_3 => true,
                MapTypes.BATTLE_4_4 => true,
                MapTypes.BATTLE_4_5 => true,
                _ => false,
            };
        }

        public static bool IsGalaxyGateMap(MapTypes currentMap)
        {
            return currentMap switch
            {
                MapTypes.GATE_ALPHA => true,
                MapTypes.GATE_BETA => true,
                MapTypes.GATE_GAMMA => true,
                MapTypes.GATE_DELTA => true,
                _ => false,
            };
        }

        public static bool IsAmmunitionType(ResourceTypes resourceType)
        {
            return resourceType switch
            {
                ResourceTypes.Ammunition1 => true,
                ResourceTypes.Ammunition2 => true,
                ResourceTypes.Ammunition3 => true,
                ResourceTypes.Ammunition4 => true,
                ResourceTypes.AmmunitionSab => true,
                _ => false,
            };
        }

        public static bool IsRocketType(ResourceTypes resourceType)
        {
            return resourceType switch
            {
                ResourceTypes.Rocket1 => true,
                ResourceTypes.Rocket2 => true,
                ResourceTypes.Rocket3 => true,
                _ => false,
            };
        }

        public static bool IsCargoType(ResourceTypes resourceType)
        {
            return resourceType switch
            {
                ResourceTypes.Prometium => true,
                ResourceTypes.Endurium => true,
                ResourceTypes.Terbium => true,
                ResourceTypes.Prometid => true,
                ResourceTypes.Duranium => true,
                ResourceTypes.Promerium => true,
                _ => false,
            };
        }

        public static bool IsShipPrefabType(this PrefabTypes prefab)
        {
            return IsPrefabType(PrefabTypes.Phoenix_type, prefab)
              || IsPrefabType(PrefabTypes.Yamato_type, prefab)
              || IsPrefabType(PrefabTypes.Leonov_type, prefab)
              || IsPrefabType(PrefabTypes.Defcom_type, prefab)
              || IsPrefabType(PrefabTypes.Liberator_type, prefab)
              || IsPrefabType(PrefabTypes.Piranha_type, prefab)
              || IsPrefabType(PrefabTypes.Nostromo_type, prefab)
              || IsPrefabType(PrefabTypes.Vengeance_type, prefab)
              || IsPrefabType(PrefabTypes.all_bigboy_type, prefab)
              || IsPrefabType(PrefabTypes.all_goliath_type, prefab)
              || prefab switch
              {
                  PrefabTypes.Admin => true,
                  _ => false,
              };
        }

        public static bool IsEnemyPrefabType(this PrefabTypes prefab)
        {
            return IsPrefabType(PrefabTypes.streuner_type, prefab)
              || IsPrefabType(PrefabTypes.lordakia_type, prefab)
              || IsPrefabType(PrefabTypes.saimon_type, prefab)
              || IsPrefabType(PrefabTypes.mordon_type, prefab)
              || IsPrefabType(PrefabTypes.devolarium_type, prefab)
              || IsPrefabType(PrefabTypes.sibelon_type, prefab)
              || IsPrefabType(PrefabTypes.sibelonit_type, prefab)
              || IsPrefabType(PrefabTypes.lordakium_type, prefab)
              || IsPrefabType(PrefabTypes.kristallin_type, prefab)
              || IsPrefabType(PrefabTypes.kristallon_type, prefab)
              || IsPrefabType(PrefabTypes.cubikon_type, prefab)
              || IsPrefabType(PrefabTypes.protegit_type, prefab)
              || IsPrefabType(PrefabTypes.streuner_2_type , prefab)
              || IsPrefabType(PrefabTypes.cucurbium_type, prefab)
              || IsPrefabType(PrefabTypes.demaner_type, prefab)
              || prefab switch
              {
                  PrefabTypes.Ufo => true,
                  _ => false,
              };
        }

        public static bool IsPrefabType(this PrefabTypes prefab_type, PrefabTypes prefab)
        {
            if (prefab_type == PrefabTypes.playerShips)
                return IsShipPrefabType(prefab);
            else if (prefab_type == PrefabTypes.enemyShips)
                return IsEnemyPrefabType(prefab);

            else if (prefab_type == prefab)
                return true;

            return prefab_type switch
            {
                PrefabTypes.Phoenix_type => prefab switch
                {
                    PrefabTypes.Phoenix_normal => true,
                    PrefabTypes.Phoenix_medium => true,
                    PrefabTypes.Phoenix_full => true,
                    _ => false,
                },
                PrefabTypes.Yamato_type => prefab switch
                {
                    PrefabTypes.Yamato_normal => true,
                    PrefabTypes.Yamato_medium => true,
                    PrefabTypes.Yamato_full => true,
                    _ => false,
                },
                PrefabTypes.Leonov_type => prefab switch
                {
                    PrefabTypes.Leonov_normal => true,
                    PrefabTypes.Leonov_medium => true,
                    PrefabTypes.Leonov_full => true,
                    _ => false,
                },
                PrefabTypes.Defcom_type => prefab switch
                {
                    PrefabTypes.Defcom_normal => true,
                    PrefabTypes.Defcom_medium => true,
                    PrefabTypes.Defcom_full => true,
                    _ => false,
                },
                PrefabTypes.Liberator_type => prefab switch
                {
                    PrefabTypes.Liberator_normal => true,
                    PrefabTypes.Liberator_medium => true,
                    PrefabTypes.Liberator_full => true,
                    _ => false,
                },
                PrefabTypes.Piranha_type => prefab switch
                {
                    PrefabTypes.Piranha_normal => true,
                    PrefabTypes.Piranha_medium => true,
                    PrefabTypes.Piranha_full => true,
                    _ => false,
                },
                PrefabTypes.Nostromo_type => prefab switch
                {
                    PrefabTypes.Nostromo_normal => true,
                    PrefabTypes.Nostromo_medium => true,
                    PrefabTypes.Nostromo_full => true,
                    _ => false,
                },
                PrefabTypes.Vengeance_type => prefab switch
                {
                    PrefabTypes.Vengeance_normal => true,
                    PrefabTypes.Vengeance_medium => true,
                    PrefabTypes.Vengeance_full => true,
                    _ => false,
                },

                PrefabTypes.Bigboy_type => prefab switch
                {
                    PrefabTypes.Bigboy_normal => true,
                    PrefabTypes.Bigboy_medium => true,
                    PrefabTypes.Bigboy_full => true,
                    _ => false,
                },
                PrefabTypes.Bigboy_red_type => prefab switch
                {
                    PrefabTypes.Bigboy_red_normal => true,
                    PrefabTypes.Bigboy_red_medium => true,
                    PrefabTypes.Bigboy_red_full => true,
                    _ => false,
                },
                PrefabTypes.Bigboy_green_type => prefab switch
                {
                    PrefabTypes.Bigboy_green_normal => true,
                    PrefabTypes.Bigboy_green_medium => true,
                    PrefabTypes.Bigboy_green_full => true,
                    _ => false,
                },
                PrefabTypes.all_bigboy_type => IsPrefabType(PrefabTypes.Bigboy_type, prefab) || IsPrefabType(PrefabTypes.Bigboy_red_type, prefab) || IsPrefabType(PrefabTypes.Bigboy_green_type, prefab),

                PrefabTypes.Goliath_type => prefab switch
                {
                    PrefabTypes.Goliath_normal => true,
                    PrefabTypes.Goliath_medium => true,
                    PrefabTypes.Goliath_full => true,
                    _ => false,
                },
                PrefabTypes.Goliath_yellow_type => prefab switch
                {
                    PrefabTypes.Goliath_yellow_normal => true,
                    PrefabTypes.Goliath_yellow_medium => true,
                    PrefabTypes.Goliath_yellow_full => true,
                    _ => false,
                },
                PrefabTypes.Goliath_red_type => prefab switch
                {
                    PrefabTypes.Goliath_red_normal => true,
                    PrefabTypes.Goliath_red_medium => true,
                    PrefabTypes.Goliath_red_full => true,
                    _ => false,
                },
                PrefabTypes.Goliath_blue_type => prefab switch
                {
                    PrefabTypes.Goliath_blue_normal => true,
                    _ => false,
                },
                PrefabTypes.all_goliath_type => IsPrefabType(PrefabTypes.Goliath_type, prefab) || IsPrefabType(PrefabTypes.Goliath_yellow_type, prefab) || IsPrefabType(PrefabTypes.Goliath_red_type, prefab) || IsPrefabType(PrefabTypes.Goliath_blue_type, prefab),



                PrefabTypes.streuner_type => prefab switch
                {
                    PrefabTypes.Streuner => true,
                    PrefabTypes.BossStreuner => true,
                    PrefabTypes.UberStreuner => true,
                    _ => false,
                },
                PrefabTypes.lordakia_type => prefab switch
                {
                    PrefabTypes.Lordakia => true,
                    PrefabTypes.BossLordakia => true,
                    PrefabTypes.UberLordakia => true,
                    _ => false,
                },
                PrefabTypes.saimon_type => prefab switch
                {
                    PrefabTypes.Saimon => true,
                    PrefabTypes.BossSaimon => true,
                    PrefabTypes.UberSaimon => true,
                    _ => false,
                },
                PrefabTypes.mordon_type => prefab switch
                {
                    PrefabTypes.Mordon => true,
                    PrefabTypes.BossMordon => true,
                    PrefabTypes.UberMordon => true,
                    _ => false,
                },
                PrefabTypes.devolarium_type => prefab switch
                {
                    PrefabTypes.Devolarium => true,
                    PrefabTypes.BossDevolarium => true,
                    PrefabTypes.UberDevolarium => true,
                    _ => false,
                },
                PrefabTypes.sibelon_type => prefab switch
                {
                    PrefabTypes.Sibelon => true,
                    PrefabTypes.BossSibelon => true,
                    PrefabTypes.UberSibelon => true,
                    _ => false,
                },
                PrefabTypes.sibelonit_type => prefab switch
                {
                    PrefabTypes.Sibelonit => true,
                    PrefabTypes.BossSibelonit => true,
                    PrefabTypes.UberSibelonit => true,
                    _ => false,
                },
                PrefabTypes.lordakium_type => prefab switch
                {
                    PrefabTypes.Lordakium => true,
                    PrefabTypes.BossLordakium => true,
                    PrefabTypes.UberLordakium => true,
                    _ => false,
                },
                PrefabTypes.kristallin_type => prefab switch
                {
                    PrefabTypes.Kristallin => true,
                    PrefabTypes.BossKristallin => true,
                    PrefabTypes.UberKristallin => true,
                    _ => false,
                },
                PrefabTypes.kristallon_type => prefab switch
                {
                    PrefabTypes.Kristallon => true,
                    PrefabTypes.BossKristallon => true,
                    PrefabTypes.UberKristallon => true,
                    _ => false,
                },
                PrefabTypes.cubikon_type => prefab switch
                {
                    PrefabTypes.Cubikon => true,
                    PrefabTypes.BossCubikon => true,
                    PrefabTypes.UberCubikon => true,
                    _ => false,
                },
                PrefabTypes.protegit_type => prefab switch
                {
                    PrefabTypes.Protegit => true,
                    PrefabTypes.BossProtegit => true,
                    PrefabTypes.UberProtegit => true,
                    _ => false,
                },
                PrefabTypes.streuner_2_type  => prefab switch
                {
                    PrefabTypes.Streuner_2 => true,
                    PrefabTypes.BossStreuner_2 => true,
                    PrefabTypes.UberStreuner_2 => true,
                    _ => false,
                },
                PrefabTypes.cucurbium_type => prefab switch
                {
                    PrefabTypes.Cucurbium => true,
                    PrefabTypes.BossCucurbium => true,
                    _ => false,
                },
                PrefabTypes.demaner_type => prefab switch
                {
                    PrefabTypes.Demaner => true,
                    PrefabTypes.BossDemaner => true,
                    _ => false,
                },



                PrefabTypes.flax_type => prefab switch
                {
                    PrefabTypes.Flax_1 => true,
                    PrefabTypes.Flax_2 => true,
                    PrefabTypes.Flax_3 => true,
                    PrefabTypes.Flax_4 => true,
                    PrefabTypes.Flax_5 => true,
                    PrefabTypes.Flax_6 => true,
                    _ => false,
                },
                PrefabTypes.iris_type => prefab switch
                {
                    PrefabTypes.Iris_1 => true,
                    PrefabTypes.Iris_2 => true,
                    PrefabTypes.Iris_3 => true,
                    PrefabTypes.Iris_4 => true,
                    PrefabTypes.Iris_5 => true,
                    PrefabTypes.Iris_6 => true,
                    _ => false,
                },
                PrefabTypes.drone_type => IsPrefabType(PrefabTypes.flax_type, prefab) || IsPrefabType(PrefabTypes.iris_type, prefab),



                PrefabTypes.cargo_type => prefab switch
                {
                    PrefabTypes.CargoBox => true,
                    PrefabTypes.CargoBox_Occupied => true,
                    _ => false,
                },
                PrefabTypes.box_type => prefab switch
                {
                    PrefabTypes.BonusBox => true,
                    PrefabTypes.BonusBox_PvP => true,
                    PrefabTypes.BonusBox_OnlyX4 => true,
                    _ => false,
                },
                PrefabTypes.boxes_type => IsPrefabType(PrefabTypes.cargo_type, prefab) || IsPrefabType(PrefabTypes.box_type, prefab),



                _ => false,
            };
        }

        public static PrefabTypes GetDronePrefab(this DroneTypes droneType, int level)
        {
            return droneType switch
            {
                DroneTypes.Flax => level switch
                {
                    1 => PrefabTypes.Flax_1,
                    2 => PrefabTypes.Flax_2,
                    3 => PrefabTypes.Flax_3,
                    4 => PrefabTypes.Flax_4,
                    5 => PrefabTypes.Flax_5,
                    6 => PrefabTypes.Flax_6,
                    _ => throw new NotImplementedException(),
                },
                DroneTypes.Iris => level switch
                {
                    1 => PrefabTypes.Iris_1,
                    2 => PrefabTypes.Iris_2,
                    3 => PrefabTypes.Iris_3,
                    4 => PrefabTypes.Iris_4,
                    5 => PrefabTypes.Iris_5,
                    6 => PrefabTypes.Iris_6,
                    _ => throw new NotImplementedException(),
                },
                _ => throw new NotImplementedException(),
            };
        }

        public static string GetMapName(this MapTypes mapType)
        {
            return mapType switch
            {
                MapTypes.MMO_1_1 => "1-1",
                MapTypes.MMO_1_2 => "1-2",
                MapTypes.MMO_1_3 => "1-3",
                MapTypes.MMO_1_4 => "1-4",
                MapTypes.MMO_1_5 => "1-5",
                MapTypes.MMO_1_6 => "1-6",
                MapTypes.MMO_1_7 => "1-7",
                MapTypes.MMO_1_8 => "1-8",

                MapTypes.EIC_2_1 => "2-1",
                MapTypes.EIC_2_2 => "2-2",
                MapTypes.EIC_2_3 => "2-3",
                MapTypes.EIC_2_4 => "2-4",
                MapTypes.EIC_2_5 => "2-5",
                MapTypes.EIC_2_6 => "2-6",
                MapTypes.EIC_2_7 => "2-7",
                MapTypes.EIC_2_8 => "2-8",

                MapTypes.VRU_3_1 => "3-1",
                MapTypes.VRU_3_2 => "3-2",
                MapTypes.VRU_3_3 => "3-3",
                MapTypes.VRU_3_4 => "3-4",
                MapTypes.VRU_3_5 => "3-5",
                MapTypes.VRU_3_6 => "3-6",
                MapTypes.VRU_3_7 => "3-7",
                MapTypes.VRU_3_8 => "3-8",

                MapTypes.BATTLE_4_1 => "4-1",
                MapTypes.BATTLE_4_2 => "4-2",
                MapTypes.BATTLE_4_3 => "4-3",
                MapTypes.BATTLE_4_4 => "4-4",
                MapTypes.BATTLE_4_5 => "4-5",

                MapTypes.BONUS => "???",

                MapTypes.GATE_ALPHA => "0x03B1",
                MapTypes.GATE_BETA => "0xA7B5",
                MapTypes.GATE_GAMMA => "0x0263",
                MapTypes.GATE_DELTA => "0x1E9F",

                _ => throw new NotImplementedException(),
            };
        }

        public static MapTypes GetRespawnMap(this MapTypes deadMap, FirmTypes pilotFirm)
        {
            switch (deadMap)
            {
                case MapTypes.MMO_1_1:
                case MapTypes.MMO_1_2:
                case MapTypes.MMO_1_3:
                case MapTypes.MMO_1_4:
                case MapTypes.EIC_2_1:
                case MapTypes.EIC_2_2:
                case MapTypes.EIC_2_3:
                case MapTypes.EIC_2_4:
                case MapTypes.VRU_3_1:
                case MapTypes.VRU_3_2:
                case MapTypes.VRU_3_3:
                case MapTypes.VRU_3_4:
                case MapTypes.BATTLE_4_1:
                case MapTypes.BATTLE_4_2:
                case MapTypes.BATTLE_4_3:
                case MapTypes.BONUS:
                case MapTypes.GATE_ALPHA:
                case MapTypes.GATE_BETA:
                case MapTypes.GATE_GAMMA:
                case MapTypes.GATE_DELTA:
                    return pilotFirm switch
                    {
                        FirmTypes.MMO => MapTypes.MMO_1_1,
                        FirmTypes.EIC => MapTypes.EIC_2_1,
                        FirmTypes.VRU => MapTypes.VRU_3_1,
                        _ => throw new NotImplementedException(),
                    };

                case MapTypes.MMO_1_5:
                case MapTypes.MMO_1_6:
                case MapTypes.MMO_1_7:
                case MapTypes.MMO_1_8:
                case MapTypes.EIC_2_5:
                case MapTypes.EIC_2_6:
                case MapTypes.EIC_2_7:
                case MapTypes.EIC_2_8:
                case MapTypes.VRU_3_5:
                case MapTypes.VRU_3_6:
                case MapTypes.VRU_3_7:
                case MapTypes.VRU_3_8:
                case MapTypes.BATTLE_4_4:
                case MapTypes.BATTLE_4_5:
                    return pilotFirm switch
                    {
                        FirmTypes.MMO => MapTypes.MMO_1_8,
                        FirmTypes.EIC => MapTypes.EIC_2_8,
                        FirmTypes.VRU => MapTypes.VRU_3_8,
                        _ => throw new NotImplementedException(),
                    };

                default:
                    throw new NotImplementedException();
            };
        }

        public static PrefabTypes ConfigureShipType(this PrefabTypes prefabType, List<AbstractItem> items)
        {
            var prefab = prefabType.ToString();
            if (prefab.Contains("_"))
            {
                var split = prefab.Split('_');

                int lf2 = items.Where(o => o.ItemType == ItemTypes.LF_2).Count();
                int lf3 = items.Where(o => o.ItemType == ItemTypes.LF_3).Count();

                var ship = AbstractShip.GetInstance(prefabType);

                PrefabTypes findPrefab;

                if (ship.LaserSlots == lf3 && Enum.TryParse($"{split[0]}_full", out findPrefab))
                {
                    return findPrefab;
                }
                else if (lf2 + lf3 > ship.LaserSlots / 2 && Enum.TryParse($"{split[0]}_medium", out findPrefab))
                {
                    return findPrefab;
                }
                else if (Enum.TryParse($"{split[0]}_normal", out findPrefab))
                {
                    return findPrefab;
                }
            }

            return prefabType;
        }
        #endregion Enum helpers

        #region Levels
        /// <summary>
        /// Return true if gained level.
        /// </summary>
        public static bool CalculateLevel(int currentLevel, long experience)
        {
            var beforeLevel = currentLevel;

            switch (experience)
            {
                case var exp when exp < 10000:
                    currentLevel = 1;
                    break;
                case var exp when exp < 20000:
                    currentLevel = 2;
                    break;
                case var exp when exp < 40000:
                    currentLevel = 3;
                    break;
                case var exp when exp < 80000:
                    currentLevel = 4;
                    break;
                case var exp when exp < 160000:
                    currentLevel = 5;
                    break;
                case var exp when exp < 320000:
                    currentLevel = 6;
                    break;
                case var exp when exp < 640000:
                    currentLevel = 7;
                    break;
                case var exp when exp < 1280000:
                    currentLevel = 8;
                    break;
                case var exp when exp < 2560000:
                    currentLevel = 9;
                    break;
                case var exp when exp < 5120000:
                    currentLevel = 10;
                    break;
                case var exp when exp < 10240000:
                    currentLevel = 11;
                    break;
                case var exp when exp < 20480000:
                    currentLevel = 12;
                    break;
                case var exp when exp < 40960000:
                    currentLevel = 13;
                    break;
                case var exp when exp < 81920000:
                    currentLevel = 14;
                    break;
                case var exp when exp < 163840000:
                    currentLevel = 15;
                    break;
                case var exp when exp < 327680000:
                    currentLevel = 16;
                    break;
                case var exp when exp < 655360000:
                    currentLevel = 17;
                    break;
                case var exp when exp < 1310720000:
                    currentLevel = 18;
                    break;
                case var exp when exp < 2621440000:
                    currentLevel = 19;
                    break;
                case var exp when exp < 5242880000:
                    currentLevel = 20;
                    break;
                case var exp when exp < 10485760000:
                    currentLevel = 21;
                    break;
                case var exp when exp < 20971520000:
                    currentLevel = 22;
                    break;
                case var exp when exp < 41943040000:
                    currentLevel = 23;
                    break;
                case var exp when exp < 83886080000:
                    currentLevel = 24;
                    break;
                case var exp when exp < 167772160000:
                    currentLevel = 25;
                    break;
                case var exp when exp < 335544320000:
                    currentLevel = 26;
                    break;
                case var exp when exp < 671088640000:
                    currentLevel = 27;
                    break;
                case var exp when exp < 1342177280000:
                    currentLevel = 28;
                    break;
                case var exp when exp < 2684354560000:
                    currentLevel = 29;
                    break;
                case var exp when exp < 5368709120000:
                    currentLevel = 30;
                    break;
            }

            return currentLevel != beforeLevel;
        }
        #endregion Levels

        public static T DeepClone<T>(this T obj)
        {
            using (var ms = new MemoryStream())
            {
                var formatter = new BinaryFormatter();
                formatter.Serialize(ms, obj);
                ms.Position = 0;

                return (T)formatter.Deserialize(ms);
            }
        }
    }
}