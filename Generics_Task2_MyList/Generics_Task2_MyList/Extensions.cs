using System;
using System.Collections.Generic;
using System.Text;

namespace Generics_Task2_MyList
{
    static class Extensions
    {

        public static void  GetArray<T>(this MyList<T> myList)
        {
            myList.DisplayAllElements();
        }
    }
}
