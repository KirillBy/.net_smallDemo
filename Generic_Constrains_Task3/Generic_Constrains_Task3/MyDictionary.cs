using System;
using System.Collections.Generic;
using System.Text;

namespace Generic_Constrains_Task3
{
    internal class MyDictionary<TKey, TValue> where TKey: IEquatable<TKey>
    {

        TKey[] keyArray;
        TValue[] valueArray;

        //Lenght property
        public int Lenght { get { return keyArray.Length; }  }


        //indexer
        public TValue this[TKey index]
        {
            get 
            {
                int returnIndex = -1;
                for(int i = 0 ; i < keyArray.Length; i++)
                {
                    if (keyArray[i].Equals(index))
                        returnIndex = i;
                }
                if (returnIndex >= 0)
                    return valueArray[returnIndex];
                else
                    return valueArray[valueArray.Length-1];
            }
           
        }
        // add method
        public void Add(TKey key, TValue value)
        {
            if( keyArray == null)
            { 
                keyArray = new TKey[] { key };
                valueArray = new TValue[] { value };
            }
            else
            {
                TKey[] keyTemp = keyArray;
                TValue[] valueTemp = valueArray;
                keyArray = new TKey[keyTemp.Length + 1];
                valueArray = new TValue[valueTemp.Length + 1];
                for (int i = 0; i < keyTemp.Length; i++)
                {
                    keyArray[i] = keyTemp[i];
                    valueArray[i] = valueTemp[i];
                }
                keyArray[keyTemp.Length] = key;
                valueArray[valueTemp.Length] = value;
            }
        }
        //remove method
        public void Remove(int index)
        {

            if (keyArray == null)
            {
                Console.WriteLine("Your dictionary is already empty");
            }
            else
            {

                int indexToDelete = -1;
                for(int i = 0; i < keyArray.Length; i++)
                {
                    if (index.Equals(keyArray[i]))
                        indexToDelete = index;
                }
                if(indexToDelete > 0)
                {
                    TKey[] keyTemp = keyArray;
                    TValue[] valueTemp = valueArray;
                    keyArray = new TKey[keyTemp.Length - 1];
                    valueArray = new TValue[valueTemp.Length - 1];
                    int k = 0;
                    for (int i = 0; i < keyTemp.Length; i++)
                    {
                        if(!indexToDelete.Equals(keyTemp[i]))
                        {
                            keyArray[k] = keyTemp[i];
                            valueArray[k] = valueTemp[i];
                            k++;
                        }
                        

                       
                    }
                
                }

            }
        }
    }
}
