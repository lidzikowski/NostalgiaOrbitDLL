using MongoDB.Bson.Serialization.Attributes;
using NostalgiaOrbitDLL.Core;
using NostalgiaOrbitDLL.Core.Commands;
using NostalgiaOrbitDLL.Drones;
using NostalgiaOrbitDLL.Items;
using NostalgiaOrbitDLL.Maps;
using NostalgiaOrbitDLL.Ships;
using System;
using System.Collections.Generic;
using System.Linq;

namespace NostalgiaOrbitDLL
{
    [Serializable]
    public class Pilot
    {
        [BsonId]
        public Guid Id { get; protected set; }

        // Register
        public string Username { get; protected set; }
        public string Password { get; protected set; }
        public string Email { get; protected set; }
        public Servers Server { get; protected set; }
        public bool Rules { get; protected set; }
        public bool Newsletter { get; protected set; }
        public DateTime RegisterDate { get; protected set; }
        public List<Login> Logins { get; protected set; }

        // Game
        public string PilotName { get; set; }

        public FirmTypes FirmType { get; set; }

        public MapTypes Map { get; set; }
        public PositionVector Position { get; set; }

        public List<OwnedShip> OwnedShips { get; set; }
        public PrefabTypes ShipType { get; set; }
        public bool ConfigurationFirst { get; set; }
        public List<Item> Items { get; set; }
        public List<Drone> Drones { get; set; }

        public int Level { get; set; }
        public long Experience { get; set; }
        public long Honor { get; set; }
        public ResourceTypes Select_Ammunition { get; set; }
        public ResourceTypes Select_Rocket { get; set; }
        public List<PilotResource> Resources { get; set; }

        public long RankingPoints { get; set; }
        public RankTypes RankType { get; set; }

        public bool PremiumStatus { get; set; }
        public DateTime? PremiumEndDate { get; set; }
        public AccountTypes AccountType { get; set; }



        [BsonIgnore]
        public int LasersQuantityInCurrentConfiguration
        {
            get
            {
                Func<Item, bool> func;

                if (ConfigurationFirst)
                {
                    func = o => o.IsEquipConfiguration1 || o.IsEquipInDroneConfiguration1;
                }
                else
                {
                    func = o => o.IsEquipConfiguration2 || o.IsEquipInDroneConfiguration2;
                }

                var laserQuantity = Items.Where(func)
                    .Count(o => AbstractItem.GetItemByType(o.ItemType).IsLaser);

                return laserQuantity;
            }
        }
        [BsonIgnore]
        public OwnedShip GetOwnedShip { get => OwnedShips.First(o => o.ShipType.IsPrefabType(ShipType)); }
        [BsonIgnore]
        public long HaveHitpoints
        {
            get => GetOwnedShip.Hitpoints;
            set => GetOwnedShip.Hitpoints = value;
        }
        public long HaveShields { get; set; }



        [BsonIgnore]
        public long Equipment_Hitpoints { get; set; }
        [BsonIgnore]
        public long Equipment_Shields { get; private set; }
        [BsonIgnore]
        private long Equipment_ShieldsShip { get; set; }
        [BsonIgnore]
        private long Equipment_ShieldsDrones { get; set; }
        [BsonIgnore]
        public float Equipment_ShieldsAbsorption { get; set; }
        [BsonIgnore]
        public long Equipment_CargoCapacity { get; set; }
        [BsonIgnore]
        public long Equipment_CargoInResources => Convert.ToInt64(Resources.Where(o => DLLHelpers.IsCargoType(o.ResourceType)).Sum(o => o.Quantity));
        /// <summary>
        /// Ship + Equipment
        /// </summary>
        [BsonIgnore]
        public long Equipment_Speed { get; set; }
        [BsonIgnore]
        public long Equipment_Damage { get; private set; }
        [BsonIgnore]
        private long Equipment_DamageShip { get; set; }
        [BsonIgnore]
        private long Equipment_DamageDrones { get; set; }



        public Pilot()
        {
        }
        public Pilot(RegisterCommand registerCommand)
        {
            Username = registerCommand.Username;
            Password = registerCommand.Password;
            Email = registerCommand.Email;
            Server = registerCommand.Server;
            Rules = registerCommand.Rules;
            Newsletter = registerCommand.Newsletter;
            PilotName = registerCommand.PilotName;
        }



        [BsonIgnore]
        public AbstractShip Ship { get { return AbstractShip.GetInstance(ShipType); } }
        [BsonIgnore]
        public bool ShipBonus
        {
            get
            {
                var ownedBonus = false;
                if (Ship.Bonus_Statistics && Ship.Bonus_Maps.Contains(Map))
                {
                    var companyMap = DLLHelpers.IsCompanyMap(FirmType, Map, Ship.Bonus_Maps);
                    if (!Ship.Bonus_WorkOnlyFirmMap || (Ship.Bonus_WorkOnlyFirmMap && companyMap))
                    {
                        ownedBonus = true;
                    }
                }
                return ownedBonus;
            }
        }

        public void CalculateConfiguration()
        {
            Func<Item, bool> funcShip;
            Func<Item, bool> funcDrones;

            if (ConfigurationFirst)
            {
                funcShip = o => o.IsEquipConfiguration1;
                funcDrones = o => o.IsEquipInDroneConfiguration1;
            }
            else
            {
                funcShip = o => o.IsEquipConfiguration2;
                funcDrones = o => o.IsEquipInDroneConfiguration2;
            }

            List<AbstractItem> itemsShip = Items.Where(funcShip)
                .Select(o => AbstractItem.GetItemByType(o.ItemType))
                .ToList();

            List<AbstractItem> itemsDrone = Items.Where(funcDrones)
                .Select(o => AbstractItem.GetItemByType(o.ItemType))
                .ToList();

            long damageDroneBonus = 0;
            long shieldDroneBonus = 0;

            foreach (var pilotItem in Items.Where(funcDrones))
            {
                var pilotDrone = Drones.First(o => ConfigurationFirst && o.Id == pilotItem.DroneIdConfiguration1 || !ConfigurationFirst && o.Id == pilotItem.DroneIdConfiguration2);

                if (pilotDrone.Level == 1)
                    continue;

                var abstractDrone = AbstractDrone.GetDroneByType(pilotDrone.DroneType);
                var abstractItem = AbstractItem.GetItemByType(pilotItem.ItemType);

                if (abstractItem.IsLaser)
                {
                    damageDroneBonus += Convert.ToInt64(abstractItem.LaserDamage * abstractDrone.Levels.First(o => o.Level == pilotDrone.Level).LaserBonus);
                }
                else if (abstractItem.IsShield)
                {
                    shieldDroneBonus += Convert.ToInt64(abstractItem.Shield * abstractDrone.Levels.First(o => o.Level == pilotDrone.Level).ShieldBonus);
                }
            }

            Equipment_Hitpoints = Ship.Hitpoints; // Bonus

            Equipment_ShieldsShip = itemsShip.Where(o => o.IsShield)?.Sum(o => o.Shield) ?? 0; // Items
            Equipment_ShieldsDrones = itemsDrone.Where(o => o.IsShield)?.Sum(o => o.Shield) ?? 0; // Items

            Equipment_ShieldsAbsorption = itemsShip.Where(o => o.IsShield)?.Sum(o => o.ShieldAbsorption) ?? 0 + itemsDrone.Where(o => o.IsShield)?.Sum(o => o.ShieldAbsorption) ?? 0; // Items

            Equipment_CargoCapacity = Ship.CargoSize; // Bonus

            Equipment_Speed = Ship.Speed + itemsShip.Where(o => o.IsGear)?.Sum(o => o.GearSpeed) ?? 0; // Bonus, Items

            Equipment_DamageShip = itemsShip.Where(o => o.IsLaser)?.Sum(o => o.LaserDamage) ?? 0; // Bonus, Items
            Equipment_DamageDrones = itemsDrone.Where(o => o.IsLaser)?.Sum(o => o.LaserDamage) ?? 0; // Bonus, Items

            if (ShipBonus)
            {
                Equipment_Hitpoints += Ship.Bonus_Hitpoints;

                Equipment_ShieldsShip = Convert.ToInt64(Equipment_ShieldsShip * Ship.Bonus_ShieldMultiplyInShip);

                Equipment_CargoCapacity += Ship.Bonus_CargoSize;

                Equipment_Speed += Ship.Bonus_Speed;

                Equipment_DamageShip = Convert.ToInt64(Equipment_DamageShip * Ship.Bonus_LasersDamageMultiplyInShip);
            }

            Equipment_Shields = Equipment_ShieldsShip + Equipment_ShieldsDrones + shieldDroneBonus;

            Equipment_Damage = Equipment_DamageShip + Equipment_DamageDrones + damageDroneBonus;

            ShipType = DLLHelpers.ConfigureShipType(ShipType, itemsShip);

            if (AccountType == AccountTypes.Administrator)
            {
                Equipment_Damage *= 15;
            }
        }

        public void ConfigureNewPilot()
        {
            OwnedShips = new List<OwnedShip>()
            {
                new OwnedShip(PrefabTypes.Phoenix_type)
            };
            ShipType = PrefabTypes.Phoenix_normal;
            Items = new List<Item>()
            {
                new Item(ItemTypes.LF_3, true, true),
                new Item(ItemTypes.REP_1, true, true),
            };
            Resources = new List<PilotResource>()
            {
                new PilotResource(ResourceTypes.Credits, 10000),
                new PilotResource(ResourceTypes.Uridium, 2000),
                new PilotResource(ResourceTypes.Ammunition1, 1000),
                new PilotResource(ResourceTypes.Rocket1, 100),
            };
            Drones = new List<Drone>();
            Level = 1;
            RankType = RankTypes.BasicSpacePilot;
            FirmType = FirmTypes.None;
            Logins = new List<Login>();

            Select_Ammunition = ResourceTypes.Ammunition1;
            Select_Rocket = ResourceTypes.Rocket1;

            ConfigurationFirst = true;
            AccountType = AccountTypes.User;
        }

        public void ConfigureNewAdministrator()
        {
            OwnedShips = new List<OwnedShip>()
            {
                new OwnedShip(PrefabTypes.Admin) { Hitpoints = AbstractShip.GetInstance(PrefabTypes.Admin).Hitpoints },
            };
            ShipType = PrefabTypes.Admin;
            Items = new List<Item>()
            {
                new Item(ItemTypes.REP_1, true, true),
            };

            for (int i = 0; i < AbstractShip.GetInstance(PrefabTypes.Admin).LaserSlots; i++)
            {
                Items.Add(new Item(ItemTypes.LF_3, true, true));
            }

            for (int i = 0; i < AbstractShip.GetInstance(PrefabTypes.Admin).ShieldAndGearSlots; i++)
            {
                Items.Add(new Item(ItemTypes.B02, true, true));
            }

            Resources = new List<PilotResource>()
            {
                new PilotResource(ResourceTypes.Credits, 10000000),
                new PilotResource(ResourceTypes.Uridium, 10000000),
                new PilotResource(ResourceTypes.Ammunition1, 10000000),
                new PilotResource(ResourceTypes.Ammunition2, 10000000),
                new PilotResource(ResourceTypes.Ammunition3, 10000000),
                new PilotResource(ResourceTypes.Ammunition4, 10000000),
                new PilotResource(ResourceTypes.AmmunitionSab, 10000000),
                new PilotResource(ResourceTypes.Rocket1, 10000000),
                new PilotResource(ResourceTypes.Rocket2, 10000000),
                new PilotResource(ResourceTypes.Rocket3, 10000000),
            };
            Drones = new List<Drone>()
            {
                new Drone(DroneTypes.Iris) { Level = 6 },
                new Drone(DroneTypes.Iris) { Level = 6 },
                new Drone(DroneTypes.Iris) { Level = 6 },
                new Drone(DroneTypes.Iris) { Level = 6 },
                new Drone(DroneTypes.Iris) { Level = 6 },
                new Drone(DroneTypes.Iris) { Level = 6 },
                new Drone(DroneTypes.Iris) { Level = 6 },
                new Drone(DroneTypes.Iris) { Level = 6 },
            };
            Level = 17;
            RankType = RankTypes.Admin;
            Logins = new List<Login>();

            Select_Ammunition = ResourceTypes.Ammunition1;
            Select_Rocket = ResourceTypes.Rocket1;

            ConfigurationFirst = true;
            AccountType = AccountTypes.Administrator;
        }

        public void ConfigureCompany(FirmTypes firmType)
        {
            FirmType = firmType;

            switch (firmType)
            {
                case FirmTypes.MMO:
                    Map = MapTypes.MMO_1_1;
                    Position = AbstractMap.GetMapByType(MapTypes.MMO_1_1).Base_Position;
                    break;
                case FirmTypes.EIC:
                    Map = MapTypes.EIC_2_1;
                    Position = AbstractMap.GetMapByType(MapTypes.EIC_2_1).Base_Position;
                    break;
                case FirmTypes.VRU:
                    Map = MapTypes.VRU_3_1;
                    Position = AbstractMap.GetMapByType(MapTypes.VRU_3_1).Base_Position;
                    break;
            }
        }

        public void RemovePassword()
        {
            Password = default;
        }

        public void ApplyReward(Reward reward)
        {
            Experience += reward.Experience;
            Honor += reward.Honor;

            if (reward.Resources?.Any() ?? false)
            {
                foreach (var resource in reward.Resources)
                {
                    if (Resources.Any(o => o.ResourceType == resource.Key))
                    {
                        Resources.Single(o => o.ResourceType == resource.Key).Quantity += resource.Value;
                    }
                    else
                    {
                        Resources.Add(new PilotResource(resource.Key, resource.Value));
                    }
                }
            }

            if (reward.Items?.Any() ?? false)
            {
                foreach (var item in reward.Items)
                {
                    Items.Add(new Item(item, false, false));
                }
            }
        }

        public List<Cargo> ApplyCargo(List<Cargo> cargos)
        {
            var result = new List<Cargo>();

            foreach (var resource in cargos)
            {
                if (DLLHelpers.IsCargoType(resource.Resource))
                {
                    var canEquipCargo = Equipment_CargoCapacity - Equipment_CargoInResources;

                    if (canEquipCargo >= resource.Quantity)
                    {
                        Equip(resource);
                    }
                    else
                    {
                        result.Add(new Cargo(resource.Resource, Equip(resource, canEquipCargo)));
                    }
                }
                else
                {
                    Equip(resource);
                }
            }

            float Equip(Cargo cargo, float? canEquip = null)
            {
                var equip = canEquip ?? cargo.Quantity;

                if (equip <= 0)
                    return cargo.Quantity;

                if (Resources.Any(o => o.ResourceType == cargo.Resource))
                {
                    Resources.Single(o => o.ResourceType == cargo.Resource).Quantity += equip;
                }
                else
                {
                    Resources.Add(new PilotResource(cargo.Resource, equip));
                }

                return canEquip.HasValue ? cargo.Quantity - canEquip.Value : 0;
            }

            return result;
        }

        public float GetResource(ResourceTypes resourceType)
        {
            if (Resources.Any(o => o.ResourceType == resourceType))
                return Resources.First(o => o.ResourceType == resourceType).Quantity;
            return 0;
        }

        public static int LaserShotRange = 700;
    }
}