namespace SIvPaVS_Podatelna
{
    partial class formPodatelna
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
            this.fbdPodania = new System.Windows.Forms.FolderBrowserDialog();
            this.btSelectFolder = new System.Windows.Forms.Button();
            this.rtbResults = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // fbdPodania
            // 
            this.fbdPodania.SelectedPath = "C:\\Users\\Gajdoš Michal\\Desktop\\Priklady";
            // 
            // btSelectFolder
            // 
            this.btSelectFolder.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSelectFolder.ForeColor = System.Drawing.Color.DarkGreen;
            this.btSelectFolder.Location = new System.Drawing.Point(0, 9);
            this.btSelectFolder.Name = "btSelectFolder";
            this.btSelectFolder.Size = new System.Drawing.Size(1083, 33);
            this.btSelectFolder.TabIndex = 0;
            this.btSelectFolder.Text = "Vybrať priečinok s podaniami";
            this.btSelectFolder.UseVisualStyleBackColor = true;
            this.btSelectFolder.Click += new System.EventHandler(this.btSelectFolder_Click);
            // 
            // rtbResults
            // 
            this.rtbResults.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.rtbResults.Location = new System.Drawing.Point(0, 48);
            this.rtbResults.Name = "rtbResults";
            this.rtbResults.Size = new System.Drawing.Size(1083, 611);
            this.rtbResults.TabIndex = 1;
            this.rtbResults.Text = "";
            // 
            // formPodatelna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1083, 659);
            this.Controls.Add(this.rtbResults);
            this.Controls.Add(this.btSelectFolder);
            this.Name = "formPodatelna";
            this.Text = "Podateľňa";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog fbdPodania;
        private System.Windows.Forms.Button btSelectFolder;
        private System.Windows.Forms.RichTextBox rtbResults;
    }
}

