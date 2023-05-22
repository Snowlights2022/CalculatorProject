namespace CalEngine
{
    class InfixToPostfix//RPN（逆波兰算法）转换
    {
        // 运算符优先级字典
       private static readonly Dictionary<string, int> OperatorPrecedence =
            new Dictionary<string, int>
            {
                    {"+", 2}, {"-", 2}, {"*", 3}, {"/", 3},//加减乘除
            };
        //科学函数名称集合
        private static readonly HashSet<string> ScientificFunctions = new HashSet<string>
        {
            "sin", "cos", "tan", "arcsin", "arccos", "arctan", "abs", "pow"
        };

        public static string[] RPN(string[] InputExpression)
        {
            // 创建一个栈来存储运算符
            Stack<string> OperatorStack = new Stack<string>();
            // 创建一个队列来存储输出的后缀表达式
            Queue<string> OutputExpression = new Queue<string>();

            // 遍历中缀表达式数组
            foreach (string Input in InputExpression)
            {
                // 如果Input是操作数,则将其插入到输出的后缀表达式队列末尾
                if (double.TryParse(Input, out _)) { OutputExpression.Enqueue(Input); }
                // 如果Input是科学函数名称,则将其插入到运算符栈中
                else if (ScientificFunctions.Contains(Input)) { OperatorStack.Push(Input); }
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

            // 将栈中剩余的运算符弹出，并将其插入到输出队列中
            while (OperatorStack.TryPop(out var TopOperator))
            {
                OutputExpression.Enqueue(TopOperator);
            }

            // 返回后缀表达式数组
            return OutputExpression.ToArray();
        }
    }
    class Cal_2Num//两个数字之间的运算
    {
        private static double CalculateOperation(string Operator, double Op1, double Op2)
        {
            switch (Operator)
            {
                case "+":
                    return Op1 + Op2;
                case "-":
                    return Op1 - Op2;
                case "×":
                    return Op1 * Op2;
                case "÷":
                    if (Math.Abs(Op2) ==0)
                    {
                        throw new DivideByZeroException("除数不能为0");
                    }

                    return Op1 / Op2;
                case "^":
                    return Math.Pow(Op1, Op2);
                default:
                    throw new InvalidOperationException($"不支持的运算符：{Operator}");
            }
        }
    }
    class Cal_Scinetific//科学函数内部运算
    {
        private static int GetFunctionArgumentCount(string FuncName)//获取科学函数参数数量
        {
            return FuncName switch
            {
                //根据Microsoft支持网站内容，Math类的三角函数默认为Rad（弧度制）。以下代码与switch,case语句等价。
                "sin" or "cos" or "tan" or "arcsin" or "arccos" or "arctan" or "abs" => 1,
                "pow" => 2,
                _ => throw new InvalidOperationException($"不支持的函数名：{FuncName}"),
            };
        }
        private static double CalculateFunction(string funcName, double[] Op)//计算科学函数
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
    }
}