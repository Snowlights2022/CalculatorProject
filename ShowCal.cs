using CalEngine;

namespace ShowCal
{
    public static class Global//妥协的全局变量静态类
    {
        public static string CalResult_CopyofCalMem;
        public static List<string> MainRawInfix = new List<string>();//充当全局混沌中缀表达式……

        //CalHis……
        public static string MIDDLE;
        public static List<string> CalHis = new List<string>();
    }
    public class Calculate//运算地点……
    {
        //初始化最开始的混沌表达式，供输入调用
        public static InfixInitialize GetExpStarted(List<string> strings)
        {
            InfixInitialize Rawinfix = new InfixInitialize();
            Rawinfix.BracketContent = strings;
            return Rawinfix;//这个程序最开始装表达式的就是它喽！
        }

        //全部的计算发生在这个func.BracketContent里面,这个函数是计算的主体，最后结果在func.BracketContent[0]。
        public static Store StartCal(Bracket funcbra)
        {
            Store CalMem = new Store();
            CalMem.StoreStartTime();
            CalMem.StoreExp(funcbra.BracketContent);
        Recall:
            {
                if (Functions.FindFunc(funcbra))
                {
                    Cal_Universal.CalFunc(funcbra.BracketContent);
                    goto Recall;
                }
                else
                {
                    Cal_Universal.CalDouble(funcbra);
                }
            }
            CalMem.StoreResult(funcbra);//这里已经更新了全局变量中间结果
            CalMem.StoreUsedTime();
            return CalMem;
        }
    }

    public class Store//存储结果
    {
        //字段声明
        public string CalStartTime;//计算开始时间
        private TimeSpan CalStart;
        private TimeSpan CalFinish;
        public string CalUsedTime;//计算用时
        public string CalResult;//计算结果，显示框输出
        public string CalExp;//计算表达式(中缀)
        public string CalMiddle;//历史输出
        public string CalMiddle1;//

        //构造函数
        //public Store() { }
        public Store()
        {
            this.CalStartTime = DateTime.Now.ToString(format: "yyyy" + "年" + "MM" + "月" + "dd" + "日" + "HH-mmssffff");
            this.CalStart = new TimeSpan(DateTime.Now.Ticks);
        }

        //合成字符串
        public string GetResult()//这一个合成的是历史记录显示
        {
            string Result = "计算开始时间：" + this.CalStartTime + "\n" + "计算用时：" + this.CalUsedTime + "ms" + "\n" + "计算表达式：" + this.CalExp + "\n" + "计算结果：" + this.CalResult + "\n";
            return Result;
        }
        public static string GetResult(List<string> list)
        {
            string str = null;
            foreach (var item in list)
            {
                str = str + item;
            }
            return str;
        }

        //存储结果，同时更新了全局变量中间结果
        public void StoreResult(Bracket MotherBra)
        {
            this.CalResult = MotherBra.BracketContent[0];
            Global.CalResult_CopyofCalMem = this.CalResult;
            Global.MIDDLE = this.GetResult();
        }
        //存储中缀表达式
        public void StoreExp(List<string> Rawinfix)
        {
            this.CalExp = Store.GetResult(Rawinfix);
        }
        //存储开始时间
        public void StoreStartTime()
        {
            this.CalStartTime = DateTime.Now.ToString(format: "yyyy" + "年" + "MM" + "月" + "dd" + "日" + "HH-mmssffff");
        }
        //存储用时
        public void StoreUsedTime()
        {
            this.CalFinish = new TimeSpan(DateTime.Now.Ticks);
            TimeSpan st = new TimeSpan();
            this.CalUsedTime = Convert.ToString((CalStart.Subtract(CalFinish).Duration()).Milliseconds);
        }



        //以下是对历史的处理
        //存储到List
        public void StoreHistory()
        {
            Global.CalHis.Add(this.GetResult());
        }

        //写入文件
        public static void StoreHistoryToFile()
        {
            string fileName = "CalculateHistory.txt";//目标文件名
            string fullPath = Path.Combine(Application.StartupPath, fileName);

            if (File.Exists(fullPath))//如果文件存在，就追加写入
            {
                using (StreamWriter writer = File.AppendText(fullPath))
                {
                    writer.WriteLine(Global.MIDDLE);
                }
            }
            else//文件不存在，那就一次性写完
            {
                using (StreamWriter writer = File.CreateText(fullPath))
                {
                    foreach (var item in Global.CalHis)
                    {
                        writer.WriteLine(item);
                    }
                }
            }
        }
    }
}
