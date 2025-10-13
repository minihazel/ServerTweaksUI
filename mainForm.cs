using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Diagnostics;

namespace ServerTweaksUI
{
    public partial class mainForm : Form
    {
        public string? currentEnv = AppDomain.CurrentDomain.BaseDirectory;
        public string? configJson = null;
        public string? configContent = null;
        public string? configObj = null;
        public Dictionary<string, bool> lostOnDeathItems = new Dictionary<string, bool>();

        public mainForm()
        {
            InitializeComponent();
        }

        private void saveToConfig()
        {
            if (configJson == null) return;
            string content = File.ReadAllText(configJson);
            var jsonObject = JObject.Parse(content);

            bool enableLogging = valueEFL.Checked;
            bool gctValue = valueGCT.Checked;

            bool RemoveAllRestrictions = valueRCR.Checked;

            bool extendedRaid = valueEED.Checked;
            decimal extendedDuration = valueERD.Value;
            int extendedRaidDuration = Convert.ToInt32(extendedDuration);

            bool openStandardExfils = valueOSE.Checked;

            decimal cost = valueCPCE.Value;
            int costCoopExfil = Convert.ToInt32(cost);
            bool usePaidExfil = valueCCEPE.Checked;

            bool weightedArmbands = valueWA.Checked;
            int armbandWeight = int.TryParse(valueAW.Text, out int weight) ? weight : -60;
            bool lootableMelee = valueLBM.Checked;

            bool masterKey = valueMK.Checked;
            bool lostHeadgear = valueLIOD.Checked;

            bool allClothingFree = valueACF.Checked;

            bool unlockFlea = valueUFL.Checked;

            bool insuranceOnLabs = valueIL.Checked;
            bool guaranteedReturnPrapor = valueGIRP.Checked;
            bool guaranteedReturnTherapist = valueGIRT.Checked;

            decimal insuranceMaxStorageDecimal = valueMSTHI.Value;
            int insuranceMaxStorage = Convert.ToInt32(insuranceMaxStorageDecimal);

            decimal whenShouldInsuranceReturnDecimal = valueWSIRH.Value;
            int whenShouldInsuranceReturn = Convert.ToInt32(whenShouldInsuranceReturnDecimal);

            jsonObject["EnableFullLogging"] = enableLogging;
            jsonObject["Hideout"]["RemoveGlobalConstructionTime"] = gctValue;
            jsonObject["Hideout"]["RemoveAllRestrictions"] = RemoveAllRestrictions;

            jsonObject["Raids"]["EnableExtendedDuration"] = extendedRaid;
            jsonObject["Raids"]["ExtraExfilTime"] = extendedRaidDuration;
            jsonObject["Raids"]["OpenStandardExfils"] = openStandardExfils;
            jsonObject["Raids"]["UsePaidCoopExfil"] = usePaidExfil;
            jsonObject["Raids"]["CostForCoopExfil"] = costCoopExfil;

            jsonObject["Inventory"]["WeightedArmbands"] = weightedArmbands;
            jsonObject["Inventory"]["ArmbandWeight"] = armbandWeight;
            jsonObject["Inventory"]["LootableMelee"] = lootableMelee;
            jsonObject["Inventory"]["MasterKey"] = masterKey;
            jsonObject["Inventory"]["LoseItemsOnDeath"]["Headgear"] = lostOnDeathItems["Headgear"];
            jsonObject["Inventory"]["LoseItemsOnDeath"]["Body"] = lostOnDeathItems["Body"];
            jsonObject["Inventory"]["LoseItemsOnDeath"]["Guns"] = lostOnDeathItems["Guns"];
            jsonObject["Inventory"]["LoseItemsOnDeath"]["Knife"] = lostOnDeathItems["Knife"];
            jsonObject["Inventory"]["LoseItemsOnDeath"]["Container"] = lostOnDeathItems["Container"];
            jsonObject["Inventory"]["LoseItemsOnDeath"]["QuestItems"] = lostOnDeathItems["QuestItems"];
            jsonObject["Inventory"]["LoseItemsOnDeath"]["SpecialSlotItems"] = lostOnDeathItems["SpecialSlotItems"];

            jsonObject["Traders"]["AllClothingIsFree"] = allClothingFree;

            jsonObject["FleaMarket"]["UnlockFleaAtLevel1"] = unlockFlea;

            jsonObject["Insurance"]["InsuranceOnLabs"] = insuranceOnLabs;
            jsonObject["Insurance"]["GuaranteedReturnPrapor"] = guaranteedReturnPrapor;
            jsonObject["Insurance"]["GuaranteedReturnTherapist"] = guaranteedReturnTherapist;
            jsonObject["Insurance"]["InsuranceMaxStorageTimeInHours"] = insuranceMaxStorage;
            jsonObject["Insurance"]["WhenShouldInsuranceReturnInHours"] = whenShouldInsuranceReturn;

            try
            {
                string indentedContent = JsonConvert.SerializeObject(jsonObject, Formatting.Indented);
                File.WriteAllText(configJson, indentedContent);
            }
            catch (Exception ex)
            {
                return;
            }
        }

        private void loadConfig()
        {
            if (configJson == null) return;
            string content = File.ReadAllText(configJson);
            var jsonObject = JObject.Parse(content);

            valueEFL.Checked = jsonObject["EnableFullLogging"]?.ToObject<bool>() ?? true;
            valueGCT.Checked = jsonObject["Hideout"]["RemoveGlobalConstructionTime"]?.ToObject<bool>() ?? false;
            valueRCR.Checked = jsonObject["Hideout"]["RemoveAllRestrictions"]?.ToObject<bool>() ?? false;

            valueEED.Checked = jsonObject["Raids"]["EnableExtendedDuration"]?.ToObject<bool>() ?? false;
            valueERD.Text = jsonObject["Raids"]["ExtraExfilTime"]?.ToString() ?? "-60";
            valueOSE.Checked = jsonObject["Raids"]["OpenStandardExfils"]?.ToObject<bool>() ?? false;
            valueCCEPE.Checked = jsonObject["Raids"]["UsePaidCoopExfil"]?.ToObject<bool>() ?? false;
            valueCPCE.Value = jsonObject["Raids"]["CostForCoopExfil"]?.ToObject<decimal>() ?? 10000;

            valueWA.Checked = jsonObject["Inventory"]["WeightedArmbands"]?.ToObject<bool>() ?? false;
            valueLBM.Checked = jsonObject["Inventory"]["LootableMelee"]?.ToObject<bool>() ?? false;
            valueMK.Checked = jsonObject["Inventory"]["MasterKey"]?.ToObject<bool>() ?? false;

            listDeathItems.SelectedIndex = 0;
            valueLIOD.Checked = jsonObject["Inventory"]["LoseItemsOnDeath"]["Headgear"]?.ToObject<bool>() ?? true;

            valueACF.Checked = jsonObject["Traders"]["AllClothingIsFree"]?.ToObject<bool>() ?? false;

            valueUFL.Checked = jsonObject["FleaMarket"]["UnlockFleaAtLevel1"]?.ToObject<bool>() ?? false;

            valueIL.Checked = jsonObject["Insurance"]["InsuranceOnLabs"]?.ToObject<bool>() ?? false;
            valueGIRP.Checked = jsonObject["Insurance"]["GuaranteedReturnPrapor"]?.ToObject<bool>() ?? false;
            valueGIRT.Checked = jsonObject["Insurance"]["GuaranteedReturnTherapist"]?.ToObject<bool>() ?? false;
            valueMSTHI.Value = jsonObject["Insurance"]["InsuranceMaxStorageTimeInHours"]?.ToObject<decimal>() ?? 144;
            valueWSIRH.Value = jsonObject["Insurance"]["WhenShouldInsuranceReturnInHours"]?.ToObject<decimal>() ?? 0;
        }

        private void initializeApp()
        {
            DirectoryInfo? appFolder = new DirectoryInfo(currentEnv); // ServerTweaks
            DirectoryInfo? modsFolder = appFolder?.Parent; // mods
            DirectoryInfo? userFolder = modsFolder?.Parent; // user
            DirectoryInfo? sptFolder = userFolder?.Parent; // SPT

            if (modsFolder?.Name == "mods" &&
                    userFolder?.Name == "user" &&
                    sptFolder != null)
            {
                configJson = Path.Join(currentEnv, "config.jsonc");
                bool fileExists = File.Exists(configJson);
                if (fileExists)
                {
                    string fullPath = Path.GetFullPath(configJson);
                    btnModsLink.Tag = fullPath;
                    btnModsLink.Text = "SPT/user/mods/ServerTweaks (click to open)";

                    lostOnDeathItems.Add("Headgear", true);
                    lostOnDeathItems.Add("Body", true);
                    lostOnDeathItems.Add("Guns", true);
                    lostOnDeathItems.Add("Knife", true);
                    lostOnDeathItems.Add("Container", true);
                    lostOnDeathItems.Add("QuestItems", true);
                    lostOnDeathItems.Add("SpecialSlotItems", true);

                    listDeathItems.Items.Add("Headgear");
                    listDeathItems.Items.Add("Body");
                    listDeathItems.Items.Add("Guns");
                    listDeathItems.Items.Add("Knife");
                    listDeathItems.Items.Add("Container");
                    listDeathItems.Items.Add("Quest Items");
                    listDeathItems.Items.Add("Special Slot Items");

                    loadConfig();
                    return;
                }
                else
                {
                    var config = new ModConfig
                    {
                        EnableFullLogging = true,
                        Hideout = new HideoutConfig
                        {
                            RemoveGlobalConstructionTime = false,
                            RemoveAllRestrictions = false
                        },
                        Raids = new RaidsConfig
                        {
                            EnableExtendedDuration = false,
                            ExtraExfilTime = 40,
                            OpenStandardExfils = false,
                            UsePaidCoopExfil = false,
                            CostForCoopExfil = 10000
                        },
                        Inventory = new InventoryConfig
                        {
                            WeightedArmbands = false,
                            ArmbandWeight = -60,
                            LootableMelee = false,
                            MasterKey = false,
                            LoseItemsOnDeath = new LoseItemsOnDeathConfig
                            {
                                Headgear = true,
                                Body = true,
                                Guns = true,
                                Knife = true,
                                Container = true,
                                QuestItems = true,
                                SpecialSlotItems = true
                            }
                        },
                        Traders = new TradersConfig
                        {
                            AllClothingIsFree = false
                        },
                        Fleamarket = new FleamarketConfig
                        {
                            UnlockFleaAtLevel1 = false
                        },
                        Insurance = new InsuranceConfig
                        {
                            InsuranceOnLabs = false,
                            GuaranteedReturnPrapor = false,
                            GuaranteedReturnTherapist = false,
                            InsuranceMaxStorageTimeInHours = 144,
                            WhenShouldInsuranceReturnInHours = 0
                        }
                    };

                    config.SaveToFile(configJson);
                    initializeApp();
                }
            }
            else
            {
                errorPanel.BringToFront();
                return;
            }
        }

        private void mainForm_Load(object sender, EventArgs e)
        {
            initializeApp();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnExit_MouseEnter(object sender, EventArgs e)
        {
            btnExit.Image = Properties.Resources.door_Select;
        }

        private void btnExit_MouseLeave(object sender, EventArgs e)
        {
            btnExit.Image = Properties.Resources.door;
        }

        private void separatorPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void valueERD_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '-' && !char.IsControl(e.KeyChar))
            {
                if (char.IsControl(e.KeyChar))
                    return;
                if (char.IsDigit(e.KeyChar))
                    return;
                if (e.KeyChar == '-' && !valueERD.Text.Contains('-'))
                    return;
                e.Handled = true;
            }
        }

        private void valueAW_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '-' && !char.IsControl(e.KeyChar))
            {
                if (char.IsControl(e.KeyChar))
                    return;
                if (char.IsDigit(e.KeyChar))
                    return;
                if (e.KeyChar == '-' && !valueAW.Text.Contains('-'))
                    return;
                e.Handled = true;
            }
        }

        private void valueAW_TextChanged(object sender, EventArgs e)
        {
            string filteredInput = new string(valueAW.Text.Where(c => char.IsDigit(c) || c == '-').ToArray());
            if (valueAW.Text != filteredInput)
            {
                int cursorPosition = valueAW.SelectionStart;
                valueAW.Text = filteredInput;
                valueAW.SelectionStart = Math.Min(cursorPosition, valueAW.Text.Length);
            }
        }

        private void valueGCT_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                saveToConfig();
            }
        }

        private void valueRCR_CheckedChanged(object sender, EventArgs e)
        {
            saveToConfig();
        }

        private void valueERD_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                saveToConfig();
            }
        }

        private void valueCCEPE_CheckedChanged(object sender, EventArgs e)
        {
            saveToConfig();
        }

        private void valueOSE_CheckedChanged(object sender, EventArgs e)
        {
            saveToConfig();
        }

        private void valueCCEPE_CheckedChanged_1(object sender, EventArgs e)
        {
            saveToConfig();
        }

        private void valueCPCE_ValueChanged(object sender, EventArgs e)
        {
            saveToConfig();
        }

        private void valueWA_CheckedChanged(object sender, EventArgs e)
        {
            saveToConfig();
        }

        private void valueAW_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                saveToConfig();
            }
        }

        private void valueLBM_CheckedChanged(object sender, EventArgs e)
        {
            saveToConfig();
        }

        private void valueMK_CheckedChanged(object sender, EventArgs e)
        {
            saveToConfig();
            if (valueMK.Checked)
            {
                valueLIOD.Enabled = true;
                listDeathItems.Enabled = true;
            }
            else
            {
                valueLIOD.Enabled = false;
                listDeathItems.Enabled = false;
            }
        }
        private void valueLIOD_CheckedChanged(object sender, EventArgs e)
        {
            if (listDeathItems.SelectedItem == null) return;

            string currentlyselected = listDeathItems.SelectedItem.ToString();
            if (currentlyselected == "Quest Items")
            {
                lostOnDeathItems["QuestItems"] = valueLIOD.Checked;
            }
            else if (currentlyselected == "Special Slot Items")
            {
                lostOnDeathItems["SpecialSlotItems"] = valueLIOD.Checked;
            }
            else
            {
            }

            saveToConfig();
        }

        private void valueACF_CheckedChanged(object sender, EventArgs e)
        {
            saveToConfig();
        }

        private void valueUFL_CheckedChanged(object sender, EventArgs e)
        {
            saveToConfig();
        }

        private void valueIL_CheckedChanged(object sender, EventArgs e)
        {
            saveToConfig();
        }

        private void valueGIRP_CheckedChanged(object sender, EventArgs e)
        {
            saveToConfig();
        }

        private void valueGIRT_CheckedChanged(object sender, EventArgs e)
        {
            saveToConfig();
        }

        private void valueMSTHI_ValueChanged(object sender, EventArgs e)
        {
            saveToConfig();
        }

        private void valueWSIRH_ValueChanged(object sender, EventArgs e)
        {
            saveToConfig();
        }

        private void listDeathItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listDeathItems.SelectedItem == null) return;

            string? currentlyselected = listDeathItems.SelectedItem.ToString();
            if (currentlyselected == "Quest Items")
            {
                valueLIOD.Checked = lostOnDeathItems["QuestItems"];
            }
            else if (currentlyselected == "Special Slot Items")
            {
                valueLIOD.Checked = lostOnDeathItems["SpecialSlotItems"];
            }
            else
            {
                valueLIOD.Checked = lostOnDeathItems[currentlyselected];
            }
        }

        private void valueGCT_CheckedChanged(object sender, EventArgs e)
        {
            saveToConfig();
        }

        private void btnModsLink_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(currentEnv))
            {
                MessageBox.Show("Hmm, it appears that the folder this app is in doesn\'t exist. Please restart the app and try again.", Text, MessageBoxButtons.OK);
                return;
            }

            try
            {
                Process.Start("explorer.exe", currentEnv);
            }
            catch (Exception)
            {
                return;
            }
        }

        private void valueEED_CheckedChanged(object sender, EventArgs e)
        {
            saveToConfig();
        }

        private void valueERD_ValueChanged(object sender, EventArgs e)
        {
            saveToConfig();
        }

        private void valueEFL_CheckedChanged(object sender, EventArgs e)
        {
            saveToConfig();
        }
    }
}
