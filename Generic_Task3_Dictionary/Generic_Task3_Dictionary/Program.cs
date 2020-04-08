using System;

namespace Generic_Task3_Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> dictionary = new Dictionary<int, string>();
            dictionary.Add(1, "Asus");
            dictionary.Add(2, "Acer");
            dictionary.Add(3, "MSI");
            Console.WriteLine(dictionary[1] + " " + dictionary[1]);
            Console.WriteLine(dictionary[3] + " " + dictionary[2]);
            Console.WriteLine(dictionary[3] + " " + dictionary[3]);
            dictionary.Add(4, "HP");
            dictionary.Add(5, "DELL");
            dictionary.Add(6, "Sony");


        }
    }
}
