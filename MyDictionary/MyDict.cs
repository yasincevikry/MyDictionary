using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictionary
{
    class MyDict<SKey, SValue>
    {
        SKey[] key;
        SKey[] tempKey;
        SValue[] value;
        SValue[] tempValue;
        public MyDict()
        {
            key = new SKey[0];
            value = new SValue[0];
        }
        public void Add(SKey sKey, SValue sValue)
        {
            tempKey = key;
            key = new SKey[key.Length + 1];
            for (int i = 0; i < tempKey.Length; i++)
            {
                key[i] = tempKey[i];
            }
            key[key.Length - 1] = sKey;

            tempValue = value;
            value = new SValue[value.Length + 1];
            for (int i = 0; i < tempValue.Length; i++)
            {
                value[i] = tempValue[i];
            }
            value[value.Length - 1] = sValue;

        }
        public SKey[] Key
        {
            get { return key; }
        }
        public SValue[] Value
        {
            get { return value; }
        }
    }
}