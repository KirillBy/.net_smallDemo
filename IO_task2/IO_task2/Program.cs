using System;
using System.IO;
using System.Text;

namespace IO_task2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var file2 = new FileStream("test.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);

            var writer = new StreamWriter(file2);
            writer.WriteLine("Stay home \nStay true");


            
            var reader = new StreamReader(file2);
            
            Console.WriteLine(reader.ReadToEnd());
            writer.Close();
            file2.Close();
           
     
        }
    }
}
