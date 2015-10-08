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
            this.tsmi_FileNew = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_FileSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmi_FileSave = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_FileSaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_FileSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmi_FileExit = new System.Windows.Forms.ToolStripMenuItem();
            this.gbCompany = new System.Windows.Forms.GroupBox();
            this.tbTaxCode = new System.Windows.Forms.TextBox();
            this.lbTaxCode = new System.Windows.Forms.Label();
            this.dtDate = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.gbCompanyAddress = new System.Windows.Forms.GroupBox();
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
            this.gbProducts = new System.Windows.Forms.GroupBox();
            this.dgwProducts = new System.Windows.Forms.DataGridView();
            this.clmnId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnTotalPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ms_MainMenu.SuspendLayout();
            this.gbCompany.SuspendLayout();
            this.gbCompanyAddress.SuspendLayout();
            this.gbProducts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwProducts)).BeginInit();
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
            this.ms_MainMenu.Size = new System.Drawing.Size(1238, 28);
            this.ms_MainMenu.TabIndex = 0;
            this.ms_MainMenu.Text = "Main Menu";
            // 
            // tsmi_File
            // 
            this.tsmi_File.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_FileNew,
            this.tsmi_FileSeparator1,
            this.tsmi_FileSave,
            this.tsmi_FileSaveAs,
            this.tsmi_FileSeparator2,
            this.tsmi_FileExit});
            this.tsmi_File.Name = "tsmi_File";
            this.tsmi_File.Size = new System.Drawing.Size(44, 24);
            this.tsmi_File.Text = "File";
            // 
            // tsmi_FileNew
            // 
            this.tsmi_FileNew.Name = "tsmi_FileNew";
            this.tsmi_FileNew.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.tsmi_FileNew.Size = new System.Drawing.Size(176, 26);
            this.tsmi_FileNew.Text = "New...";
            this.tsmi_FileNew.Click += new System.EventHandler(this.eh_tsmi_File_Click);
            // 
            // tsmi_FileSeparator1
            // 
            this.tsmi_FileSeparator1.Name = "tsmi_FileSeparator1";
            this.tsmi_FileSeparator1.Size = new System.Drawing.Size(173, 6);
            // 
            // tsmi_FileSave
            // 
            this.tsmi_FileSave.Name = "tsmi_FileSave";
            this.tsmi_FileSave.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.tsmi_FileSave.Size = new System.Drawing.Size(176, 26);
            this.tsmi_FileSave.Text = "Save";
            this.tsmi_FileSave.Click += new System.EventHandler(this.eh_tsmi_File_Click);
            // 
            // tsmi_FileSaveAs
            // 
            this.tsmi_FileSaveAs.Name = "tsmi_FileSaveAs";
            this.tsmi_FileSaveAs.Size = new System.Drawing.Size(176, 26);
            this.tsmi_FileSaveAs.Text = "Save as...";
            this.tsmi_FileSaveAs.Click += new System.EventHandler(this.eh_tsmi_File_Click);
            // 
            // tsmi_FileSeparator2
            // 
            this.tsmi_FileSeparator2.Name = "tsmi_FileSeparator2";
            this.tsmi_FileSeparator2.Size = new System.Drawing.Size(173, 6);
            // 
            // tsmi_FileExit
            // 
            this.tsmi_FileExit.Name = "tsmi_FileExit";
            this.tsmi_FileExit.Size = new System.Drawing.Size(176, 26);
            this.tsmi_FileExit.Text = "Exit";
            this.tsmi_FileExit.Click += new System.EventHandler(this.eh_tsmi_File_Click);
            // 
            // gbCompany
            // 
            this.gbCompany.Controls.Add(this.tbTaxCode);
            this.gbCompany.Controls.Add(this.lbTaxCode);
            this.gbCompany.Controls.Add(this.dtDate);
            this.gbCompany.Controls.Add(this.dateTimePicker1);
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
            this.gbCompany.Size = new System.Drawing.Size(1238, 379);
            this.gbCompany.TabIndex = 4;
            this.gbCompany.TabStop = false;
            this.gbCompany.Text = "Spoločnosť";
            // 
            // tbTaxCode
            // 
            this.tbTaxCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTaxCode.Location = new System.Drawing.Point(210, 335);
            this.tbTaxCode.Name = "tbTaxCode";
            this.tbTaxCode.Size = new System.Drawing.Size(247, 26);
            this.tbTaxCode.TabIndex = 11;
            this.tbTaxCode.Text = "SK58-47-555-355";
            // 
            // lbTaxCode
            // 
            this.lbTaxCode.AutoSize = true;
            this.lbTaxCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTaxCode.Location = new System.Drawing.Point(52, 344);
            this.lbTaxCode.Name = "lbTaxCode";
            this.lbTaxCode.Size = new System.Drawing.Size(138, 17);
            this.lbTaxCode.TabIndex = 10;
            this.lbTaxCode.Text = "Kód reg. pokladnice:";
            // 
            // dtDate
            // 
            this.dtDate.AutoSize = true;
            this.dtDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtDate.Location = new System.Drawing.Point(52, 311);
            this.dtDate.Name = "dtDate";
            this.dtDate.Size = new System.Drawing.Size(53, 17);
            this.dtDate.TabIndex = 9;
            this.dtDate.Text = "Dátum:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(260, 303);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(197, 26);
            this.dateTimePicker1.TabIndex = 7;
            // 
            // gbCompanyAddress
            // 
            this.gbCompanyAddress.Controls.Add(this.tbZIP);
            this.gbCompanyAddress.Controls.Add(this.lbZIP);
            this.gbCompanyAddress.Controls.Add(this.tbCity);
            this.gbCompanyAddress.Controls.Add(this.lbCity);
            this.gbCompanyAddress.Controls.Add(this.tbStreet);
            this.gbCompanyAddress.Controls.Add(this.lbStreet);
            this.gbCompanyAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbCompanyAddress.Location = new System.Drawing.Point(12, 161);
            this.gbCompanyAddress.Name = "gbCompanyAddress";
            this.gbCompanyAddress.Size = new System.Drawing.Size(547, 124);
            this.gbCompanyAddress.TabIndex = 6;
            this.gbCompanyAddress.TabStop = false;
            this.gbCompanyAddress.Text = "Adresa";
            // 
            // tbZIP
            // 
            this.tbZIP.Location = new System.Drawing.Point(128, 90);
            this.tbZIP.Name = "tbZIP";
            this.tbZIP.Size = new System.Drawing.Size(72, 26);
            this.tbZIP.TabIndex = 11;
            this.tbZIP.Text = "018 55";
            // 
            // lbZIP
            // 
            this.lbZIP.AutoSize = true;
            this.lbZIP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbZIP.Location = new System.Drawing.Point(58, 98);
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
            // 
            // lbCity
            // 
            this.lbCity.AutoSize = true;
            this.lbCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCity.Location = new System.Drawing.Point(58, 66);
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
            // 
            // lbStreet
            // 
            this.lbStreet.AutoSize = true;
            this.lbStreet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStreet.Location = new System.Drawing.Point(58, 34);
            this.lbStreet.Name = "lbStreet";
            this.lbStreet.Size = new System.Drawing.Size(45, 18);
            this.lbStreet.TabIndex = 6;
            this.lbStreet.Text = "Ulica:";
            // 
            // tbCompanyTaxNumber
            // 
            this.tbCompanyTaxNumber.Location = new System.Drawing.Point(140, 112);
            this.tbCompanyTaxNumber.Name = "tbCompanyTaxNumber";
            this.tbCompanyTaxNumber.Size = new System.Drawing.Size(388, 30);
            this.tbCompanyTaxNumber.TabIndex = 5;
            this.tbCompanyTaxNumber.Text = "SK2820001611";
            // 
            // lbCompanyTaxNumber
            // 
            this.lbCompanyTaxNumber.AutoSize = true;
            this.lbCompanyTaxNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCompanyTaxNumber.Location = new System.Drawing.Point(39, 124);
            this.lbCompanyTaxNumber.Name = "lbCompanyTaxNumber";
            this.lbCompanyTaxNumber.Size = new System.Drawing.Size(37, 18);
            this.lbCompanyTaxNumber.TabIndex = 4;
            this.lbCompanyTaxNumber.Text = "DIČ:";
            // 
            // tbCompanyRegNumber
            // 
            this.tbCompanyRegNumber.Location = new System.Drawing.Point(140, 76);
            this.tbCompanyRegNumber.Name = "tbCompanyRegNumber";
            this.tbCompanyRegNumber.Size = new System.Drawing.Size(388, 30);
            this.tbCompanyRegNumber.TabIndex = 3;
            this.tbCompanyRegNumber.Text = "46 493 115";
            // 
            // lbCompanyRegNumber
            // 
            this.lbCompanyRegNumber.AutoSize = true;
            this.lbCompanyRegNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCompanyRegNumber.Location = new System.Drawing.Point(39, 88);
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
            // 
            // lbCompanyName
            // 
            this.lbCompanyName.AutoSize = true;
            this.lbCompanyName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCompanyName.Location = new System.Drawing.Point(39, 52);
            this.lbCompanyName.Name = "lbCompanyName";
            this.lbCompanyName.Size = new System.Drawing.Size(55, 18);
            this.lbCompanyName.TabIndex = 0;
            this.lbCompanyName.Text = "Názov:";
            // 
            // gbProducts
            // 
            this.gbProducts.Controls.Add(this.dgwProducts);
            this.gbProducts.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbProducts.Location = new System.Drawing.Point(0, 407);
            this.gbProducts.Name = "gbProducts";
            this.gbProducts.Size = new System.Drawing.Size(1238, 332);
            this.gbProducts.TabIndex = 5;
            this.gbProducts.TabStop = false;
            this.gbProducts.Text = "Produkty";
            // 
            // dgwProducts
            // 
            this.dgwProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwProducts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmnId,
            this.clmnProductName,
            this.clmnQuantity,
            this.clmnPrice,
            this.clmnTotalPrice});
            this.dgwProducts.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgwProducts.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgwProducts.Location = new System.Drawing.Point(3, 22);
            this.dgwProducts.Name = "dgwProducts";
            this.dgwProducts.RowTemplate.Height = 24;
            this.dgwProducts.Size = new System.Drawing.Size(1232, 217);
            this.dgwProducts.TabIndex = 0;
            // 
            // clmnId
            // 
            this.clmnId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clmnId.Frozen = true;
            this.clmnId.HeaderText = "ID";
            this.clmnId.MinimumWidth = 50;
            this.clmnId.Name = "clmnId";
            this.clmnId.ReadOnly = true;
            this.clmnId.Width = 57;
            // 
            // clmnProductName
            // 
            this.clmnProductName.HeaderText = "Názov";
            this.clmnProductName.MinimumWidth = 400;
            this.clmnProductName.Name = "clmnProductName";
            this.clmnProductName.Width = 400;
            // 
            // clmnQuantity
            // 
            this.clmnQuantity.HeaderText = "Množstvo";
            this.clmnQuantity.MinimumWidth = 100;
            this.clmnQuantity.Name = "clmnQuantity";
            // 
            // clmnPrice
            // 
            this.clmnPrice.HeaderText = "Cena za MJ";
            this.clmnPrice.MinimumWidth = 150;
            this.clmnPrice.Name = "clmnPrice";
            this.clmnPrice.Width = 150;
            // 
            // clmnTotalPrice
            // 
            this.clmnTotalPrice.HeaderText = "Celkom";
            this.clmnTotalPrice.MinimumWidth = 180;
            this.clmnTotalPrice.Name = "clmnTotalPrice";
            this.clmnTotalPrice.Width = 180;
            // 
            // form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1238, 824);
            this.Controls.Add(this.gbProducts);
            this.Controls.Add(this.gbCompany);
            this.Controls.Add(this.ms_MainMenu);
            this.MainMenuStrip = this.ms_MainMenu;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1256, 871);
            this.MinimumSize = new System.Drawing.Size(1256, 871);
            this.Name = "form_Main";
            this.Text = "Pokladničný blok";
            this.ms_MainMenu.ResumeLayout(false);
            this.ms_MainMenu.PerformLayout();
            this.gbCompany.ResumeLayout(false);
            this.gbCompany.PerformLayout();
            this.gbCompanyAddress.ResumeLayout(false);
            this.gbCompanyAddress.PerformLayout();
            this.gbProducts.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgwProducts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip ms_MainMenu;
        private System.Windows.Forms.ToolStripMenuItem tsmi_File;
        private System.Windows.Forms.ToolStripMenuItem tsmi_FileNew;
        private System.Windows.Forms.ToolStripSeparator tsmi_FileSeparator1;
        private System.Windows.Forms.ToolStripMenuItem tsmi_FileSave;
        private System.Windows.Forms.ToolStripMenuItem tsmi_FileSaveAs;
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
        private System.Windows.Forms.Label dtDate;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.GroupBox gbCompanyAddress;
        private System.Windows.Forms.TextBox tbZIP;
        private System.Windows.Forms.Label lbZIP;
        private System.Windows.Forms.TextBox tbCity;
        private System.Windows.Forms.Label lbCity;
        private System.Windows.Forms.TextBox tbStreet;
        private System.Windows.Forms.Label lbStreet;
        private System.Windows.Forms.GroupBox gbProducts;
        private System.Windows.Forms.DataGridView dgwProducts;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnId;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnTotalPrice;
    }
}

