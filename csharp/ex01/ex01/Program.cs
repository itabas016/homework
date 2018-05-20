using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace ex01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This program can calculate two numbers behaviors: (+-*/)\r\n");

            var number1 = getNumber("Please input the first number:");
            var number2 = getNumberNotZero("Please input the second number:");

            Console.WriteLine(String.Format("{0} + {1} = {2}", number1, number2, number1 + number2));
            Console.WriteLine(String.Format("{0} - {1} = {2}", number1, number2, number1 - number2));
            Console.WriteLine(String.Format("{0} * {1} = {2}", number1, number2, number1 * number2));
            Console.WriteLine(String.Format("{0} / {1} = {2}", number1, number2, number1 / number2));

            Console.ReadLine();
        }

        public static bool isNumberic(string input)
        {
            var pattern = "/^(0|[1-9][0-9]*|-[1-9][0-9]*)$";
            Regex regex = new Regex(pattern);

            return regex.IsMatch(input);
        }

        public static Int64 getNumber(string inputText)
        {
            var isValid = false;
            do
            {
                Console.WriteLine(inputText);

                var input = Console.ReadLine();
                isValid = isNumberic(input);

                return Int64.Parse(input.Replace("+", ""));

            } while (!isValid);
        }

        public static Int64 getNumberNotZero(string inputText)
        {
            var isValid = false;
            Int64 number;
            do
            {
                number = getNumber(inputText);

                if (number != 0)
                {
                    isValid = true;
                    return number;
                }

                Console.WriteLine("Invalid number.");

                inputText = "Please re-input the second number:";

            } while (!isValid);

            return number;
        }
    }
}
