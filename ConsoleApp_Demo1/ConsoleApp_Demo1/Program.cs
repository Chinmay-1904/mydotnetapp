using System;
using System.Threading;

namespace ConsoleApp_Demo1
{
    class Program
    {
        static void Main(string[] args)
        {
            Test obj1 = new Test();

            Thread t1 = new Thread(obj1.f1);
            Thread t2 = new Thread(obj1.f2);
            Thread t3 = new Thread(obj1.f3);
            t1.Start();
            t2.Start();
            t3.Start();
            Console.ReadLine();
        }

        class Test
        {
            public void f1()
            {
                for(int i = 1; i <= 10; i++)
                {
                    Console.WriteLine(i);
                }
            }

            public void f2()
            {
                for (int i = 11; i <= 20; i++)
                {
                    Console.WriteLine(i);
                }
            }

            public void f3()
            {
                for (int i = 21; i <=30; i++)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
