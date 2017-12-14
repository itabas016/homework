using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SortLab
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("简单选择排序测试");
            Console.WriteLine();

            Console.WriteLine("请输入一个数组(用空格隔开)：");
            var input = Console.ReadLine();

            while (string.IsNullOrEmpty(input) || (input.IndexOfAny(new char[] {' ', ',', '\t', ':', ';'}) == -1))
            {
                Console.WriteLine("请重新输入一个数组(用空格隔开)：");
                input = Console.ReadLine();
            }

            var array = input.Split(' ').Select(x => Convert.ToInt32(x)).ToArray();

            SelectSort(array);
            Console.ReadLine();
        }

        public static void SelectSort(int[] array)
        {
            int i, j, k, temp;

            for (i = 0; i < array.Length; i++)
            {
                k = i;
                for (j = i + 1; j < array.Length; j++)
                {
                    if (array[j] < array[k])
                    {
                        k = j;
                    }
                }
                if (k != i)
                {
                    temp = array[i];
                    array[i] = array[k];
                    array[k] = temp;
                }
                Console.WriteLine("执行{0}次后", i + 1);
                Print(array);
            }
        }

        public static void Print(int[] array)
        {
            var sb = new StringBuilder();
            for (int i = 0; i < array.Length; i++)
            {
                sb.Append(array[i]);
                sb.Append(',');
            }
            Console.WriteLine("数组顺序是：[{0}]", sb.ToString().TrimEnd(','));
            Console.WriteLine();
        }
    }
}
