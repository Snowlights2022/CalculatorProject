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
            TopSearch = new MenuStrip();
            Settings = new ToolStripMenuItem();
            设置 = new ToolStripMenuItem();
            DegreeSettings = new ToolStripComboBox();
            复数格式ToolStripMenuItem = new ToolStripMenuItem();
            ComplexnumSettings = new ToolStripComboBox();
            重置ToolStripMenuItem = new ToolStripMenuItem();
            History = new ToolStripMenuItem();
            SaveHistorytoFile = new ToolStripMenuItem();
            Help = new ToolStripMenuItem();
            gitHubToolStripMenuItem = new ToolStripMenuItem();
            localHelpToolStripMenuItem = new ToolStripMenuItem();
            checkForUpdateToolStripMenuItem = new ToolStripMenuItem();
            Num9 = new Button();
            ShowCalculate = new TextBox();
            Num8 = new Button();
            Num7 = new Button();
            Num6 = new Button();
            Num5 = new Button();
            Num4 = new Button();
            Num3 = new Button();
            Num2 = new Button();
            Num1 = new Button();
            Calculate = new Button();
            M = new Button();
            MClear = new Button();
            Cal1 = new Button();
            Cal2 = new Button();
            Cal3 = new Button();
            Num_point = new Button();
            Num0 = new Button();
            button20 = new Button();
            Clean = new Button();
            button22 = new Button();
            Con_e = new Button();
            log = new Button();
            Op2 = new Button();
            tan = new Button();
            arctan = new Button();
            pow = new Button();
            ln = new Button();
            Op1 = new Button();
            cos = new Button();
            arccos = new Button();
            sqrt = new Button();
            button35 = new Button();
            Abs = new Button();
            Hyp = new Button();
            RndorRndInt = new Button();
            ParrallelSeparator = new Button();
            sin = new Button();
            arcsin = new Button();
            button42 = new Button();
            button43 = new Button();
            Mminus = new Button();
            button45 = new Button();
            button46 = new Button();
            button47 = new Button();
            Mplus = new Button();
            button49 = new Button();
            button50 = new Button();
            button51 = new Button();
            button52 = new Button();
            button53 = new Button();
            button54 = new Button();
            button55 = new Button();
            Con_pi = new Button();
            Delete = new Button();
            SetShift = new Button();
            SetAlpha = new Button();
            STO = new Button();
            VAR = new Button();
            CALC = new Button();
            TopSearch.SuspendLayout();
            SuspendLayout();
            // 
            // TopSearch
            // 
            TopSearch.ImageScalingSize = new Size(24, 24);
            TopSearch.Items.AddRange(new ToolStripItem[] { Settings, History, Help });
            TopSearch.Location = new Point(0, 0);
            TopSearch.Name = "TopSearch";
            TopSearch.Size = new Size(1078, 43);
            TopSearch.TabIndex = 0;
            TopSearch.Text = "menuStrip1";
            // 
            // Settings
            // 
            Settings.DropDownItems.AddRange(new ToolStripItem[] { 设置, 复数格式ToolStripMenuItem, 重置ToolStripMenuItem });
            Settings.Name = "Settings";
            Settings.Size = new Size(85, 39);
            Settings.Text = "设置";
            // 
            // 设置
            // 
            设置.DropDownItems.AddRange(new ToolStripItem[] { DegreeSettings });
            设置.Name = "设置";
            设置.Size = new Size(228, 44);
            设置.Text = "角度单位";
            // 
            // DegreeSettings
            // 
            DegreeSettings.DropDownWidth = 150;
            DegreeSettings.Items.AddRange(new object[] { "Deg", "Rad", "Gra" });
            DegreeSettings.Name = "DegreeSettings";
            DegreeSettings.Size = new Size(240, 43);
            DegreeSettings.Text = "(默认为Rad）";
            // 
            // 复数格式ToolStripMenuItem
            // 
            复数格式ToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { ComplexnumSettings });
            复数格式ToolStripMenuItem.Name = "复数格式ToolStripMenuItem";
            复数格式ToolStripMenuItem.Size = new Size(228, 44);
            复数格式ToolStripMenuItem.Text = "复数格式";
            // 
            // ComplexnumSettings
            // 
            ComplexnumSettings.Items.AddRange(new object[] { "直角坐标", "极坐标" });
            ComplexnumSettings.Name = "ComplexnumSettings";
            ComplexnumSettings.Size = new Size(240, 43);
            ComplexnumSettings.Text = "(默认为直角坐标）";
            // 
            // 重置ToolStripMenuItem
            // 
            重置ToolStripMenuItem.Name = "重置ToolStripMenuItem";
            重置ToolStripMenuItem.Size = new Size(228, 44);
            重置ToolStripMenuItem.Text = "重置";
            // 
            // History
            // 
            History.DropDownItems.AddRange(new ToolStripItem[] { SaveHistorytoFile });
            History.Name = "History";
            History.Size = new Size(139, 39);
            History.Text = "计算历史";
            History.Click += History_Click;
            // 
            // SaveHistorytoFile
            // 
            SaveHistorytoFile.Name = "SaveHistorytoFile";
            SaveHistorytoFile.Size = new Size(525, 44);
            SaveHistorytoFile.Text = "存储到当前运行目录（同步记录）";
            SaveHistorytoFile.Click += SaveHistorytoFile_Click;
            // 
            // Help
            // 
            Help.DropDownItems.AddRange(new ToolStripItem[] { gitHubToolStripMenuItem, localHelpToolStripMenuItem, checkForUpdateToolStripMenuItem });
            Help.Name = "Help";
            Help.Size = new Size(91, 39);
            Help.Text = "Help";
            // 
            // gitHubToolStripMenuItem
            // 
            gitHubToolStripMenuItem.Name = "gitHubToolStripMenuItem";
            gitHubToolStripMenuItem.Size = new Size(345, 44);
            gitHubToolStripMenuItem.Text = "GitHub";
            gitHubToolStripMenuItem.Click += GitHubToolStripMenuItem_Click;
            // 
            // localHelpToolStripMenuItem
            // 
            localHelpToolStripMenuItem.Name = "localHelpToolStripMenuItem";
            localHelpToolStripMenuItem.Size = new Size(345, 44);
            localHelpToolStripMenuItem.Text = "LocalHelp";
            // 
            // checkForUpdateToolStripMenuItem
            // 
            checkForUpdateToolStripMenuItem.Name = "checkForUpdateToolStripMenuItem";
            checkForUpdateToolStripMenuItem.Size = new Size(345, 44);
            checkForUpdateToolStripMenuItem.Text = "Check for Update";
            // 
            // Num9
            // 
            Num9.Location = new Point(863, 228);
            Num9.Name = "Num9";
            Num9.Size = new Size(60, 60);
            Num9.TabIndex = 1;
            Num9.Text = "9";
            Num9.UseVisualStyleBackColor = true;
            Num9.Click += Num9_Click;
            // 
            // ShowCalculate
            // 
            ShowCalculate.Location = new Point(12, 59);
            ShowCalculate.MaximumSize = new Size(1054, 163);
            ShowCalculate.MinimumSize = new Size(1054, 163);
            ShowCalculate.Multiline = true;
            ShowCalculate.Name = "ShowCalculate";
            ShowCalculate.ScrollBars = ScrollBars.Horizontal;
            ShowCalculate.Size = new Size(1054, 163);
            ShowCalculate.TabIndex = 2;
            ShowCalculate.TextChanged += ShowCalculate_TextChanged;
            // 
            // Num8
            // 
            Num8.Location = new Point(796, 228);
            Num8.Name = "Num8";
            Num8.Size = new Size(60, 60);
            Num8.TabIndex = 3;
            Num8.Text = "8";
            Num8.UseVisualStyleBackColor = true;
            Num8.Click += Num8_Click;
            // 
            // Num7
            // 
            Num7.Location = new Point(730, 228);
            Num7.Name = "Num7";
            Num7.Size = new Size(60, 60);
            Num7.TabIndex = 4;
            Num7.Text = "7";
            Num7.UseVisualStyleBackColor = true;
            Num7.Click += Num7_Click;
            // 
            // Num6
            // 
            Num6.Location = new Point(863, 294);
            Num6.Name = "Num6";
            Num6.Size = new Size(60, 60);
            Num6.TabIndex = 6;
            Num6.Text = "6";
            Num6.UseVisualStyleBackColor = true;
            Num6.Click += Num6_Click;
            // 
            // Num5
            // 
            Num5.Location = new Point(796, 294);
            Num5.Name = "Num5";
            Num5.Size = new Size(60, 60);
            Num5.TabIndex = 7;
            Num5.Text = "5";
            Num5.UseVisualStyleBackColor = true;
            Num5.Click += Num5_Click;
            // 
            // Num4
            // 
            Num4.Location = new Point(730, 294);
            Num4.Name = "Num4";
            Num4.Size = new Size(60, 60);
            Num4.TabIndex = 8;
            Num4.Text = "4";
            Num4.UseVisualStyleBackColor = true;
            Num4.Click += Num4_Click;
            // 
            // Num3
            // 
            Num3.Location = new Point(863, 360);
            Num3.Name = "Num3";
            Num3.Size = new Size(60, 60);
            Num3.TabIndex = 9;
            Num3.Text = "3";
            Num3.UseVisualStyleBackColor = true;
            Num3.Click += Num3_Click;
            // 
            // Num2
            // 
            Num2.Location = new Point(796, 360);
            Num2.Name = "Num2";
            Num2.Size = new Size(60, 60);
            Num2.TabIndex = 10;
            Num2.Text = "2";
            Num2.UseVisualStyleBackColor = true;
            Num2.Click += Num2_Click;
            // 
            // Num1
            // 
            Num1.Location = new Point(730, 360);
            Num1.Name = "Num1";
            Num1.Size = new Size(60, 60);
            Num1.TabIndex = 11;
            Num1.Text = "1";
            Num1.UseVisualStyleBackColor = true;
            Num1.Click += Num1_Click;
            // 
            // Calculate
            // 
            Calculate.Font = new Font("Microsoft YaHei UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            Calculate.Location = new Point(946, 426);
            Calculate.Name = "Calculate";
            Calculate.Size = new Size(120, 127);
            Calculate.TabIndex = 12;
            Calculate.Text = "EXE";
            Calculate.UseVisualStyleBackColor = true;
            Calculate.Click += Calculate_Click;
            // 
            // M
            // 
            M.Location = new Point(946, 228);
            M.Name = "M";
            M.Size = new Size(120, 48);
            M.TabIndex = 13;
            M.Text = "M";
            M.UseVisualStyleBackColor = true;
            // 
            // MClear
            // 
            MClear.Location = new Point(946, 282);
            MClear.Name = "MClear";
            MClear.Size = new Size(120, 42);
            MClear.TabIndex = 14;
            MClear.Text = "MC";
            MClear.UseVisualStyleBackColor = true;
            // 
            // Cal1
            // 
            Cal1.Location = new Point(797, 426);
            Cal1.Name = "Cal1";
            Cal1.Size = new Size(60, 60);
            Cal1.TabIndex = 17;
            Cal1.Text = "+";
            Cal1.UseVisualStyleBackColor = true;
            Cal1.Click += Cal1_Click;
            // 
            // Cal2
            // 
            Cal2.Location = new Point(863, 426);
            Cal2.Name = "Cal2";
            Cal2.Size = new Size(60, 60);
            Cal2.TabIndex = 18;
            Cal2.Text = "-";
            Cal2.UseVisualStyleBackColor = true;
            Cal2.Click += Cal2_Click;
            // 
            // Cal3
            // 
            Cal3.Location = new Point(797, 492);
            Cal3.Name = "Cal3";
            Cal3.Size = new Size(60, 60);
            Cal3.TabIndex = 19;
            Cal3.Text = "×";
            Cal3.UseVisualStyleBackColor = true;
            Cal3.Click += Cal3_Click;
            // 
            // Num_point
            // 
            Num_point.Location = new Point(730, 492);
            Num_point.Name = "Num_point";
            Num_point.Size = new Size(60, 60);
            Num_point.TabIndex = 20;
            Num_point.Text = ".";
            Num_point.UseVisualStyleBackColor = true;
            Num_point.Click += Num_point_Click;
            // 
            // Num0
            // 
            Num0.Location = new Point(730, 426);
            Num0.Name = "Num0";
            Num0.Size = new Size(60, 60);
            Num0.TabIndex = 21;
            Num0.Text = "0";
            Num0.UseVisualStyleBackColor = true;
            Num0.Click += Num0_Click;
            // 
            // button20
            // 
            button20.Location = new Point(863, 492);
            button20.Name = "button20";
            button20.Size = new Size(60, 60);
            button20.TabIndex = 22;
            button20.Text = "÷";
            button20.UseVisualStyleBackColor = true;
            button20.Click += button20_Click;
            // 
            // Clean
            // 
            Clean.Location = new Point(644, 228);
            Clean.Name = "Clean";
            Clean.Size = new Size(80, 60);
            Clean.TabIndex = 23;
            Clean.Text = "C";
            Clean.UseVisualStyleBackColor = true;
            Clean.Click += Clean_Click;
            // 
            // button22
            // 
            button22.Location = new Point(644, 294);
            button22.Name = "button22";
            button22.Size = new Size(80, 60);
            button22.TabIndex = 24;
            button22.Text = "±";
            button22.UseVisualStyleBackColor = true;
            // 
            // Con_e
            // 
            Con_e.Location = new Point(644, 426);
            Con_e.Name = "Con_e";
            Con_e.Size = new Size(80, 60);
            Con_e.TabIndex = 26;
            Con_e.Text = "e";
            Con_e.UseVisualStyleBackColor = true;
            Con_e.Click += Con_e_Click;
            // 
            // log
            // 
            log.Location = new Point(644, 492);
            log.Name = "log";
            log.Size = new Size(80, 60);
            log.TabIndex = 27;
            log.Text = "㏒";
            log.UseVisualStyleBackColor = true;
            log.Click += log_Click;
            // 
            // Op2
            // 
            Op2.Location = new Point(472, 228);
            Op2.Name = "Op2";
            Op2.Size = new Size(80, 60);
            Op2.TabIndex = 28;
            Op2.Text = ")";
            Op2.UseVisualStyleBackColor = true;
            Op2.Click += Op2_Click;
            // 
            // tan
            // 
            tan.Location = new Point(558, 294);
            tan.Name = "tan";
            tan.Size = new Size(80, 60);
            tan.TabIndex = 29;
            tan.Text = "tan";
            tan.UseVisualStyleBackColor = true;
            tan.Click += tan_Click;
            // 
            // arctan
            // 
            arctan.Font = new Font("Microsoft YaHei UI", 10.5F, FontStyle.Regular, GraphicsUnit.Point);
            arctan.Location = new Point(558, 360);
            arctan.Name = "arctan";
            arctan.Size = new Size(80, 60);
            arctan.TabIndex = 30;
            arctan.Text = "atan";
            arctan.UseVisualStyleBackColor = true;
            arctan.Click += arctan_Click;
            // 
            // pow
            // 
            pow.Location = new Point(558, 426);
            pow.Name = "pow";
            pow.Size = new Size(80, 60);
            pow.TabIndex = 31;
            pow.Text = "pow";
            pow.UseVisualStyleBackColor = true;
            pow.Click += pow_Click;
            // 
            // ln
            // 
            ln.Location = new Point(558, 492);
            ln.Name = "ln";
            ln.Size = new Size(80, 60);
            ln.TabIndex = 32;
            ln.Text = "㏑";
            ln.UseVisualStyleBackColor = true;
            ln.Click += ln_Click;
            // 
            // Op1
            // 
            Op1.Location = new Point(386, 228);
            Op1.Name = "Op1";
            Op1.Size = new Size(80, 60);
            Op1.TabIndex = 33;
            Op1.Text = "(";
            Op1.UseVisualStyleBackColor = true;
            Op1.Click += Op1_Click;
            // 
            // cos
            // 
            cos.Location = new Point(472, 294);
            cos.Name = "cos";
            cos.Size = new Size(80, 60);
            cos.TabIndex = 34;
            cos.Text = "cos";
            cos.UseVisualStyleBackColor = true;
            cos.Click += cos_Click;
            // 
            // arccos
            // 
            arccos.Font = new Font("Microsoft YaHei UI", 10.5F, FontStyle.Regular, GraphicsUnit.Point);
            arccos.Location = new Point(472, 360);
            arccos.Name = "arccos";
            arccos.Size = new Size(80, 60);
            arccos.TabIndex = 35;
            arccos.Text = "acos";
            arccos.UseVisualStyleBackColor = true;
            arccos.Click += arccos_Click;
            // 
            // sqrt
            // 
            sqrt.Location = new Point(472, 426);
            sqrt.Name = "sqrt";
            sqrt.Size = new Size(80, 60);
            sqrt.TabIndex = 36;
            sqrt.UseVisualStyleBackColor = true;
            // 
            // button35
            // 
            button35.Location = new Point(472, 492);
            button35.Name = "button35";
            button35.Size = new Size(80, 60);
            button35.TabIndex = 37;
            button35.UseVisualStyleBackColor = true;
            // 
            // Abs
            // 
            Abs.Location = new Point(214, 228);
            Abs.Name = "Abs";
            Abs.Size = new Size(80, 60);
            Abs.TabIndex = 38;
            Abs.Text = "Abs";
            Abs.UseVisualStyleBackColor = true;
            // 
            // Hyp
            // 
            Hyp.Location = new Point(128, 228);
            Hyp.Name = "Hyp";
            Hyp.Size = new Size(80, 60);
            Hyp.TabIndex = 39;
            Hyp.Text = "Hyp";
            Hyp.UseVisualStyleBackColor = true;
            // 
            // RndorRndInt
            // 
            RndorRndInt.Location = new Point(300, 228);
            RndorRndInt.Name = "RndorRndInt";
            RndorRndInt.Size = new Size(80, 60);
            RndorRndInt.TabIndex = 40;
            RndorRndInt.Text = "Rnd";
            RndorRndInt.UseVisualStyleBackColor = true;
            RndorRndInt.Click += button38_Click;
            // 
            // ParrallelSeparator
            // 
            ParrallelSeparator.Location = new Point(558, 228);
            ParrallelSeparator.Name = "ParrallelSeparator";
            ParrallelSeparator.Size = new Size(80, 60);
            ParrallelSeparator.TabIndex = 41;
            ParrallelSeparator.Text = ",";
            ParrallelSeparator.UseVisualStyleBackColor = true;
            ParrallelSeparator.Click += ParrallelSeparator_Click;
            // 
            // sin
            // 
            sin.Location = new Point(386, 294);
            sin.Name = "sin";
            sin.Size = new Size(80, 60);
            sin.TabIndex = 42;
            sin.Text = "sin";
            sin.UseVisualStyleBackColor = true;
            sin.Click += sin_Click;
            // 
            // arcsin
            // 
            arcsin.Font = new Font("Microsoft YaHei UI", 10.5F, FontStyle.Regular, GraphicsUnit.Point);
            arcsin.Location = new Point(386, 360);
            arcsin.Name = "arcsin";
            arcsin.Size = new Size(80, 60);
            arcsin.TabIndex = 43;
            arcsin.Text = "asin";
            arcsin.UseVisualStyleBackColor = true;
            arcsin.Click += arcsin_Click;
            // 
            // button42
            // 
            button42.Location = new Point(386, 426);
            button42.Name = "button42";
            button42.Size = new Size(80, 60);
            button42.TabIndex = 44;
            button42.UseVisualStyleBackColor = true;
            // 
            // button43
            // 
            button43.Location = new Point(386, 493);
            button43.Name = "button43";
            button43.Size = new Size(80, 60);
            button43.TabIndex = 45;
            button43.UseVisualStyleBackColor = true;
            // 
            // Mminus
            // 
            Mminus.Location = new Point(300, 294);
            Mminus.Name = "Mminus";
            Mminus.Size = new Size(80, 60);
            Mminus.TabIndex = 46;
            Mminus.Text = "M-";
            Mminus.UseVisualStyleBackColor = true;
            // 
            // button45
            // 
            button45.Location = new Point(300, 360);
            button45.Name = "button45";
            button45.Size = new Size(80, 60);
            button45.TabIndex = 47;
            button45.UseVisualStyleBackColor = true;
            // 
            // button46
            // 
            button46.Location = new Point(300, 426);
            button46.Name = "button46";
            button46.Size = new Size(80, 60);
            button46.TabIndex = 48;
            button46.UseVisualStyleBackColor = true;
            // 
            // button47
            // 
            button47.Location = new Point(300, 493);
            button47.Name = "button47";
            button47.Size = new Size(80, 60);
            button47.TabIndex = 49;
            button47.UseVisualStyleBackColor = true;
            // 
            // Mplus
            // 
            Mplus.Location = new Point(214, 294);
            Mplus.Name = "Mplus";
            Mplus.Size = new Size(80, 60);
            Mplus.TabIndex = 50;
            Mplus.Text = "M+";
            Mplus.UseVisualStyleBackColor = true;
            // 
            // button49
            // 
            button49.Location = new Point(128, 294);
            button49.Name = "button49";
            button49.Size = new Size(80, 60);
            button49.TabIndex = 51;
            button49.UseVisualStyleBackColor = true;
            // 
            // button50
            // 
            button50.Location = new Point(214, 360);
            button50.Name = "button50";
            button50.Size = new Size(80, 60);
            button50.TabIndex = 52;
            button50.UseVisualStyleBackColor = true;
            // 
            // button51
            // 
            button51.Location = new Point(128, 493);
            button51.Name = "button51";
            button51.Size = new Size(80, 60);
            button51.TabIndex = 53;
            button51.UseVisualStyleBackColor = true;
            // 
            // button52
            // 
            button52.Location = new Point(214, 426);
            button52.Name = "button52";
            button52.Size = new Size(80, 60);
            button52.TabIndex = 53;
            button52.UseVisualStyleBackColor = true;
            // 
            // button53
            // 
            button53.Location = new Point(214, 493);
            button53.Name = "button53";
            button53.Size = new Size(80, 60);
            button53.TabIndex = 54;
            button53.UseVisualStyleBackColor = true;
            // 
            // button54
            // 
            button54.Location = new Point(128, 360);
            button54.Name = "button54";
            button54.Size = new Size(80, 60);
            button54.TabIndex = 55;
            button54.UseVisualStyleBackColor = true;
            // 
            // button55
            // 
            button55.Location = new Point(128, 426);
            button55.Name = "button55";
            button55.Size = new Size(80, 60);
            button55.TabIndex = 56;
            button55.UseVisualStyleBackColor = true;
            // 
            // Con_pi
            // 
            Con_pi.Location = new Point(644, 360);
            Con_pi.Name = "Con_pi";
            Con_pi.Size = new Size(80, 60);
            Con_pi.TabIndex = 57;
            Con_pi.Text = "π";
            Con_pi.UseVisualStyleBackColor = true;
            Con_pi.Click += Con_pi_Click;
            // 
            // Delete
            // 
            Delete.Location = new Point(946, 330);
            Delete.Name = "Delete";
            Delete.Size = new Size(120, 90);
            Delete.TabIndex = 58;
            Delete.Text = "Del";
            Delete.UseVisualStyleBackColor = true;
            Delete.Click += Delete_Click;
            // 
            // SetShift
            // 
            SetShift.Location = new Point(12, 228);
            SetShift.Name = "SetShift";
            SetShift.Size = new Size(110, 60);
            SetShift.TabIndex = 59;
            SetShift.Text = "Shift";
            SetShift.UseVisualStyleBackColor = true;
            // 
            // SetAlpha
            // 
            SetAlpha.Location = new Point(12, 294);
            SetAlpha.Name = "SetAlpha";
            SetAlpha.Size = new Size(110, 60);
            SetAlpha.TabIndex = 60;
            SetAlpha.Text = " Alpha";
            SetAlpha.UseVisualStyleBackColor = true;
            // 
            // STO
            // 
            STO.Location = new Point(12, 360);
            STO.Name = "STO";
            STO.Size = new Size(110, 60);
            STO.TabIndex = 61;
            STO.Text = " STO";
            STO.UseVisualStyleBackColor = true;
            // 
            // VAR
            // 
            VAR.Location = new Point(12, 426);
            VAR.Name = "VAR";
            VAR.Size = new Size(110, 60);
            VAR.TabIndex = 62;
            VAR.Text = "VAR";
            VAR.UseVisualStyleBackColor = true;
            // 
            // CALC
            // 
            CALC.Location = new Point(12, 493);
            CALC.Name = "CALC";
            CALC.Size = new Size(110, 60);
            CALC.TabIndex = 63;
            CALC.Text = " CALC";
            CALC.UseVisualStyleBackColor = true;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new SizeF(16F, 35F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(1078, 560);
            this.Controls.Add(CALC);
            this.Controls.Add(VAR);
            this.Controls.Add(STO);
            this.Controls.Add(SetAlpha);
            this.Controls.Add(SetShift);
            this.Controls.Add(Delete);
            this.Controls.Add(Con_pi);
            this.Controls.Add(button55);
            this.Controls.Add(button54);
            this.Controls.Add(button53);
            this.Controls.Add(button52);
            this.Controls.Add(button51);
            this.Controls.Add(button50);
            this.Controls.Add(button49);
            this.Controls.Add(Mplus);
            this.Controls.Add(button47);
            this.Controls.Add(button46);
            this.Controls.Add(button45);
            this.Controls.Add(Mminus);
            this.Controls.Add(button43);
            this.Controls.Add(button42);
            this.Controls.Add(arcsin);
            this.Controls.Add(sin);
            this.Controls.Add(ParrallelSeparator);
            this.Controls.Add(RndorRndInt);
            this.Controls.Add(Hyp);
            this.Controls.Add(Abs);
            this.Controls.Add(button35);
            this.Controls.Add(sqrt);
            this.Controls.Add(arccos);
            this.Controls.Add(cos);
            this.Controls.Add(Op1);
            this.Controls.Add(ln);
            this.Controls.Add(pow);
            this.Controls.Add(arctan);
            this.Controls.Add(tan);
            this.Controls.Add(Op2);
            this.Controls.Add(log);
            this.Controls.Add(Con_e);
            this.Controls.Add(button22);
            this.Controls.Add(Clean);
            this.Controls.Add(button20);
            this.Controls.Add(Num0);
            this.Controls.Add(Num_point);
            this.Controls.Add(Cal3);
            this.Controls.Add(Cal2);
            this.Controls.Add(Cal1);
            this.Controls.Add(MClear);
            this.Controls.Add(M);
            this.Controls.Add(Calculate);
            this.Controls.Add(Num1);
            this.Controls.Add(Num2);
            this.Controls.Add(Num3);
            this.Controls.Add(Num4);
            this.Controls.Add(Num5);
            this.Controls.Add(Num6);
            this.Controls.Add(Num7);
            this.Controls.Add(Num8);
            this.Controls.Add(ShowCalculate);
            this.Controls.Add(Num9);
            this.Controls.Add(TopSearch);
            this.MainMenuStrip = TopSearch;
            this.MaximumSize = new Size(1100, 620);
            this.MinimumSize = new Size(1100, 620);
            this.Name = "Main";
            this.Text = "MetazinicAcid alpha ";
            Load += Main_Load;
            TopSearch.ResumeLayout(false);
            TopSearch.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip TopSearch;
        private ToolStripMenuItem Settings;
        private ToolStripMenuItem 设置;
        private ToolStripMenuItem History;
        private ToolStripMenuItem Help;
        private ToolStripComboBox DegreeSettings;
        private ToolStripMenuItem 复数格式ToolStripMenuItem;
        private ToolStripComboBox ComplexnumSettings;
        private ToolStripMenuItem checkForUpdateToolStripMenuItem;
        private ToolStripMenuItem gitHubToolStripMenuItem;
        private ToolStripMenuItem localHelpToolStripMenuItem;
        private Button Num9;
        private TextBox ShowCalculate;
        private Button Num8;
        private Button Num7;
        private Button Num6;
        private Button Num5;
        private Button Num4;
        private Button Num3;
        private Button Num2;
        private Button Num1;
        private Button Calculate;
        private Button M;
        private Button MClear;
        private Button Cal1;
        private Button Cal2;
        private Button Cal3;
        private Button Num_point;
        private Button Num0;
        private Button button20;
        private Button Clean;
        private Button button22;
        private Button Con_e;
        private Button log;
        private Button Op2;
        private Button tan;
        private Button arctan;
        private Button pow;
        private Button ln;
        private Button Op1;
        private Button cos;
        private Button arccos;
        private Button sqrt;
        private Button button35;
        private Button Abs;
        private Button Hyp;
        private Button RndorRndInt;
        private Button ParrallelSeparator;
        private Button sin;
        private Button arcsin;
        private Button button42;
        private Button button43;
        private Button Mminus;
        private Button button45;
        private Button button46;
        private Button button47;
        private Button Mplus;
        private Button button49;
        private Button button50;
        private Button button51;
        private Button button52;
        private Button button53;
        private Button button54;
        private Button button55;
        private Button Con_pi;
        private Button Delete;
        private Button SetShift;
        private Button SetAlpha;
        private Button STO;
        private Button VAR;
        private Button CALC;
        private ToolStripMenuItem 重置ToolStripMenuItem;
        private ToolStripMenuItem SaveHistorytoFile;
    }
}