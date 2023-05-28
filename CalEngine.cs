using System.Collections.ObjectModel;
using System.Security.Cryptography;

namespace CalEngine
{
    //中缀表达式初始化
    public class InfixInitialize : Bracket
    {
        //唯一特有字段，显示给人看的string类型中缀表达式
        public static List<string> InfixExp;
        //构造函数
        public InfixInitialize()
        {
            this.StIndex = 0;
            this.BracketContent = new List<string>();
        }

        //下面这个方法用于将括号内的字符串数组，函数参数数组替换为占位符等。
        internal static void ReplaceWith(List<string> InfixExp, int Index, int Count, string NewToken)
        {
            InfixExp.Insert(Index, NewToken);
            InfixExp.RemoveRange(Index + 1, Count);

        }
        //下面这个重载用于将中间运算结果替换原来的占位符。
        internal static void ReplaceWith(List<string> InfixExp, int Index, string NewToken)
        {
            InfixExp.Insert(Index, NewToken);
            InfixExp.RemoveAt(Index + 1);
        }
    }

    //括号处理
    public class Bracket
    {
        //成员属性变量
        protected int StIndex;//标记括号起点位置
        protected int EndIndex;//标记括号终点位置
        protected int Length;//标记括号长度
        public string UsingSeat;//占位标识符，作为括号在上一级的中缀表达式的标记
        internal List<string> BracketContent = new List<string>();//括号内的内容
        internal bool Functions;//标记是否为科学函数所属的括号
        public int BraDepth;//标记括号的深度
        public bool Converted;//标记是否已经转换为后缀表达式


        //构造函数
        public Bracket()
        {
            this.BraDepth = 1;
            this.Converted = false;
            this.Functions = false;
        }
        public Bracket(int Depth)
        {
            this.UsingSeat = "Bra" + DateTime.Now.ToString(format: "yyyyMMddHHmmssffff");
            this.BraDepth = Depth;
        }
        public Bracket(bool Functions)
        {
            this.Functions = Functions;
            this.UsingSeat = "Bra" + DateTime.Now.ToString(format: "yyyyMMddHHmmssffff");
        }
        //析构函数

        //找到从左往右最近的最小括号对，用BracketContent返回括号内的中缀表达式，使用标识符占位。
        //原来的中缀表达式已经被修改，返回子式。
        internal Bracket GetBracket()
        {
            Bracket SonBra = new Bracket();
            List<string> InputExpression = this.BracketContent;
            for (int Index = 0; Index < InputExpression.Count; Index++)
            {
                string Token = InputExpression[Index];
                if (Token == "(")
                {
                    SonBra.StIndex = InputExpression.IndexOf(Token);
                    for (int i = SonBra.StIndex; i < InputExpression.Count; i++)
                    {
                        string token = InputExpression[i];
                        if (token == "(")
                        {
                            SonBra.StIndex = i;
                            continue;
                        }
                        if (token == ")")
                        {
                            SonBra.EndIndex = i;
                            break;
                        }
                    }
                    //将括号内的内容存入SonBra.BracketContent
                    for (int i = SonBra.StIndex + 1; i < SonBra.EndIndex; i++)
                    {
                        string token = InputExpression[i];
                        SonBra.BracketContent.Add(token);
                    }
                    //将括号位置的元素{包括括号}替换为占位符
                    InfixInitialize.ReplaceWith
                        (this.BracketContent, SonBra.StIndex, SonBra.EndIndex - SonBra.StIndex + 1, SonBra.UsingSeat);
                    //标记长度
                    SonBra.Length = SonBra.BracketContent.Count;
                }
                else
                {
                    continue;
                }
                break;
            }
            return SonBra;
        }

        //判断{括号内}是否还有括号，如果有则调用一次GetBracket方法,并标记深度+1。
        //依附实例调用。如果没有括号则返回原来的Bracket。(已弃用）
        private Bracket BracketRecursion()
        {
            Bracket SonBra = new Bracket();
            for (int i = 0; i < this.Length; i++)
            {
                string Token = this.BracketContent[i];
                if (Token == "(")
                {
                    SonBra = this.GetBracket();
                    SonBra.BraDepth = this.BraDepth + 1;
                    return SonBra;
                }
                else
                {
                    continue;
                }

            }
            return this;
        }


        //判断string是否为一个Bracket的标识符
        internal static bool IsBracket(string Token)
        {
            bool IsBra = false;
            if (Token.StartsWith("Bra"))
            {
                IsBra = true;
            }
            return IsBra;
        }

    }

    //括号内部运算
    internal class Cal_Scientific
    {
        //调用函数将括号计算完毕的的BracketContent返回到上一级的中缀表达式，这将会销毁子式Bracket实例。
        public static void RecallBracket(Bracket Fatherbra, Bracket Sonbra)
        {
            InfixInitialize.ReplaceWith
                (Fatherbra.BracketContent,
                Fatherbra.BracketContent.IndexOf(Sonbra.UsingSeat)
                , Convert.ToString(Sonbra.BracketContent[0]));
        }

        //计算多重括号内的表达式
        internal static Bracket CalBras(Bracket Fatherbra)
        {
            Bracket Sonbra = new Bracket();
            Sonbra = Fatherbra.GetBracket();
            Cal_Standard.Calculate(Sonbra);
            Cal_Scientific.RecallBracket(Fatherbra, Sonbra);

            return Fatherbra;
        }
    }

    //计算含有括号保存着参数的函数
    internal class Functions : Bracket
    {
        private string FunctionName;//函数名
        private int NumofPara;//参数数量
        private Bracket Para1 = new Bracket(true);//参数存放实例
        private Bracket Para2 = new Bracket(true);
        private Bracket Para3 = new Bracket(true);

        //函数名和参数数量对应关系查找方法
        public static List<string> FunctionDic = new List<string>
            { "sin", "cos", "tan",
            "arcsin", "arccos", "arctan",
            "sinh", "cosh", "tanh",
            "abs", "RanInt", "ln",
            "pow", "log", "Rnd" };


        //寻找中缀式中是否有函数，常数，特殊字符。
        //若有，返回true，否则返回false。
        public static bool FindFunc(Bracket bra)
        {
            foreach (var Value in FunctionDic)
            {
                if (bra.BracketContent.Contains(Value))
                {
                    return true;
                }
            }
            return false;
        }


        //根据函数名返回参数数量
        private static int GetFuncArguCount(string funcName)
        {
            return funcName switch//名称全部小写
            {
                "sin" or "cos" or "tan" or
                "arcsin" or "arccos" or "arctan" or
                "sinh" or "cosh" or "tanh" or
                "abs" or "RanInt" or "ln" => 1,
                "pow" or "log" => 2,
                "Rnd" => 3,
                _ => -1,
            };
        }

        //构造函数
        public Functions() { }
        public Functions(string functionName)//该方法已经弃用
        {
            this.Functions = true;//基本上弃用的标识字段
            this.FunctionName = functionName;
            this.NumofPara = GetFuncArguCount(functionName);
            SetUp(this);
        }

        //初始化func的全部参数列表
        private static void SetUp(Functions func)
        {
            func.UsingSeat = "Bra" + DateTime.Now.ToString("yyyyMMddHHmmssfff");
            func.NumofPara = GetFuncArguCount(func.FunctionName);
            switch (func.NumofPara)
            {
                case 1:
                    func.Para1 = new Bracket(true);
                    break;
                case 2:
                    func.Para1 = new Bracket(true);
                    func.Para2 = new Bracket(true);
                    break;
                case 3:
                    func.Para1 = new Bracket(true);
                    func.Para2 = new Bracket(true);
                    func.Para3 = new Bracket(true);
                    break;
                default:
                    break;
            }
        }



        //从原始中缀表达式List<string>中找到科学函数结构。将函数名存入func.FunctionName，攫取参数到对应Para[?],
        //在原来的中缀表达式中返回计算结果。直接对func.FunctionName等操作，无返回值。
        //暂不支持函数嵌套
        internal static void GetFunc(List<string> InfixExp)
        {
            Functions func = new Functions();
            foreach (string token in InfixExp)
            {
                if (GetFuncArguCount(token) >= 1 && GetFuncArguCount(token) <= 3)
                {
                    func.StIndex = InfixExp.IndexOf(token);//此时的token一定是函数名
                    func.FunctionName = token;
                    SetUp(func);
                    for (int index0 = InfixExp.IndexOf(token) + 1; index0 < InfixExp.Count; index0++)
                    {
                        int LB = 0;
                        int RB = 0;

                        string Token = InfixExp[index0];//此时的Token一定是左括号
                        if (Token == "(")
                        {

                            for (int i = index0; i < InfixExp.Count; i++)//不能IndexOf，因为可能有多个左括号
                            {
                                string s = InfixExp[i];
                                if (s == "(")
                                {
                                    LB++;
                                    continue;
                                }
                                if (s == ")")
                                {
                                    RB++;
                                    if (LB == RB)
                                    {
                                        func.EndIndex = i;
                                        break;
                                    }
                                    else
                                    {
                                        continue;
                                    }
                                }
                            }
                            //将括号内的内容存入func.BracketContent
                            for (int i = func.StIndex + 2; i < func.EndIndex; i++)
                            {
                                func.BracketContent.Add(InfixExp[i]);
                            }
                            //将括号位置的元素{包括括号}替换为占位符
                            InfixInitialize.ReplaceWith
                                (InfixExp, func.StIndex, func.BracketContent.Count + 3, func.UsingSeat);
                            //标记长度
                            func.Length = func.BracketContent.Count;
                        }
                        else
                        {
                            continue;
                        }
                        break;
                    }
                }
                else
                {
                    continue;
                }
                break;
            }
            func.GetFuncPara(func);//获取，化简参数
            func.CalPara();//计算参数
            func.CalFunction();//计算函数，把结果返回到func.BracketContent
            Cal_Universal.CalFuncReturn(InfixExp, func);
        }
        //将原始的最外侧没有括号的Bracket.BracketContent转换为func的参数,并存入func的参数列表。直接对func.Para[?]操作，无返回值。
        private void GetFuncPara(Bracket InputBracket)
        {
            int indexofpara = 1;
            for (int index1 = 0; index1 <= InputBracket.BracketContent.Count - 1; index1++)
            {
                string token = InputBracket.BracketContent[index1];
                if (token != ",")
                {
                    switch (indexofpara)
                    {
                        case 1: this.Para1.BracketContent.Add(token); break;
                        case 2: this.Para2.BracketContent.Add(token); break;
                        case 3: this.Para3.BracketContent.Add(token); break;
                    }
                }
                else
                {
                    indexofpara++;
                    continue;
                }
            }
        }




        //化简计算func的参数
        internal void CalPara()
        {
            switch (this.NumofPara)
            {
                case 1:
                    Cal_Universal.CalDouble(this.Para1);
                    break;
                case 2:
                    Cal_Universal.CalDouble(this.Para1);
                    Cal_Universal.CalDouble(this.Para2);
                    break;
                case 3:
                    Cal_Universal.CalDouble(this.Para1);
                    Cal_Universal.CalDouble(this.Para2);
                    Cal_Universal.CalDouble(this.Para3);
                    break;
                default:
                    throw new Exception("未定义的函数!");
            }
        }




        //计算函数,结果存在func.BracketContent[0]中
        internal void CalFunction()
        {
            this.BracketContent.Clear();
            switch (this.FunctionName)
            {
                case "sin":
                    this.BracketContent.Add(Convert.ToString(Math.Sin(Convert.ToDouble(this.Para1.BracketContent[0]))));
                    break;
                case "cos":
                    this.BracketContent.Add(Convert.ToString(Math.Cos(Convert.ToDouble(this.Para1.BracketContent[0]))));
                    break;
                case "tan":
                    this.BracketContent.Add(Convert.ToString(Math.Tan(Convert.ToDouble(this.Para1.BracketContent[0]))));
                    break;
                case "arcsin":
                    this.BracketContent.Add(Convert.ToString(Math.Asin(Convert.ToDouble(this.Para1.BracketContent[0]))));
                    break;
                case "arccos":
                    this.BracketContent.Add(Convert.ToString(Math.Acos(Convert.ToDouble(this.Para1.BracketContent[0]))));
                    break;
                case "arctan":
                    this.BracketContent.Add(Convert.ToString(Math.Atan(Convert.ToDouble(this.Para1.BracketContent[0]))));
                    break;
                case "sinh":
                    this.BracketContent.Add(Convert.ToString(Math.Sinh(Convert.ToDouble(this.Para1.BracketContent[0]))));
                    break;
                case "cosh":
                    this.BracketContent.Add(Convert.ToString(Math.Cosh(Convert.ToDouble(this.Para1.BracketContent[0]))));
                    break;
                case "tanh":
                    this.BracketContent.Add(Convert.ToString(Math.Tanh(Convert.ToDouble(this.Para1.BracketContent[0]))));
                    break;
                case "abs":
                    this.BracketContent.Add(Convert.ToString(Math.Abs(Convert.ToDouble(this.Para1.BracketContent[0]))));
                    break;
                case "pow"://底数，指数
                    this.BracketContent.Add(Convert.ToString(Math.Pow(Convert.ToDouble(this.Para1.BracketContent[0]), Convert.ToDouble(this.Para2.BracketContent[0]))));
                    break;
                case "log"://真数，底数
                    this.BracketContent.Add(Convert.ToString(Math.Log(Convert.ToDouble(this.Para1.BracketContent[0]), Convert.ToDouble(this.Para2.BracketContent[0]))));
                    break;
                case "ln"://自动补全底数为e，输入的数字是真数
                    this.BracketContent.Add(Convert.ToString(Math.Log(Convert.ToDouble(this.Para1.BracketContent[0]))));
                    break;
                case "Rnd"://生成从Para1到Para2之间的的随机整数,上下限都要求是整数
                    this.BracketContent.Add(Convert.ToString(RandomNumberGenerator.GetInt32(Convert.ToInt32(this.Para1.BracketContent[0]), Convert.ToInt32(this.Para2.BracketContent[0]))));
                    break;
                case "RanInt"://生成从0到Para1之间的的随机整数，上限要求是整数
                    this.BracketContent.Add(Convert.ToString(RandomNumberGenerator.GetInt32(Convert.ToInt32(this.Para1.BracketContent[0]))));
                    break;
                default:
                    throw new Exception("不支持的函数{FunctionName}");
            };
        }
    }


    //RPN以及占位符运算。该类已经写死，不可继承。
    internal sealed class Cal_Simplyfy
    {

        //RPN转换，使用实例的BracketContent属性,修改，无返回值
        public static void ConvertToPostfix(Bracket bracket)
        {
            List<string> InfixExp = bracket.BracketContent;
            List<string> postfixExp = new List<string>();
            Stack<string> opStack = new Stack<string>();

            foreach (string token in InfixExp)
            {
                if (IsNumber(token))
                {
                    postfixExp.Add(token);
                }
                else if (Bracket.IsBracket(token))
                {
                    postfixExp.Add(token);
                }
                else if (IsOperator(token))
                {
                    if (opStack.Count == 0)
                    {
                        opStack.Push(token);
                    }
                    else if (PrecedenceDic[opStack.Peek()] < PrecedenceDic[token])
                    {
                        opStack.Push(token);
                    }
                    else
                    {
                        for (; opStack.Count != 0;)
                        {
                            if (PrecedenceDic[opStack.Peek()] >= PrecedenceDic[token])
                            {
                                postfixExp.Add(opStack.Pop());
                            }
                        }
                        opStack.Push(token);
                    }
                    //右结合性等待Develop
                }
                else
                {
                    throw new Exception("未知的符号");
                }

            }
            //将opStack中剩余的运算符加入到postfixExp中
            while (opStack.Count > 0)
            {
                postfixExp.Add(opStack.Pop());
            }
            bracket.BracketContent = postfixExp;//Content转换为后缀表达式
            bracket.Converted = true;//标记已经转换
        }

        //判断str是否为运算符
        internal static bool IsOperator(string str)
        {
            return PrecedenceDic.ContainsKey(str);
        }
        //判断str是否为数字
        internal static bool IsNumber(string str)
        {
            bool IsNum = false;
            if (double.TryParse(str, out double Num))
            {
                IsNum = true;
            }
            return IsNum;
        }

        //运算符优先级字典，写死，不可修改
        private static readonly Dictionary<string, int> PrecedenceDic = new Dictionary<string, int>
        {
            { "+", 1 },{ "-", 1 },{ "*", 2 },{ "/", 2 }
        };

    }

    //利用逆波兰式的基本四则运算
    internal class Cal_Standard
    {
        //计算只含有四则运算的逆波兰式。使用实例的BracketContent属性,修改，返回Brecket。
        public static void Calculate(Bracket bracket)
        {
            if (bracket.Converted == false)
            {
                Cal_Simplyfy.ConvertToPostfix(bracket);
                Calculate(bracket);
            }
            else
            {
                Stack<string> Middle = new Stack<string>();
                foreach (var token in bracket.BracketContent)
                {
                    if (Cal_Simplyfy.IsNumber(token))
                    {
                        Middle.Push(token);
                    }
                    else if (Cal_Simplyfy.IsOperator(token))
                    {
                        double middle1 = Convert.ToDouble(Middle.Pop());
                        double middle2 = Convert.ToDouble(Middle.Pop());
                        double middle3;
                        switch (token)
                        {
                            case "+":
                                middle3 = middle2 + middle1;
                                Middle.Push(Convert.ToString(middle3));
                                break;
                            case "-":
                                middle3 = middle2 - middle1;
                                Middle.Push(Convert.ToString(middle3));
                                break;
                            case "*":
                                middle3 = middle2 * middle1;
                                Middle.Push(Convert.ToString(middle3));
                                break;
                            case "/":
                                try
                                {
                                    middle3 = middle2 / middle1;
                                }
                                catch (DivideByZeroException)
                                {
                                    throw new Exception("除数不能为0！");
                                }
                                Middle.Push(Convert.ToString(middle3));
                                break;
                            default:
                                throw new Exception("未知的符号！");
                        }
                    }
                }
                bracket.BracketContent.Clear();
                bracket.BracketContent.Add(Middle.Pop());
            }
        }
    }

    internal class Cal_Universal//应该是最终在计算器里面调用的计算单个完整表达式的类
    {
        //计算单个完整表达式，使用实例的BracketContent属性,修改，无返回值
        public static void CalDouble(Bracket FatherBra)
        {
            for (; FatherBra.BracketContent.Contains("(");)
            {
                Cal_Scientific.CalBras(FatherBra);
            }
            Cal_Standard.Calculate(FatherBra);
        }

        //计算科学函数，将结果存在使用实例的Functions.BracketContent[0]，无返回值
        public static void CalF(Functions func)
        {
            func.CalPara();//计算参数
            func.CalFunction();
        }

        //返回科学函数的值到上一级的中缀表达式
        public static void CalFuncReturn(List<string> InfixExp, Functions func)
        {
            InfixInitialize.ReplaceWith(InfixExp, InfixExp.IndexOf(func.UsingSeat), func.BracketContent[0]);
        }

        //摘出科学函数，计算完毕返回到输入是list<string>。支持多重括号在内部，但是不能有函数嵌套。
        public static void CalFunc(List<string> InfixExp)
        {
            Functions.GetFunc(InfixExp);
        }

        //操作符，定位符{括号}，函数 字典
        private static readonly Collection<string> CalDic = new Collection<string>
        {
            "+","-","*","/",//四则运算运算符
            "(",")",",","E","e","π",//定位符,参数分隔符，科学计数法指示符，自然对数的底数，圆周率等科学常数
            "sin", "cos", "tan",
            "arcsin", "arccos", "arctan",
            "sinh", "cosh", "tanh",//三角类函数
            "abs", "RanInt", "Rnd",//绝对值，随机整数，随机数
            "pow", "log", "ln"//幂指函数，对数函数，自然对数函数
        };

        //初始化最初的表达式。
        //将多位整数初始化，{"operator" "a" "b" "operator"}转化为{"operator" "ab" "operator"};
        //将小数初始化，("a"".""b")转化为"a.b";
        //将负数初始化，首项("-""a")转换为"-a";
        //将百分数初始化，("a""%")转化为{"(" "a" "/" "100" ")"};
        //将科学计数法初始化，{"a" "E" "b"}转化为{"(" "a" "*" "pow" "(" "10" "," "b" ")" ")"};
        //其中的a,b都是式子或者数字。
        //全部符号均为英文状态输入

        //InfixInitialize是Bracket的子类,可以直接调用Bracket的属性。
        //从而new一个后续计算用的Bracket实例就能完成后续全部运算。
        //生成并返回Bracket实例，它的属性BracketContent是初始化后的表达式。
        public static Bracket Initialize(InfixInitialize infixInitialized)
        {
            Bracket MotherBra = new Bracket();//输出的Bracket
            string middle = null;//整个方法里面用到的中间存储变量

            //合并数字
            for (int xunhuan = 0; xunhuan < infixInitialized.BracketContent.Count; xunhuan++)
            {
                if (Cal_Simplyfy.IsNumber(infixInitialized.BracketContent[xunhuan])
                    || infixInitialized.BracketContent[xunhuan] == ".")//如果是数字或者小数点，就合并
                {
                    middle = middle + infixInitialized.BracketContent[xunhuan];
                }
                else//如果不是数字或者小数点，就输出前面循环得到的数字，再输出符号
                {
                    if (middle != null)//第一项是符号时，判断不为空，避免报错
                    {
                        MotherBra.BracketContent.Add(middle);
                        middle = null;
                    }
                    MotherBra.BracketContent.Add(infixInitialized.BracketContent[xunhuan]);//输出符号
                }
                continue;
                ////如果是符号字典的项目，就不合并，
                ////直接输出到MotherBra.BracketContent。；
                //if (CalDic.Contains(infixInitialized.BracketContent[xunhuan]))
                //{
                //    if (middle != null)
                //    {
                //        MotherBra.BracketContent.Add(middle);//输出前面循环得到的数字
                //        middle = null;//清空，避免影响后续取值
                //        middle = infixInitialized.BracketContent[xunhuan];//然后继续执行，输出字典项目
                //        MotherBra.BracketContent.Add(middle);
                //        middle = null;
                //    }
                //    else
                //    {
                //        middle= infixInitialized.BracketContent[xunhuan];//如果前面没有数字，直接输出字典项目
                //        MotherBra.BracketContent.Add(middle);
                //        middle = null;
                //    }
                //}
                //else//如果不是符号字典内容，必定为数字的组成部分，
                //    //继续循环找到全部数字部分，合并输出。
                //{
                //    middle = middle + infixInitialized.BracketContent[xunhuan];
                //    continue;
                //}
                //continue;
            }
            if (middle != null)
            {
                MotherBra.BracketContent.Add(middle);
            }//输出最后一项
            infixInitialized.BracketContent = MotherBra.BracketContent;//还回，继续下一步处理
            middle = null;

        //Dictionary<int, string> keyValuePairs = new Dictionary<int, string>();
        //这个字典用来存储正负号在infixInitialized.BracketContent中的位置索引，
        //以及是正号还是负号的判断符，
        //以及该符号后边是括号还是数字的判断符,
        //其中两个判断符使用{"正负判断@后面是什么判断"}格式存储，
        //规定正号为"0",负号为"1",
        //括号为"0",数字为"1"。(已弃用）
        Cherry_Pick://首项负数替换
            {
                for (int a = 0; a < infixInitialized.BracketContent.Count - 1; a++)
                {
                    if (infixInitialized.BracketContent[a] == "(" || infixInitialized.BracketContent[a] == "，" || infixInitialized.BracketContent[a] == "E")
                    //左括号，逗号,E后面跟着的就是首项
                    {
                        if (infixInitialized.BracketContent[a + 1] == "-" || infixInitialized.BracketContent[a + 1] == "+")
                        //如果首项是正负号，那就把它附加到后面的数字上面去。后面是括号的，变形处理。
                        {
                            if (Cal_Simplyfy.IsNumber(infixInitialized.BracketContent[a + 2]))//是数字的，附到开头
                            {
                                middle = infixInitialized.BracketContent[a + 1] + infixInitialized.BracketContent[a + 2];
                                InfixInitialize.ReplaceWith(MotherBra.BracketContent, a + 1, 2, middle);
                                middle = null;//清除数值
                                infixInitialized.BracketContent = MotherBra.BracketContent;
                                goto Cherry_Pick;
                            }
                            else//如果首项是正负号，后面跟着的是括号，
                                //那就把"-"变成{"-1" "*"},"+"变成{"1" "*"},括号以及括号内部内容不变。
                            {
                                if (infixInitialized.BracketContent[a + 1] == "-")
                                {
                                    InfixInitialize.ReplaceWith(MotherBra.BracketContent, a + 1, 1, "-1");
                                    MotherBra.BracketContent.Insert(a + 2, "*");
                                    infixInitialized.BracketContent = MotherBra.BracketContent;
                                    goto Cherry_Pick;
                                }
                                else
                                {
                                    InfixInitialize.ReplaceWith(MotherBra.BracketContent, a + 1, 1, "1");
                                    MotherBra.BracketContent.Insert(a + 2, "*");
                                    infixInitialized.BracketContent = MotherBra.BracketContent;
                                    goto Cherry_Pick;
                                }
                            }
                        }
                        //else
                        //{
                        //    continue;//首项不是正负号，继续遍历
                        //}
                    }
                    else
                    {
                        continue;//这里计划开发-(XXX)的转化,先留个位置
                    }
                }
                infixInitialized.BracketContent = MotherBra.BracketContent; //还回，继续下一步处理,
                                                                            //直到整个式子中不存在
                                                                            //首项前面有正负号
            }
            infixInitialized.BracketContent = MotherBra.BracketContent;//还回，继续下一步处理
            middle = null;


        //替换特殊字符，
        //将百分数初始化，("a""%")转化为{"a" "/" "100"}，
        //该计算器默认的百分号运算范围是左边的第一个式子，不作运算保护(即不自动添加括号保证运算正确);
        //将科学计数法初始化，("a" "E" "b")转化为{"a" "*" "pow" "(" "10" "," "b" ")"}，
        //该计算器默认的科学计数法范围是左边的第一个式子，不做运算保护(即不主动添加括号保证运算正确),
        //且指数只能为一个数字,不能为括号表达式;
        //未来版本可能会添加自动判断并添加括号的功能；
        //全部符号均为英文状态输入。
        Pick:
            {
                for (int i = 0; i <= infixInitialized.BracketContent.Count-1; i++)
                {
                    if (infixInitialized.BracketContent[i] == "%")
                    {
                        InfixInitialize.ReplaceWith(MotherBra.BracketContent, i, 1, "/");
                        MotherBra.BracketContent.Insert(i + 1, "100");
                        infixInitialized.BracketContent = MotherBra.BracketContent;
                        i = 0;
                        goto Pick;
                    }
                    else if (infixInitialized.BracketContent[i] == "E")
                    {
                        middle = infixInitialized.BracketContent[i + 1];
                        MotherBra.BracketContent.RemoveRange(i, 2);
                        List<string> temp = new List<string> { "*", "pow", "(", "10", ",", middle, ")" };
                        MotherBra.BracketContent.InsertRange(i, temp);
                        middle = null;//清除数值
                        infixInitialized.BracketContent = MotherBra.BracketContent;
                        i = 0;
                        goto Pick;
                    }
                    else if (infixInitialized.BracketContent[i] == "e")
                    {
                        MotherBra.BracketContent.RemoveRange(i, 1);
                        MotherBra.BracketContent.Insert(i, Convert.ToString(Math.E));
                        infixInitialized.BracketContent = MotherBra.BracketContent;
                        i = 0;
                        goto Pick;
                    }
                    else if (infixInitialized.BracketContent[i] == "π")
                    {
                        MotherBra.BracketContent.RemoveRange(i, 1);
                        MotherBra.BracketContent.Insert(i, Convert.ToString(Math.PI));
                        infixInitialized.BracketContent = MotherBra.BracketContent;
                        i = 0;
                        goto Pick;
                    }
                    else
                    {
                        continue;
                    }
                }
                infixInitialized.BracketContent = MotherBra.BracketContent;//还回，继续下一步处理,
                                                                           //直到整个式子中不存在
                                                                           //百分数和科学计数法
            }
            return MotherBra;
        }

    }
}

