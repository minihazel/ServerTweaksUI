using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Diagnostics;

namespace ServerTweaksUI
{
    public partial class mainForm : Form
    {
        public string? currentEnv = Environment.CurrentDirectory;
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

            bool gctValue = valueGCT.Checked;

            bool removeRestrictions = valueRCR.Checked;
            int extraExfilTime = int.TryParse(valueERD.Text, out int eftParsed) ? eftParsed : 0;

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

            jsonObject["hideout"]["removeGlobalConstructionTime"] = gctValue;
            jsonObject["hideout"]["RemoveRestrictions"] = removeRestrictions;

            jsonObject["raids"]["ExtraExfilTime"] = extraExfilTime;
            jsonObject["raids"]["UsePaidCoopExfil"] = usePaidExfil;
            jsonObject["raids"]["CostForCoopExfil"] = costCoopExfil;

            jsonObject["inventory"]["WeightedArmbands"] = weightedArmbands;
            jsonObject["inventory"]["ArmbandWeight"] = armbandWeight;
            jsonObject["inventory"]["LootableMelee"] = lootableMelee;
            jsonObject["inventory"]["masterKey"] = masterKey;
            jsonObject["inventory"]["loseItemsOnDeath"]["Headgear"] = lostOnDeathItems["Headgear"];
            jsonObject["inventory"]["loseItemsOnDeath"]["Body"] = lostOnDeathItems["Body"];
            jsonObject["inventory"]["loseItemsOnDeath"]["Guns"] = lostOnDeathItems["Guns"];
            jsonObject["inventory"]["loseItemsOnDeath"]["Knife"] = lostOnDeathItems["Knife"];
            jsonObject["inventory"]["loseItemsOnDeath"]["Container"] = lostOnDeathItems["Container"];
            jsonObject["inventory"]["loseItemsOnDeath"]["questItems"] = lostOnDeathItems["questItems"];
            jsonObject["inventory"]["loseItemsOnDeath"]["specialItems"] = lostOnDeathItems["specialItems"];

            jsonObject["traders"]["AllClothingIsFree"] = allClothingFree;

            jsonObject["fleamarket"]["UnlockFleaAtLevel1"] = unlockFlea;

            jsonObject["insurance"]["InsuranceOnLabs"] = insuranceOnLabs;
            jsonObject["insurance"]["GuaranteedReturnPrapor"] = guaranteedReturnPrapor;
            jsonObject["insurance"]["GuaranteedReturnTherapist"] = guaranteedReturnTherapist;
            jsonObject["insurance"]["InsuranceMaxStorageTimeInHours"] = insuranceMaxStorage;
            jsonObject["insurance"]["WhenShouldInsuranceReturnInHours"] = whenShouldInsuranceReturn;

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

            valueGCT.Checked = jsonObject["hideout"]["removeGlobalConstructionTime"]?.ToObject<bool>() ?? true;
            valueRCR.Checked = jsonObject["hideout"]["RemoveRestrictions"]?.ToObject<bool>() ?? false;

            valueERD.Text = jsonObject["raids"]["ExtraExfilTime"]?.ToString() ?? "-60";
            valueCCEPE.Checked = jsonObject["raids"]["UsePaidCoopExfil"]?.ToObject<bool>() ?? false;
            valueCPCE.Value = jsonObject["raids"]["CostForCoopExfil"]?.ToObject<decimal>() ?? 10000;

            valueWA.Checked = jsonObject["inventory"]["WeightedArmbands"]?.ToObject<bool>() ?? false;
            valueLBM.Checked = jsonObject["inventory"]["LootableMelee"]?.ToObject<bool>() ?? false;
            valueMK.Checked = jsonObject["inventory"]["masterKey"]?.ToObject<bool>() ?? true;

            listDeathItems.SelectedIndex = 0;
            valueLIOD.Checked = jsonObject["inventory"]["loseItemsOnDeath"]["Headgear"]?.ToObject<bool>() ?? true;

            valueACF.Checked = jsonObject["traders"]["AllClothingIsFree"]?.ToObject<bool>() ?? false;
            valueUFL.Checked = jsonObject["fleamarket"]["UnlockFleaAtLevel1"]?.ToObject<bool>() ?? false;
            valueIL.Checked = jsonObject["insurance"]["InsuranceOnLabs"]?.ToObject<bool>() ?? false;
            valueGIRP.Checked = jsonObject["insurance"]["GuaranteedReturnPrapor"]?.ToObject<bool>() ?? false;
            valueGIRT.Checked = jsonObject["insurance"]["GuaranteedReturnTherapist"]?.ToObject<bool>() ?? false;
            valueMSTHI.Value = jsonObject["insurance"]["InsuranceMaxStorageTimeInHours"]?.ToObject<decimal>() ?? 144;
            valueWSIRH.Value = jsonObject["insurance"]["WhenShouldInsuranceReturnInHours"]?.ToObject<decimal>() ?? 0;
        }

        private void mainForm_Load(object sender, EventArgs e)
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
                lostOnDeathItems.Add("questItems", true);
                lostOnDeathItems.Add("specialItems", true);

                loadConfig();

                return;
            }

            errorPanel.BringToFront();
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

        private void valueERD_TextChanged(object sender, EventArgs e)
        {
            string filteredInput = new string(valueERD.Text.Where(c => char.IsDigit(c) || c == '-').ToArray());
            if (valueERD.Text != filteredInput)
            {
                int cursorPosition = valueERD.SelectionStart;
                valueERD.Text = filteredInput;
                valueERD.SelectionStart = Math.Min(cursorPosition, valueERD.Text.Length);
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
        }

        private void valueLIOD_CheckedChanged(object sender, EventArgs e)
        {
            if (listDeathItems.SelectedItem == null) return;

            string currentlyselected = listDeathItems.SelectedItem.ToString();
            if (currentlyselected == "Quest Items")
            {
                lostOnDeathItems["questItems"] = valueLIOD.Checked;
            }
            else if (currentlyselected == "Special Items")
            {
                lostOnDeathItems["specialItems"] = valueLIOD.Checked;
            }
            else
            {
                lostOnDeathItems[currentlyselected] = valueLIOD.Checked;
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

            string currentlyselected = listDeathItems.SelectedItem.ToString();
            if (currentlyselected == "Quest Items")
            {
                valueLIOD.Checked = lostOnDeathItems["questItems"];
            }
            else if (currentlyselected == "Special Items")
            {
                valueLIOD.Checked = lostOnDeathItems["specialItems"];
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
    }
}
