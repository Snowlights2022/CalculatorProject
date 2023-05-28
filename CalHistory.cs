using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class CalHistory : Form
    {
        //private readonly int setted = 0;
        private static string TextofShowHistory = ShowCal.Global.MIDDLE;

        //后台以及前台实时从Show.Global.MIDDLE更新ShowHistory.Text
        private void CalHistory_Load(object sender, EventArgs e)
        {
            if (this.ShowHistory.Text == "" || this.ShowHistory.Text == null)
            {
                this.ShowHistory.Text = "历史记录为空";
            }
            if (!this.ShowHistory.Text.Contains(ShowCal.Global.MIDDLE))
            {
                this.ShowHistory.Text = $"{this.ShowHistory.Text}\n{ShowCal.Global.MIDDLE}";
            }
        }


        public CalHistory()
        {
            InitializeComponent();
        }

        private void ShowHistory_TextChanged(object sender, EventArgs e)
        {

        }

        private void CleanHistory_Click(object sender, EventArgs e)//相当于AC
        {
            this.ShowHistory.Text = null;
            ShowCal.Global.CalResult_CopyofCalMem = null;
            ShowCal.Global.MIDDLE = null;
        }
    }
}
