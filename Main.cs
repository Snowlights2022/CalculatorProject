using CalEngine;

using ShowCal;

using System.Diagnostics;

namespace Calculator
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            InfixInitialize MainRawInfix = new InfixInitialize();
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }
        //历史记录窗口调用
        private bool HistoryWindowOpen = false;
        private CalHistory HistoryWindow;
        private void History_Click(object sender, EventArgs e)
        {
            ////这部分还没有开发完全，子窗体注释掉了
            //if (HistoryWindow != null && !HistoryWindow.IsDisposed)//当窗口被释放(disposed)时，激活窗口
            //{
            //    HistoryWindow.Activate();
            //}
            //else//新建并打开窗口
            //{
            //    HistoryWindowOpen = true;
            //    HistoryWindow = new CalHistory();
            //    HistoryWindow.FormClosed += (_, __) => HistoryWindowOpen = false;//Lambda表达式,一种无需命名的简洁函数。此处作用是重置HistoryWindowOpen的bool值。
            //    HistoryWindow.Show(this);
            //}
        }

        private void GitHubToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("explorer.exe", "https://github.com/Snowlights2022/CalculatorProject");//调用默认浏览器，打开项目网页地址~
        }

        private void button38_Click(object sender, EventArgs e)
        {

        }

        private void Op1_Click(object sender, EventArgs e)
        {
            Global.MainRawInfix.Add("(");
            ShowCalculate.Text = ShowCalculate.Text + "(";
        }

        private void Num1_Click(object sender, EventArgs e)
        {
            Global.MainRawInfix.Add("1");
            ShowCalculate.Text = ShowCalculate.Text + "1";
        }

        private void Op2_Click(object sender, EventArgs e)
        {
            Global.MainRawInfix.Add(")");
            ShowCalculate.Text = ShowCalculate.Text + ")";
        }

        private void Num7_Click(object sender, EventArgs e)
        {
            Global.MainRawInfix.Add("7");
            ShowCalculate.Text = ShowCalculate.Text + "7";
        }

        private void Num4_Click(object sender, EventArgs e)
        {
            Global.MainRawInfix.Add("4");
            ShowCalculate.Text = ShowCalculate.Text + "4";
        }

        private void Num9_Click(object sender, EventArgs e)
        {
            Global.MainRawInfix.Add("9");
            ShowCalculate.Text = ShowCalculate.Text + "9";
        }

        private void Num0_Click(object sender, EventArgs e)
        {
            Global.MainRawInfix.Add("0");
            ShowCalculate.Text = ShowCalculate.Text + "0";
        }

        private void Num2_Click(object sender, EventArgs e)
        {
            Global.MainRawInfix.Add("2");
            ShowCalculate.Text = ShowCalculate.Text + "2";
        }

        private void Num3_Click(object sender, EventArgs e)
        {
            Global.MainRawInfix.Add("3");
            ShowCalculate.Text = ShowCalculate.Text + "3";
        }

        private void Num5_Click(object sender, EventArgs e)
        {
            Global.MainRawInfix.Add("5");
            ShowCalculate.Text = ShowCalculate.Text + "5";
        }

        private void Num6_Click(object sender, EventArgs e)
        {
            Global.MainRawInfix.Add("6");
            ShowCalculate.Text = ShowCalculate.Text + "6";
        }

        private void Num8_Click(object sender, EventArgs e)
        {
            Global.MainRawInfix.Add("8");
            ShowCalculate.Text = ShowCalculate.Text + "8";
        }

        private void sin_Click(object sender, EventArgs e)
        {
            Global.MainRawInfix.Add("sin");
            ShowCalculate.Text = ShowCalculate.Text + "sin";
        }

        private void cos_Click(object sender, EventArgs e)
        {
            Global.MainRawInfix.Add("cos");
            ShowCalculate.Text = ShowCalculate.Text + "cos";
        }

        private void tan_Click(object sender, EventArgs e)
        {
            Global.MainRawInfix.Add("tan");
            ShowCalculate.Text = ShowCalculate.Text + "tan";
        }

        private void arcsin_Click(object sender, EventArgs e)
        {
            Global.MainRawInfix.Add("arctan");
            ShowCalculate.Text = ShowCalculate.Text + "arctan";
        }

        private void arccos_Click(object sender, EventArgs e)
        {
            Global.MainRawInfix.Add("arccos");
            ShowCalculate.Text = ShowCalculate.Text + "arccos";
        }

        private void arctan_Click(object sender, EventArgs e)
        {
            Global.MainRawInfix.Add("arctan");
            ShowCalculate.Text = ShowCalculate.Text + "arctan";
        }

        private void log_Click(object sender, EventArgs e)
        {
            Global.MainRawInfix.Add("log");
            ShowCalculate.Text = ShowCalculate.Text + "log";
        }

        private void ln_Click(object sender, EventArgs e)
        {
            Global.MainRawInfix.Add("ln");
            ShowCalculate.Text = ShowCalculate.Text + "ln";
        }

        private void pow_Click(object sender, EventArgs e)
        {
            Global.MainRawInfix.Add("pow");
            ShowCalculate.Text = ShowCalculate.Text + "pow";
        }

        private void Calculate_Click(object sender, EventArgs e)
        {
            InfixInitialize Rawinfix = new InfixInitialize();
            Store CalMemory = new Store();
            Rawinfix = ShowCal.Calculate.GetExpStarted(Global.MainRawInfix);//获取表达式
            if (Global.CalResult_CopyofCalMem != null)//如果有运算结果，继承运算结果到表达式[0]位置
            {
                ShowCalculate.Text = Global.CalResult_CopyofCalMem + ShowCalculate.Text;
                Rawinfix.BracketContent.Insert(0, Global.CalResult_CopyofCalMem);
            }
            Bracket NEW = new Bracket();
            NEW = CalEngine.Cal_Universal.Initialize(Rawinfix);
            CalMemory = ShowCal.Calculate.StartCal(NEW);
            ShowCalculate.Text = null;
            ShowCalculate.Text = CalMemory.CalResult;

            //将计算结果情况加入历史记录中
            ShowCal.Global.MIDDLE = CalMemory.GetResult();
            ShowCal.Global.CalHis.Add(ShowCal.Global.MIDDLE);
        }

        private void ShowCalculate_TextChanged(object sender, EventArgs e)
        {

        }

        private void Cal1_Click(object sender, EventArgs e)
        {
            Global.MainRawInfix.Add("+");
            ShowCalculate.Text = ShowCalculate.Text + "+";
        }

        private void Cal2_Click(object sender, EventArgs e)
        {
            Global.MainRawInfix.Add("-");
            ShowCalculate.Text = ShowCalculate.Text + "-";
        }

        private void Cal3_Click(object sender, EventArgs e)
        {
            Global.MainRawInfix.Add("*");
            ShowCalculate.Text = ShowCalculate.Text + "*";
        }

        private void button20_Click(object sender, EventArgs e)
        {
            Global.MainRawInfix.Add("/");
            ShowCalculate.Text = ShowCalculate.Text + "/";
        }

        private void Num_point_Click(object sender, EventArgs e)
        {
            Global.MainRawInfix.Add(".");
            ShowCalculate.Text = ShowCalculate.Text + ".";
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            if (Global.MainRawInfix.Count >= 2)//不是空的时候才能删除
            {
                Global.MainRawInfix.RemoveAt((Global.MainRawInfix.Count - 1));
                ShowCalculate.Text = ShowCal.Store.GetResult(Global.MainRawInfix);
            }
            else if (Global.MainRawInfix.Count == 1)//判断是不是继承的结果，若是则清空系统MEM和显示
            {
                if (CalEngine.Cal_Simplyfy.IsNumber(Global.MainRawInfix[0]))
                {
                    Global.MainRawInfix.Clear();
                    ShowCalculate.Text = null;
                    Global.CalResult_CopyofCalMem = null;//这个也处理掉，防止乱窜
                }
            }
            else if (Global.MainRawInfix.Count == 0)
            {

            }
        }//删除的处理

        private void Con_pi_Click(object sender, EventArgs e)
        {
            Global.MainRawInfix.Add("π");
            ShowCalculate.Text = ShowCalculate.Text + "π";
        }

        private void Con_e_Click(object sender, EventArgs e)
        {
            Global.MainRawInfix.Add("e");
            ShowCalculate.Text = ShowCalculate.Text + "e";
        }

        private void ParrallelSeparator_Click(object sender, EventArgs e)
        {
            Global.MainRawInfix.Add(",");
            ShowCalculate.Text = ShowCalculate.Text + ",";
        }

        private void Clean_Click(object sender, EventArgs e)
        {
            Global.MainRawInfix.Clear();
            ShowCalculate.Text = null;
            Global.CalResult_CopyofCalMem = null;
        }

        private void SaveHistorytoFile_Click(object sender, EventArgs e)
        {
            ShowCal.Store.StoreHistoryToFile();
        }
    }
}