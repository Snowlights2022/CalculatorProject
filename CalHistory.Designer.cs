namespace Calculator
{
    partial class CalHistory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CalHistory));
            ShowHistory = new TextBox();
            CleanHistory = new Button();
            SuspendLayout();
            // 
            // ShowHistory
            // 
            resources.ApplyResources(ShowHistory, "ShowHistory");
            ShowHistory.Name = "ShowHistory";
            ShowHistory.ReadOnly = true;
            ShowHistory.TextChanged += ShowHistory_TextChanged;
            // 
            // CleanHistory
            // 
            resources.ApplyResources(CleanHistory, "CleanHistory");
            CleanHistory.Name = "CleanHistory";
            CleanHistory.UseVisualStyleBackColor = true;
            CleanHistory.Click += CleanHistory_Click;
            // 
            // CalHis
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = AutoScaleMode.Font;
            this.Controls.Add(CleanHistory);
            this.Controls.Add(ShowHistory);
            this.Name = "CalHistory";
            this.ShowInTaskbar = false;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox ShowHistory;
        private Button CleanHistory;
    }
}