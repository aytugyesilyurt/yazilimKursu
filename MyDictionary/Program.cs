using System;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            DictionaryManager<int, string> myDictionary = new DictionaryManager<int, string>();
            myDictionary.Add(61, "Aytug");
            myDictionary.Add(35, "Çağatay");
            myDictionary.Add(45, "Mert");
            myDictionary.Add(20, "Göktuğ");

            Console.WriteLine(myDictionary.Count);
        }
    }
}
