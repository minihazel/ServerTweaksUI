namespace ServerTweaksUI
{
    partial class mainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            sidePanel = new Panel();
            btnModsLink = new Button();
            btnExit = new PictureBox();
            namePanel = new Panel();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            valueUAC = new CheckBox();
            label24 = new Label();
            valueGCT = new CheckBox();
            valueRCR = new CheckBox();
            label4 = new Label();
            label3 = new Label();
            tabPage2 = new TabPage();
            valueCCEPE = new CheckBox();
            label23 = new Label();
            valueERD = new NumericUpDown();
            valueEED = new CheckBox();
            label21 = new Label();
            valueCPCE = new NumericUpDown();
            label7 = new Label();
            valueOSE = new CheckBox();
            label5 = new Label();
            label6 = new Label();
            tabPage3 = new TabPage();
            valueLIOD = new CheckBox();
            listDeathItems = new ComboBox();
            label12 = new Label();
            valueMK = new CheckBox();
            label11 = new Label();
            valueLBM = new CheckBox();
            label8 = new Label();
            valueAW = new TextBox();
            valueWA = new CheckBox();
            label9 = new Label();
            label10 = new Label();
            tabPage4 = new TabPage();
            valueACF = new CheckBox();
            label13 = new Label();
            tabPage5 = new TabPage();
            valueUFL = new CheckBox();
            label14 = new Label();
            tabPage6 = new TabPage();
            valueWSIRH = new NumericUpDown();
            label19 = new Label();
            valueMSTHI = new NumericUpDown();
            label18 = new Label();
            valueGIRT = new CheckBox();
            label17 = new Label();
            valueGIRP = new CheckBox();
            label16 = new Label();
            valueIL = new CheckBox();
            label15 = new Label();
            tabPage7 = new TabPage();
            valueEFL = new CheckBox();
            label22 = new Label();
            panel1 = new Panel();
            errorPanel = new Panel();
            label20 = new Label();
            tweakTooltip = new ToolTip(components);
            sidePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnExit).BeginInit();
            namePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)valueERD).BeginInit();
            ((System.ComponentModel.ISupportInitialize)valueCPCE).BeginInit();
            tabPage3.SuspendLayout();
            tabPage4.SuspendLayout();
            tabPage5.SuspendLayout();
            tabPage6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)valueWSIRH).BeginInit();
            ((System.ComponentModel.ISupportInitialize)valueMSTHI).BeginInit();
            tabPage7.SuspendLayout();
            panel1.SuspendLayout();
            errorPanel.SuspendLayout();
            SuspendLayout();
            // 
            // sidePanel
            // 
            sidePanel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            sidePanel.BackColor = Color.FromArgb(40, 40, 40);
            sidePanel.Controls.Add(btnModsLink);
            sidePanel.Controls.Add(btnExit);
            sidePanel.Controls.Add(namePanel);
            sidePanel.Location = new Point(0, 0);
            sidePanel.Name = "sidePanel";
            sidePanel.Size = new Size(838, 83);
            sidePanel.TabIndex = 0;
            // 
            // btnModsLink
            // 
            btnModsLink.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnModsLink.Cursor = Cursors.Hand;
            btnModsLink.FlatAppearance.BorderSize = 0;
            btnModsLink.FlatStyle = FlatStyle.Flat;
            btnModsLink.Font = new Font("Bahnschrift Light", 11F);
            btnModsLink.Location = new Point(260, 27);
            btnModsLink.Name = "btnModsLink";
            btnModsLink.Size = new Size(510, 28);
            btnModsLink.TabIndex = 5;
            btnModsLink.Text = "Placeholder";
            btnModsLink.TextAlign = ContentAlignment.MiddleLeft;
            btnModsLink.UseVisualStyleBackColor = true;
            btnModsLink.Click += btnModsLink_Click;
            // 
            // btnExit
            // 
            btnExit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnExit.Cursor = Cursors.Hand;
            btnExit.Image = Properties.Resources.door;
            btnExit.Location = new Point(776, 26);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(30, 30);
            btnExit.SizeMode = PictureBoxSizeMode.StretchImage;
            btnExit.TabIndex = 4;
            btnExit.TabStop = false;
            btnExit.Click += btnExit_Click;
            btnExit.MouseEnter += btnExit_MouseEnter;
            btnExit.MouseLeave += btnExit_MouseLeave;
            // 
            // namePanel
            // 
            namePanel.Controls.Add(label2);
            namePanel.Controls.Add(label1);
            namePanel.Controls.Add(pictureBox1);
            namePanel.Location = new Point(3, 3);
            namePanel.Name = "namePanel";
            namePanel.Size = new Size(251, 75);
            namePanel.TabIndex = 0;
            // 
            // label2
            // 
            label2.Font = new Font("Bahnschrift Light", 9F);
            label2.Location = new Point(81, 40);
            label2.Name = "label2";
            label2.Size = new Size(167, 20);
            label2.TabIndex = 2;
            label2.Text = "1.0.0";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe Print", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(78, 9);
            label1.Name = "label1";
            label1.Size = new Size(170, 33);
            label1.TabIndex = 1;
            label1.Text = "ServerTweaks";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.server;
            pictureBox1.Location = new Point(15, 15);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(45, 45);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(tabPage4);
            tabControl1.Controls.Add(tabPage5);
            tabControl1.Controls.Add(tabPage6);
            tabControl1.Controls.Add(tabPage7);
            tabControl1.Location = new Point(11, 8);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(808, 430);
            tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.FromArgb(24, 24, 28);
            tabPage1.Controls.Add(valueUAC);
            tabPage1.Controls.Add(label24);
            tabPage1.Controls.Add(valueGCT);
            tabPage1.Controls.Add(valueRCR);
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(label3);
            tabPage1.Location = new Point(4, 27);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(800, 399);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Hideout";
            // 
            // valueUAC
            // 
            valueUAC.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            valueUAC.AutoSize = true;
            valueUAC.Checked = true;
            valueUAC.CheckState = CheckState.Checked;
            valueUAC.Cursor = Cursors.Hand;
            valueUAC.Location = new Point(445, 96);
            valueUAC.Name = "valueUAC";
            valueUAC.Size = new Size(54, 22);
            valueUAC.TabIndex = 5;
            valueUAC.Text = "true";
            valueUAC.UseVisualStyleBackColor = true;
            valueUAC.CheckedChanged += valueUAC_CheckedChanged;
            // 
            // label24
            // 
            label24.Location = new Point(24, 96);
            label24.Name = "label24";
            label24.Size = new Size(415, 21);
            label24.TabIndex = 4;
            label24.Text = "Unlock All Customization";
            label24.TextAlign = ContentAlignment.MiddleLeft;
            tweakTooltip.SetToolTip(label24, "If enabled, all customization options will be available and free");
            // 
            // valueGCT
            // 
            valueGCT.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            valueGCT.AutoSize = true;
            valueGCT.Checked = true;
            valueGCT.CheckState = CheckState.Checked;
            valueGCT.Cursor = Cursors.Hand;
            valueGCT.Location = new Point(445, 24);
            valueGCT.Name = "valueGCT";
            valueGCT.Size = new Size(54, 22);
            valueGCT.TabIndex = 3;
            valueGCT.Text = "true";
            valueGCT.UseVisualStyleBackColor = true;
            valueGCT.CheckedChanged += valueGCT_CheckedChanged;
            // 
            // valueRCR
            // 
            valueRCR.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            valueRCR.AutoSize = true;
            valueRCR.Checked = true;
            valueRCR.CheckState = CheckState.Checked;
            valueRCR.Cursor = Cursors.Hand;
            valueRCR.Location = new Point(445, 60);
            valueRCR.Name = "valueRCR";
            valueRCR.Size = new Size(54, 22);
            valueRCR.TabIndex = 2;
            valueRCR.Text = "true";
            valueRCR.UseVisualStyleBackColor = true;
            valueRCR.CheckedChanged += valueRCR_CheckedChanged;
            // 
            // label4
            // 
            label4.Location = new Point(24, 60);
            label4.Name = "label4";
            label4.Size = new Size(415, 21);
            label4.TabIndex = 1;
            label4.Text = "Remove Construction Restrictions";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            tweakTooltip.SetToolTip(label4, "If enabled, construction and upgrading won't have any requirements");
            // 
            // label3
            // 
            label3.Location = new Point(24, 24);
            label3.Name = "label3";
            label3.Size = new Size(415, 21);
            label3.TabIndex = 0;
            label3.Text = "Global Construction Time";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            tweakTooltip.SetToolTip(label3, "If enabled, construction and upgrading will be instant");
            // 
            // tabPage2
            // 
            tabPage2.BackColor = Color.FromArgb(24, 24, 28);
            tabPage2.Controls.Add(valueCCEPE);
            tabPage2.Controls.Add(label23);
            tabPage2.Controls.Add(valueERD);
            tabPage2.Controls.Add(valueEED);
            tabPage2.Controls.Add(label21);
            tabPage2.Controls.Add(valueCPCE);
            tabPage2.Controls.Add(label7);
            tabPage2.Controls.Add(valueOSE);
            tabPage2.Controls.Add(label5);
            tabPage2.Controls.Add(label6);
            tabPage2.Location = new Point(4, 27);
            tabPage2.Name = "tabPage2";
            tabPage2.Size = new Size(800, 399);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Raids";
            // 
            // valueCCEPE
            // 
            valueCCEPE.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            valueCCEPE.AutoSize = true;
            valueCCEPE.Checked = true;
            valueCCEPE.CheckState = CheckState.Checked;
            valueCCEPE.Cursor = Cursors.Hand;
            valueCCEPE.Location = new Point(445, 132);
            valueCCEPE.Name = "valueCCEPE";
            valueCCEPE.Size = new Size(54, 22);
            valueCCEPE.TabIndex = 15;
            valueCCEPE.Text = "true";
            valueCCEPE.UseVisualStyleBackColor = true;
            valueCCEPE.CheckedChanged += valueCCEPE_CheckedChanged_1;
            // 
            // label23
            // 
            label23.Location = new Point(24, 132);
            label23.Name = "label23";
            label23.Size = new Size(415, 21);
            label23.TabIndex = 14;
            label23.Text = "Convert Coop Exfils to Paid Exfils";
            label23.TextAlign = ContentAlignment.MiddleLeft;
            tweakTooltip.SetToolTip(label23, "If enabled, coop exfils will be converted to paid exfils");
            // 
            // valueERD
            // 
            valueERD.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            valueERD.BackColor = Color.FromArgb(24, 24, 28);
            valueERD.BorderStyle = BorderStyle.FixedSingle;
            valueERD.ForeColor = Color.Silver;
            valueERD.Increment = new decimal(new int[] { 5, 0, 0, 0 });
            valueERD.Location = new Point(445, 59);
            valueERD.Maximum = new decimal(new int[] { 604800, 0, 0, 0 });
            valueERD.Minimum = new decimal(new int[] { 5, 0, 0, 0 });
            valueERD.Name = "valueERD";
            valueERD.Size = new Size(100, 25);
            valueERD.TabIndex = 13;
            valueERD.ThousandsSeparator = true;
            valueERD.Value = new decimal(new int[] { 40, 0, 0, 0 });
            valueERD.ValueChanged += valueERD_ValueChanged;
            // 
            // valueEED
            // 
            valueEED.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            valueEED.AutoSize = true;
            valueEED.Checked = true;
            valueEED.CheckState = CheckState.Checked;
            valueEED.Cursor = Cursors.Hand;
            valueEED.Location = new Point(445, 24);
            valueEED.Name = "valueEED";
            valueEED.Size = new Size(54, 22);
            valueEED.TabIndex = 12;
            valueEED.Text = "true";
            valueEED.UseVisualStyleBackColor = true;
            valueEED.CheckedChanged += valueEED_CheckedChanged;
            // 
            // label21
            // 
            label21.Location = new Point(24, 24);
            label21.Name = "label21";
            label21.Size = new Size(415, 21);
            label21.TabIndex = 11;
            label21.Text = "Enable Extended Raid Duration";
            label21.TextAlign = ContentAlignment.MiddleLeft;
            tweakTooltip.SetToolTip(label21, "If enabled, your raids will have select more minutes of time");
            // 
            // valueCPCE
            // 
            valueCPCE.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            valueCPCE.BackColor = Color.FromArgb(24, 24, 28);
            valueCPCE.BorderStyle = BorderStyle.FixedSingle;
            valueCPCE.ForeColor = Color.Silver;
            valueCPCE.Increment = new decimal(new int[] { 1000, 0, 0, 0 });
            valueCPCE.Location = new Point(445, 164);
            valueCPCE.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            valueCPCE.Name = "valueCPCE";
            valueCPCE.Size = new Size(100, 25);
            valueCPCE.TabIndex = 10;
            valueCPCE.ThousandsSeparator = true;
            valueCPCE.Value = new decimal(new int[] { 10000, 0, 0, 0 });
            valueCPCE.ValueChanged += valueCPCE_ValueChanged;
            // 
            // label7
            // 
            label7.Location = new Point(24, 168);
            label7.Name = "label7";
            label7.Size = new Size(415, 21);
            label7.TabIndex = 8;
            label7.Text = "Cost for Paid Coop Exfil";
            label7.TextAlign = ContentAlignment.MiddleLeft;
            tweakTooltip.SetToolTip(label7, "If the above option is enabled, converted coop exfils will cost this much to use");
            // 
            // valueOSE
            // 
            valueOSE.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            valueOSE.AutoSize = true;
            valueOSE.Checked = true;
            valueOSE.CheckState = CheckState.Checked;
            valueOSE.Cursor = Cursors.Hand;
            valueOSE.Location = new Point(445, 96);
            valueOSE.Name = "valueOSE";
            valueOSE.Size = new Size(54, 22);
            valueOSE.TabIndex = 6;
            valueOSE.Text = "true";
            valueOSE.UseVisualStyleBackColor = true;
            valueOSE.CheckedChanged += valueOSE_CheckedChanged;
            // 
            // label5
            // 
            label5.Location = new Point(24, 96);
            label5.Name = "label5";
            label5.Size = new Size(415, 21);
            label5.TabIndex = 5;
            label5.Text = "Open Standard Exfils";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            tweakTooltip.SetToolTip(label5, "If enabled, all available PMC exfils will be available and accessible");
            // 
            // label6
            // 
            label6.Location = new Point(24, 60);
            label6.Name = "label6";
            label6.Size = new Size(415, 21);
            label6.TabIndex = 4;
            label6.Text = "Extended Raid Duration";
            label6.TextAlign = ContentAlignment.MiddleLeft;
            tweakTooltip.SetToolTip(label6, "Select how many minutes to increase your raids by");
            // 
            // tabPage3
            // 
            tabPage3.BackColor = Color.FromArgb(24, 24, 28);
            tabPage3.Controls.Add(valueLIOD);
            tabPage3.Controls.Add(listDeathItems);
            tabPage3.Controls.Add(label12);
            tabPage3.Controls.Add(valueMK);
            tabPage3.Controls.Add(label11);
            tabPage3.Controls.Add(valueLBM);
            tabPage3.Controls.Add(label8);
            tabPage3.Controls.Add(valueAW);
            tabPage3.Controls.Add(valueWA);
            tabPage3.Controls.Add(label9);
            tabPage3.Controls.Add(label10);
            tabPage3.Location = new Point(4, 27);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(800, 399);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Inventory";
            // 
            // valueLIOD
            // 
            valueLIOD.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            valueLIOD.AutoSize = true;
            valueLIOD.Checked = true;
            valueLIOD.CheckState = CheckState.Checked;
            valueLIOD.Cursor = Cursors.Hand;
            valueLIOD.Enabled = false;
            valueLIOD.Location = new Point(445, 194);
            valueLIOD.Name = "valueLIOD";
            valueLIOD.Size = new Size(54, 22);
            valueLIOD.TabIndex = 21;
            valueLIOD.Text = "true";
            valueLIOD.UseVisualStyleBackColor = true;
            valueLIOD.CheckedChanged += valueLIOD_CheckedChanged;
            // 
            // listDeathItems
            // 
            listDeathItems.DropDownStyle = ComboBoxStyle.DropDownList;
            listDeathItems.Enabled = false;
            listDeathItems.FormattingEnabled = true;
            listDeathItems.Location = new Point(24, 192);
            listDeathItems.Name = "listDeathItems";
            listDeathItems.Size = new Size(205, 26);
            listDeathItems.TabIndex = 20;
            listDeathItems.SelectedIndexChanged += listDeathItems_SelectedIndexChanged;
            // 
            // label12
            // 
            label12.Location = new Point(24, 168);
            label12.Name = "label12";
            label12.Size = new Size(415, 21);
            label12.TabIndex = 19;
            label12.Text = "Lose Items On Death";
            label12.TextAlign = ContentAlignment.MiddleLeft;
            tweakTooltip.SetToolTip(label12, "Which items to lose when you die");
            // 
            // valueMK
            // 
            valueMK.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            valueMK.AutoSize = true;
            valueMK.Checked = true;
            valueMK.CheckState = CheckState.Checked;
            valueMK.Cursor = Cursors.Hand;
            valueMK.Location = new Point(445, 132);
            valueMK.Name = "valueMK";
            valueMK.Size = new Size(54, 22);
            valueMK.TabIndex = 18;
            valueMK.Text = "true";
            valueMK.UseVisualStyleBackColor = true;
            valueMK.CheckedChanged += valueMK_CheckedChanged;
            // 
            // label11
            // 
            label11.Location = new Point(24, 132);
            label11.Name = "label11";
            label11.Size = new Size(415, 21);
            label11.TabIndex = 17;
            label11.Text = "Master Key";
            label11.TextAlign = ContentAlignment.MiddleLeft;
            tweakTooltip.SetToolTip(label11, "If enabled, the below option will be used by the server");
            // 
            // valueLBM
            // 
            valueLBM.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            valueLBM.AutoSize = true;
            valueLBM.Checked = true;
            valueLBM.CheckState = CheckState.Checked;
            valueLBM.Cursor = Cursors.Hand;
            valueLBM.Location = new Point(445, 96);
            valueLBM.Name = "valueLBM";
            valueLBM.Size = new Size(54, 22);
            valueLBM.TabIndex = 16;
            valueLBM.Text = "true";
            valueLBM.UseVisualStyleBackColor = true;
            valueLBM.CheckedChanged += valueLBM_CheckedChanged;
            // 
            // label8
            // 
            label8.Location = new Point(24, 96);
            label8.Name = "label8";
            label8.Size = new Size(415, 21);
            label8.TabIndex = 15;
            label8.Text = "Lootable Bot Melee";
            label8.TextAlign = ContentAlignment.MiddleLeft;
            tweakTooltip.SetToolTip(label8, "If enabled, all bots you loot will have their melee slots accessible for looting");
            // 
            // valueAW
            // 
            valueAW.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            valueAW.BackColor = Color.FromArgb(24, 24, 28);
            valueAW.BorderStyle = BorderStyle.FixedSingle;
            valueAW.ForeColor = Color.Silver;
            valueAW.Location = new Point(445, 56);
            valueAW.Name = "valueAW";
            valueAW.Size = new Size(100, 25);
            valueAW.TabIndex = 14;
            valueAW.Text = "-60";
            valueAW.TextChanged += valueAW_TextChanged;
            valueAW.KeyDown += valueAW_KeyDown;
            valueAW.KeyPress += valueAW_KeyPress;
            // 
            // valueWA
            // 
            valueWA.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            valueWA.AutoSize = true;
            valueWA.Checked = true;
            valueWA.CheckState = CheckState.Checked;
            valueWA.Cursor = Cursors.Hand;
            valueWA.Location = new Point(445, 23);
            valueWA.Name = "valueWA";
            valueWA.Size = new Size(54, 22);
            valueWA.TabIndex = 13;
            valueWA.Text = "true";
            valueWA.UseVisualStyleBackColor = true;
            valueWA.CheckedChanged += valueWA_CheckedChanged;
            // 
            // label9
            // 
            label9.Location = new Point(24, 60);
            label9.Name = "label9";
            label9.Size = new Size(415, 21);
            label9.TabIndex = 12;
            label9.Text = "Armband Weight";
            label9.TextAlign = ContentAlignment.MiddleLeft;
            tweakTooltip.SetToolTip(label9, "Will only apply if the above option is enabled");
            // 
            // label10
            // 
            label10.Location = new Point(24, 24);
            label10.Name = "label10";
            label10.Size = new Size(415, 21);
            label10.TabIndex = 11;
            label10.Text = "Weighted Armbands";
            label10.TextAlign = ContentAlignment.MiddleLeft;
            tweakTooltip.SetToolTip(label10, "If enabled, all in-game armbands will have the below value as their weight");
            // 
            // tabPage4
            // 
            tabPage4.BackColor = Color.FromArgb(24, 24, 28);
            tabPage4.Controls.Add(valueACF);
            tabPage4.Controls.Add(label13);
            tabPage4.Location = new Point(4, 27);
            tabPage4.Name = "tabPage4";
            tabPage4.Size = new Size(800, 399);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "Traders";
            // 
            // valueACF
            // 
            valueACF.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            valueACF.AutoSize = true;
            valueACF.Checked = true;
            valueACF.CheckState = CheckState.Checked;
            valueACF.Cursor = Cursors.Hand;
            valueACF.Location = new Point(445, 23);
            valueACF.Name = "valueACF";
            valueACF.Size = new Size(54, 22);
            valueACF.TabIndex = 15;
            valueACF.Text = "true";
            valueACF.UseVisualStyleBackColor = true;
            valueACF.CheckedChanged += valueACF_CheckedChanged;
            // 
            // label13
            // 
            label13.Location = new Point(24, 24);
            label13.Name = "label13";
            label13.Size = new Size(415, 21);
            label13.TabIndex = 14;
            label13.Text = "All Clothing is Free";
            label13.TextAlign = ContentAlignment.MiddleLeft;
            tweakTooltip.SetToolTip(label13, "If enabled, all of Ragman's assortment of clothing will be available and free");
            // 
            // tabPage5
            // 
            tabPage5.BackColor = Color.FromArgb(24, 24, 28);
            tabPage5.Controls.Add(valueUFL);
            tabPage5.Controls.Add(label14);
            tabPage5.Location = new Point(4, 27);
            tabPage5.Name = "tabPage5";
            tabPage5.Size = new Size(800, 399);
            tabPage5.TabIndex = 4;
            tabPage5.Text = "Flea market";
            // 
            // valueUFL
            // 
            valueUFL.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            valueUFL.AutoSize = true;
            valueUFL.Checked = true;
            valueUFL.CheckState = CheckState.Checked;
            valueUFL.Cursor = Cursors.Hand;
            valueUFL.Location = new Point(445, 23);
            valueUFL.Name = "valueUFL";
            valueUFL.Size = new Size(54, 22);
            valueUFL.TabIndex = 17;
            valueUFL.Text = "true";
            valueUFL.UseVisualStyleBackColor = true;
            valueUFL.CheckedChanged += valueUFL_CheckedChanged;
            // 
            // label14
            // 
            label14.Location = new Point(24, 24);
            label14.Name = "label14";
            label14.Size = new Size(415, 21);
            label14.TabIndex = 16;
            label14.Text = "Unlock Flea at Level 1";
            label14.TextAlign = ContentAlignment.MiddleLeft;
            tweakTooltip.SetToolTip(label14, "If enabled, the Flea market will be unlocked from level 1 instead of 15");
            // 
            // tabPage6
            // 
            tabPage6.BackColor = Color.FromArgb(24, 24, 28);
            tabPage6.Controls.Add(valueWSIRH);
            tabPage6.Controls.Add(label19);
            tabPage6.Controls.Add(valueMSTHI);
            tabPage6.Controls.Add(label18);
            tabPage6.Controls.Add(valueGIRT);
            tabPage6.Controls.Add(label17);
            tabPage6.Controls.Add(valueGIRP);
            tabPage6.Controls.Add(label16);
            tabPage6.Controls.Add(valueIL);
            tabPage6.Controls.Add(label15);
            tabPage6.Location = new Point(4, 27);
            tabPage6.Name = "tabPage6";
            tabPage6.Size = new Size(800, 399);
            tabPage6.TabIndex = 5;
            tabPage6.Text = "Insurance";
            // 
            // valueWSIRH
            // 
            valueWSIRH.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            valueWSIRH.BackColor = Color.FromArgb(24, 24, 28);
            valueWSIRH.BorderStyle = BorderStyle.FixedSingle;
            valueWSIRH.ForeColor = Color.Silver;
            valueWSIRH.Location = new Point(445, 164);
            valueWSIRH.Maximum = new decimal(new int[] { 168, 0, 0, 0 });
            valueWSIRH.Name = "valueWSIRH";
            valueWSIRH.Size = new Size(100, 25);
            valueWSIRH.TabIndex = 27;
            valueWSIRH.ThousandsSeparator = true;
            valueWSIRH.ValueChanged += valueWSIRH_ValueChanged;
            // 
            // label19
            // 
            label19.Location = new Point(24, 168);
            label19.Name = "label19";
            label19.Size = new Size(415, 21);
            label19.TabIndex = 26;
            label19.Text = "When Should Insurance Return in Hours";
            label19.TextAlign = ContentAlignment.MiddleLeft;
            tweakTooltip.SetToolTip(label19, "How long before insurance should be returned");
            // 
            // valueMSTHI
            // 
            valueMSTHI.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            valueMSTHI.BackColor = Color.FromArgb(24, 24, 28);
            valueMSTHI.BorderStyle = BorderStyle.FixedSingle;
            valueMSTHI.ForeColor = Color.Silver;
            valueMSTHI.Location = new Point(445, 128);
            valueMSTHI.Maximum = new decimal(new int[] { 168, 0, 0, 0 });
            valueMSTHI.Name = "valueMSTHI";
            valueMSTHI.Size = new Size(100, 25);
            valueMSTHI.TabIndex = 25;
            valueMSTHI.ThousandsSeparator = true;
            valueMSTHI.Value = new decimal(new int[] { 144, 0, 0, 0 });
            valueMSTHI.ValueChanged += valueMSTHI_ValueChanged;
            // 
            // label18
            // 
            label18.Location = new Point(24, 132);
            label18.Name = "label18";
            label18.Size = new Size(415, 21);
            label18.TabIndex = 24;
            label18.Text = "Max Storage Time in Hours for Insurance";
            label18.TextAlign = ContentAlignment.MiddleLeft;
            tweakTooltip.SetToolTip(label18, "How long insurance can be stored in the server before going MIA");
            // 
            // valueGIRT
            // 
            valueGIRT.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            valueGIRT.AutoSize = true;
            valueGIRT.Checked = true;
            valueGIRT.CheckState = CheckState.Checked;
            valueGIRT.Cursor = Cursors.Hand;
            valueGIRT.Location = new Point(445, 96);
            valueGIRT.Name = "valueGIRT";
            valueGIRT.Size = new Size(54, 22);
            valueGIRT.TabIndex = 23;
            valueGIRT.Text = "true";
            valueGIRT.UseVisualStyleBackColor = true;
            valueGIRT.CheckedChanged += valueGIRT_CheckedChanged;
            // 
            // label17
            // 
            label17.Location = new Point(24, 96);
            label17.Name = "label17";
            label17.Size = new Size(415, 21);
            label17.TabIndex = 22;
            label17.Text = "Guaranteed Insurance Return on Therapist";
            label17.TextAlign = ContentAlignment.MiddleLeft;
            tweakTooltip.SetToolTip(label17, "If enabled, Therapist's insurance will always return");
            // 
            // valueGIRP
            // 
            valueGIRP.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            valueGIRP.AutoSize = true;
            valueGIRP.Checked = true;
            valueGIRP.CheckState = CheckState.Checked;
            valueGIRP.Cursor = Cursors.Hand;
            valueGIRP.Location = new Point(445, 60);
            valueGIRP.Name = "valueGIRP";
            valueGIRP.Size = new Size(54, 22);
            valueGIRP.TabIndex = 21;
            valueGIRP.Text = "true";
            valueGIRP.UseVisualStyleBackColor = true;
            valueGIRP.CheckedChanged += valueGIRP_CheckedChanged;
            // 
            // label16
            // 
            label16.Location = new Point(24, 60);
            label16.Name = "label16";
            label16.Size = new Size(415, 21);
            label16.TabIndex = 20;
            label16.Text = "Guaranteed Insurance Return on Prapor";
            label16.TextAlign = ContentAlignment.MiddleLeft;
            tweakTooltip.SetToolTip(label16, "If enabled, Prapor's insurance will always return");
            // 
            // valueIL
            // 
            valueIL.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            valueIL.AutoSize = true;
            valueIL.Checked = true;
            valueIL.CheckState = CheckState.Checked;
            valueIL.Cursor = Cursors.Hand;
            valueIL.Location = new Point(445, 23);
            valueIL.Name = "valueIL";
            valueIL.Size = new Size(54, 22);
            valueIL.TabIndex = 19;
            valueIL.Text = "true";
            valueIL.UseVisualStyleBackColor = true;
            valueIL.CheckedChanged += valueIL_CheckedChanged;
            // 
            // label15
            // 
            label15.Location = new Point(24, 24);
            label15.Name = "label15";
            label15.Size = new Size(415, 21);
            label15.TabIndex = 18;
            label15.Text = "Insurance on Labs";
            label15.TextAlign = ContentAlignment.MiddleLeft;
            tweakTooltip.SetToolTip(label15, "If enabled, the Laboratory will have insurance enabled");
            // 
            // tabPage7
            // 
            tabPage7.BackColor = Color.FromArgb(24, 24, 28);
            tabPage7.Controls.Add(valueEFL);
            tabPage7.Controls.Add(label22);
            tabPage7.Location = new Point(4, 27);
            tabPage7.Name = "tabPage7";
            tabPage7.Padding = new Padding(3);
            tabPage7.Size = new Size(800, 399);
            tabPage7.TabIndex = 6;
            tabPage7.Text = "Logging";
            // 
            // valueEFL
            // 
            valueEFL.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            valueEFL.AutoSize = true;
            valueEFL.Checked = true;
            valueEFL.CheckState = CheckState.Checked;
            valueEFL.Cursor = Cursors.Hand;
            valueEFL.Location = new Point(445, 24);
            valueEFL.Name = "valueEFL";
            valueEFL.Size = new Size(54, 22);
            valueEFL.TabIndex = 5;
            valueEFL.Text = "true";
            valueEFL.UseVisualStyleBackColor = true;
            valueEFL.CheckedChanged += valueEFL_CheckedChanged;
            // 
            // label22
            // 
            label22.Location = new Point(24, 24);
            label22.Name = "label22";
            label22.Size = new Size(415, 21);
            label22.TabIndex = 4;
            label22.Text = "Enable Full Logging";
            label22.TextAlign = ContentAlignment.MiddleLeft;
            tweakTooltip.SetToolTip(label22, "If enabled, the server console will log every available adjustment");
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Controls.Add(tabControl1);
            panel1.Location = new Point(3, 89);
            panel1.Name = "panel1";
            panel1.Size = new Size(831, 447);
            panel1.TabIndex = 2;
            // 
            // errorPanel
            // 
            errorPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            errorPanel.Controls.Add(label20);
            errorPanel.Location = new Point(3, 89);
            errorPanel.Name = "errorPanel";
            errorPanel.Size = new Size(831, 447);
            errorPanel.TabIndex = 3;
            // 
            // label20
            // 
            label20.Font = new Font("Bahnschrift Light", 14F);
            label20.Location = new Point(3, 95);
            label20.Name = "label20";
            label20.Size = new Size(825, 185);
            label20.TabIndex = 0;
            label20.Text = "ServerTweaks is not in the `user / mods` folder.\r\n\r\nPlease move `ServerTweaksUI.exe` into the `user / mods / ServerTweaks` folder.";
            label20.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // mainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(24, 24, 28);
            ClientSize = new Size(838, 548);
            Controls.Add(sidePanel);
            Controls.Add(panel1);
            Controls.Add(errorPanel);
            Font = new Font("Bahnschrift", 11F);
            ForeColor = Color.Silver;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "mainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ServerTweaks - UI";
            Load += mainForm_Load;
            sidePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)btnExit).EndInit();
            namePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)valueERD).EndInit();
            ((System.ComponentModel.ISupportInitialize)valueCPCE).EndInit();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            tabPage4.ResumeLayout(false);
            tabPage4.PerformLayout();
            tabPage5.ResumeLayout(false);
            tabPage5.PerformLayout();
            tabPage6.ResumeLayout(false);
            tabPage6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)valueWSIRH).EndInit();
            ((System.ComponentModel.ISupportInitialize)valueMSTHI).EndInit();
            tabPage7.ResumeLayout(false);
            tabPage7.PerformLayout();
            panel1.ResumeLayout(false);
            errorPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel sidePanel;
        private Panel namePanel;
        private PictureBox btnExit;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private TabPage tabPage4;
        private TabPage tabPage5;
        private TabPage tabPage6;
        private Label label3;
        private Label label4;
        private CheckBox valueRCR;
        private CheckBox valueOSE;
        private Label label5;
        private Label label6;
        private Label label7;
        private NumericUpDown valueCPCE;
        private Label label8;
        private TextBox valueAW;
        private CheckBox valueWA;
        private Label label9;
        private Label label10;
        private CheckBox valueLBM;
        private CheckBox valueMK;
        private Label label11;
        private Label label12;
        private ComboBox listDeathItems;
        private CheckBox valueLIOD;
        private CheckBox valueACF;
        private Label label13;
        private CheckBox valueUFL;
        private Label label14;
        private CheckBox valueIL;
        private Label label15;
        private CheckBox valueGIRT;
        private Label label17;
        private CheckBox valueGIRP;
        private Label label16;
        private NumericUpDown valueWSIRH;
        private Label label19;
        private NumericUpDown valueMSTHI;
        private Label label18;
        private Panel panel1;
        private Panel errorPanel;
        private Label label20;
        private Button btnModsLink;
        private CheckBox valueGCT;
        private CheckBox valueEED;
        private Label label21;
        private NumericUpDown valueERD;
        private TabPage tabPage7;
        private CheckBox valueEFL;
        private Label label22;
        private CheckBox valueCCEPE;
        private Label label23;
        private CheckBox valueUAC;
        private Label label24;
        private ToolTip tweakTooltip;
    }
}
