using System;
using System.Collections.Generic;
using System.Text;

namespace Generics_Task2_MyList
{
     class MyList<T>
    {
        private T[] myArray;

        //property for showing lenght
        public int Lenght { get { if (myArray == null)
                                   return 0;
                                  return myArray.Length; }  }

        //indexer
        public object this[int index]
        {
            get { if (index >= 0 && index < myArray.Length) { return myArray[index]; }
                else { Console.WriteLine("Index out of range"); return myArray[myArray.Length - 1]; } } 
            set { if (index >= 0 && index < myArray.Length) { myArray[index] = (T)value; }
                else { Console.WriteLine("Index out of range"); }
            }
        }

        //add elements method
        public void Add(T newelement)
        {
            if (myArray != null)
            {
                T[] timearr = myArray;
                int size = timearr.Length;
                myArray = new T[size + 1];
                for (int i = 0; i < timearr.Length; i++)
                {
                    myArray[i] = timearr[i];
                }
                myArray[size] = newelement;
            }
            else
                myArray = new T[1] { newelement };
        }


        // Display all elements method
        public void DisplayAllElements()
        {
            if(myArray != null)
            {
                foreach (var item in myArray)
                {
                    Console.WriteLine(item);
                }
            }
            else
                Console.WriteLine("List is empty");
        
        }
    }
}
