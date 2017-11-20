using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StructureLab
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("本项目包含顺序表和单链表两个测试...");
            Console.WriteLine("(注)：0表示顺序表，1表示单链表");

            var input = Int32.Parse(Console.ReadLine());

            while (!input.Equals(0) && !input.Equals(1))
            {
                Console.WriteLine("输入有误，请重新输入...(0表示顺序表，1表示单链表)");
                input = Int32.Parse(Console.ReadLine());
            }

            switch (input)
            {
                case 0:
                    SequenceListTest();
                    break;
                case 1:
                    LinkListTest();
                    break;
                default:
                    break;
            }
        }

        static void SequenceListTest()
        {
            Console.WriteLine("########顺序表测试开始...########");
            Console.WriteLine();
            Console.WriteLine("初始化顺序表(最大长度10)[a,b,c,d,e,f,g]");
            Console.WriteLine();

            SequenceList<string> seq = new SequenceList<string>(10);
            seq.Append("a");
            seq.Append("b");
            seq.Append("c");
            seq.Append("d");
            seq.Append("e");
            seq.Append("f");
            seq.Append("g");
            Console.WriteLine("########顺序表初始化结束.########");
            Console.WriteLine();

            Console.WriteLine("当前顺序表元素是：" + seq.ToString());
            Console.WriteLine();

            Console.WriteLine("######测试顺序表插入[元素前和元素后]...######");
            Console.WriteLine();

            Console.WriteLine("在第1个元素a前面插入A: ");
            seq.InsertBefore("A", 0);
            Console.WriteLine("执行结果：" + seq.ToString());
            Console.WriteLine();

            Console.WriteLine("在最后1个元素g前面插入G: ");
            seq.InsertBefore("G", seq.Last);
            Console.WriteLine("执行结果：" + seq.ToString());
            Console.WriteLine();

            Console.WriteLine("在第5个元素d后面插入E: ");
            seq.InsertAfter("E", 4);
            Console.WriteLine("执行结果：" + seq.ToString());
            Console.WriteLine();

            Console.WriteLine("当前顺序表元素是：" + seq.ToString());
            Console.WriteLine("当前顺序表长度：" + seq.Count());
            Console.WriteLine();

            Console.WriteLine("在第1个元素A前面插入S: ");
            seq.InsertBefore("S", 0);
            Console.WriteLine("无法插入新元素，当前顺序表：" + seq.ToString());
            Console.WriteLine();

            Console.WriteLine("在最后1个元素g后面面插入Z: ");
            seq.InsertBefore("Z", seq.Last);
            Console.WriteLine("无法插入新元素，当前顺序表：" + seq.ToString());
            Console.WriteLine();

            Console.WriteLine("########测试顺序表查找...########");
            Console.WriteLine();

            Console.WriteLine("(注): 当前顺序表为[{0}]，共有{1}个元素.", seq.ToString(), seq.Count());
            Console.WriteLine();

            Console.WriteLine("查找第1个元素：");
            Console.WriteLine(seq.GetItemAt(0));
            Console.WriteLine();

            Console.WriteLine("查找最后1个元素：");
            Console.WriteLine(seq.GetItemAt(seq.Last));
            Console.WriteLine();

            Console.WriteLine("查找第5个元素：");
            Console.WriteLine(seq.GetItemAt(4));
            Console.WriteLine();

            Console.WriteLine("查找倒数第3个元素：");
            Console.WriteLine(seq.GetItemAt(seq.Last - 2));
            Console.WriteLine();

            Console.WriteLine("########测试顺序表删除...########");
            Console.WriteLine();

            Console.WriteLine("(注)：当前顺序表元素：" + seq.ToString());

            Console.WriteLine("删除最后1个元素g: ");
            seq.RemoveAt(seq.Last);
            Console.WriteLine("执行结果：" + seq.ToString());
            Console.WriteLine();

            Console.WriteLine("删除第5个元素d: ");
            seq.RemoveAt(4);
            Console.WriteLine("执行结果：" + seq.ToString());
            Console.WriteLine();

            Console.WriteLine("删除倒数第3个元素e: ");
            seq.RemoveAt(seq.Last - 2);
            Console.WriteLine("执行结果：" + seq.ToString());
            Console.WriteLine();
            Console.WriteLine("最后顺序表元素：" + seq.ToString());


            Console.ReadKey();
        }

        static void LinkListTest()
        {
            Console.WriteLine("########单链表测试开始...########");
            Console.WriteLine();
            Console.WriteLine("初始化单链表");
            Console.WriteLine();

            LinkList<string> seq = new LinkList<string>();
            Console.WriteLine("创建头节点x:");
            seq.Append("x");
            Console.WriteLine();

            Console.WriteLine("在头元素处插入w:");
            seq.InsertBefore("w", 0);
            Console.WriteLine();

            Console.WriteLine("在头元素处插入v:");
            seq.InsertBefore("v", 0);
            Console.WriteLine();

            Console.WriteLine("当前链表元素：" + seq.ToString());
            Console.WriteLine();

            Console.WriteLine("########单链表测试插入...########");
            Console.WriteLine("(注：)当前链表元素：" + seq.ToString());
            Console.WriteLine();

            Console.WriteLine("向当前链表插入元素y:");
            seq.Append("y");
            Console.WriteLine("当前链表元素：" + seq.ToString());
            Console.WriteLine();

            Console.WriteLine("向当前链表插入元素Y:");
            seq.Append("Y");
            Console.WriteLine("当前链表元素：" + seq.ToString());
            Console.WriteLine();
            
            Console.WriteLine("在链表元素Y前面插入元素X:");
            seq.InsertBefore("X", seq.IndexOf("Y"));
            Console.WriteLine("当前链表元素：" + seq.ToString());
            Console.WriteLine();

            Console.WriteLine("在链表元素Y后面面插入元素z:");
            seq.InsertAfter("z", seq.IndexOf("Y"));
            Console.WriteLine("当前链表元素：" + seq.ToString());
            Console.WriteLine();

            Console.WriteLine("########单链表测试查找...########");
            Console.WriteLine("(注：)当前链表元素：" + seq.ToString());
            Console.WriteLine();

            Console.WriteLine("查找链表第二个元素:");
            Console.WriteLine("查找结果： " + seq.GetItemAt(1));
            Console.WriteLine();

            Console.WriteLine("查找链表倒数第三个元素:");
            Console.WriteLine("查找结果： " + seq.GetItemAt(seq.Count() - 3));
            Console.WriteLine();

            Console.WriteLine("查找链表元素z前面的一个元素:");
            Console.WriteLine("查找结果： " + seq.GetItemAt(seq.IndexOf("z") - 1));
            Console.WriteLine();

            Console.WriteLine("查找链表元素x相邻的两个元素:");
            Console.WriteLine("查找结果： 前一个元素是 {0}， 后一个元素是 {1}", seq.GetItemAt(seq.IndexOf("x") - 1), seq.GetItemAt(seq.IndexOf("x") + 1));
            Console.WriteLine();

            Console.WriteLine("########单链表测试删除...########");
            Console.WriteLine();

            Console.WriteLine("删除最后一个元素：");
            seq.RemoveAt(seq.Count() - 1);
            Console.WriteLine("当前链表元素：" + seq.ToString());
            Console.WriteLine();

            Console.WriteLine("删除第二个元素：");
            seq.RemoveAt(1);
            Console.WriteLine("当前链表元素：" + seq.ToString());
            Console.WriteLine();

            Console.WriteLine("最后链表元素：" + seq.ToString());

            Console.ReadKey();
        }

    }
}
