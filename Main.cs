using CalEngine;

using System.Diagnostics;

namespace Calculator
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }
        //历史记录窗口调用
        private bool HistoryWindowOpen = false;
        private CalHistory HistoryWindow;
        private void History_Click(object sender, EventArgs e)
        {
            if (HistoryWindow != null && !HistoryWindow.IsDisposed)//当窗口被释放(disposed)时，激活窗口
            {
                HistoryWindow.Activate();
            }
            else//新建并打开窗口
            {
                HistoryWindowOpen = true;
                HistoryWindow = new CalHistory();
                HistoryWindow.FormClosed += (_, __) => HistoryWindowOpen = false;//Lambda表达式,一种无需命名的简洁函数。此处作用是重置HistoryWindowOpen的bool值。
                HistoryWindow.Show(this);
            }
        }

        private void GitHubToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("explorer.exe", "https://github.com/Snowlights2022/CalculatorProject");//调用默认浏览器，打开项目网页地址~
        }
    }
}