using System;
using System.Collections.Generic;
using System.Text;

namespace Generic_Task3_Dictionary
{
    class Dictionary<TKey, TValue>
    {
        private const int LIMIT = 4;
        private int limitControl = 0;
        private TKey[] key = new TKey[5];
        private TValue[] value = new TValue[5];

        public void Add(TKey key, TValue value)
        {
            if (limitControl <= LIMIT)
            {
                this.key[limitControl] = key;
                this.value[limitControl] = value;
                limitControl++;
            }
            else
                Console.WriteLine("No more place in Dictionary");
                
        }
        public string this[TKey index]
        {
            get
            {
                for (int i = 0; i < key.Length; i++)
                    if (key[i].Equals(index))
                        return key[i] + " - " + value[i];

                return string.Format("{0} - нет перевода для этого слова.", index);
            }
        }

        public string this[TValue index]
        {
            get
            {
                for (int i = 0; i < value.Length; i++)
                    if (value[i].Equals(index))
                        return key[i] + " - " + value[i];

                return string.Format("{0} - нет перевода для этого слова.", index);
            }
        }
    }
}
