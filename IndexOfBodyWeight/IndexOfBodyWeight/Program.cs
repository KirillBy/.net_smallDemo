using System;

namespace IndexOfBodyWeight
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your Name");
            string name = Console.ReadLine();
            Console.WriteLine("Enter your Surname");
            string surname = Console.ReadLine();
            Console.WriteLine("Enter your Age");
            double age= double.Parse(Console.ReadLine());
            Console.WriteLine("Enter your Weigth");
            double weight = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter your Heigth");
            double height = double.Parse(Console.ReadLine());

            double iobw = weight/(height*height)*100;

            Console.WriteLine($"You profile: \nFull name: {name} {surname}\nAge: {age}\nWeight: {weight}\n" +
                $"Height: {height}\nIndex of body weight: {iobw}");
        }
    }
}
