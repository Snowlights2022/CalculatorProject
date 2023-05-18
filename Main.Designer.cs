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
            SuspendLayout();
            // 
            // Main
            // 
            this.AutoScaleDimensions = new SizeF(11F, 24F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(684, 417);
            this.Margin = new Padding(2, 2, 2, 2);
            this.MaximumSize = new Size(700, 460);
            this.MinimumSize = new Size(700, 460);
            this.Name = "Main";
            this.Text = "Calculator test";
            Load += Main_Load;
            ResumeLayout(false);
        }

        #endregion
    }
}