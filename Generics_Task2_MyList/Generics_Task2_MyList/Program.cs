using System;

namespace Generics_Task2_MyList
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<int> myList = new MyList<int>();
            Console.WriteLine("Lenght now " + myList.Lenght);
            myList.DisplayAllElements();
            myList.Add(5);
            myList.DisplayAllElements();
            Console.WriteLine("Lenght now " + myList.Lenght);
            myList.Add(100);
            myList.Add(111);
            myList.Add(222);
            myList.Add(112);
            myList.DisplayAllElements();
            myList[1] = 101;
            Console.WriteLine(myList[1]);
            myList[10] = 400;
            Console.WriteLine(new string('-',30));
            myList.GetArray();
        }
    }
}
