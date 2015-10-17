namespace SIvPaVS_App
{
    partial class ItemSection
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbItemName = new System.Windows.Forms.TextBox();
            this.tbQuantity = new System.Windows.Forms.TextBox();
            this.tbItemtPrice = new System.Windows.Forms.TextBox();
            this.tbItemTotalPrice = new System.Windows.Forms.TextBox();
            this.lbID = new System.Windows.Forms.Label();
            this.lbDelete = new System.Windows.Forms.Label();
            this.lbAddItem = new System.Windows.Forms.Label();
            this.lbItemTotalEUR = new System.Windows.Forms.Label();
            this.lbMultiply = new System.Windows.Forms.Label();
            this.lbUnitPriceEUR = new System.Windows.Forms.Label();
            this.dudItemUnit = new System.Windows.Forms.DomainUpDown();
            this.SuspendLayout();
            // 
            // tbItemName
            // 
            this.tbItemName.Location = new System.Drawing.Point(36, 3);
            this.tbItemName.Name = "tbItemName";
            this.tbItemName.Size = new System.Drawing.Size(373, 22);
            this.tbItemName.TabIndex = 0;
            this.tbItemName.Text = "Nohavice";
            // 
            // tbQuantity
            // 
            this.tbQuantity.Location = new System.Drawing.Point(36, 30);
            this.tbQuantity.Name = "tbQuantity";
            this.tbQuantity.Size = new System.Drawing.Size(80, 22);
            this.tbQuantity.TabIndex = 1;
            this.tbQuantity.Text = "5";
            this.tbQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbItemtPrice
            // 
            this.tbItemtPrice.Location = new System.Drawing.Point(206, 31);
            this.tbItemtPrice.Name = "tbItemtPrice";
            this.tbItemtPrice.Size = new System.Drawing.Size(80, 22);
            this.tbItemtPrice.TabIndex = 2;
            this.tbItemtPrice.Text = "5";
            this.tbItemtPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbItemTotalPrice
            // 
            this.tbItemTotalPrice.Location = new System.Drawing.Point(342, 31);
            this.tbItemTotalPrice.Name = "tbItemTotalPrice";
            this.tbItemTotalPrice.ReadOnly = true;
            this.tbItemTotalPrice.Size = new System.Drawing.Size(77, 22);
            this.tbItemTotalPrice.TabIndex = 3;
            this.tbItemTotalPrice.Text = "5";
            this.tbItemTotalPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lbID
            // 
            this.lbID.AutoSize = true;
            this.lbID.Location = new System.Drawing.Point(4, 4);
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(16, 17);
            this.lbID.TabIndex = 4;
            this.lbID.Text = "1";
            // 
            // lbDelete
            // 
            this.lbDelete.AutoSize = true;
            this.lbDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDelete.ForeColor = System.Drawing.Color.Red;
            this.lbDelete.Location = new System.Drawing.Point(442, 3);
            this.lbDelete.Name = "lbDelete";
            this.lbDelete.Size = new System.Drawing.Size(18, 17);
            this.lbDelete.TabIndex = 5;
            this.lbDelete.Text = "X";
            this.lbDelete.Click += new System.EventHandler(this.eh_lbDelete_Click);
            // 
            // lbAddItem
            // 
            this.lbAddItem.AutoSize = true;
            this.lbAddItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAddItem.ForeColor = System.Drawing.Color.Green;
            this.lbAddItem.Location = new System.Drawing.Point(475, 21);
            this.lbAddItem.Name = "lbAddItem";
            this.lbAddItem.Size = new System.Drawing.Size(38, 39);
            this.lbAddItem.TabIndex = 6;
            this.lbAddItem.Text = "+";
            this.lbAddItem.Click += new System.EventHandler(this.lbAddItem_Click);
            // 
            // lbItemTotalEUR
            // 
            this.lbItemTotalEUR.AutoSize = true;
            this.lbItemTotalEUR.Location = new System.Drawing.Point(423, 34);
            this.lbItemTotalEUR.Name = "lbItemTotalEUR";
            this.lbItemTotalEUR.Size = new System.Drawing.Size(37, 17);
            this.lbItemTotalEUR.TabIndex = 7;
            this.lbItemTotalEUR.Text = "EUR";
            // 
            // lbMultiply
            // 
            this.lbMultiply.AutoSize = true;
            this.lbMultiply.Location = new System.Drawing.Point(186, 34);
            this.lbMultiply.Name = "lbMultiply";
            this.lbMultiply.Size = new System.Drawing.Size(14, 17);
            this.lbMultiply.TabIndex = 8;
            this.lbMultiply.Text = "x";
            // 
            // lbUnitPriceEUR
            // 
            this.lbUnitPriceEUR.AutoSize = true;
            this.lbUnitPriceEUR.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUnitPriceEUR.Location = new System.Drawing.Point(292, 36);
            this.lbUnitPriceEUR.Name = "lbUnitPriceEUR";
            this.lbUnitPriceEUR.Size = new System.Drawing.Size(30, 13);
            this.lbUnitPriceEUR.TabIndex = 9;
            this.lbUnitPriceEUR.Text = "EUR";
            // 
            // dudItemUnit
            // 
            this.dudItemUnit.Location = new System.Drawing.Point(122, 31);
            this.dudItemUnit.Name = "dudItemUnit";
            this.dudItemUnit.ReadOnly = true;
            this.dudItemUnit.Size = new System.Drawing.Size(58, 22);
            this.dudItemUnit.TabIndex = 10;
            this.dudItemUnit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // ItemSection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dudItemUnit);
            this.Controls.Add(this.lbUnitPriceEUR);
            this.Controls.Add(this.lbMultiply);
            this.Controls.Add(this.lbItemTotalEUR);
            this.Controls.Add(this.lbAddItem);
            this.Controls.Add(this.lbDelete);
            this.Controls.Add(this.lbID);
            this.Controls.Add(this.tbItemTotalPrice);
            this.Controls.Add(this.tbItemtPrice);
            this.Controls.Add(this.tbQuantity);
            this.Controls.Add(this.tbItemName);
            this.Name = "ItemSection";
            this.Size = new System.Drawing.Size(513, 60);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbItemName;
        private System.Windows.Forms.TextBox tbQuantity;
        private System.Windows.Forms.TextBox tbItemtPrice;
        private System.Windows.Forms.TextBox tbItemTotalPrice;
        private System.Windows.Forms.Label lbID;
        private System.Windows.Forms.Label lbDelete;
        private System.Windows.Forms.Label lbAddItem;
        private System.Windows.Forms.Label lbItemTotalEUR;
        private System.Windows.Forms.Label lbMultiply;
        private System.Windows.Forms.Label lbUnitPriceEUR;
        private System.Windows.Forms.DomainUpDown dudItemUnit;
    }
}
