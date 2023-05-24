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
            this.ShowHistory = new TextBox();
            this.CleanHistory = new Button();
            SuspendLayout();
            // 
            // ShowHistory
            // 
            resources.ApplyResources(this.ShowHistory, "ShowHistory");
            this.ShowHistory.Name = "ShowHistory";
            this.ShowHistory.ReadOnly = true;
            this.ShowHistory.TextChanged += ShowHistory_TextChanged;
            // 
            // CleanHistory
            // 
            resources.ApplyResources(this.CleanHistory, "CleanHistory");
            this.CleanHistory.Name = "CleanHistory";
            this.CleanHistory.UseVisualStyleBackColor = true;
            // 
            // CalHistory
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = AutoScaleMode.Font;
            this.Controls.Add(this.CleanHistory);
            this.Controls.Add(this.ShowHistory);
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