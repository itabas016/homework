using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ex0103
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input four numbers: ");
            Console.WriteLine("eg: 59 78 9 354");

            var input = Console.ReadLine();

            string[] array = input.Split(new char[] { ' ' });
            Console.WriteLine("Before sort:");

            foreach (var item in array)
            {
                Console.WriteLine("{0,3} ", item);
            }

            Console.WriteLine("After sort:");
            Array.Sort(array);
            Array.Reverse(array);

            foreach (var item in array)
            {
                Console.WriteLine("{0,3} ", item);
            }

            Console.ReadLine();
        }
    }
}
