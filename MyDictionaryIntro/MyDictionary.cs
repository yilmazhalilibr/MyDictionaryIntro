using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictionaryIntro
{
    class MyDictionary<T,T1>
    {
        public T[] DictKey;
        public T[] TempDictKey;
        public T1[] DictValue;
        public T1[] TempDictValue;

        public MyDictionary()
        {
            DictKey = new T[0];
            DictValue = new T1[0];
        }
        public void Add(T keys , T1 values)
        {
            TempDictKey = DictKey;
            TempDictValue = DictValue;

            DictKey = new T[DictKey.Length + 1];
            DictValue = new T1[DictValue.Length + 1];

            for (int i = 0; i < TempDictKey.Length; i++)
            {
                TempDictKey[i] = DictKey[i];

            }
            for (int i = 0; i < TempDictValue.Length; i++)
            {
                TempDictValue[i] = DictValue[i];
            }

            DictKey[DictKey.Length - 1] = keys;
            DictValue[DictValue.Length - 1] = values;



        }


    }
}
