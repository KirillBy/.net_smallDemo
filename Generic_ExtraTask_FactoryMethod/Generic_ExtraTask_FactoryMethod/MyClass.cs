using System;
using System.Collections.Generic;
using System.Text;

namespace Generic_ExtraTask_FactoryMethod
{
    class MyClass<T> where T: new()
    {
         public T FactoryMethod() => new T();
    }
}
