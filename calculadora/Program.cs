using System;

namespace calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            for (; ; )
            {
                Console.WriteLine("请输入第一个数");
                int a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("请输入计算符号：（+  -  *   /   %）");
                String b = Console.ReadLine();
                Console.WriteLine("请输入第二个数");
                int c = int.Parse(Console.ReadLine());
                int d;
                switch (b)
                {
                    case ("+"):
                        d = a + c;
                        Console.WriteLine("输出结果为" + d);
                        break;

                    case ("-"):
                        d = a - c;
                        Console.WriteLine("输出结果为" + d);
                        break;

                    case ("*"):
                        d = a * c;
                        Console.WriteLine("输出结果为" + d);
                        break;

                    case ("/"):
                        d = a / c;
                        Console.WriteLine("输出结果为" + d);
                        break;

                    case ("%"):
                        d = a % c;
                        Console.WriteLine("输出结果为" + d);
                        break;
                    default:
                        Console.WriteLine("Not Found!");
                        break;
                }
            }
        }
    }
}

