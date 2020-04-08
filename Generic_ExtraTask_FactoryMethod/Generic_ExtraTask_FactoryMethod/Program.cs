using System;

namespace Generic_ExtraTask_FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            MyClass<int> intClass = new MyClass<int>();
            MyClass<double> doubleClass = new MyClass<double>();
            var unknown1 = intClass.FactoryMethod();
            Console.WriteLine(unknown1.GetType());
            var unknown2 = doubleClass.FactoryMethod();
            Console.WriteLine(unknown2.GetType());
        }
    }
}
