
using System;
using System.Linq;
using System.Reflection;

namespace ReflectionSample
{
    class Program
    {
        static void Main()
        {
            //Motorcycle motorcycle = new Motorcycle("Honda");
            //Console.WriteLine(motorcycle);


            // Assembly[] assemblies = AppDomain.CurrentDomain.GetAssemblies();
            Type motoType = typeof(Motorcycle);
            Type ctorParameter = Type.GetType("System.String");

            //ConstructorInfo ctor = motoType.GetTypeInfo().DeclaredConstructors
            //     .First(ct => ct.GetParameters()[0].ParameterType == ctorParameter);

            object[] args = new object[] { "Honda" };
            var ctorDefault = motoType.GetConstructors().First();

            //object obj = ctor.Invoke(args);
            object obj = ctorDefault.Invoke(null);

            Console.WriteLine($"Current type - {obj.GetType()}");
            Console.WriteLine(obj);

            FieldInfo fieldInfo = obj.GetType().GetTypeInfo().GetDeclaredField("_vinNumber");
            Console.WriteLine($"Field - {fieldInfo.Name}");
            Console.WriteLine($"Is Private - {fieldInfo.IsPrivate}");

            fieldInfo.SetValue(obj, 999_999);
            Console.WriteLine(obj);
        }
    }
}
