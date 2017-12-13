using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QueueStackLab
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Test Stack Palindrome(栈回文测试) ==>");
                Console.WriteLine("Please input string(请输入一串字符)：");
                var input = Console.ReadLine();

                while (string.IsNullOrEmpty(input))
                {
                    Console.WriteLine("Please input string(请输入一串字符)：");
                    input = Console.ReadLine();
                }

                var stack = PushStack(input);
                var stack2 = PushStack(input);
                Console.WriteLine("Complete pop test result(全部出栈测试结果):");
                Palindrome(stack, input);

                Console.WriteLine("Half pop test result(一半出栈测试结果):");
                PalindromeWithBinary(stack2, input);
                Console.WriteLine();
            }
        }

        public static Stack<char> PushStack(string input)
        {
            var stack = new Stack<char>();

            for (int i = 0; i < input.Length; i++)
            {
                stack.Push(input[i]);
            }
            return stack;
        }

        /// <summary>
        /// 栈是先进后出
        /// </summary>
        /// <param name="queue"></param>
        public static void Palindrome(Stack<char> stack, string input)
        {
            var success = true;
            var output = string.Empty;

            while (stack.Count > 0)
            {
                output += stack.Pop();
            }

            if (output != input) success = false;

            if (!success)
            {
                Console.WriteLine("Wrong");
            }
            else
            {
                Console.WriteLine("Right");
            }
        }

        /// <summary>
        /// 最大只pop字符串的一半长度即可
        /// </summary>
        /// <param name="stack"></param>
        /// <param name="input"></param>
        public static void PalindromeWithBinary(Stack<char> stack, string input)
        {
            var loopTimes = (input.Length % 2 == 0) ? input.Length / 2 : (input.Length + 1) / 2;
            var success = true;

            for (int i = 0; i < loopTimes; i++)
            {
                if (input[i] != stack.Pop())
                {
                    Console.WriteLine("Wrong");
                    success = false;
                    break;
                }
            }
            if (success)
            {
                Console.WriteLine("Right");
            }
        }
    }
}
