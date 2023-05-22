namespace Calculator
{
    partial class Main
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
            this.menuStrip1 = new MenuStrip();
            this.Settings = new ToolStripMenuItem();
            this.设置 = new ToolStripMenuItem();
            this.DegreeSettings = new ToolStripComboBox();
            this.复数格式ToolStripMenuItem = new ToolStripMenuItem();
            this.ComplexnumSettings = new ToolStripComboBox();
            this.History = new ToolStripMenuItem();
            this.toolStripMenuItem3 = new ToolStripMenuItem();
            this.gitHubToolStripMenuItem = new ToolStripMenuItem();
            this.localHelpToolStripMenuItem = new ToolStripMenuItem();
            this.checkForUpdateToolStripMenuItem = new ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new Size(24, 24);
            this.menuStrip1.Items.AddRange(new ToolStripItem[] { this.Settings, this.History, this.toolStripMenuItem3 });
            this.menuStrip1.Location = new Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new Size(986, 43);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // Settings
            // 
            this.Settings.DropDownItems.AddRange(new ToolStripItem[] { this.设置, this.复数格式ToolStripMenuItem });
            this.Settings.Name = "Settings";
            this.Settings.Size = new Size(136, 39);
            this.Settings.Text = "Settings";
            // 
            // 设置
            // 
            this.设置.DropDownItems.AddRange(new ToolStripItem[] { this.DegreeSettings });
            this.设置.Name = "设置";
            this.设置.Size = new Size(228, 44);
            this.设置.Text = "角度单位";
            // 
            // DegreeSettings
            // 
            this.DegreeSettings.DropDownWidth = 150;
            this.DegreeSettings.Items.AddRange(new object[] { "Deg", "Rad", "Gra" });
            this.DegreeSettings.Name = "DegreeSettings";
            this.DegreeSettings.Size = new Size(240, 43);
            this.DegreeSettings.Text = "(默认为Degree）";
            // 
            // 复数格式ToolStripMenuItem
            // 
            this.复数格式ToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { this.ComplexnumSettings });
            this.复数格式ToolStripMenuItem.Name = "复数格式ToolStripMenuItem";
            this.复数格式ToolStripMenuItem.Size = new Size(228, 44);
            this.复数格式ToolStripMenuItem.Text = "复数格式";
            // 
            // ComplexnumSettings
            // 
            this.ComplexnumSettings.Items.AddRange(new object[] { "直角坐标", "极坐标" });
            this.ComplexnumSettings.Name = "ComplexnumSettings";
            this.ComplexnumSettings.Size = new Size(240, 43);
            this.ComplexnumSettings.Text = "(默认为直角坐标）";
            // 
            // History
            // 
            this.History.Name = "History";
            this.History.Size = new Size(177, 39);
            this.History.Text = "CalcHistory";
            this.History.Click += History_Click;
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.DropDownItems.AddRange(new ToolStripItem[] { this.gitHubToolStripMenuItem, this.localHelpToolStripMenuItem, this.checkForUpdateToolStripMenuItem });
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new Size(91, 39);
            this.toolStripMenuItem3.Text = "Help";
            // 
            // gitHubToolStripMenuItem
            // 
            this.gitHubToolStripMenuItem.Name = "gitHubToolStripMenuItem";
            this.gitHubToolStripMenuItem.Size = new Size(345, 44);
            this.gitHubToolStripMenuItem.Text = "GitHub";
            this.gitHubToolStripMenuItem.Click += GitHubToolStripMenuItem_Click;
            // 
            // localHelpToolStripMenuItem
            // 
            this.localHelpToolStripMenuItem.Name = "localHelpToolStripMenuItem";
            this.localHelpToolStripMenuItem.Size = new Size(345, 44);
            this.localHelpToolStripMenuItem.Text = "LocalHelp";
            // 
            // checkForUpdateToolStripMenuItem
            // 
            this.checkForUpdateToolStripMenuItem.Name = "checkForUpdateToolStripMenuItem";
            this.checkForUpdateToolStripMenuItem.Size = new Size(345, 44);
            this.checkForUpdateToolStripMenuItem.Text = "Check for Update";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new SizeF(16F, 35F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(986, 583);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new Size(1008, 643);
            this.MinimumSize = new Size(1008, 643);
            this.Name = "Main";
            this.Text = "Calculator test";
            Load += Main_Load;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem Settings;
        private ToolStripMenuItem 设置;
        private ToolStripMenuItem History;
        private ToolStripMenuItem toolStripMenuItem3;
        private ToolStripComboBox DegreeSettings;
        private ToolStripMenuItem 复数格式ToolStripMenuItem;
        private ToolStripComboBox ComplexnumSettings;
        private ToolStripMenuItem checkForUpdateToolStripMenuItem;
        private ToolStripMenuItem gitHubToolStripMenuItem;
        private ToolStripMenuItem localHelpToolStripMenuItem;
    }
}