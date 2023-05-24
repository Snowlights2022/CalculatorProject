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
            this.button1 = new Button();
            this.textBox1 = new TextBox();
            this.button2 = new Button();
            this.button3 = new Button();
            this.button5 = new Button();
            this.button6 = new Button();
            this.button7 = new Button();
            this.button4 = new Button();
            this.button8 = new Button();
            this.button9 = new Button();
            this.button10 = new Button();
            this.button11 = new Button();
            this.button12 = new Button();
            this.button13 = new Button();
            this.button14 = new Button();
            this.button15 = new Button();
            this.button16 = new Button();
            this.button17 = new Button();
            this.button18 = new Button();
            this.button19 = new Button();
            this.button20 = new Button();
            this.button21 = new Button();
            this.button22 = new Button();
            this.button23 = new Button();
            this.button24 = new Button();
            this.button25 = new Button();
            this.menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new Size(24, 24);
            this.menuStrip1.Items.AddRange(new ToolStripItem[] { this.Settings, this.History, this.toolStripMenuItem3 });
            this.menuStrip1.Location = new Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new Size(1078, 43);
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
            // button1
            // 
            this.button1.Location = new Point(863, 228);
            this.button1.Name = "button1";
            this.button1.Size = new Size(60, 60);
            this.button1.TabIndex = 1;
            this.button1.Text = "9";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new Point(12, 59);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new Size(1054, 163);
            this.textBox1.TabIndex = 2;
            // 
            // button2
            // 
            this.button2.Location = new Point(796, 228);
            this.button2.Name = "button2";
            this.button2.Size = new Size(60, 60);
            this.button2.TabIndex = 3;
            this.button2.Text = "8";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new Point(730, 228);
            this.button3.Name = "button3";
            this.button3.Size = new Size(60, 60);
            this.button3.TabIndex = 4;
            this.button3.Text = "7";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new Point(863, 294);
            this.button5.Name = "button5";
            this.button5.Size = new Size(60, 60);
            this.button5.TabIndex = 6;
            this.button5.Text = "6";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new Point(796, 294);
            this.button6.Name = "button6";
            this.button6.Size = new Size(60, 60);
            this.button6.TabIndex = 7;
            this.button6.Text = "5";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Location = new Point(730, 294);
            this.button7.Name = "button7";
            this.button7.Size = new Size(60, 60);
            this.button7.TabIndex = 8;
            this.button7.Text = "4";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new Point(863, 360);
            this.button4.Name = "button4";
            this.button4.Size = new Size(60, 60);
            this.button4.TabIndex = 9;
            this.button4.Text = "3";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Location = new Point(796, 360);
            this.button8.Name = "button8";
            this.button8.Size = new Size(60, 60);
            this.button8.TabIndex = 10;
            this.button8.Text = "2";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            this.button9.Location = new Point(730, 360);
            this.button9.Name = "button9";
            this.button9.Size = new Size(60, 60);
            this.button9.TabIndex = 11;
            this.button9.Text = "1";
            this.button9.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            this.button10.Font = new Font("Microsoft YaHei UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            this.button10.Location = new Point(946, 421);
            this.button10.Name = "button10";
            this.button10.Size = new Size(120, 127);
            this.button10.TabIndex = 12;
            this.button10.Text = "EXE";
            this.button10.UseVisualStyleBackColor = true;
            // 
            // button11
            // 
            this.button11.Location = new Point(946, 228);
            this.button11.Name = "button11";
            this.button11.Size = new Size(120, 42);
            this.button11.TabIndex = 13;
            this.button11.Text = "M";
            this.button11.UseVisualStyleBackColor = true;
            // 
            // button12
            // 
            this.button12.Location = new Point(946, 276);
            this.button12.Name = "button12";
            this.button12.Size = new Size(120, 42);
            this.button12.TabIndex = 14;
            this.button12.Text = "MC";
            this.button12.UseVisualStyleBackColor = true;
            // 
            // button13
            // 
            this.button13.Location = new Point(946, 324);
            this.button13.Name = "button13";
            this.button13.Size = new Size(120, 42);
            this.button13.TabIndex = 15;
            this.button13.Text = "M+";
            this.button13.UseVisualStyleBackColor = true;
            // 
            // button14
            // 
            this.button14.Location = new Point(946, 372);
            this.button14.Name = "button14";
            this.button14.Size = new Size(120, 42);
            this.button14.TabIndex = 16;
            this.button14.Text = "M-";
            this.button14.UseVisualStyleBackColor = true;
            // 
            // button15
            // 
            this.button15.Location = new Point(797, 426);
            this.button15.Name = "button15";
            this.button15.Size = new Size(60, 60);
            this.button15.TabIndex = 17;
            this.button15.Text = "+";
            this.button15.UseVisualStyleBackColor = true;
            // 
            // button16
            // 
            this.button16.Location = new Point(863, 426);
            this.button16.Name = "button16";
            this.button16.Size = new Size(60, 60);
            this.button16.TabIndex = 18;
            this.button16.Text = "-";
            this.button16.UseVisualStyleBackColor = true;
            // 
            // button17
            // 
            this.button17.Location = new Point(797, 492);
            this.button17.Name = "button17";
            this.button17.Size = new Size(60, 60);
            this.button17.TabIndex = 19;
            this.button17.Text = "×";
            this.button17.UseVisualStyleBackColor = true;
            // 
            // button18
            // 
            this.button18.Location = new Point(730, 492);
            this.button18.Name = "button18";
            this.button18.Size = new Size(60, 60);
            this.button18.TabIndex = 20;
            this.button18.Text = ".";
            this.button18.UseVisualStyleBackColor = true;
            // 
            // button19
            // 
            this.button19.Location = new Point(730, 426);
            this.button19.Name = "button19";
            this.button19.Size = new Size(60, 60);
            this.button19.TabIndex = 21;
            this.button19.Text = "0";
            this.button19.UseVisualStyleBackColor = true;
            // 
            // button20
            // 
            this.button20.Location = new Point(863, 492);
            this.button20.Name = "button20";
            this.button20.Size = new Size(60, 60);
            this.button20.TabIndex = 22;
            this.button20.Text = "÷";
            this.button20.UseVisualStyleBackColor = true;
            // 
            // button21
            // 
            this.button21.Location = new Point(644, 228);
            this.button21.Name = "button21";
            this.button21.Size = new Size(80, 60);
            this.button21.TabIndex = 23;
            this.button21.Text = "C";
            this.button21.UseVisualStyleBackColor = true;
            // 
            // button22
            // 
            this.button22.Location = new Point(644, 294);
            this.button22.Name = "button22";
            this.button22.Size = new Size(80, 60);
            this.button22.TabIndex = 24;
            this.button22.Text = "±";
            this.button22.UseVisualStyleBackColor = true;
            // 
            // button23
            // 
            this.button23.Location = new Point(644, 360);
            this.button23.Name = "button23";
            this.button23.Size = new Size(80, 60);
            this.button23.TabIndex = 25;
            this.button23.Text = "%";
            this.button23.UseVisualStyleBackColor = true;
            // 
            // button24
            // 
            this.button24.Location = new Point(644, 426);
            this.button24.Name = "button24";
            this.button24.Size = new Size(80, 60);
            this.button24.TabIndex = 26;
            this.button24.Text = "i";
            this.button24.UseVisualStyleBackColor = true;
            // 
            // button25
            // 
            this.button25.Location = new Point(644, 492);
            this.button25.Name = "button25";
            this.button25.Size = new Size(80, 60);
            this.button25.TabIndex = 27;
            this.button25.Text = "㏒";
            this.button25.UseVisualStyleBackColor = true;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new SizeF(16F, 35F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(1078, 560);
            this.Controls.Add(this.button25);
            this.Controls.Add(this.button24);
            this.Controls.Add(this.button23);
            this.Controls.Add(this.button22);
            this.Controls.Add(this.button21);
            this.Controls.Add(this.button20);
            this.Controls.Add(this.button19);
            this.Controls.Add(this.button18);
            this.Controls.Add(this.button17);
            this.Controls.Add(this.button16);
            this.Controls.Add(this.button15);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new Size(1100, 620);
            this.MinimumSize = new Size(1100, 620);
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
        private Button button1;
        private TextBox textBox1;
        private Button button2;
        private Button button3;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button4;
        private Button button8;
        private Button button9;
        private Button button10;
        private Button button11;
        private Button button12;
        private Button button13;
        private Button button14;
        private Button button15;
        private Button button16;
        private Button button17;
        private Button button18;
        private Button button19;
        private Button button20;
        private Button button21;
        private Button button22;
        private Button button23;
        private Button button24;
        private Button button25;
    }
}