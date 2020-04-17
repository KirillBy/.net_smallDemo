using System;
using System.Collections.Generic;
using System.Text;

namespace Generic_Constrains_Task2
{ 
    class CarCollection<T> where T: Car
    {
        private const int PASSWORD = 111;
        private T[] carArray;

        //legth property
        public int Lenght { get { if (carArray.Length == 0)
                    return 0;  
                return carArray.Length; }  }

        //indexer
        public T this[int index]
        {
            get 
            {
                if (index >= 0 && index < carArray.Length)
                    return carArray[index];
                else return carArray[carArray.Length];
            }
            set {
                if (index >= 0 && index < carArray.Length)
                    carArray[index] = value;
                else
                    carArray[carArray.Length] = value;
            }
        }

        //add elements method
        public void Add(T newelement)
        {
            if (carArray != null)
            {
                T[] timearr = carArray;
                int size = timearr.Length;
                carArray = new T[size + 1];
                for (int i = 0; i < timearr.Length; i++)
                {
                    carArray[i] = timearr[i];
                }
                carArray[size] = newelement;
            }
            else
                carArray = new T[1] { newelement };
        }

        //remove all cars method
        public void RemoveAllCars()
        {
            Console.WriteLine("Please enter the secret password to remove all cars from garage");
            int _enteredPas; 
            Int32.TryParse(Console.ReadLine(), out _enteredPas);
            if (_enteredPas == PASSWORD)
                carArray = new T[0];
            else
                Console.WriteLine("Incorrect Password");
        }
    }
}
