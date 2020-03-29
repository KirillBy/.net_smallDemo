﻿using System;
using System.Threading;
namespace TreadsSecondExample
{
    class MyThread
    {
        public int Count;
        public Thread Thrd;
        public MyThread(string name)
        {
            Count = 0;
            Thrd = new Thread(this.Run);
            Thrd.Name = name;
            Thrd.Start();
        }
        public void Run()
        {
            Console.WriteLine("Thread " + Thrd.Name + " has begun");
            do
            {
                Thread.Sleep(500);
                Console.WriteLine("In thread " + Thrd.Name + " count is " + Count);
                Count++;
            } while (Count < 10);
            Console.WriteLine("Thread " + Thrd.Name + " is finished");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Main thread has begun");
            MyThread mt1 = new MyThread("Thread No 1");
            MyThread mt2 = new MyThread("Thread No 2");
            MyThread mt3 = new MyThread("Thread No 3");
            do
            {
                Console.WriteLine(".");
                Thread.Sleep(100);
            } while (mt1.Thrd.IsAlive ||
                       mt2.Thrd.IsAlive ||
                       mt3.Thrd.IsAlive);
            Console.WriteLine("Main thread is over");
        }
    }
}
