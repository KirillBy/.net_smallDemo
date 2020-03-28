using System;
using System.Threading;

namespace ThreadsFirstExample
{
    class MyThread
    {
        public int Count;
        string thrdName;
        public MyThread(string name)
        {
            Count = 0;
            thrdName = name;
        }
        public void Run()
        {
            Console.WriteLine("Thread " + thrdName + " has begun" );
            do
            {
                Thread.Sleep(500);
                Console.WriteLine("In thread " + thrdName + " count is " + Count);
                Count++;
            } while (Count < 10);
            Console.WriteLine("Thread " + thrdName + " is finished");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Main thread has begun");
            MyThread mt = new MyThread("Thread No 1");
            Thread newThrd = new Thread(mt.Run);
            newThrd.Start();
            do
            {
                Console.WriteLine(".");
                Thread.Sleep(100);
            }while(mt.Count != 10);
        }
    }
}
