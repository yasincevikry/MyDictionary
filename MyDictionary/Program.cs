using System;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDict<int, string> myDict = new MyDict<int, string>();

            myDict.Add(11, "Yasin");
            myDict.Add(10, "İcardi");
            myDict.Add(10, "Mertens");
            myDict.Add(5, "Toreira");

            
        }
    }
}
