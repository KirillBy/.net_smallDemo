using System;

namespace Generic_Constrains_Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> myDictionary = new MyDictionary<int, string>();
            myDictionary.Add(1, "Belarus");
            myDictionary.Add(5, "Russia");
            myDictionary.Add(7, "Ukraine");
            myDictionary.Add(3, "Poland");
            myDictionary.Add(15, "USA");
            myDictionary.Remove(5);
            myDictionary.Remove(15);
            Console.WriteLine(myDictionary[5]);
            Console.WriteLine("Numbers of countries in dictionary {0}", myDictionary.Lenght);
            
        }
    }
}
