using System;
using System.Reflection;
namespace Reflection_Method_Analyze
{
    class MyClass
    {
        int x; int y;
        public MyClass(int i, int j)
        {
            x = i; y = j;
        }
        public int Sum()
        {
            return x + y;
        }
        public bool IsBetween(int i)
        {
            if (x < i || x < y)
                return true;
            else
                return false;
        }
        public void Set(int a, int b)
        {
            x = a; y = b;
        }
        public void Set(double a, double b)
        {
            x = (int)a;
            y = (int)b;
        }
        public void Show()
        {
            Console.WriteLine("X: {0}, Y: {1}", x, y);
        }
    }
    class ReflectDemo
    {
        static void Main(string[] args)
        {
            Type t = typeof(MyClass);
            Console.WriteLine("Analyze of methods in class" + t.Name);
            Console.WriteLine("Supported methods\n\n");
            MethodInfo[] methods = t.GetMethods();
            foreach(var m in methods)
            {
                Console.WriteLine(m.ReturnType.Name + " " + m.Name);
                ParameterInfo[] parameters = m.GetParameters();
                foreach (var p in parameters)
                {
                    Console.WriteLine(p.ParameterType.Name + " " + p.Name);
                }
                Console.WriteLine("\n");
            }


        }
    }
}
