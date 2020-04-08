using System;

namespace Delegates_Task3_AnonimusMethod
{
    class Program
    {
        public delegate int mydelegate();
        public delegate int mydel(mydelegate[] arr);
        static void Main(string[] args)
        {
            Random rand = new Random();
            mydelegate[] delegateArray = new mydelegate[5];
            for (int i = 0; i < delegateArray.Length; i++)
                delegateArray[i] = () => rand.Next(0, 1000);
            mydel md = delegate (mydelegate[] arr)
            {
                int count = 0;
                for (int i = 0; i < arr.Length; i++)
                { count += arr[i].Invoke(); Console.WriteLine(count); }
                return count / arr.Length;
            };
            Console.WriteLine(md.Invoke(delegateArray));
        }
    }
}
