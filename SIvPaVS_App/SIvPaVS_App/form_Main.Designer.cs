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
            this.ms_MainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // ms_MainMenu
            // 
            this.ms_MainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_File});
            this.ms_MainMenu.Location = new System.Drawing.Point(0, 0);
            this.ms_MainMenu.Name = "ms_MainMenu";
            this.ms_MainMenu.Size = new System.Drawing.Size(784, 24);
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
            this.tsmi_File.Size = new System.Drawing.Size(37, 20);
            this.tsmi_File.Text = "File";
            // 
            // tsmi_FileNew
            // 
            this.tsmi_FileNew.Name = "tsmi_FileNew";
            this.tsmi_FileNew.Size = new System.Drawing.Size(152, 22);
            this.tsmi_FileNew.Text = "New...";
            // 
            // tsmi_FileSeparator1
            // 
            this.tsmi_FileSeparator1.Name = "tsmi_FileSeparator1";
            this.tsmi_FileSeparator1.Size = new System.Drawing.Size(149, 6);
            // 
            // tsmi_FileSave
            // 
            this.tsmi_FileSave.Name = "tsmi_FileSave";
            this.tsmi_FileSave.Size = new System.Drawing.Size(152, 22);
            this.tsmi_FileSave.Text = "Save";
            // 
            // tsmi_FileSaveAs
            // 
            this.tsmi_FileSaveAs.Name = "tsmi_FileSaveAs";
            this.tsmi_FileSaveAs.Size = new System.Drawing.Size(152, 22);
            this.tsmi_FileSaveAs.Text = "Save as...";
            // 
            // tsmi_FileSeparator2
            // 
            this.tsmi_FileSeparator2.Name = "tsmi_FileSeparator2";
            this.tsmi_FileSeparator2.Size = new System.Drawing.Size(149, 6);
            // 
            // tsmi_FileExit
            // 
            this.tsmi_FileExit.Name = "tsmi_FileExit";
            this.tsmi_FileExit.Size = new System.Drawing.Size(152, 22);
            this.tsmi_FileExit.Text = "Exit";
            // 
            // form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.ms_MainMenu);
            this.MainMenuStrip = this.ms_MainMenu;
            this.Name = "form_Main";
            this.Text = "Application Main Window";
            this.ms_MainMenu.ResumeLayout(false);
            this.ms_MainMenu.PerformLayout();
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
    }
}

