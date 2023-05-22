using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Linq;
using System.Text.RegularExpressions;

namespace Calculator
{
    /// <summary>
    /// 科学计算器
    /// </summary>
    public class ScientificCalculator
    {
        // 定义运算符优先级字典
        private static readonly Dictionary<string, int> OperatorPrecedence = new Dictionary<string, int>
        {
            {"+", 2}, {"-", 2}, {"×", 3}, {"÷", 3}, {"^", 4}
        };

        // 定义科学函数名称集合变量，包括sin,cos,tan,asin,acos,atan,abs,pow等函数
        private static readonly HashSet<string> ScientificFunctions = new HashSet<string>
        {
            "sin", "cos", "tan", "asin", "acos", "atan", "abs", "pow"
        };

        /// <summary>
        /// 计算后缀表达式的值
        /// </summary>
        /// <param name="postfixExpression">后缀表达式数组</param>
        /// <returns>计算结果</returns>
        public static double CalculatePostfix(string[] postfixExpression)
        {
            // 创建一个栈来存储操作数
            var operandStack = new Stack<double>();

            // 遍历后缀表达式数组
            foreach (var token in postfixExpression)
            {
                // 如果token是操作数：将其插入到操作数栈中
                if (double.TryParse(token, NumberStyles.Any, CultureInfo.InvariantCulture, out var parsedOperand))
                {
                    operandStack.Push(parsedOperand);
                }

                // 如果token是科学函数名，将其计算结果插入到操作数栈中
                else if (ScientificFunctions.Contains(token))
                {
                    var functionArgs = new List<double>();
                    for (var i = 0; i < GetFunctionArgumentCount(token); i++)
                    {
                        functionArgs.Insert(0, operandStack.Pop());
                    }
                    operandStack.Push(CalculateFunction(token, functionArgs));
                }

                // 如果token是运算符：将栈顶的两个数字弹出，进行运算，将结果压入栈中
                else if (OperatorPrecedence.ContainsKey(token))
                {
                    var operand2 = operandStack.Pop();
                    var operand1 = operandStack.Pop();
                    operandStack.Push(CalculateOperation(token, operand1, operand2));
                }
            }

            // 返回栈中仅剩的一个数字
            return operandStack.Pop();
        }

        /// <summary>
        /// 将中缀表达式字符串转换为后缀表达式数组。
        /// </summary>
        /// <param name="infixExpression">中缀表达式字符串</param>
        /// <returns>后缀表达式数组</returns>
        public static string[] InfixToPostfix(string infixExpression)
        {
            // 转换为字符串数组
            var infixTokens = SplitInfixExpression(infixExpression);

            // 创建一个栈来存储运算符
            var operatorStack = new Stack<string>();

            // 创建一个队列来存储后缀表达式
            var postfixExpression = new Queue<string>();

            // 遍历中缀表达式数组
            foreach (var token in infixTokens)
            {
                // 如果token是操作数：将其插入到后缀表达式队列中
                if (double.TryParse(token, NumberStyles.Any, CultureInfo.InvariantCulture, out _))
                {
                    postfixExpression.Enqueue(token);
                }

                // 如果token是科学函数名，将插入到运算符栈中
                else if (ScientificFunctions.Contains(token))
                {
                    operatorStack.Push(token);
                }

                // 如果token是运算符：
                else if (OperatorPrecedence.ContainsKey(token))
                {
                    // 只要栈顶的运算符优先级高于或等于token的优先级，就将栈顶的运算符弹出，并将其插入到后缀表达式队列中
                    while (operatorStack.TryPeek(out var topOperator) &&
                           (OperatorPrecedence[topOperator] > OperatorPrecedence[token]
                            || (OperatorPrecedence[topOperator] == OperatorPrecedence[token] && topOperator != "^")))
                    {
                        postfixExpression.Enqueue(operatorStack.Pop());
                    }

                    // 将token插入到运算符栈顶
                    operatorStack.Push(token);
                }

                // 如果token是左括号，将其插入到运算符栈中
                else if (token == "(")
                {
                    operatorStack.Push(token);
                }

                // 如果token是右括号：
                else if (token == ")")
                {
                    // 只要栈顶不是左括号，就将栈顶的运算符弹出，并将其插入到后缀表达式队列中
                    while (operatorStack.TryPeek(out var topOperator) && topOperator != "(")
                    {
                        postfixExpression.Enqueue(operatorStack.Pop());
                    }

                    // 计算科学函数中的参数后插入到后缀表达式队列中
                    if (operatorStack.TryPeek(out var funcName) && ScientificFunctions.Contains(funcName))
                    {
                        operatorStack.Pop();
                        var functionArgs = new List<string>();
                        while (postfixExpression.TryPeek(out var funcArgToken) &&
                               double.TryParse(funcArgToken, NumberStyles.Any, CultureInfo.InvariantCulture,
                                   out var funcArgNum))
                        {
                            functionArgs.Insert(0, funcArgNum.ToString(CultureInfo.InvariantCulture));
                            postfixExpression.Dequeue();
                        }

                        postfixExpression.Enqueue($"{funcName}({string.Join(",", functionArgs.ToArray())})");
                    }

                    // 弹出（并丢弃）左括号
                    operatorStack.Pop();
                }
            }

            // 将运算符栈中剩余的运算符弹出，并将其插入到后缀表达式队列中
            while (operatorStack.TryPop(out var topOperator))
            {
                postfixExpression.Enqueue(topOperator);
            }

            // 返回后缀表达式数组
            return postfixExpression.ToArray();
        }

        /// <summary>
        /// 计算两个数字的二元运算结果
        /// </summary>
        /// <param name="operator">运算符</param>
        /// <param name="operand1">数字1</param>
        /// <param name="operand2">数字2</param>
        /// <returns>运算结果</returns>
        private static double CalculateOperation(string @operator, double operand1, double operand2)
        {
            switch (@operator)
            {
                case "+":
                    return operand1 + operand2;
                case "-":
                    return operand1 - operand2;
                case "×":
                    return operand1 * operand2;
                case "÷":
                    if (Math.Abs(operand2) < double.Epsilon)
                    {
                        throw new DivideByZeroException("除数不能为0");
                    }

                    return operand1 / operand2;
                case "^":
                    return Math.Pow(operand1, operand2);
                default:
                    throw new InvalidOperationException($"不支持的运算符：{@operator}");
            }
        }

        /// <summary>
        /// 计算科学函数的结果
        /// </summary>
        /// <param name="funcName">函数名</param>
        /// <param name="args">参数列表</param>
        /// <returns>函数结果</returns>
        private static double CalculateFunction(string funcName, List<double> args)
        {
            return funcName switch
            {
                "sin" => Math.Sin(args[0]),
                "cos" => Math.Cos(args[0]),
                "tan" => Math.Tan(args[0]),
                "asin" => Math.Asin(args[0]),
                "acos" => Math.Acos(args[0]),
                "atan" => Math.Atan(args[0]),
                "abs" => Math.Abs(args[0]),
                "pow" => Math.Pow(args[0], args[1]),
                _ => throw new InvalidOperationException($"不支持的函数名：{funcName}"),
            };
        }

        /// <summary>
        /// 获取科学函数的参数个数
        /// </summary>
        /// <param name="funcName">函数名</param>
        /// <returns>参数个数</returns>
        private static int GetFunctionArgumentCount(string funcName)
        {
            return funcName switch
            {
                "sin" or "cos" or "tan" or "asin" or "acos" or "atan" or "abs" => 1,
                "pow" => 2,
                _ => throw new InvalidOperationException($"不支持的函数名：{funcName}"),
            };
        }

        /// <summary>
        /// 将中缀表达式字符串分割为单词字符串数组。
        /// </summary>
        /// <param name="infixExpression">中缀表达式字符串</param>
        /// <returns>单词字符串数组</returns>
        private static string[] SplitInfixExpression(string infixExpression)
        {
            infixExpression = Regex.Replace(infixExpression, @"\s+", ""); // 移除空格
            infixExpression = infixExpression.Replace("(-", "(0-"); // 将负号转移
            infixExpression = infixExpression.Replace("×", "*").Replace("÷", "/"); // 统一运算符

            // 分割函数名称和参数，例如 sin(1)+2*3 被分割为 [sin, (, 1, ), +, 2, *, 3]
            var tokens = Regex.Split(infixExpression, @"(\d+|\D)")
                .Where(x => !string.IsNullOrEmpty(x)).ToArray();

            // 处理连乘连除
            for (var i = 1; i < tokens.Length - 1; i++)
            {
                var token = tokens[i];
                if (token == "*" || token == "/")
                {
                    if (double.TryParse(tokens[i - 1], NumberStyles.Any, CultureInfo.InvariantCulture, out _)
                        && double.TryParse(tokens[i + 1], NumberStyles.Any, CultureInfo.InvariantCulture, out _))
                    {
                        tokens[i] = token == "*" ? "×" : "÷";
                    }
                }
            }

            // 追加0以处理开头或分组前缺少操作数的情况，例如 -1+(2-1)*3 被分割为 [0, -, 1, +, (, 2, -, 1, ), *, 3]
            var result = new List<string>();
            foreach (var token in tokens)
            {
                if (double.TryParse(token, NumberStyles.Any, CultureInfo.InvariantCulture, out _))
                {
                    result.Add(token);
                }
                else
                {
                    result.Add(token);
                    result.Add("0");
                }
            }

            return result.ToArray();
        }
    }
}
