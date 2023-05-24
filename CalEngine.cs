using System.Text.RegularExpressions;

namespace CalEngine
{
    internal class InfixToPostfix//RPN（逆波兰算法）转换
    {
        // 运算符优先级字典
        private static readonly Dictionary<string, int> OperatorPrecedence =
             new Dictionary<string, int>
             {
                    {"+", 2}, {"-", 2}, {"*", 3}, {"/", 3},//加减乘除
             };
        //科学函数名称集合
        protected internal static readonly HashSet<string> ScientificFunctions =
            new HashSet<string>
            {
                "sin", "cos", "tan",
                "arcsin", "arccos", "arctan",
                "sinh","cosh","tanh",
                "abs", "pow","log","rand","exp"
            };

        public static List<string> RPN(List<string> InputExpression)
        {
            // 创建一个栈来存储运算符
            Stack<string> OperatorStack = new Stack<string>();
            // 创建一个队列来存储输出的后缀表达式
            Queue<string> OutputExpression = new Queue<string>();
            //遍历中缀表达式数组
            foreach (string Input in InputExpression)
            {
                // 如果Input是操作数,则将其插入到输出的后缀表达式队列末尾
                if (double.TryParse(Input, out _)) { OutputExpression.Enqueue(Input); }
                // 如果Input是科学函数名称,则将其插入到运算符栈中
                else if (ScientificFunctions.Contains(Input))
                {
                    OperatorStack.Push(Input);
                }
                // 如果Input是运算符：
                else if (OperatorPrecedence.ContainsKey(Input))
                {
                    // 只要栈顶的运算符优先级高于或等于Input的优先级，就将栈顶的运算符弹出，并将其插入到输出队列中
                    while (OperatorStack.TryPeek(out var topOperator)
                            && OperatorPrecedence[topOperator] >= OperatorPrecedence[Input])
                    {
                        OutputExpression.Enqueue(OperatorStack.Pop());
                    }
                    // 将Input插入到栈顶
                    OperatorStack.Push(Input);
                }
                // 如果Input是左括号，将其插入到运算符栈中
                else if (Input == "(")
                {
                    OperatorStack.Push(Input);
                }
                // 如果Input是右括号：
                else if (Input == ")")
                {
                    // 只要栈顶不是左括号，就将栈顶的运算符弹出，并将其插入到输出的后缀表达式队列中
                    while (OperatorStack.TryPeek(out var topOperator) && topOperator != "(")
                    {
                        OutputExpression.Enqueue(OperatorStack.Pop());
                    }
                    //计算科学函数中的参数后，插入输出的后缀表达式队列中
                    if (ScientificFunctions.Contains(OperatorStack.Peek()))//返回Stack顶部对象
                    {
                        OutputExpression.Enqueue(OperatorStack.Pop());
                    }

                    // 弹出（并丢弃）左括号
                    OperatorStack.Pop();
                }
            }
            return OutputExpression.ToList();
        }
    }

    internal class Cal_2Num//两个数字之间的运算
    {
        internal static double CalculateOperation(List<string> RPNedStringlist)
        {
            Stack<double> operandStack = new Stack<double>();
            foreach (string Token in RPNedStringlist)
            {
                if (double.TryParse(Token, out double operand))
                {
                    operandStack.Push(operand);
                }
                else
                {
                    double operand2 = operandStack.Pop();
                    double operand1 = operandStack.Pop();
                    double result = 0;
                    switch (Token)
                    {
                        case "+":
                            result = operand1 + operand2;
                            break;
                        case "-":
                            result = operand1 - operand2;
                            break;
                        case "*":
                            result = operand1 * operand2;
                            break;
                        case "/":
                            result = operand1 / operand2;
                            break;
                    }
                    operandStack.Push(result);
                }
            }
            return operandStack.Pop();
        }
    }

    internal class Cal_Scinetific//科学函数内部运算以及最小括号处理
    {
        //获取科学函数参数数量
        private static int GetFunctionArgumentCount(string FuncName)
        {
            return FuncName switch
            {
                //根据Microsoft支持网站内容，Math类的三角函数默认为Rad（弧度制）。以下代码与switch,case语句等价。
                "sin" or "cos" or "tan" or "arcsin" or "arccos" or "arctan" or "abs" => 1,
                "pow" => 2,
                _ => throw new InvalidOperationException($"不支持的函数名：{FuncName}"),
            };
        }

        //计算科学函数
        private static double CalculateFunction(string funcName, double[] Op)
        {
            return funcName switch
            {
                //根据Microsoft支持网站内容，Math类的三角函数默认为Rad（弧度制）。以下代码与switch,case语句等价。
                "sin" => Math.Sin(Op[0]),
                "cos" => Math.Cos(Op[0]),
                "tan" => Math.Tan(Op[0]),
                "arcsin" => Math.Asin(Op[0]),
                "arccos" => Math.Acos(Op[0]),
                "arctan" => Math.Atan(Op[0]),
                "abs" => Math.Abs(Op[0]),
                "pow" => Math.Pow(Op[0], Op[1]),
                _ => throw new InvalidOperationException($"不支持的函数名：{funcName}"),
            };
        }

        //检查中缀表达式中的最小括号对,并化简
        private static List<string> SimplifyBra(List<string> InputExpression)
        {
            List<string> BracketContent = new List<string>();//存放括号内的内容
            foreach (var Input in InputExpression)
            {
                Regex regex = new Regex(@"(?<=\()[^()]*(?=\))"); // 创建一个正则表达式对象，该对象可以匹配位于括号间的内容，但是括号本身不属于匹配内容
                MatchCollection matches = regex.Matches(Input); // 使用正则表达式获取所有符合要求的匹配对象
                /*这段正则表达式是用来匹配出括号中的文本的。它会匹配所有位于开括号 ( 和闭括号 ) {英文括号}中间的非空字符串。
                 * (?<=\() 是一个正向预查，它会匹配开括号符号的位置。换言之，它会检测当前位置之前的字符是否为 (。
                 * \( 是对开括号字符的转义，因为在正则表达式中， ( 是有特殊意义的。
                 * [^()]* 用来匹配任意非空的、不含有括号的字符串。这些字符尽可能地匹配规则，输出更多符合要求的字符串。
                 * (?=\)) 是一个正向预查，它会匹配闭括号符号的位置。换言之，它会检测当前位置之后的字符是否为 )。
                 * \) 是对闭括号字符的转义，因为在正则表达式中， ) 是有特殊意义的。
                */
                foreach (Match match in matches) // 迭代每一个匹配对象
                {
                    BracketContent.Add(match.Value); // 将匹配对象内的字符串添加到List中
                }
            }
            List<string> RPNed = new List<string>();
            List<string> Middle = new List<string>();
            foreach (var Input in BracketContent)
            {
                RPNed = InfixToPostfix.RPN(BracketContent);//将括号内的内容转换为后缀表达式
                Middle.Add(Convert.ToString(Cal_2Num.CalculateOperation(RPNed)));//计算后缀表达式结果
            }
            return Middle;
        }
    }
}