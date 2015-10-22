using System;

namespace SIvPaVS_App
{
    partial class form_Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ms_MainMenu = new System.Windows.Forms.MenuStrip();
            this.tsmi_File = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_Open = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_FileNew = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_FileSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmi_FileSaveXML = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_FileSaveTXT = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_FileSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmi_FileExit = new System.Windows.Forms.ToolStripMenuItem();
            this.gbCompany = new System.Windows.Forms.GroupBox();
            this.cbManualTime = new System.Windows.Forms.CheckBox();
            this.lbTime = new System.Windows.Forms.Label();
            this.dtTime = new System.Windows.Forms.DateTimePicker();
            this.tbTaxCode = new System.Windows.Forms.TextBox();
            this.lbTaxCode = new System.Windows.Forms.Label();
            this.gbCompanyAddress = new System.Windows.Forms.GroupBox();
            this.cbCountry = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbZIP = new System.Windows.Forms.TextBox();
            this.lbZIP = new System.Windows.Forms.Label();
            this.tbCity = new System.Windows.Forms.TextBox();
            this.lbCity = new System.Windows.Forms.Label();
            this.tbStreet = new System.Windows.Forms.TextBox();
            this.lbStreet = new System.Windows.Forms.Label();
            this.tbCompanyTaxNumber = new System.Windows.Forms.TextBox();
            this.lbCompanyTaxNumber = new System.Windows.Forms.Label();
            this.tbCompanyRegNumber = new System.Windows.Forms.TextBox();
            this.lbCompanyRegNumber = new System.Windows.Forms.Label();
            this.tbCompanyName = new System.Windows.Forms.TextBox();
            this.lbCompanyName = new System.Windows.Forms.Label();
            this.panelItems = new System.Windows.Forms.TableLayoutPanel();
            this.outerPanelItems = new System.Windows.Forms.Panel();
            this.lbTAXPercentage = new System.Windows.Forms.Label();
            this.tbTAXPercentage = new System.Windows.Forms.TextBox();
            this.lbPercentPercentage = new System.Windows.Forms.Label();
            this.lbTAXBaseEUR = new System.Windows.Forms.Label();
            this.tbTAXBase = new System.Windows.Forms.TextBox();
            this.lbTAXBase = new System.Windows.Forms.Label();
            this.lbTAXTotalEur = new System.Windows.Forms.Label();
            this.tbTAXTotal = new System.Windows.Forms.TextBox();
            this.lbTAXTotal = new System.Windows.Forms.Label();
            this.lbTotal = new System.Windows.Forms.Label();
            this.tbTotalPrice = new System.Windows.Forms.TextBox();
            this.lbTotalEUR = new System.Windows.Forms.Label();
            this.gbSummary = new System.Windows.Forms.GroupBox();
            this.btValidate = new System.Windows.Forms.Button();
            this.lbAllFieldsRequired = new System.Windows.Forms.Label();
            this.fbdSelectSavingPlace = new System.Windows.Forms.FolderBrowserDialog();
            this.ofdLoadXml = new System.Windows.Forms.OpenFileDialog();
            this.btSign = new System.Windows.Forms.Button();
            this.ms_MainMenu.SuspendLayout();
            this.gbCompany.SuspendLayout();
            this.gbCompanyAddress.SuspendLayout();
            this.outerPanelItems.SuspendLayout();
            this.gbSummary.SuspendLayout();
            this.SuspendLayout();
            // 
            // ms_MainMenu
            // 
            this.ms_MainMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ms_MainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_File});
            this.ms_MainMenu.Location = new System.Drawing.Point(0, 0);
            this.ms_MainMenu.Name = "ms_MainMenu";
            this.ms_MainMenu.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.ms_MainMenu.Size = new System.Drawing.Size(569, 28);
            this.ms_MainMenu.TabIndex = 0;
            this.ms_MainMenu.Text = "Main Menu";
            // 
            // tsmi_File
            // 
            this.tsmi_File.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_Open,
            this.tsmi_FileNew,
            this.tsmi_FileSeparator1,
            this.tsmi_FileSaveXML,
            this.tsmi_FileSaveTXT,
            this.tsmi_FileSeparator2,
            this.tsmi_FileExit});
            this.tsmi_File.Name = "tsmi_File";
            this.tsmi_File.Size = new System.Drawing.Size(44, 24);
            this.tsmi_File.Text = "File";
            // 
            // tsmi_Open
            // 
            this.tsmi_Open.Name = "tsmi_Open";
            this.tsmi_Open.Size = new System.Drawing.Size(216, 26);
            this.tsmi_Open.Text = "Open...";
            this.tsmi_Open.Click += new System.EventHandler(this.eh_tsmi_File_Click);
            // 
            // tsmi_FileNew
            // 
            this.tsmi_FileNew.Name = "tsmi_FileNew";
            this.tsmi_FileNew.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.tsmi_FileNew.Size = new System.Drawing.Size(216, 26);
            this.tsmi_FileNew.Text = "New...";
            this.tsmi_FileNew.Click += new System.EventHandler(this.eh_tsmi_File_Click);
            // 
            // tsmi_FileSeparator1
            // 
            this.tsmi_FileSeparator1.Name = "tsmi_FileSeparator1";
            this.tsmi_FileSeparator1.Size = new System.Drawing.Size(213, 6);
            // 
            // tsmi_FileSaveXML
            // 
            this.tsmi_FileSaveXML.Name = "tsmi_FileSaveXML";
            this.tsmi_FileSaveXML.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.tsmi_FileSaveXML.Size = new System.Drawing.Size(216, 26);
            this.tsmi_FileSaveXML.Text = "Save as XML";
            this.tsmi_FileSaveXML.Click += new System.EventHandler(this.eh_tsmi_File_Click);
            // 
            // tsmi_FileSaveTXT
            // 
            this.tsmi_FileSaveTXT.Name = "tsmi_FileSaveTXT";
            this.tsmi_FileSaveTXT.Size = new System.Drawing.Size(216, 26);
            this.tsmi_FileSaveTXT.Text = "Save as TXT";
            this.tsmi_FileSaveTXT.Click += new System.EventHandler(this.eh_tsmi_File_Click);
            // 
            // tsmi_FileSeparator2
            // 
            this.tsmi_FileSeparator2.Name = "tsmi_FileSeparator2";
            this.tsmi_FileSeparator2.Size = new System.Drawing.Size(213, 6);
            // 
            // tsmi_FileExit
            // 
            this.tsmi_FileExit.Name = "tsmi_FileExit";
            this.tsmi_FileExit.Size = new System.Drawing.Size(216, 26);
            this.tsmi_FileExit.Text = "Exit";
            this.tsmi_FileExit.Click += new System.EventHandler(this.eh_tsmi_File_Click);
            // 
            // gbCompany
            // 
            this.gbCompany.Controls.Add(this.cbManualTime);
            this.gbCompany.Controls.Add(this.lbTime);
            this.gbCompany.Controls.Add(this.dtTime);
            this.gbCompany.Controls.Add(this.tbTaxCode);
            this.gbCompany.Controls.Add(this.lbTaxCode);
            this.gbCompany.Controls.Add(this.gbCompanyAddress);
            this.gbCompany.Controls.Add(this.tbCompanyTaxNumber);
            this.gbCompany.Controls.Add(this.lbCompanyTaxNumber);
            this.gbCompany.Controls.Add(this.tbCompanyRegNumber);
            this.gbCompany.Controls.Add(this.lbCompanyRegNumber);
            this.gbCompany.Controls.Add(this.tbCompanyName);
            this.gbCompany.Controls.Add(this.lbCompanyName);
            this.gbCompany.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbCompany.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbCompany.Location = new System.Drawing.Point(0, 28);
            this.gbCompany.Name = "gbCompany";
            this.gbCompany.Size = new System.Drawing.Size(569, 416);
            this.gbCompany.TabIndex = 4;
            this.gbCompany.TabStop = false;
            this.gbCompany.Text = "Spoločnosť";
            // 
            // cbManualTime
            // 
            this.cbManualTime.AutoSize = true;
            this.cbManualTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbManualTime.Location = new System.Drawing.Point(165, 342);
            this.cbManualTime.Name = "cbManualTime";
            this.cbManualTime.Size = new System.Drawing.Size(221, 22);
            this.cbManualTime.TabIndex = 14;
            this.cbManualTime.Text = "Zadať dátum a čas manuálne";
            this.cbManualTime.UseVisualStyleBackColor = true;
            this.cbManualTime.CheckedChanged += new System.EventHandler(this.cbManualTime_CheckedChanged);
            // 
            // lbTime
            // 
            this.lbTime.AutoSize = true;
            this.lbTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTime.Location = new System.Drawing.Point(109, 318);
            this.lbTime.Name = "lbTime";
            this.lbTime.Size = new System.Drawing.Size(36, 17);
            this.lbTime.TabIndex = 13;
            this.lbTime.Text = "Čas:";
            // 
            // dtTime
            // 
            this.dtTime.CustomFormat = "dd/MM/yyyy hh:mm:ss";
            this.dtTime.Enabled = false;
            this.dtTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtTime.Location = new System.Drawing.Point(165, 310);
            this.dtTime.Name = "dtTime";
            this.dtTime.Size = new System.Drawing.Size(247, 26);
            this.dtTime.TabIndex = 12;
            this.dtTime.Value = new System.DateTime(2015, 10, 17, 15, 45, 8, 0);
            // 
            // tbTaxCode
            // 
            this.tbTaxCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTaxCode.Location = new System.Drawing.Point(165, 380);
            this.tbTaxCode.MaxLength = 16;
            this.tbTaxCode.Name = "tbTaxCode";
            this.tbTaxCode.Size = new System.Drawing.Size(247, 26);
            this.tbTaxCode.TabIndex = 11;
            this.tbTaxCode.Text = "5412145789632547";
            this.tbTaxCode.Validating += new System.ComponentModel.CancelEventHandler(this.eh_TaxCodeValidation);
            this.tbTaxCode.Validated += new System.EventHandler(this.eh_ProviderDataValidated);
            // 
            // lbTaxCode
            // 
            this.lbTaxCode.AutoSize = true;
            this.lbTaxCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTaxCode.Location = new System.Drawing.Point(7, 386);
            this.lbTaxCode.Name = "lbTaxCode";
            this.lbTaxCode.Size = new System.Drawing.Size(138, 17);
            this.lbTaxCode.TabIndex = 10;
            this.lbTaxCode.Text = "Kód reg. pokladnice:";
            // 
            // gbCompanyAddress
            // 
            this.gbCompanyAddress.Controls.Add(this.cbCountry);
            this.gbCompanyAddress.Controls.Add(this.label1);
            this.gbCompanyAddress.Controls.Add(this.tbZIP);
            this.gbCompanyAddress.Controls.Add(this.lbZIP);
            this.gbCompanyAddress.Controls.Add(this.tbCity);
            this.gbCompanyAddress.Controls.Add(this.lbCity);
            this.gbCompanyAddress.Controls.Add(this.tbStreet);
            this.gbCompanyAddress.Controls.Add(this.lbStreet);
            this.gbCompanyAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbCompanyAddress.Location = new System.Drawing.Point(14, 148);
            this.gbCompanyAddress.Name = "gbCompanyAddress";
            this.gbCompanyAddress.Size = new System.Drawing.Size(547, 156);
            this.gbCompanyAddress.TabIndex = 6;
            this.gbCompanyAddress.TabStop = false;
            this.gbCompanyAddress.Text = "Adresa";
            // 
            // cbCountry
            // 
            this.cbCountry.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCountry.FormattingEnabled = true;
            this.cbCountry.Location = new System.Drawing.Point(128, 122);
            this.cbCountry.Name = "cbCountry";
            this.cbCountry.Size = new System.Drawing.Size(344, 28);
            this.cbCountry.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(51, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 18);
            this.label1.TabIndex = 12;
            this.label1.Text = "Štát:";
            // 
            // tbZIP
            // 
            this.tbZIP.Location = new System.Drawing.Point(128, 90);
            this.tbZIP.MaxLength = 5;
            this.tbZIP.Name = "tbZIP";
            this.tbZIP.Size = new System.Drawing.Size(72, 26);
            this.tbZIP.TabIndex = 11;
            this.tbZIP.Text = "018 55";
            this.tbZIP.Validating += new System.ComponentModel.CancelEventHandler(this.eh_ZIPValidation);
            this.tbZIP.Validated += new System.EventHandler(this.eh_ProviderDataValidated);
            // 
            // lbZIP
            // 
            this.lbZIP.AutoSize = true;
            this.lbZIP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbZIP.Location = new System.Drawing.Point(46, 94);
            this.lbZIP.Name = "lbZIP";
            this.lbZIP.Size = new System.Drawing.Size(43, 18);
            this.lbZIP.TabIndex = 10;
            this.lbZIP.Text = "PSČ:";
            // 
            // tbCity
            // 
            this.tbCity.Location = new System.Drawing.Point(128, 58);
            this.tbCity.Name = "tbCity";
            this.tbCity.Size = new System.Drawing.Size(353, 26);
            this.tbCity.TabIndex = 9;
            this.tbCity.Text = "Tuchyňa";
            this.tbCity.Validating += new System.ComponentModel.CancelEventHandler(this.eh_ReceiptValueValidate);
            // 
            // lbCity
            // 
            this.lbCity.AutoSize = true;
            this.lbCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCity.Location = new System.Drawing.Point(35, 62);
            this.lbCity.Name = "lbCity";
            this.lbCity.Size = new System.Drawing.Size(54, 18);
            this.lbCity.TabIndex = 8;
            this.lbCity.Text = "Mesto:";
            // 
            // tbStreet
            // 
            this.tbStreet.Location = new System.Drawing.Point(128, 26);
            this.tbStreet.Name = "tbStreet";
            this.tbStreet.Size = new System.Drawing.Size(353, 26);
            this.tbStreet.TabIndex = 7;
            this.tbStreet.Text = "Tuchyňa 108";
            this.tbStreet.Validating += new System.ComponentModel.CancelEventHandler(this.eh_ReceiptValueValidate);
            // 
            // lbStreet
            // 
            this.lbStreet.AutoSize = true;
            this.lbStreet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStreet.Location = new System.Drawing.Point(44, 30);
            this.lbStreet.Name = "lbStreet";
            this.lbStreet.Size = new System.Drawing.Size(45, 18);
            this.lbStreet.TabIndex = 6;
            this.lbStreet.Text = "Ulica:";
            // 
            // tbCompanyTaxNumber
            // 
            this.tbCompanyTaxNumber.Location = new System.Drawing.Point(140, 112);
            this.tbCompanyTaxNumber.MaxLength = 12;
            this.tbCompanyTaxNumber.Name = "tbCompanyTaxNumber";
            this.tbCompanyTaxNumber.Size = new System.Drawing.Size(388, 30);
            this.tbCompanyTaxNumber.TabIndex = 5;
            this.tbCompanyTaxNumber.Text = " ";
            this.tbCompanyTaxNumber.Validating += new System.ComponentModel.CancelEventHandler(this.eh_TAXNumberValidation);
            this.tbCompanyTaxNumber.Validated += new System.EventHandler(this.eh_ProviderDataValidated);
            // 
            // lbCompanyTaxNumber
            // 
            this.lbCompanyTaxNumber.AutoSize = true;
            this.lbCompanyTaxNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCompanyTaxNumber.Location = new System.Drawing.Point(39, 124);
            this.lbCompanyTaxNumber.Name = "lbCompanyTaxNumber";
            this.lbCompanyTaxNumber.Size = new System.Drawing.Size(62, 18);
            this.lbCompanyTaxNumber.TabIndex = 4;
            this.lbCompanyTaxNumber.Text = "IČ DPH:";
            // 
            // tbCompanyRegNumber
            // 
            this.tbCompanyRegNumber.Location = new System.Drawing.Point(140, 76);
            this.tbCompanyRegNumber.MaxLength = 8;
            this.tbCompanyRegNumber.Name = "tbCompanyRegNumber";
            this.tbCompanyRegNumber.Size = new System.Drawing.Size(388, 30);
            this.tbCompanyRegNumber.TabIndex = 3;
            this.tbCompanyRegNumber.Text = "46 493 115";
            this.tbCompanyRegNumber.Validating += new System.ComponentModel.CancelEventHandler(this.eh_RegNumberValidation);
            // 
            // lbCompanyRegNumber
            // 
            this.lbCompanyRegNumber.AutoSize = true;
            this.lbCompanyRegNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCompanyRegNumber.Location = new System.Drawing.Point(63, 84);
            this.lbCompanyRegNumber.Name = "lbCompanyRegNumber";
            this.lbCompanyRegNumber.Size = new System.Drawing.Size(38, 18);
            this.lbCompanyRegNumber.TabIndex = 2;
            this.lbCompanyRegNumber.Text = "IČO:";
            // 
            // tbCompanyName
            // 
            this.tbCompanyName.Location = new System.Drawing.Point(140, 40);
            this.tbCompanyName.Name = "tbCompanyName";
            this.tbCompanyName.Size = new System.Drawing.Size(388, 30);
            this.tbCompanyName.TabIndex = 1;
            this.tbCompanyName.Text = "JMG Agro, s.r.o.";
            this.tbCompanyName.Validating += new System.ComponentModel.CancelEventHandler(this.eh_ReceiptValueValidate);
            // 
            // lbCompanyName
            // 
            this.lbCompanyName.AutoSize = true;
            this.lbCompanyName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCompanyName.Location = new System.Drawing.Point(46, 48);
            this.lbCompanyName.Name = "lbCompanyName";
            this.lbCompanyName.Size = new System.Drawing.Size(55, 18);
            this.lbCompanyName.TabIndex = 0;
            this.lbCompanyName.Text = "Názov:";
            // 
            // panelItems
            // 
            this.panelItems.AutoSize = true;
            this.panelItems.ColumnCount = 1;
            this.panelItems.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.panelItems.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelItems.Location = new System.Drawing.Point(0, 0);
            this.panelItems.Name = "panelItems";
            this.panelItems.RowCount = 1;
            this.panelItems.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.panelItems.Size = new System.Drawing.Size(569, 0);
            this.panelItems.TabIndex = 6;
            // 
            // outerPanelItems
            // 
            this.outerPanelItems.AutoScroll = true;
            this.outerPanelItems.Controls.Add(this.panelItems);
            this.outerPanelItems.Dock = System.Windows.Forms.DockStyle.Top;
            this.outerPanelItems.Location = new System.Drawing.Point(0, 444);
            this.outerPanelItems.MaximumSize = new System.Drawing.Size(569, 250);
            this.outerPanelItems.Name = "outerPanelItems";
            this.outerPanelItems.Size = new System.Drawing.Size(569, 130);
            this.outerPanelItems.TabIndex = 7;
            // 
            // lbTAXPercentage
            // 
            this.lbTAXPercentage.AutoSize = true;
            this.lbTAXPercentage.Location = new System.Drawing.Point(218, 23);
            this.lbTAXPercentage.Name = "lbTAXPercentage";
            this.lbTAXPercentage.Size = new System.Drawing.Size(93, 17);
            this.lbTAXPercentage.TabIndex = 8;
            this.lbTAXPercentage.Text = "Sadzba DPH:";
            // 
            // tbTAXPercentage
            // 
            this.tbTAXPercentage.Location = new System.Drawing.Point(317, 20);
            this.tbTAXPercentage.Name = "tbTAXPercentage";
            this.tbTAXPercentage.Size = new System.Drawing.Size(35, 22);
            this.tbTAXPercentage.TabIndex = 9;
            this.tbTAXPercentage.Text = "20";
            this.tbTAXPercentage.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbTAXPercentage.Validating += new System.ComponentModel.CancelEventHandler(this.eh_TAXPercentageValidation);
            this.tbTAXPercentage.Validated += new System.EventHandler(this.eh_TAXPercentageValidated);
            // 
            // lbPercentPercentage
            // 
            this.lbPercentPercentage.AutoSize = true;
            this.lbPercentPercentage.Location = new System.Drawing.Point(356, 23);
            this.lbPercentPercentage.Name = "lbPercentPercentage";
            this.lbPercentPercentage.Size = new System.Drawing.Size(20, 17);
            this.lbPercentPercentage.TabIndex = 10;
            this.lbPercentPercentage.Text = "%";
            // 
            // lbTAXBaseEUR
            // 
            this.lbTAXBaseEUR.AutoSize = true;
            this.lbTAXBaseEUR.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbTAXBaseEUR.Location = new System.Drawing.Point(418, 51);
            this.lbTAXBaseEUR.Name = "lbTAXBaseEUR";
            this.lbTAXBaseEUR.Size = new System.Drawing.Size(37, 17);
            this.lbTAXBaseEUR.TabIndex = 13;
            this.lbTAXBaseEUR.Text = "EUR";
            // 
            // tbTAXBase
            // 
            this.tbTAXBase.Location = new System.Drawing.Point(317, 48);
            this.tbTAXBase.Name = "tbTAXBase";
            this.tbTAXBase.ReadOnly = true;
            this.tbTAXBase.Size = new System.Drawing.Size(95, 22);
            this.tbTAXBase.TabIndex = 12;
            this.tbTAXBase.Text = "20";
            this.tbTAXBase.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lbTAXBase
            // 
            this.lbTAXBase.AutoSize = true;
            this.lbTAXBase.Location = new System.Drawing.Point(223, 51);
            this.lbTAXBase.Name = "lbTAXBase";
            this.lbTAXBase.Size = new System.Drawing.Size(88, 17);
            this.lbTAXBase.TabIndex = 11;
            this.lbTAXBase.Text = "Základ DPH:";
            // 
            // lbTAXTotalEur
            // 
            this.lbTAXTotalEur.AutoSize = true;
            this.lbTAXTotalEur.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbTAXTotalEur.Location = new System.Drawing.Point(418, 81);
            this.lbTAXTotalEur.Name = "lbTAXTotalEur";
            this.lbTAXTotalEur.Size = new System.Drawing.Size(37, 17);
            this.lbTAXTotalEur.TabIndex = 16;
            this.lbTAXTotalEur.Text = "EUR";
            // 
            // tbTAXTotal
            // 
            this.tbTAXTotal.Location = new System.Drawing.Point(317, 78);
            this.tbTAXTotal.Name = "tbTAXTotal";
            this.tbTAXTotal.ReadOnly = true;
            this.tbTAXTotal.Size = new System.Drawing.Size(95, 22);
            this.tbTAXTotal.TabIndex = 15;
            this.tbTAXTotal.Text = "20";
            this.tbTAXTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lbTAXTotal
            // 
            this.lbTAXTotal.AutoSize = true;
            this.lbTAXTotal.Location = new System.Drawing.Point(270, 81);
            this.lbTAXTotal.Name = "lbTAXTotal";
            this.lbTAXTotal.Size = new System.Drawing.Size(41, 17);
            this.lbTAXTotal.TabIndex = 14;
            this.lbTAXTotal.Text = "DPH:";
            // 
            // lbTotal
            // 
            this.lbTotal.AutoSize = true;
            this.lbTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotal.Location = new System.Drawing.Point(200, 125);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(111, 25);
            this.lbTotal.TabIndex = 17;
            this.lbTotal.Text = "CELKOM:";
            // 
            // tbTotalPrice
            // 
            this.tbTotalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTotalPrice.Location = new System.Drawing.Point(317, 122);
            this.tbTotalPrice.Name = "tbTotalPrice";
            this.tbTotalPrice.ReadOnly = true;
            this.tbTotalPrice.Size = new System.Drawing.Size(167, 30);
            this.tbTotalPrice.TabIndex = 18;
            this.tbTotalPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lbTotalEUR
            // 
            this.lbTotalEUR.AutoSize = true;
            this.lbTotalEUR.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotalEUR.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbTotalEUR.Location = new System.Drawing.Point(490, 125);
            this.lbTotalEUR.Name = "lbTotalEUR";
            this.lbTotalEUR.Size = new System.Drawing.Size(55, 25);
            this.lbTotalEUR.TabIndex = 19;
            this.lbTotalEUR.Text = "EUR";
            // 
            // gbSummary
            // 
            this.gbSummary.Controls.Add(this.tbTAXBase);
            this.gbSummary.Controls.Add(this.tbTAXPercentage);
            this.gbSummary.Controls.Add(this.lbTAXTotal);
            this.gbSummary.Controls.Add(this.lbTotalEUR);
            this.gbSummary.Controls.Add(this.lbTAXBaseEUR);
            this.gbSummary.Controls.Add(this.lbTAXPercentage);
            this.gbSummary.Controls.Add(this.tbTAXTotal);
            this.gbSummary.Controls.Add(this.tbTotalPrice);
            this.gbSummary.Controls.Add(this.lbTAXTotalEur);
            this.gbSummary.Controls.Add(this.lbPercentPercentage);
            this.gbSummary.Controls.Add(this.lbTAXBase);
            this.gbSummary.Controls.Add(this.lbTotal);
            this.gbSummary.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbSummary.Location = new System.Drawing.Point(0, 574);
            this.gbSummary.Name = "gbSummary";
            this.gbSummary.Size = new System.Drawing.Size(569, 174);
            this.gbSummary.TabIndex = 7;
            this.gbSummary.TabStop = false;
            // 
            // btValidate
            // 
            this.btValidate.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btValidate.ForeColor = System.Drawing.Color.Blue;
            this.btValidate.Location = new System.Drawing.Point(10, 780);
            this.btValidate.Name = "btValidate";
            this.btValidate.Size = new System.Drawing.Size(89, 45);
            this.btValidate.TabIndex = 7;
            this.btValidate.Text = "Validuj";
            this.btValidate.UseVisualStyleBackColor = true;
            this.btValidate.Click += new System.EventHandler(this.eh_btValidate_Click);
            // 
            // lbAllFieldsRequired
            // 
            this.lbAllFieldsRequired.AutoSize = true;
            this.lbAllFieldsRequired.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAllFieldsRequired.ForeColor = System.Drawing.Color.Red;
            this.lbAllFieldsRequired.Location = new System.Drawing.Point(7, 759);
            this.lbAllFieldsRequired.Name = "lbAllFieldsRequired";
            this.lbAllFieldsRequired.Size = new System.Drawing.Size(259, 18);
            this.lbAllFieldsRequired.TabIndex = 8;
            this.lbAllFieldsRequired.Text = "ERROR: Všetky polia sú povinné!";
            this.lbAllFieldsRequired.Visible = false;
            // 
            // btSign
            // 
            this.btSign.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSign.ForeColor = System.Drawing.Color.DarkGreen;
            this.btSign.Location = new System.Drawing.Point(443, 780);
            this.btSign.Name = "btSign";
            this.btSign.Size = new System.Drawing.Size(112, 45);
            this.btSign.TabIndex = 9;
            this.btSign.Text = "Podpísať";
            this.btSign.UseVisualStyleBackColor = true;
            this.btSign.Click += new System.EventHandler(this.eh_btSign_Click);
            // 
            // form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 1045);
            this.Controls.Add(this.btSign);
            this.Controls.Add(this.lbAllFieldsRequired);
            this.Controls.Add(this.btValidate);
            this.Controls.Add(this.gbSummary);
            this.Controls.Add(this.outerPanelItems);
            this.Controls.Add(this.gbCompany);
            this.Controls.Add(this.ms_MainMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.ms_MainMenu;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1256, 1800);
            this.MinimumSize = new System.Drawing.Size(587, 1030);
            this.Name = "form_Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pokladničný blok";
            this.ms_MainMenu.ResumeLayout(false);
            this.ms_MainMenu.PerformLayout();
            this.gbCompany.ResumeLayout(false);
            this.gbCompany.PerformLayout();
            this.gbCompanyAddress.ResumeLayout(false);
            this.gbCompanyAddress.PerformLayout();
            this.outerPanelItems.ResumeLayout(false);
            this.outerPanelItems.PerformLayout();
            this.gbSummary.ResumeLayout(false);
            this.gbSummary.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip ms_MainMenu;
        private System.Windows.Forms.ToolStripMenuItem tsmi_File;
        private System.Windows.Forms.ToolStripMenuItem tsmi_FileNew;
        private System.Windows.Forms.ToolStripSeparator tsmi_FileSeparator1;
        private System.Windows.Forms.ToolStripMenuItem tsmi_FileSaveXML;
        private System.Windows.Forms.ToolStripMenuItem tsmi_FileSaveTXT;
        private System.Windows.Forms.ToolStripSeparator tsmi_FileSeparator2;
        private System.Windows.Forms.ToolStripMenuItem tsmi_FileExit;
        private System.Windows.Forms.GroupBox gbCompany;
        private System.Windows.Forms.Label lbCompanyName;
        private System.Windows.Forms.TextBox tbCompanyRegNumber;
        private System.Windows.Forms.Label lbCompanyRegNumber;
        private System.Windows.Forms.TextBox tbCompanyName;
        private System.Windows.Forms.TextBox tbCompanyTaxNumber;
        private System.Windows.Forms.Label lbCompanyTaxNumber;
        private System.Windows.Forms.TextBox tbTaxCode;
        private System.Windows.Forms.Label lbTaxCode;
        private System.Windows.Forms.GroupBox gbCompanyAddress;
        private System.Windows.Forms.TextBox tbZIP;
        private System.Windows.Forms.Label lbZIP;
        private System.Windows.Forms.TextBox tbCity;
        private System.Windows.Forms.Label lbCity;
        private System.Windows.Forms.TextBox tbStreet;
        private System.Windows.Forms.Label lbStreet;
        private System.Windows.Forms.TableLayoutPanel panelItems;
        private System.Windows.Forms.Panel outerPanelItems;
        private System.Windows.Forms.Label lbTAXPercentage;
        private System.Windows.Forms.TextBox tbTAXPercentage;
        private System.Windows.Forms.Label lbPercentPercentage;
        private System.Windows.Forms.Label lbTAXBaseEUR;
        private System.Windows.Forms.TextBox tbTAXBase;
        private System.Windows.Forms.Label lbTAXBase;
        private System.Windows.Forms.Label lbTAXTotalEur;
        private System.Windows.Forms.TextBox tbTAXTotal;
        private System.Windows.Forms.Label lbTAXTotal;
        private System.Windows.Forms.Label lbTotal;
        private System.Windows.Forms.TextBox tbTotalPrice;
        private System.Windows.Forms.Label lbTotalEUR;
        private System.Windows.Forms.GroupBox gbSummary;
        private System.Windows.Forms.Label lbTime;
        private System.Windows.Forms.DateTimePicker dtTime;
        private System.Windows.Forms.CheckBox cbManualTime;
        private System.Windows.Forms.ComboBox cbCountry;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btValidate;
        private System.Windows.Forms.Label lbAllFieldsRequired;
        private System.Windows.Forms.FolderBrowserDialog fbdSelectSavingPlace;
        private System.Windows.Forms.ToolStripMenuItem tsmi_Open;
        private System.Windows.Forms.OpenFileDialog ofdLoadXml;
        private System.Windows.Forms.Button btSign;
    }
}

