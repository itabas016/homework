using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FindLab
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("折半查找：");
                Console.WriteLine();
                Console.WriteLine("例：一个有序数组[2, 9, 15, 16, 19, 24, 30, 40, 46, 52, 66, 70]");
                Console.WriteLine("请输入你要查找的值：");

                var input = Console.ReadLine();
                int key;

                while (!Int32.TryParse(input, out key))
                {
                    Console.WriteLine("请重新输入你要查找的值：");
                    input = Console.ReadLine();
                }

                Console.WriteLine("{0}元素的查找过程：", key);
                var array = new int[] { 2, 9, 15, 16, 19, 24, 30, 40, 46, 52, 66, 70 };
                BinarySearch(array, key);
                Console.WriteLine();
            }
        }

        public static void BinarySearch(int[] array, int key)
        {
            if (array.Length <= 0)
            {
                Console.WriteLine("当前数组为空，请初始化该数组...");
                return;
            }
            var lowIndex = 1;
            var highIndex = array.Length;
            var times = 1;

            while (lowIndex <= highIndex)
            {
                var middleIndex = (lowIndex + highIndex) / 2;
                Console.WriteLine("第{0}次查找：查找区间是[{1}, {2}],中间元素值是{3}", times, array[lowIndex - 1], array[highIndex - 1], array[middleIndex - 1]);

                if (key == array[middleIndex - 1])
                {
                    Console.WriteLine("查找结束，查询次数{0}次", times);
                    break;
                }
                else if (key < array[middleIndex - 1])
                {
                    //高位前移
                    highIndex = middleIndex - 1;
                    times++;
                }
                else
                {
                    //低位前移
                    lowIndex = middleIndex + 1;
                    times++;
                }
            }
            if (lowIndex > highIndex)
            {
                Console.WriteLine("查询次数{0}次,查找失败!", times);
            }
        }
    }
}
