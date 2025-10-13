using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServerTweaksUI
{
    public class ModConfig
    {
        [JsonProperty("EnableFullLogging")]
        public bool EnableFullLogging { get; set; }

        [JsonProperty("Hideout")]
        public HideoutConfig Hideout { get; set; } = new();

        [JsonProperty("Raids")]
        public RaidsConfig Raids { get; set; } = new();

        [JsonProperty("Inventory")]
        public InventoryConfig Inventory { get; set; } = new();

        [JsonProperty("Traders")]
        public TradersConfig Traders { get; set; } = new();

        [JsonProperty("FleaMarket")]
        public FleamarketConfig Fleamarket { get; set; } = new();

        [JsonProperty("Insurance")]
        public InsuranceConfig Insurance { get; set; } = new();

        public void SaveToFile(string filePath)
        {
            string json = JsonConvert.SerializeObject(this, Formatting.Indented);
            File.WriteAllText(filePath, json);
        }
    }

    public class HideoutConfig
    {
        [JsonProperty("RemoveGlobalConstructionTime")]
        public bool RemoveGlobalConstructionTime { get; set; }

        [JsonProperty("RemoveRestrictions")]
        public bool RemoveRestrictions { get; set; }
    }

    public class RaidsConfig
    {
        [JsonProperty("EnableExtendedDuration")]
        public bool EnableExtendedDuration { get; set; }

        [JsonProperty("ExtraExfilTime")]
        public int ExtraExfilTime { get; set; }

        [JsonProperty("UsePaidCoopExfil")]
        public bool UsePaidCoopExfil { get; set; }

        [JsonProperty("CostForCoopExfil")]
        public int CostForCoopExfil { get; set; }
    }

    public class InventoryConfig
    {
        [JsonProperty("WeightedArmbands")]
        public bool WeightedArmbands { get; set; }

        [JsonProperty("ArmbandWeight")]
        public int ArmbandWeight { get; set; }

        [JsonProperty("LootableMelee")]
        public bool LootableMelee { get; set; }

        [JsonProperty("MasterKey")]
        public bool MasterKey { get; set; }

        [JsonProperty("LoseItemsOnDeath")]
        public LoseItemsOnDeathConfig LoseItemsOnDeath { get; set; } = new();
    }

    public class LoseItemsOnDeathConfig
    {
        [JsonProperty("Headgear")]
        public bool Headgear { get; set; }

        [JsonProperty("Body")]
        public bool Body { get; set; }

        [JsonProperty("Guns")]
        public bool Guns { get; set; }

        [JsonProperty("Knife")]
        public bool Knife { get; set; }

        [JsonProperty("Container")]
        public bool Container { get; set; }

        [JsonProperty("QuestItems")]
        public bool QuestItems { get; set; }

        [JsonProperty("SpecialSlotItems")]
        public bool SpecialItems { get; set; }
    }

    public class TradersConfig
    {
        [JsonProperty("AllClothingIsFree")]
        public bool AllClothingIsFree { get; set; }
    }

    public class FleamarketConfig
    {
        [JsonProperty("UnlockFleaAtLevel1")]
        public bool UnlockFleaAtLevel1 { get; set; }
    }

    public class InsuranceConfig
    {
        [JsonProperty("InsuranceOnLabs")]
        public bool InsuranceOnLabs { get; set; }

        [JsonProperty("GuaranteedReturnPrapor")]
        public bool GuaranteedReturnPrapor { get; set; }

        [JsonProperty("GuaranteedReturnTherapist")]
        public bool GuaranteedReturnTherapist { get; set; }

        [JsonProperty("InsuranceMaxStorageTimeInHours")]
        public int InsuranceMaxStorageTimeInHours { get; set; }

        [JsonProperty("WhenShouldInsuranceReturnInHours")]
        public int WhenShouldInsuranceReturnInHours { get; set; }
    }
}
