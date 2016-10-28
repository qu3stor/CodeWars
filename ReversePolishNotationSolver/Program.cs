using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePolishNotationSolver
{
    class Program
    {
        //rosettacode.org/wiki/Parsing/RPN_calculator_algorithm#C.23
        static void Main(string[] args)
        {
            Console.WriteLine(SolvePostfix("73 12 47 + 45 48 - 38 75 37 * + - + -"));
            Console.ReadKey();
        }

        public static double SolvePostfix(string expression)
        {
            string[] arr = expression.Split(' ');

            Stack<double> stack = new Stack<double>();
            double number = 0;

            foreach (var item in arr)
            {
                if (double.TryParse(item, out number))
                {
                    stack.Push(number);
                }
                else
                {
                    switch (item)
                    {
                        case "^":
                            {
                                number = stack.Pop();
                                stack.Push(Math.Pow(stack.Pop(), number));
                                break;
                            }
                        case "*":
                            {
                                stack.Push(stack.Pop() * stack.Pop());
                                break;
                            }
                        case "/":
                            {
                                number = stack.Pop();
                                stack.Push(stack.Pop() / number);
                                break;
                            }
                        case "+":
                            {
                                stack.Push(stack.Pop() + stack.Pop());
                                break;
                            }
                        case "-":
                            {
                                number = stack.Pop();
                                stack.Push(stack.Pop() - number);
                                break;
                            }
                    }
                }
            }


            return stack.Pop();
        }
    }
}
